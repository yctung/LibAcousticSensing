//
//  InputTextViewController.h
//  KingFongVer2
//
//  Created by eddyxd don on 4/10/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "InputCallerDelegate.h"

@interface InputTextViewController : UIViewController {
	IBOutlet UITextView *inputText;
	UITextView *refTextView;
	id<InputCallerDelegate> refCaller;
	IBOutlet UINavigationItem *titleItem;
}

- (IBAction)checkInput;
- (IBAction)cancelInput;
@property (nonatomic, retain) IBOutlet UITextView *inputText;
@property (nonatomic, assign) UITextView *refTextView;
@property (nonatomic, assign) id refCaller;
@property (nonatomic, retain) IBOutlet UINavigationItem *titleItem;

@end
