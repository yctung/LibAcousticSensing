//
//  ServerClientViewController.h
//  DevApp
//
//  Created by Yu-Chih on 2/6/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <UIKit/UIKit.h>


#ifndef ServerClientViewController_h
#define ServerClientViewController_h

#import "StandaloneCallback.h"
#import <LibAcousticSensingFramework/AcousticSensingController.h>
#import <LibAcousticSensingFramework/AcousticSensingControllerCallerDelegate.h>

@interface ServerClientViewController : UIViewController<AcousticSensingControllerCallerDelegate> {
    BOOL isSensing;
    AcousticSensingController *asc;
    StandaloneCallback *sc;
}

@property (retain, nonatomic) AcousticSensingController *asc;
@property (retain, nonatomic) IBOutlet UIButton *startOrStopButton;
@property (retain, nonatomic) IBOutlet UILabel *debugStatus;
- (IBAction) actionStartOrStopSensing;
- (IBAction) connectToServer;

#endif /* ServerClientViewController_h */

@end
