//
//  AcousticControllerCallerDelegate.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/30/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <Foundation/Foundation.h>

@protocol AcousticControllerCallerDelegate <NSObject>

- (void)audioRecorded:(UInt32)byteSize audioData:(void *)audioData currentRecordedSampleCnt:(UInt32) currentRecordedSampleCnt;
- (void)onSurveyEnd;
@end
