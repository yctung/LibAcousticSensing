//
//  NetworkController.m
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/25/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "NetworkController.h"


@implementation NetworkController
@synthesize refCaller;

- (BOOL)getIsConnected{
    return isConnected;
}

- (void) connectServerWithIp: (NSString*) addr andPort: (int) port{
    NSLog(@"Try to connect to server at %@:%d", addr, port);
    CFReadStreamRef readStream;
    CFWriteStreamRef writeStream;
    CFStreamCreatePairWithSocketToHost(NULL,CFBridgingRetain(addr),port, &readStream, &writeStream);
    
    if (readStream && writeStream)
    {
        CFReadStreamSetProperty(readStream,
                                kCFStreamPropertyShouldCloseNativeSocket,
                                kCFBooleanTrue);
        CFWriteStreamSetProperty(writeStream,
                                 kCFStreamPropertyShouldCloseNativeSocket,
                                 kCFBooleanTrue);
        
        inputStream = (NSInputStream *)readStream;
        [inputStream retain];
        [inputStream setDelegate:self];
        [inputStream scheduleInRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
        [inputStream open];
        
        outputStream = (NSOutputStream *)writeStream;
        [outputStream retain];
        [outputStream setDelegate:self];
        [outputStream scheduleInRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
        [outputStream open];
    }
    
    /*
    inputStream = (__bridge_transfer NSInputStream *)readStream;
    outputStream = (__bridge_transfer NSOutputStream *)writeStream;
    [inputStream scheduleInRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
    [outputStream scheduleInRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
    [outputStream open];
    [inputStream open];
    
    
    CFReadStreamSetProperty(readStream, kCFStreamPropertyShouldCloseNativeSocket, kCFBooleanTrue);
    CFWriteStreamSetProperty(writeStream, kCFStreamPropertyShouldCloseNativeSocket, kCFBooleanTrue);
     */
}

- (void)sendData:(UInt32)byteSize audioData:(void *)audioData{
    NSMutableData *dataToSend = [[NSMutableData alloc] init];
    
    const int8_t ACTION_DATA = 2;
    // 1. send action code
    [dataToSend appendBytes:&ACTION_DATA length:1];
    // 2. send data length
    UInt32 byteSizeToSend = CFSwapInt32HostToBig(byteSize);
    [dataToSend appendBytes:&byteSizeToSend length:sizeof(UInt32)];
    // 3. send actuall data
    [dataToSend appendBytes:audioData length:byteSize];
    // 4. send ending check data
    const int8_t check = -1;
    [dataToSend appendBytes:&check length:1];
    // 5. send data if it is possible
    [self sendDataWhenPossible:dataToSend];
    

}

- (void)sendInitAction{
    const int8_t ACTION_INIT = 4;
    NSData *dataToSend = [NSData dataWithBytes:&ACTION_INIT length:1];
    [self sendDataWhenPossible:dataToSend];

}

// this is sepcialed set action for string only
- (void)sendSetStringAction:(NSString*)name andStringToSet:(NSString *) dataString{
    NSData* data = [dataString dataUsingEncoding:NSUTF8StringEncoding];
    [self sendSetAction:SET_TYPE_STRING withName:name andData:data];
}

- (void)sendSetValueStringAction:(NSString*)name andStringToSet:(NSString *) dataString{
    NSData* data = [dataString dataUsingEncoding:NSUTF8StringEncoding];
    [self sendSetAction:SET_TYPE_VALUE_STRING withName:name andData:data];
}

- (void)sendSetAction:(int)setType withName:(NSString*) name andData:(NSData*) data{
    // put writing bytes to this data buffer
    NSMutableData *dataToSend = [[NSMutableData alloc] init];
    
    const int8_t ACTION_SET = 3;
    const int8_t check = -1;
    
    // 1. write action code
    [dataToSend appendBytes:&ACTION_SET length:1];
    
    // 2. write setType
    UInt32 setTypeToSend = CFSwapInt32HostToBig(setType); // convert to big-endian for socket transmissions
    [dataToSend appendBytes:&setTypeToSend length:sizeof(UInt32)];
    
    // 3. write name string data
    NSData *nameData = [name dataUsingEncoding:NSUTF8StringEncoding];
    UInt32 nameLengthToSend = CFSwapInt32HostToBig((UInt32)[name length]);
    [dataToSend appendBytes:&nameLengthToSend length:sizeof(nameLengthToSend)];
    [dataToSend appendBytes:[nameData bytes] length:[nameData length]];
    [dataToSend appendBytes:&check length:1];
    
    // 4. write the read data string
    UInt32 dataLengthToSend = CFSwapInt32HostToBig((UInt32)[data length]);
    [dataToSend appendBytes:&dataLengthToSend length:sizeof(dataLengthToSend)];
    [dataToSend appendBytes:[data bytes] length:[data length]];
    [dataToSend appendBytes:&check length:1];
    
    // 5. use another method to schedule how data is sent
    [self sendDataWhenPossible:dataToSend];

}

- (void)closeServer{
    isConnected = NO;
    const int8_t ACTION_CLOSE = -1;
    NSUInteger length = 1;
    NSInteger error = [outputStream write:(uint8_t*)&ACTION_CLOSE maxLength:length];
    
    if(error<0){
        NSLog(@"Unalbe to closeServer: error = %ld",(long)error);
    }

}

- (id)initWithUILabel:(UILabel *) networkStatus andCaller:(id<NetworkControllerCallerDelegate>)callerIn {
    self = [super init];
    if (self) {
        statusText = networkStatus;
        isConnected = NO;
        refCaller = callerIn;
        dataWaitToSend = [[NSMutableArray alloc] init];
        okToSendDataDirectly = NO;
        currentDataToSendOffset = 0;
    }
    return self;
}

// wait the send operation until socket is ready to send
-(void)sendDataWhenPossible:(NSData*) dataToSend{
    [dataWaitToSend insertObject:dataToSend atIndex:0];
    if (okToSendDataDirectly){
        [self sendWaitedDataDirectly];
    }
}



// really send the data -> NOTE: it will block the thread -> should be executed at the proper timiing
-(void)sendWaitedDataDirectly{
    const int BYTE_LENGTH_TO_WRITE_EACH_TIME = 1024;
    
    okToSendDataDirectly = NO; // block any furhter writing is operated until socket is ready next time
    NSData *dataToSend = [dataWaitToSend lastObject]; // start send by the last data -> data being pushed first
    if (dataToSend == nil) {
        okToSendDataDirectly = YES; // no data to send at now -> means socket is ready for the next sending
        return;
    }
    
    // start send part of the data
    uint8_t* byteToSend = (uint8_t*)[dataToSend bytes];
    byteToSend += currentDataToSendOffset; // shift data to the current offset
    NSUInteger dataLength = [dataToSend length];
    NSUInteger lengthOfDataToWrite = (dataLength - currentDataToSendOffset >= BYTE_LENGTH_TO_WRITE_EACH_TIME) ? BYTE_LENGTH_TO_WRITE_EACH_TIME : (dataLength - currentDataToSendOffset);
    NSInteger bytesWritten = [outputStream write:byteToSend maxLength:lengthOfDataToWrite];
    
    if (bytesWritten > 0) {
        currentDataToSendOffset += bytesWritten;
        if (currentDataToSendOffset == dataLength) { // current dataToSend is completely being sent -> go next one
            [dataWaitToSend removeLastObject];
            currentDataToSendOffset = 0;
        }
    } else {
        NSLog(@"[ERROR]: unable to write -> something must be wrong (no network connection?)");
    }
}

// NSStreamDelegate callback functions
-(void)stream:(NSStream *)theStream handleEvent:(NSStreamEvent)streamEvent {
    NSString *io;
    if (theStream == inputStream) io = @">>";
    else io = @"<<";
    
    NSString *event;
    switch (streamEvent)
    {
        case NSStreamEventNone:
            event = @"NSStreamEventNone";
            //[statusText setText:@"Can not connect to the host!" ];
            [refCaller isConnected:NO withResp:event];
            break;
            
        case NSStreamEventOpenCompleted:
            event = @"NSStreamEventOpenCompleted";
            //[statusText setText:@"Connected"];
            //[refCaller isConnected:YES withResp:event];
            //isConnected = YES;
            break;
            
        case NSStreamEventHasBytesAvailable:
            event = @"NSStreamEventHasBytesAvailable";
            if (theStream == inputStream)
            {
                uint8_t buffer[1024];
                NSInteger len = [inputStream read:buffer maxLength:sizeof(buffer)];
                if (len > 0) {
                    NSData *dataReceived = [[NSData alloc] initWithBytes:buffer length:len];
                    
                    NSLog(@"socket received data with len = %ld",(long)len);
                    [refCaller consumeReceivedData:dataReceived];
                } else {
                    NSLog(@"[ERROR]: unable to read socket");
                }
                
            }
            break;
            
        case NSStreamEventHasSpaceAvailable:
            event = @"NSStreamEventHasSpaceAvailable";
            if (theStream == outputStream)
            {
                if(!isConnected){ // first init this stream
                    isConnected = YES;
                    okToSendDataDirectly = YES;
                    [refCaller isConnected:YES withResp:event];
                } else {
                    NSLog(@"[WARN]: stream is ready to send something");
                    [self sendWaitedDataDirectly];
                }
            }
            break;
        case NSStreamEventErrorOccurred:
            event = @"NSStreamEventErrorOccurred";
            //statusText.text = @"Can not connect to the host!";
            [refCaller isConnected:NO withResp:event];
            break;
            
        case NSStreamEventEndEncountered:
            event = @"NSStreamEventEndEncountered";
            //statusText.text = @"Connection closed by the server.";
            [refCaller isConnected:NO withResp:event];
            [theStream close];
            [theStream removeFromRunLoop:[NSRunLoop currentRunLoop] forMode:NSDefaultRunLoopMode];
            [theStream release];
            theStream = nil;
            break;
        default:
            event = @"** Unknown";
    }
    
    NSLog(@"%@ : %@", io, event);
}


@end