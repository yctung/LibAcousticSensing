//
//  InputLineTextViewController.m
//  KingFongVer2
//
//  Created by eddyxd don on 4/11/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import "InputLineTextViewController.h"
#import "AppConstant.h"

#define DEFAULT_TITLE_STRING (@"Please input text")

@implementation InputLineTextViewController
@synthesize lineTextInput,refCaller,refLineTextString,customTitleString,titleItem;

 // The designated initializer.  Override if you create the controller programmatically and want to perform customization that is not appropriate for viewDidLoad.
- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil {
    if ((self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil])) {
        // Custom initialization
    }
    return self;
}



// Implement viewDidLoad to do additional setup after loading the view, typically from a nib.
- (void)viewDidLoad {
    [super viewDidLoad];
	[lineTextInput becomeFirstResponder];
}

- (void)viewDidAppear:(BOOL)animated {
	[super viewDidAppear:animated];
	
	[lineTextInput becomeFirstResponder];
	
	if ([refLineTextString isEqualToString:INPUT_TEXT_DEFAULT]) {
		[lineTextInput setText:nil];
	} else {
		[lineTextInput setText:refLineTextString];
	}
	
	if (customTitleString!=nil) {
		titleItem.title = customTitleString;
	} else {
		titleItem.title = DEFAULT_TITLE_STRING;
	}
	
    // adjust the position of input field in 4-inch iphones
    float screenOffset = 0.0;
    CGRect screenBounds = [[UIScreen mainScreen] bounds];
    if (screenBounds.size.height == SCREEN_HEIGHT_4_INCH) {
        screenOffset = SCREEN_OFFSET_4_INCH;
    }
    
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_START_ALPHA];
	[[self view] setFrame:CGRectMake(0,200+screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
	[UIView beginAnimations:nil context:nil];
	[UIView setAnimationDuration:SELECT_VIEW_ANIMATION_DURATION];
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_END_ALPHA];
	[[self view] setFrame:CGRectMake(0,47+65+screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
	[UIView commitAnimations];
}

- (void)didReceiveMemoryWarning {
    // Releases the view if it doesn't have a superview.
    [super didReceiveMemoryWarning];
    
    // Release any cached data, images, etc that aren't in use.
}

- (void)viewDidUnload {
    [super viewDidUnload];
    // Release any retained subviews of the main view.
    // e.g. self.myOutlet = nil;
}

- (IBAction)checkInput {
	if ([[lineTextInput text]length]>0) {
		[refLineTextString setString:[lineTextInput text]];
	}
	[refCaller finishedThenReloadData];
	[[self view] removeFromSuperview];
}
- (IBAction)cancelInput {
    [refCaller finishedThenReloadData];
	[[self view] removeFromSuperview];
}

- (void)dealloc {
    [super dealloc];
}


@end
