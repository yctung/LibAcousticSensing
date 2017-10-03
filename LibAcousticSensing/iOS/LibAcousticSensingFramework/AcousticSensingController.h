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

@interface AcousticSensingController : NSObject<UIAlertViewDelegate, NetworkControllerCallerDelegate, AcousticControllerCallerDelegate> {
    AcousticSensingSetting *setting;
    id<AcousticSensingControllerCallerDelegate> caller;
}

- (id)initWithCaller: (id<AcousticSensingControllerCallerDelegate>) callerIn;
//- (void) createInitModeDialogWithIp: (NSString*) serverIpDefault andPort: (int) serverPortDefault;
- (BOOL) setSensingSetting: (AcousticSensingSetting *)setting;
- (void) startSensingNow;
- (void) stopSensingNow;
- (BOOL) isSensing;
@end

#endif /* AcousticSensingController_h */