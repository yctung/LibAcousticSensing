//
//  NetworkController.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/25/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "NetworkControllerCallerDelegate.h"
#import "Constant.h"

#ifndef NetworkController_h
#define NetworkController_h

// internal constant (unable to be seen outside of this class)
// ref:http://stackoverflow.com/questions/6188672/where-do-you-declare-a-constant-in-objective-c
static const char SET_TYPE_STRING = 2;
static const char SET_TYPE_VALUE_STRING = 5; // sent value by string

@interface NetworkController : NSObject<NSStreamDelegate> {
    UILabel *statusText;
    BOOL isConnected;
    //id<NetworkControllerCallerDelegate> refCaller;
    
    int currentDataToSendOffset;

    
    NSInputStream *inputStream;
    NSOutputStream *outputStream;
    NSMutableArray *dataWaitToSend;
    BOOL okToSendDataDirectly;
}

@property (nonatomic, retain) id<NetworkControllerCallerDelegate> refCaller;

- (BOOL)getIsConnected;
- (id)initWithUILabel:(UILabel *) networkStatus andCaller:(id<NetworkControllerCallerDelegate>)callerIn;
- (void)sendInitAction;
- (void)sendSetStringAction:(NSString*)name andStringToSet:(NSString *) dataString;
- (void)sendSetValueStringAction:(NSString*)name andStringToSet:(NSString *) dataString;
- (void)sendData:(UInt32)byteSize audioData:(void *)audioData;
- (void)connectServer;
- (void)closeServer;


@end

#endif /* NetworkController_h */
