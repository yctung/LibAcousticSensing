//
//  C.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/27/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//
#import <Foundation/Foundation.h>
#import <AVFoundation/AVFoundation.h>

extern int const C_DEVICE_IDX_IPHONE;
extern BOOL const C_TRACE_SAVE_TO_FILE;
extern BOOL const C_TRACE_REALTIME_PROCESSING;
extern BOOL const C_TRACE_SEND_TO_NETWORK;


extern NSString * const C_SERVER_ADDR;
extern int const C_DETECT_SERVER_PORT;
extern int const C_TRIGGER_SERVER_PORT;

extern NSString * const C_APP_FOLDER_NAME;
extern NSString * const C_INPUT_PREFIX;
extern NSString * const C_OUTPUT_FOLDER;
extern NSString * const C_DEBUG_FOLDER;
extern int C_RECORDER_SAMPLERATE;
extern NSString * const C_TRACE_AUDIO_PREFIX;

extern NSString * const C_MOTION_TRACE_FILE_NAME;
extern double C_MOTION_UPDATE_INTERVAL;
extern int C_BIG_MOTION_DETECT_IN_RANGE_SAMPLE_SIZE;
extern double C_BIG_MOTION_DETECT_IN_ACC_METRIC_THRE;
extern double C_BIG_MOTION_DETECT_IN_GYRO_METRIC_THRE;
extern double C_BIG_MOTION_DETECT_IN_ACC_MAX_THRE;
extern double C_BIG_MOTION_DETECT_IN_GYRO_MAX_THRE;
extern double C_BIG_MOTION_DETECT_MAX_RESET_DELAY;

extern NSString * const C_FORCE_TRACE_FILE_NAME;

extern int C_RECORDER_SAMPLERATE;
extern int C_RECORDER_CHANNEL;
extern double C_PLAYER_VOL;
extern BOOL C_PLAYER_USE_BOTTOM_SPEAKER;
extern NSString * C_AUDIO_SOURCE;
extern NSString * const C_AUDIO_SOURCE_PREFIX;
extern NSString * const C_AUDIO_SOURCE_SUFFIX;
extern NSString * const C_TRACE_AUDIO_PREFIX;

extern NSString* const C_LOG_TAG_METER_FROM_OBJECT;
extern NSString* const C_LOG_TAG_PRESSURE_SENSITIVE_ENABLE;
extern NSString* const C_LOG_TAG_SQUEEZE_SENSITIVE_ENALBE;
extern NSString* const C_LOG_TAG_SET_TRIGGER;
extern NSString* const C_LOG_TAG_NOISE_TEST;
extern NSString* const C_LOG_TAG_DELAY_TEST;
extern NSString* const C_LOG_TAG_CALIBRATE;

@interface LibConstant : NSObject {
    
}

@end

