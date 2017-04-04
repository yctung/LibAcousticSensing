//
//  ServerClientViewController.h
//  DevApp
//
//  Created by Yu-Chih on 2/6/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <LibAcousticSensingFramework/AcousticSensingController.h>

@interface ServerClientViewController : UIViewController {
    BOOL isSensing;
    AcousticSensingController *asc;
}

@property (retain, nonatomic) AcousticSensingController *asc;
@property (retain, nonatomic) IBOutlet UIButton *startOrStopButton;
- (IBAction) actionStartOrStopSensing;


@end
