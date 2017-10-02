//
//  InputViewControllerCollection.h
//  KingFongVer2
//
//  Created by eddyxd don on 4/10/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "InputCallerDelegate.h"
@class SelectNumberViewController;
@class SelectDateViewController;
@class SelectWorkTypeViewController;
@class SelectOptionViewController;
@class InputTextViewController;
@class InputLineTextViewController;
@class SelectOverlay;

@interface InputViewControllerCollection : NSObject {
	SelectNumberViewController *selectNumber;
	SelectDateViewController *selectDate;
	SelectWorkTypeViewController *selectWorkType;
    SelectOptionViewController *selectOption;
	InputTextViewController *inputText;
	InputLineTextViewController *inputLineText;
	NSString *controlString;
	UIViewController<InputCallerDelegate> *refCaller;
	SelectOverlay *selectOverlay;
}
@property (nonatomic, retain) SelectNumberViewController *selectNumber;
@property (nonatomic, retain) SelectDateViewController *selectDate;
@property (nonatomic, retain) SelectWorkTypeViewController *selectWorkType;
@property (nonatomic, retain) SelectOptionViewController *selectOption;
@property (nonatomic, retain) InputTextViewController *inputText;
@property (nonatomic, retain) InputLineTextViewController *inputLineText;
@property (nonatomic, retain) NSString *controlString;
@property (nonatomic, assign) UIViewController<InputCallerDelegate>* refCaller;
@property (nonatomic, retain) SelectOverlay *selectOverlay;

- (id)initWithControlString:(NSString*)controlStringIn andCaller:(UIViewController<InputCallerDelegate>*)refCallerIn;
- (void)updateOptions: (NSArray*) array;
- (void)clean;
- (void)show:(NSString*)optionStringIn;
@end
