//
//  RemoteSensingViewController.m
//  DevApp
//
//  Created by Yu-Chih on 10/4/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "RemoteSensingViewController.h"

@interface RemoteSensingViewController ()

@end

@implementation RemoteSensingViewController
@synthesize labelStatus;

- (id)initWithAcousticSensingController:(AcousticSensingController *) acousticSensingController {
    self = [super initWithNibName:@"RemoteSensingViewController" bundle:nil];
    if (self) {
        asc = acousticSensingController;
        originalDelegate = [asc getDelegate];
        [asc setDelegate:self];
    }
    return self;
}

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view from its nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)viewWillDisappear:(BOOL)animated {
    [super viewWillDisappear:animated];
    
    // We assume it is only possible the view is disapeared when the back button is clicked
    // ref: https://stackoverflow.com/questions/6091867/find-out-if-user-pressed-the-back-button-in-uinavigationcontroller
    NSLog(@"viewWillDisappear");
    if ([self isMovingFromParentViewController]) {
        NSLog(@"Back button is clicked");
        [self onEndOfRemoteSensing];
    }
}

- (void)onEndOfRemoteSensing {
    // recover the original delegate
    [asc setDelegate:originalDelegate];
}


/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

//==================================================================================================
//	Acoustic sensing controller callbacks
//==================================================================================================
- (void)updateDebugStatus:(NSString *)status {
    NSLog(@"updateDebugStatus: %@", status);
    //[debugStatus setText:status];
}
- (void)unexpectedEnd:(int)code withReason:(NSString *)reason {
    
}

- (void)readyToSense:(BOOL)isReadyToSense message:(NSString *)message {
    NSLog(@"readyToSense: %d, message = %@", isReadyToSense, message);
    if (!isReadyToSense) {
        // server might be closed remotely
        [originalDelegate updateDebugStatus:@"Server is closed remotely"];
        [[self navigationController] popViewControllerAnimated:YES];
    }
}

- (void)sensingStarted {
    [labelStatus setText:@"Sensing..."];
}
- (void)sensingFinished {
    [labelStatus setText:@"Finshed"];
}

@end
