//
//  AcousticSensingController.m
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 2/6/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "AcousticSensingController.h"

@implementation AcousticSensingController


// fucntion to show the customized dialog for initialization
// ref: http://stackoverflow.com/questions/10389635/uialertview-with-two-textfields-and-two-buttons
- (void) createInitModeDialog {
    UIAlertView *av = [[UIAlertView alloc] initWithTitle:@"Your_Title" message:@"Your_message" delegate:self cancelButtonTitle:@"Cancel" otherButtonTitles:@"OK", nil];
    [av setAlertViewStyle:UIAlertViewStyleLoginAndPasswordInput];
    
    // Alert style customization
    [[av textFieldAtIndex:1] setSecureTextEntry:NO];
    [[av textFieldAtIndex:0] setPlaceholder:@"First_Placeholder"];
    [[av textFieldAtIndex:1] setPlaceholder:@"Second_Placeholder"];
    [av show];
}

@end
