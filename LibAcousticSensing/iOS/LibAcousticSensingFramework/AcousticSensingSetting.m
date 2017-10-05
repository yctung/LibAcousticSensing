//
//  AcousticSensingSetting.m
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 10/1/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "AcousticSensingSetting.h"

@implementation AcousticSensingSetting

NSString * const LIBAS_SETTING_SERVER_ADDR_KEY = @"LIBAS_SETTING_SERVER_ADDR_KEY";
NSString * const LIBAS_SETTING_SERVER_PORT_KEY = @"LIBAS_SETTING_SERVER_PORT_KEY";
NSString * const LIBAS_SETTING_MODE_KEY = @"LIBAS_SETTING_MODE_KEY";


NSString * const LIBAS_SETTING_SERVER_ADDR_DEFAULT = @"10.0.0.12";
NSString * const LIBAS_SETTING_SERVER_PORT_DEFAULT = @"50005";
NSString * const LIBAS_SETTING_MODE_REMOTE = @"Remote";
NSString * const LIBAS_SETTING_MODE_STANDALONE = @"Standalone";
NSString * const LIBAS_SETTING_MODE_DEFAULT = @"Remote";

NSString * const LIBAS_SETTING_RECORDER_MIC_KEY = @"LIBAS_SETTING_RECORDER_MIC_KEY";
NSString * const LIBAS_SETTING_RECORDER_MIC_BACK = @"Back";
NSString * const LIBAS_SETTING_RECORDER_MIC_FRONT = @"Front";
NSString * const LIBAS_SETTING_RECORDER_MIC_BOTTOM = @"Bottom";
NSString * const LIBAS_SETTING_RECORDER_MIC_DEFAULT = @"Back";

NSString * const LIBAS_SETTING_PLAY_SPEAKER_KEY = @"LIBAS_SETTING_PLAY_SPEAKER_KEY";
NSString * const LIBAS_SETTING_PLAY_SPEAKER_TOP = @"Top";
NSString * const LIBAS_SETTING_PLAY_SPEAKER_BOTTOM = @"Bottom";
NSString * const LIBAS_SETTING_PLAY_SPEAKER_DEFAULT = @"Top";

- (id)initWithEditorDelegate: (id<AcousticSensingSettingEditorDelegate>) callerIn {
    self = [super init];
    if (self) {
        caller = callerIn;
    }
    return self;
}

- (void) resetToDefaultSetting {
    UIViewController *vc = (UIViewController *)caller;
    [Utils showAlert:vc withTitle:@"Reset setting to default" message:@"Are you sure you want to give up the current setting?" andOkCallback:^(UIAlertAction *action){
        [self setMode:LIBAS_SETTING_MODE_DEFAULT];
        [self setServerAddress:LIBAS_SETTING_SERVER_ADDR_DEFAULT];
        [self setServerPort:LIBAS_SETTING_SERVER_PORT_DEFAULT];
        [caller finishEditSetting];
    }];
}

- (NSString *)getMode {
    return [self getStringFromPerf:LIBAS_SETTING_MODE_KEY defaultValue:LIBAS_SETTING_MODE_DEFAULT];
}

/*
- (void)editMode {
    [self showAlertEditForPicker:LIBAS_SETTING_MODE_KEY andTitle:LIBAS_SETTING_MODE_DEFAULT];
}
 */

- (void)setMode: (NSString *)mode {
    [[NSUserDefaults standardUserDefaults] setObject:mode forKey:LIBAS_SETTING_MODE_KEY];
}

- (NSString *)getServerAddress {
    return [self getStringFromPerf:LIBAS_SETTING_SERVER_ADDR_KEY defaultValue:LIBAS_SETTING_SERVER_ADDR_DEFAULT];
}

- (void)editServerAddress {
    [self showAlertEditForNumber:LIBAS_SETTING_SERVER_ADDR_KEY andTitle:@"Server address"];
}

- (void)setServerAddress: (NSString *)address {
    [[NSUserDefaults standardUserDefaults] setObject:address forKey:LIBAS_SETTING_SERVER_ADDR_KEY];
}

- (NSString *)getServerPort {
    return [self getStringFromPerf:LIBAS_SETTING_SERVER_PORT_KEY defaultValue:LIBAS_SETTING_SERVER_PORT_DEFAULT];
}

- (void)editServerPort {
    [self showAlertEditForNumber:LIBAS_SETTING_SERVER_PORT_KEY andTitle:@"Server port"];
}

- (void)setServerPort: (NSString *)port {
    [[NSUserDefaults standardUserDefaults] setObject:port forKey:LIBAS_SETTING_SERVER_PORT_KEY];
}

- (NSString *)getRecorderMic {
    return [self getStringFromPerf:LIBAS_SETTING_RECORDER_MIC_KEY defaultValue:LIBAS_SETTING_RECORDER_MIC_DEFAULT];
}

- (void)setRecorderMic: (NSString *)mic {
    [[NSUserDefaults standardUserDefaults] setObject:mic forKey:LIBAS_SETTING_RECORDER_MIC_KEY];
}

- (NSString *)getPlaySpeaker {
    return [self getStringFromPerf:LIBAS_SETTING_PLAY_SPEAKER_KEY defaultValue:LIBAS_SETTING_PLAY_SPEAKER_DEFAULT];
}

- (void)setPlaySpeaker: (NSString *)speaker {
    [[NSUserDefaults standardUserDefaults] setObject:speaker forKey:LIBAS_SETTING_PLAY_SPEAKER_KEY];
}

// Utility to get pref
- (NSString *)getStringFromPerf:(NSString *)key defaultValue:(NSString *) defaultValue {
    NSUserDefaults *pref = [NSUserDefaults standardUserDefaults];
    if ([pref objectForKey:key] == nil) {
        [pref setObject:defaultValue forKey:key];
    }
    return [pref stringForKey:key];
}



// Utility input alert controller creations
- (void)showAlertEditForNumber: (NSString *) key andTitle: (NSString *) title {
    NSUserDefaults *pref = [NSUserDefaults standardUserDefaults];
    UIAlertController *alertController = [UIAlertController alertControllerWithTitle: title
                                                                              message: @"Please input"
                                                                       preferredStyle:UIAlertControllerStyleAlert];
    [alertController addTextFieldWithConfigurationHandler:^(UITextField *textField) {
        textField.placeholder = [pref stringForKey:key];
        textField.text = [pref stringForKey:key];
        textField.textColor = [UIColor blueColor];
        textField.clearButtonMode = UITextFieldViewModeWhileEditing;
        textField.borderStyle = UITextBorderStyleRoundedRect;
        textField.keyboardType = UIKeyboardTypeDecimalPad;
    }];
    [alertController addAction:[UIAlertAction actionWithTitle:@"OK" style:UIAlertActionStyleDefault handler:^(UIAlertAction *action) {
        NSArray * textfields = alertController.textFields;
        UITextField * numberfield = textfields[0];
        NSLog(@"input number = %@", numberfield.text);
        
        [pref setObject:numberfield.text forKey:key];
        [caller finishEditSetting];
    }]];
    
    UIViewController *vc = (UIViewController *)caller;
    [vc presentViewController:alertController animated:YES completion:nil];
}
// NOTE: not working
/*
- (void)showAlertEditForPicker: (NSString *) key andTitle: (NSString *) title {
    // ref: https://stackoverflow.com/questions/25545982/is-there-any-way-to-add-uipickerview-into-uialertcontroller-alert-or-actionshee
    NSUserDefaults *pref = [NSUserDefaults standardUserDefaults];
    UIAlertController *alertController = [UIAlertController alertControllerWithTitle: title
                                                                             message: @"Please input"
                                                                      preferredStyle:UIAlertControllerStyleActionSheet];
    CGRect pickerFrame = CGRectMake(17, 52, 270, 100); // CGRectMake(left), top, width, height) - left and top are like margins
    UIPickerView *picker = [[UIPickerView alloc] initWithFrame:pickerFrame];
    
    picker.tag = 1; // use this to differentiate
    
    //picker.delegate = self;
    //picker.dataSource = self;
    [[alertController view] addSubview:picker];
    
    
    UIViewController *vc = (UIViewController *)caller;
    [vc presentViewController:alertController animated:YES completion:nil];
}
 */

@end
