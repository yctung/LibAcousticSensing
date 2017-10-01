//
//  InputViewControllerCollection.m
//  KingFongVer2
//
//  Created by eddyxd don on 4/10/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import "InputViewControllerCollection.h"
#import "SelectNumberViewController.h"
#import "SelectOptionViewController.h"
#import "InputTextViewController.h"
#import "InputLineTextViewController.h"
#import "SelectOverlay.h"
#import "AppConstant.h"
#import "AppDelegate.h"

@implementation InputViewControllerCollection
@synthesize selectNumber,selectDate,selectWorkType,inputText,inputLineText,controlString,refCaller,selectOverlay, selectOption;
- (id)initWithControlString:(NSString*)controlStringIn andCaller:(UIViewController<InputCallerDelegate>*)refCallerIn{
	if ((self = [super init])) {
		[self setControlString:controlStringIn];
		[self setRefCaller:refCallerIn];
		
		selectOverlay = [[SelectOverlay alloc] init];
		[selectOverlay setRefCaller:refCaller];
		
		NSRange range;
		range = [controlString rangeOfString:@"N"];
		if (range.location!=NSNotFound) {
			selectNumber = [[SelectNumberViewController alloc] initWithNibName:@"SelectNumber" bundle:nil];
			[[selectNumber view] setTag:5566];
			[selectNumber setRefCaller:refCaller];
		}
		
        range = [controlString rangeOfString:@"O"];
        if (range.location!=NSNotFound) {
            selectOption = [[SelectOptionViewController alloc] initWithNibName:@"SelectOption" bundle:nil];
            [[selectOption view] setTag:5566];
            [selectOption setRefCaller:refCaller];
        }
		
		range = [controlString rangeOfString:@"T"];
		if (range.location!=NSNotFound) {
			inputText = [[InputTextViewController alloc] initWithNibName:@"InputText" bundle:nil];
			[[inputText view] setTag:5566];
			[inputText setRefCaller:refCaller];
		}
		
		range = [controlString rangeOfString:@"L"];
		if (range.location!=NSNotFound) {
			inputLineText = [[InputLineTextViewController alloc] initWithNibName:@"InputLineText" bundle:nil];
			[[inputLineText view] setTag:5566];
			[inputLineText setRefCaller:refCaller];
		}
		
	}

	return self;
}

- (void)updateOptions: (NSArray*) array {
    [selectOption updateDataArray:array];
}

- (void)show:(NSString*)optionStringIn {
	// 1. check if input string
	NSRange range = [controlString rangeOfString:optionStringIn];
	if (range.location == NSNotFound || optionStringIn.length!=1) {
		NSLog(@"ERROR : controlString don't conatin option : %@, or format error",optionStringIn);
		return;
	}
	
	AppDelegate *refDelegate = [[UIApplication sharedApplication] delegate];
	
	if ([optionStringIn isEqualToString:@"N"]) {
		[selectOverlay show];
		[[refDelegate window] addSubview:selectNumber.view];
    } else if ([optionStringIn isEqualToString:@"O"]) {
        [selectOverlay show];
        [[refDelegate window] addSubview:selectOption.view];
	} else if ([optionStringIn isEqualToString:@"T"]) {
		[selectOverlay show];
		[[refDelegate window] addSubview:inputText.view];
	} else if ([optionStringIn isEqualToString:@"L"]) {
		[selectOverlay show];
		[[refDelegate window] addSubview:inputLineText.view];
	} else {
		NSLog(@"ERROR : undefined option : %@",optionStringIn);
		return;
	}
}

- (void)clean {
	AppDelegate *refDelegate = [[UIApplication sharedApplication] delegate];
	for(UIView *subview in [[refDelegate window] subviews]){
		if([subview tag]==INPUT_VIEW_TAG){
			[subview removeFromSuperview];
		}
	}
	[selectOverlay disapper];
}

- (void)dealloc {
	NSLog(@"InputCollection : dealloc");
	[self clean];
	
	if(selectNumber!=nil)[selectNumber release];
	if(selectDate!=nil)[selectDate release];
    if(selectOption!=nil)[selectOption release];
	if(selectWorkType!=nil)[selectWorkType release];
	if(inputText!=nil)[inputText release];
	if(inputLineText!=nil)[inputLineText release];
	[selectOverlay release];
	[super dealloc];
}
@end
