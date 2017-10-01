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

- (NSString *)getServerAddress {
    NSUserDefaults *pref = [NSUserDefaults standardUserDefaults];
    if ([pref objectForKey:LIBAS_SETTING_SERVER_ADDR_KEY] == nil) {
        return @"haha";
    } else {
        return [pref stringForKey:LIBAS_SETTING_SERVER_ADDR_KEY];
    }
}

@end
