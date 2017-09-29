//
//  ServerClientViewController.m
//  DevApp
//
//  Created by Yu-Chih on 2/6/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "ServerClientViewController.h"


@implementation ServerClientViewController
@synthesize startOrStopButton,debugStatus;
@synthesize asc;

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view from its nib.
    isSensing = NO;
    
    asc = [[AcousticSensingController alloc] initWithCaller:self];
    sc = [[StandaloneCallback alloc] initWithLogFolderPath:@"temp"];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}



/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

- (IBAction)connectToServer {
    //[asc createInitModeDialogWithIp:@"10.0.0.229" andPort:50005];
    [asc createInitModeDialogWithIp:@"172.20.10.2" andPort:50005];
}

- (IBAction)actionStartOrStopSensing {
    if ([asc isSensing]) {
        [asc stopSensingNow];
    } else {
        [asc startSensingNow];
    }
}

//==================================================================================================
//	Acoustic sensing controller callbacks
//==================================================================================================
- (void)updateDebugStatus: (NSString *) status {
    NSLog(@"updateDebugStatus: %@", status);
    [debugStatus setText:status];
}
- (void)unexpectedEnd:(int) code withReason: (NSString *) reason {
    
}



@end
