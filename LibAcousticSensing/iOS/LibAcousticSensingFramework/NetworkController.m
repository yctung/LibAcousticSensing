//
//  NetworkController.m
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/25/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "NetworkController.h"
#import "AudioSource.h"


// ref: https://developer.apple.com/library/content/documentation/NetworkingInternet/Conceptual/NetworkingTopics/Articles/UsingSocketsandSocketStreams.html#//apple_ref/doc/uid/CH73-SW1

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
        
        // set a time out event
        double CONNECT_TIMEOUT_IN_SEC = 1.0;
        [self performSelector:@selector(connectFailAndCleanUp) withObject:nil afterDelay:CONNECT_TIMEOUT_IN_SEC];
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

- (void)closeSocketStreams {
    [inputStream setDelegate:nil];
    [inputStream close];
    [outputStream setDelegate:nil];
    [outputStream close];
}

- (void)connectFailAndCleanUp {
    NSLog(@"connectFailAndCleanUp is checked when isConnected = %d", isConnected);
    if (!isConnected) { // failed to connect -> clean up
        [self closeSocketStreams];
        [refCaller isConnected:NO withResp:@"Connect timeout"];
    }
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

/*
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
*/
- (id)initWithCaller:(id<NetworkControllerCallerDelegate>)callerIn {
    self = [super init];
    if (self) {
        //statusText = networkStatus;
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
    
    NSLog(@"Socket going to write...");
    NSInteger bytesWritten = [outputStream write:byteToSend maxLength:lengthOfDataToWrite];
    NSLog(@"Socket write %d bytes", (int)bytesWritten);
    
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

// function to parse if the received data (when it is ready, e.g., get enough bytes)
- (void)parseReceivedData {
    // Types of receving packets from server
    const static int REACTION_SET_MEDIA 	= 1;
    const static int REACTION_ASK_SENSING   = 2;
    const static int REACTION_SET_RESULT 	= 3;
    const static int REACTION_STOP_SENSING  = 4;
    const static int REACTION_SERVER_CLOSED = 5;
    
    const int OFFSET_INT = 4; // 4 bytes int
    const int OFFSET_CHECK = 1; // 1 byte check
    
    
    while (1) {
        const uint8_t* bytes = [receivedData bytes];
        const int byteLen = (int)[receivedData length];
        if (byteLen < 1) return; // quick end, no reaction to read
        
        const uint8_t action = bytes[0];
        switch (action) {
            case REACTION_SET_MEDIA: {
                const int FS_OFFSET = 1;
                const int CH_CNT_OFFSET = FS_OFFSET + OFFSET_INT;
                const int REPEAT_CNT_OFFSET = CH_CNT_OFFSET + OFFSET_INT;
                const int PREAMBLE_LEN_OFFSET = REPEAT_CNT_OFFSET + OFFSET_INT;
                
                if (byteLen < PREAMBLE_LEN_OFFSET + OFFSET_INT) return; // not enough data to parse
                
                
                
                int preambleShortToRead = NET_BYTES_TO_INT32(bytes+PREAMBLE_LEN_OFFSET);
                int SIGNAL_LEN_OFFSET = PREAMBLE_LEN_OFFSET + OFFSET_INT + preambleShortToRead*2;
                int PREAMBLE_OFFSET = PREAMBLE_LEN_OFFSET + OFFSET_INT;
                
                if (byteLen < SIGNAL_LEN_OFFSET + OFFSET_INT) return; // not enough data to parse
                
                int signalShortToRead = NET_BYTES_TO_INT32(bytes+SIGNAL_LEN_OFFSET);
                int SIGNAL_OFFSET = SIGNAL_LEN_OFFSET + OFFSET_INT;
                
                int CHECK_OFFSET = SIGNAL_LEN_OFFSET + OFFSET_INT + signalShortToRead*2;
                
                if (CHECK_OFFSET + 1 > byteLen) return; // not enough data to parse
                
                // start reading media data
                int FS = NET_BYTES_TO_INT32(bytes+FS_OFFSET);
                int chCnt = NET_BYTES_TO_INT32(bytes+CH_CNT_OFFSET);
                int repeatCnt = NET_BYTES_TO_INT32(bytes+REPEAT_CNT_OFFSET);
                char check = bytes[CHECK_OFFSET];
                
                
                if (check != -1) {
                    NSLog(@"[ERROR]: check != -1 (value = %d)", check);
                }
                
                
                int16_t *preamble = (int16_t *) malloc(sizeof(int16_t)*preambleShortToRead);
                memcpy(preamble, bytes+PREAMBLE_OFFSET, sizeof(int16_t)*preambleShortToRead);
                NSLog(@"preamble = (%d, %d, %d), short len = %d", preamble[0], preamble[1], preamble[2],preambleShortToRead);
                NSData* preambleData = [NSData dataWithBytes:preamble length:sizeof(int16_t)*preambleShortToRead];
                
                int16_t *signal = (int16_t *) malloc(sizeof(int16_t)*signalShortToRead);
                memcpy(signal, bytes+SIGNAL_OFFSET, sizeof(int16_t)*signalShortToRead);
                NSLog(@"signal = (%d, %d, %d), short len = %d", signal[0], signal[1], signal[2],signalShortToRead);
                NSData* signalData = [NSData dataWithBytes:signal length:sizeof(int16_t)*signalShortToRead];
                
                AudioSource* audioSource = [[AudioSource alloc] initWithFS:FS andChCnt:chCnt andRepeatCnt:repeatCnt andPreamble:preambleData andSignal:signalData];
                [refCaller audioReceivedFromServer:audioSource];
                /*
                int debugOffset = 1;
                NSLog(@"%d, %d, %d, %d", bytes[debugOffset], bytes[debugOffset+1], bytes[debugOffset+2], bytes[debugOffset+3]);
                */
                
                // TODO: read real audio bytes
                NSRange rangeToRemove = NSMakeRange(0, CHECK_OFFSET+OFFSET_CHECK);
                [receivedData replaceBytesInRange:rangeToRemove withBytes:NULL length:0];
                
                break;
            }
            case REACTION_ASK_SENSING: {
                NSRange rangeToRemove = NSMakeRange(0, 1);
                [receivedData replaceBytesInRange:rangeToRemove withBytes:NULL length:0];
                [refCaller serverAskStartSensing];
                break;
            }
            case REACTION_STOP_SENSING: {
                NSRange rangeToRemove = NSMakeRange(0, 1);
                [receivedData replaceBytesInRange:rangeToRemove withBytes:NULL length:0];
                [refCaller serverAskStopSensing];
                break;
            }
            case REACTION_SET_RESULT: {
                // TODO: handle this
                NSRange rangeToRemove = NSMakeRange(0, 1);
                [receivedData replaceBytesInRange:rangeToRemove withBytes:NULL length:0];
                break;
            }
            case REACTION_SERVER_CLOSED: {
                // TODO: handle the event when the server is closed
                [refCaller isConnected:NO withResp:@"Server closed"];
                
                NSRange rangeToRemove = NSMakeRange(0, 1);
                [receivedData replaceBytesInRange:rangeToRemove withBytes:NULL length:0];
                break;
            }
            default: {
                // NOTE: even we can't hanlde it, we still need to remove the action byte
                NSRange rangeToRemove = NSMakeRange(0, 1);
                [receivedData replaceBytesInRange:rangeToRemove withBytes:NULL length:0];
                break;
            }
        }
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
                if(!receivedData) {
                    receivedData = [[NSMutableData data] retain];
                }
                
                uint8_t buffer[1024];
                NSLog(@"Socket going to read...");
                NSInteger len = [inputStream read:buffer maxLength:sizeof(buffer)];
                NSLog(@"Socket read %d bytes", (int)len);
                if (len > 0) {
                    [receivedData appendBytes:buffer length:len];
                    [self parseReceivedData];
                    /*
                    NSData *dataReceived = [[NSData alloc] initWithBytes:buffer length:len];
                    NSLog(@"socket received data with len = %ld",(long)len);
                    [refCaller consumeReceivedData:dataReceived];
                    */
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