//
//  AcousticSensingController.h
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 2/6/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
//#import "NetworkController.h"

#ifndef AcousticSensingController_h
#define AcousticSensingController_h

#import "NetworkControllerCallerDelegate.h"
#import "AcousticControllerCallerDelegate.h"
#import "AcousticSensingControllerCallerDelegate.h"
#import "AcousticSensingSetting.h"
#import "AudioSource.h"
#import "AcousticController.h"
#import "NetworkController.h"
#import "NetworkControllerCallerDelegate.h"
#import "RecordSetting.h"

@interface AcousticSensingController : NSObject<UIAlertViewDelegate, NetworkControllerCallerDelegate, AcousticControllerCallerDelegate> {
    AcousticSensingSetting *setting;
    RecordSetting *recordSetting;
    id<AcousticSensingControllerCallerDelegate> caller;
    int audioMode;
    AudioSource* audioSource;
    NetworkController* nc;
    AcousticController* ac;
}

- (id)initWithCaller: (id<AcousticSensingControllerCallerDelegate>) callerIn;
//- (void) createInitModeDialogWithIp: (NSString*) serverIpDefault andPort: (int) serverPortDefault;
- (BOOL) setSensingSetting: (AcousticSensingSetting *)setting;
- (void) startSensingNow;
- (void) stopSensingNow;
- (BOOL) isSensing;
- (id<AcousticSensingControllerCallerDelegate>)getDelegate;
- (void)setDelegate:(id<AcousticSensingControllerCallerDelegate>)delegate;
@end

#endif /* AcousticSensingController_h */