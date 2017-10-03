//
//  Utils.m
//  DevApp
//
//  Created by Yu-Chih on 10/3/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "Utils.h"

@implementation Utils

+ (void)showAlert:(UIViewController *)viewConroller withTitle:(NSString *)title message:(NSString *)message andOkCallback:(void (^)(UIAlertAction *action))handler {
    UIAlertController *alertController = [UIAlertController alertControllerWithTitle: title
                                                                             message: message
                                                                      preferredStyle:UIAlertControllerStyleAlert];
    [alertController addAction:[UIAlertAction actionWithTitle:@"Cancel" style:UIAlertActionStyleCancel handler:nil]];
    [alertController addAction:[UIAlertAction actionWithTitle:@"OK" style:UIAlertActionStyleDefault handler:handler]];
    
    [viewConroller presentViewController:alertController animated:YES completion:nil];
}

@end
