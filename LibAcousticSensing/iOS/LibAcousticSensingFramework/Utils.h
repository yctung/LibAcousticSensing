//
//  Utils.h
//  DevApp
//
//  Created by Yu-Chih on 10/3/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface Utils : NSObject
+ (void)showAlert:(UIViewController *)viewConroller withTitle:(NSString *)title message:(NSString *)message andOkCallback:(void (^)(UIAlertAction *action))handler;
@end
