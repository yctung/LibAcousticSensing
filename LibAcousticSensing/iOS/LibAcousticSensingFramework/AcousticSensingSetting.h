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

extern NSString * const LIBAS_SETTING_SERVER_ADDR_KEY;
extern NSString * const LIBAS_SETTING_SERVER_PORT_KEY;
extern NSString * const LIBAS_SETTING_MODE_KEY;

extern NSString * const LIBAS_SETTING_SERVER_ADDR_DEFAULT;
extern NSString * const LIBAS_SETTING_SERVER_PORT_DEFAULT;
extern NSString * const LIBAS_SETTING_MODE_REMOTE;
extern NSString * const LIBAS_SETTING_MODE_STANDALONE;
extern NSString * const LIBAS_SETTING_MODE_DEFAULT;



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

@end
