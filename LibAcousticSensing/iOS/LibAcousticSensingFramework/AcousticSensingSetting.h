//
//  AcousticSensingSetting.h
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 10/1/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "AcousticControllerCallerDelegate.h"

extern NSString * const LIBAS_SETTING_SERVER_ADDR_KEY;

@interface AcousticSensingSetting : NSObject {
    id<AcousticControllerCallerDelegate> caller;
}
- (id)initWithEditorDelegate: (id<AcousticControllerCallerDelegate>) callerIn;
- (NSString *)getServerAddress;
- (void)editServerAddress;
- (void)setServerAddress: (NSString *)address;

@end
