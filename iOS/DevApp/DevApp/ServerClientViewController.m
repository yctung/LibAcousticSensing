//
//  ServerClientViewController.m
//  DevApp
//
//  Created by Yu-Chih on 2/6/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "ServerClientViewController.h"


@implementation ServerClientViewController
@synthesize startOrStopButton;
@synthesize asc;

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view from its nib.
    isSensing = NO;
    
    asc = [[AcousticSensingController alloc] init];
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


- (IBAction)actionStartOrStopSensing {
    [asc createInitModeDialogWithIp:@"35.2.195.254" andPort:50005];
}

@end
