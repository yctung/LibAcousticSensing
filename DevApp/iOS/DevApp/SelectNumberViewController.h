//
//  SelectNumberViewController.h
//  KingFongVer2
//
//  Created by eddyxd don on 3/6/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "InputCallerDelegate.h"


@interface SelectNumberViewController : UIViewController {
	IBOutlet UITextField *numberInput;
	IBOutlet UILabel *titleLabel;
	IBOutlet UINavigationItem *titleItem;
	NSString *customTitleString;
	NSMutableString *refNumberString;
	id<InputCallerDelegate> refCaller;
}
@property (nonatomic, retain) IBOutlet UITextField *numberInput;
@property (nonatomic, retain) IBOutlet UILabel *titleLabel;
@property (nonatomic, retain) IBOutlet UINavigationItem *titleItem;
@property (nonatomic, assign) NSMutableString *refNumberString;
@property (nonatomic, assign) NSString *customTitleString;
@property (nonatomic, assign) id refCaller;

- (IBAction)checkSelection;
- (IBAction)cancelSelection;
- (IBAction)changeNumberHandler:(id)sender;

@end
