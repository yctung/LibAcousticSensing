//
//  NetworkControllerCallerDelegate.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/26/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "AudioSource.h"

@protocol NetworkControllerCallerDelegate <NSObject>
- (void)isConnected:(BOOL)success withResp:(NSString*) resp;
- (int)consumeReceivedData:(NSData*) dataReceived;
- (void)audioReceivedFromServer:(AudioSource *) audioSource;
- (void)serverAskStartSensing;
- (void)serverAskStopSensing;
@end
