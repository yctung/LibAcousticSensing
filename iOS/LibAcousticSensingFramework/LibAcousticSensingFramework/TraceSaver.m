//
//  TraceSaver.m
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/30/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import "TraceSaver.h"

@implementation TraceSaver
int BYTE_LENGTH_TO_SAVE_EACH_TIME = 1024;

-(id)initWithFilePath:(NSString*) filePathIn{
    self = [super init];
    if (self){
        filePath = [filePathIn retain];
        dataWaitToSave = [[[NSMutableArray alloc] init] retain];
        okToSaveDataDirectly = NO;
        isOpened = NO;
        currentDataToSaveOffset = 0;
        [self openFileToSave:filePathIn];
    }
    return self;
}

-(void)dealloc{
    [filePath release];
    [dataWaitToSave release];
    [super dealloc];
}

// public interface to write data (async)
-(void) write:(NSData*) dataToSave {
    [self saveDataWhenPossible:dataToSave];
}

-(BOOL)getIsOpened{
    return isOpened;
}

-(void)waitAllDataBeingSavedAndStop{
    while([outputStream hasSpaceAvailable] && !okToSaveDataDirectly){ // this part is busy wait
        [self saveWaitedDataDirectly];
    }
    [outputStream close];
    [outputStream removeFromRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
    [outputStream release];
}

//====================================================================================================
//  Interal interface for saving when condition is ok
//====================================================================================================


-(void) openFileToSave:(NSString*) filePathIn{
    if ([[NSFileManager defaultManager] fileExistsAtPath:filePathIn]) {
        NSLog(@"[WARN]: TraceSaver save file to a existing file (forget to create a new folder?)");
    }
    outputStream = [[[NSOutputStream alloc] initToFileAtPath:filePathIn append:NO] retain];
    [outputStream setDelegate:self];
    [outputStream scheduleInRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
    [outputStream open];
}


// wait the save operation until socket is ready to send
-(void)saveDataWhenPossible:(NSData*) dataToSend{
    [dataWaitToSave insertObject:dataToSend atIndex:0];
    if (okToSaveDataDirectly){
        [self saveWaitedDataDirectly];
    }
}



// really save the data -> NOTE: it will block the thread -> should be executed at the proper timiing
-(void)saveWaitedDataDirectly{
    okToSaveDataDirectly = NO; // block any furhter writing is operated until socket is ready next time
    NSData *dataToSend = [dataWaitToSave lastObject]; // start send by the last data -> data being pushed first
    if (dataToSend == nil) {
        okToSaveDataDirectly = YES; // no data to send at now -> means socket is ready for the next sending
        return;
    }
    
    // start send part of the data
    uint8_t* byteToSend = (uint8_t*)[dataToSend bytes];
    byteToSend += currentDataToSaveOffset; // shift data to the current offset
    NSUInteger dataLength = [dataToSend length];
    NSUInteger lengthOfDataToWrite = (dataLength - currentDataToSaveOffset >= BYTE_LENGTH_TO_SAVE_EACH_TIME) ? BYTE_LENGTH_TO_SAVE_EACH_TIME : (dataLength - currentDataToSaveOffset);
    NSInteger bytesWritten = [outputStream write:byteToSend maxLength:lengthOfDataToWrite];
    
    if (bytesWritten > 0) {
        currentDataToSaveOffset += bytesWritten;
        if (currentDataToSaveOffset == dataLength) { // current dataToSend is completely being sent -> go next one
            [dataWaitToSave removeLastObject];
            currentDataToSaveOffset = 0;
        }
    } else {
        NSLog(@"[ERROR]: unable to write -> something must be wrong (no network connection?)");
    }
}

// NSStreamDelegate callback functions
-(void)stream:(NSStream *)theStream handleEvent:(NSStreamEvent)streamEvent {
    switch (streamEvent)
    {
        case NSStreamEventOpenCompleted:
            NSLog(@"File = %@ has be opened, wait to be written", [filePath lastPathComponent]);
            break;
        case NSStreamEventHasSpaceAvailable:
            if(!isOpened){ // first init this stream
                isOpened = YES;
            } else {
                [self saveWaitedDataDirectly];
            }
            break;
        case NSStreamEventErrorOccurred:
            NSLog(@"[ERROR]: event error found = %lu", (unsigned long)streamEvent);
            break;
        case NSStreamEventEndEncountered:
            [theStream close];
            [theStream removeFromRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
            [theStream release];
            theStream = nil;
            break;
        default:
            NSLog(@"[ERROR]: unhandled event = %lu", (unsigned long)streamEvent);
    }

}

@end
