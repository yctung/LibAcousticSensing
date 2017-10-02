//
//  C.m
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/27/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//  2015/10/27: just a global calsss to store static variables

#import <Foundation/Foundation.h>

#import "LibConstant.h"

@implementation LibConstant
    // Global control
    int const C_DEVICE_IDX_IPHONE = 0;
    BOOL const C_TRACE_SAVE_TO_FILE = NO;
    // NOTE: Can only select one of TRACE_REALTIME_PROCESSING/TRACE_SEND_TO_NETWORK
    BOOL const C_TRACE_REALTIME_PROCESSING = NO;
    BOOL const C_TRACE_SEND_TO_NETWORK = YES;

    // Network setting
    //
    //NSString * const C_SERVER_ADDR = @"10.0.0.12"; // Umich5566 in office
    //NSString * const C_SERVER_ADDR = @"192.168.1.143"; // Home
    //NSString * const C_SERVER_ADDR_DEFAULT = @"192.168.0.108"; // Taiwan
    //NSString * const C_SERVER_ADDR = @"35.2.25.249"; // MWireless
    //int const C_DETECT_SERVER_PORT = 50009;
    //int const C_TRIGGER_SERVER_PORT = 50010;


    // Folder and file setting
    NSString * const C_APP_FOLDER_NAME = @"AudioAna";
    NSString * const C_INPUT_PREFIX = @"source_";
    NSString * const C_OUTPUT_FOLDER = @"DataOutput/";
    NSString * const C_DEBUG_FOLDER = @"DebugOutput/";

    // Motion setting
    NSString * const C_MOTION_TRACE_FILE_NAME = @"motion.dat";
    double C_MOTION_UPDATE_INTERVAL = 0.02; // seconds

    int C_BIG_MOTION_DETECT_IN_RANGE_SAMPLE_SIZE = 48000*1; // i.e. 1 sec
    double C_BIG_MOTION_DETECT_IN_ACC_METRIC_THRE = 0.5;
    double C_BIG_MOTION_DETECT_IN_ACC_MAX_THRE = 1.0;
    double C_BIG_MOTION_DETECT_IN_GYRO_METRIC_THRE = 1.0;
    double C_BIG_MOTION_DETECT_IN_GYRO_MAX_THRE = 2.5;


    double C_BIG_MOTION_DETECT_MAX_RESET_DELAY = 1.5; // sec

    // Force setting
    NSString * const C_FORCE_TRACE_FILE_NAME = @"force.dat";

    // Audio setting
    int C_RECORDER_SAMPLERATE = 48000;
    int C_RECORDER_CHANNEL = 1;
    double C_PLAYER_VOL = 1.0; // *** just for debu -> need to get back in futrue ***

    BOOL C_PLAYER_USE_BOTTOM_SPEAKER = NO;

    //NSString * C_AUDIO_SOURCE = @"48000rate-5000repeat-2400period+chirp-18000Hz-24000Hz-1200samples+namereduced";
    //NSString * const C_AUDIO_SOURCE_PREFIX = @"source_";

    //NSString * C_AUDIO_SOURCE = @"latestAudioToEstimateFreqResp"; // no need .wav
    NSString * C_AUDIO_SOURCE = @"latestAudioToCheckAGC"; // no need .wav


    NSString * const C_AUDIO_SOURCE_PREFIX = @"";

    NSString * const C_AUDIO_SOURCE_SUFFIX = @".wav";
    NSString * const C_TRACE_AUDIO_PREFIX = @"record_";

    // Log setting
    NSString* const C_LOG_TAG_METER_FROM_OBJECT = @"mfo";
    NSString* const C_LOG_TAG_PRESSURE_SENSITIVE_ENABLE = @"pse";
    NSString* const C_LOG_TAG_SQUEEZE_SENSITIVE_ENALBE = @"sse";
    NSString* const C_LOG_TAG_SET_TRIGGER = @"trg";
    NSString* const C_LOG_TAG_NOISE_TEST = @"nos";
    NSString* const C_LOG_TAG_DELAY_TEST = @"dly";
    NSString* const C_LOG_TAG_CALIBRATE = @"clb"; // calibrate by scale
@end
