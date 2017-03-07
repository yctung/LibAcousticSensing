//
//  AcousticController.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/30/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//  2015/10/30: a controller functioned as Android's SpectrumSurvey

#import <Foundation/Foundation.h>
#import <AVFoundation/AVFoundation.h>
#import "AcousticControllerCallerDelegate.h"
#import "AudioRecorder.h"
#import "AudioRecorderCallerDelegate.h"
#import "NetworkController.h"
#import "TraceSaver.h"
#import "TraceSaverCallerDelegate.h"

@interface AcousticController : NSObject <AudioRecorderCallerDelegate, TraceSaverCallerDelegate, AVAudioPlayerDelegate>{
    AVAudioPlayer *audioPlayer;
    AudioRecorder *audioRecorder; // use my own customized audio recorder
    TraceSaver *audioTraceSaver;
    NetworkController *refNetworkController;
}
@property (retain, nonatomic) id<AcousticControllerCallerDelegate> refCaller;
@property (retain, nonatomic) NSString *surveyBaseFolderPath;
@property (nonatomic) UInt32 currentRecordedSampleCnt;

- (id)initAudioToPlay:(NSString *)audioSourceName WithCaller:(id<AcousticControllerCallerDelegate>) caller withNetworkController:(NetworkController*) networkController;
- (void)startSurveyButDontPlaySound;
- (void)startSurvey;
- (void)stopSurvey; // force to stop survey
- (void)finalizeSurvey; // finalize the acoustic controller

@end
