//
//  AudioSource.m
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 5/30/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "AudioSource.h"

@implementation AudioSource
@synthesize FS, chCnt, repeatCnt, preamble, signal;

-(id) initWithFS:(int) FSIn andChCnt:(int) chCntIn andRepeatCnt:(int) repeatCntIn andPreamble: (NSData*) preambleIn andSignal: (NSData*) signalIn {
    self = [super init];
    if (self) {
        [self setFS:FSIn];
        [self setChCnt:chCntIn];
        [self setRepeatCnt:repeatCntIn];
        [self setPreamble:preambleIn];
        [self setSignal:signalIn];
        [self setUseBottomSpeaker:NO]; // default
    }
    return self;
}

- (void)applyDeviceSensingSetting:(AcousticSensingSetting *)setting {
    if ([[setting getPlaySpeaker] isEqualToString:LIBAS_SETTING_PLAY_SPEAKER_BOTTOM]) {
        [self setUseBottomSpeaker:YES];
    } else {
        [self setUseBottomSpeaker:NO];
    }
}

@end
