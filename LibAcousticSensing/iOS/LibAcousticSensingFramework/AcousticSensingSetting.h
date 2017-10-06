//
//  AcousticSensingSetting.h
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 10/1/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import "AcousticSensingSettingEditorDelegate.h"
#import "Utils.h"

extern NSString * const LIBAS_SETTING_MODE_KEY;
extern NSString * const LIBAS_SETTING_MODE_REMOTE;
extern NSString * const LIBAS_SETTING_MODE_STANDALONE;
extern NSString * const LIBAS_SETTING_MODE_DEFAULT;

extern NSString * const LIBAS_SETTING_SERVER_ADDR_KEY;
extern NSString * const LIBAS_SETTING_SERVER_ADDR_DEFAULT;

extern NSString * const LIBAS_SETTING_SERVER_PORT_KEY;
extern NSString * const LIBAS_SETTING_SERVER_PORT_DEFAULT;

extern NSString * const LIBAS_SETTING_RECORDER_MIC_KEY;
extern NSString * const LIBAS_SETTING_RECORDER_MIC_BACK;
extern NSString * const LIBAS_SETTING_RECORDER_MIC_FRONT;
extern NSString * const LIBAS_SETTING_RECORDER_MIC_BOTTOM;
extern NSString * const LIBAS_SETTING_RECORDER_MIC_DEFAULT;

extern NSString * const LIBAS_SETTING_PLAY_SPEAKER_KEY;
extern NSString * const LIBAS_SETTING_PLAY_SPEAKER_TOP;
extern NSString * const LIBAS_SETTING_PLAY_SPEAKER_BOTTOM;
extern NSString * const LIBAS_SETTING_PLAY_SPEAKER_DEFAULT;


@interface AcousticSensingSetting : NSObject {
    id<AcousticSensingSettingEditorDelegate> caller;
}
- (id)initWithEditorDelegate: (id<AcousticSensingSettingEditorDelegate>) callerIn;

- (void)resetToDefaultSetting;

- (NSString *)getMode;
//- (void)editMode;
- (void)setMode: (NSString *)mode;

- (NSString *)getServerAddress;
- (void)editServerAddress;
- (void)setServerAddress: (NSString *)address;

- (NSString *)getServerPort;
- (void)editServerPort;
- (void)setServerPort: (NSString *)port;

- (NSString *)getRecorderMic;
- (void)setRecorderMic: (NSString *)mic;

- (NSString *)getPlaySpeaker;
- (void)setPlaySpeaker: (NSString *)speaker;

@end
