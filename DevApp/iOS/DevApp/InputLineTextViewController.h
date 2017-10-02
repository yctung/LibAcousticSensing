//
//  InputLineTextViewController.h
//  KingFongVer2
//
//  Created by eddyxd don on 4/11/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "InputCallerDelegate.h"

@interface InputLineTextViewController : UIViewController {
	IBOutlet UITextField *lineTextInput;
	id<InputCallerDelegate> refCaller;
	NSMutableString *refLineTextString;
	NSString *customTitleString;
	IBOutlet UINavigationItem *titleItem;
	
}
@property (nonatomic, retain) IBOutlet UITextField *lineTextInput;
@property (nonatomic, assign) id refCaller;
@property (nonatomic, assign) NSMutableString *refLineTextString;
@property (nonatomic, assign) NSString *customTitleString;
@property (nonatomic, retain) IBOutlet UINavigationItem *titleItem;
- (IBAction)checkInput;
- (IBAction)cancelInput;
@end
