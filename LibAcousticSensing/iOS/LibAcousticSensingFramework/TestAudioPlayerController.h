//
//  TestAudioPlayerController.h
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 6/25/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <stdlib.h>
#import "AudioPlayer.h"
#import "AudioSource.h"

@interface TestAudioPlayerController : NSObject {
    AudioPlayer *player;
    AudioSource *source;
}


- (void) start;
@end
