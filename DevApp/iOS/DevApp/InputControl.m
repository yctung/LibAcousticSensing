//
//  InputControl.m
//  KingFongVer2
//
//  Created by eddyxd don on 4/30/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import "InputControl.h"
#import "AppConstant.h"

@implementation InputControl

+ (BOOL)hasChanged:(NSString *) target{
    if ([target isEqualToString:INPUT_TEXT_DEFAULT]) {
        return NO;
    }
	return YES;
}

@end
