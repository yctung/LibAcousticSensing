//
//  TestAudioPlayerController.m
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 6/25/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "TestAudioPlayerController.h"

@implementation TestAudioPlayerController

- (id) init {
    self = [super init];
    if (self) {
        short shorts[48000];
        for (int i=0;i<48000;i++) {
            shorts[i] = arc4random_uniform(65535) - 32768;
        }
        void *ptr = (void *) shorts;
        NSData *pData = [[NSData dataWithBytes:ptr length:48000*2] retain];
        NSData *sData = [[NSData dataWithBytes:ptr length:48000*2] retain];
        source = [[[AudioSource alloc] initWithFS:48000 andChCnt:1 andRepeatCnt:100 andPreamble:pData andSignal:sData] retain];
        player = [[[AudioPlayer alloc] initWithAudioSource:source] retain];
    }
    return self;
}


- (void) start {
    NSLog(@"Test start");
    [player startPlaying];
}

@end
