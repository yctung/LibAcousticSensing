//
//  RemoteSensingViewController.h
//  DevApp
//
//  Created by Yu-Chih on 10/4/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <LibAcousticSensingFramework/AcousticSensingController.h>
#import <LibAcousticSensingFramework/AcousticSensingControllerCallerDelegate.h>

@interface RemoteSensingViewController : UIViewController <AcousticSensingControllerCallerDelegate> {
    id<AcousticSensingControllerCallerDelegate> originalDelegate;
    AcousticSensingController *asc;
}

@property (nonatomic, retain) IBOutlet UILabel *labelStatus;

- (id)initWithAcousticSensingController:(AcousticSensingController *) acousticSensingController;

@end
