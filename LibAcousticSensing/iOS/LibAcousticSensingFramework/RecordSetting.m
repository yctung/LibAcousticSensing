//
//  RecordSetting.m
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 10/4/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "RecordSetting.h"

@implementation RecordSetting

- (id)init {
    self = [super init];
    if (self) {
        recordFS = 48000; // TODO: get from setting
        micDataSource = AVAudioSessionOrientationBack;
    }
    
    return self;
}

- (int) getRecordFS {
    return recordFS;
}

- (NSString *)getMicDataSource {
    return micDataSource;
}

- (void)applyDeviceSensingSetting:(AcousticSensingSetting *)setting {
    NSString *mic = [setting getRecorderMic];
    extern NSString * const LIBAS_SETTING_RECORDER_MIC_BACK;
    extern NSString * const LIBAS_SETTING_RECORDER_MIC_FRONT;
    extern NSString * const LIBAS_SETTING_RECORDER_MIC_BOTTOM;
    if ([mic isEqualToString:LIBAS_SETTING_RECORDER_MIC_BACK]) {
        micDataSource = AVAudioSessionOrientationBack;
    } else if ([mic isEqualToString:LIBAS_SETTING_RECORDER_MIC_FRONT]) {
        micDataSource = AVAudioSessionOrientationFront;
    } else if ([mic isEqualToString:LIBAS_SETTING_RECORDER_MIC_BOTTOM]) {
        micDataSource = AVAudioSessionOrientationBottom;
    } else {
        NSLog(@"[ERROR]: undefined mic = %@", mic);
        micDataSource = AVAudioSessionOrientationBack; // default
    }
}


@end
