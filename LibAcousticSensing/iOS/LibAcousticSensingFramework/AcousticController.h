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
#import "AudioPlayer.h"
#import "AudioSource.h"
#import "AudioRecorderCallerDelegate.h"
#import "NetworkController.h"
#import "TraceSaver.h"
#import "TraceSaverCallerDelegate.h"
#import "RecordSetting.h"

@interface AcousticController : NSObject <AudioRecorderCallerDelegate, TraceSaverCallerDelegate, AVAudioPlayerDelegate>{
    AVAudioPlayer *avAudioPlayer;
    AudioPlayer *audioPlayer;
    AudioRecorder *audioRecorder; // use my own customized audio recorder
    TraceSaver *audioTraceSaver;
    NetworkController *refNetworkController;
}
@property (retain, nonatomic) id<AcousticControllerCallerDelegate> refCaller;
@property (retain, nonatomic) NSString *surveyBaseFolderPath;
@property (nonatomic) UInt32 currentRecordedSampleCnt;
//@property (retain, nonatomic) AudioSource *audioSource;

//- (id)initAudioToPlay:(NSString *)audioSourceName WithCaller:(id<AcousticControllerCallerDelegate>) caller withNetworkController:(NetworkController*) networkController;
- (id)initWithAudioSource: (AudioSource*)audioSource recordSetting:(RecordSetting *)recordSetting andCaller:(id<AcousticControllerCallerDelegate>) caller;
- (void)startSurveyButDontPlaySound;
- (void)startSurvey;
- (void)stopSurvey; // force to stop survey
- (BOOL)isSensing;
- (void)finalizeSurvey; // finalize the acoustic controller
+ (BOOL)setAudioSessionWithAudioSource:(AudioSource *)audioSource andRecordSetting:(RecordSetting *)recordSetting;
@end
