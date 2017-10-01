//
//  SelectNumberViewController.m
//  KingFongVer2
//
//  Created by eddyxd don on 3/6/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#define DEFAULT_TITLE_STRING (@"請輸入數字")
#define DEFAULT_TITLE_STRING_CHINA (@"请输入数字")

#import "SelectNumberViewController.h"
#import "AppConstant.h"

@implementation SelectNumberViewController
@synthesize numberInput;
@synthesize titleLabel;
@synthesize titleItem;
@synthesize refNumberString;
@synthesize refCaller;
@synthesize customTitleString;

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
    [[self view] setAlpha:0.0];
}

- (void)viewDidAppear:(BOOL)animated {
	[super viewDidAppear:animated];
	
	[numberInput becomeFirstResponder];
	[numberInput setBorderStyle:UITextBorderStyleRoundedRect];
	
	if ([refNumberString isEqualToString:INPUT_TEXT_DEFAULT]) {
		[numberInput setText:nil];
	} else {
		[numberInput setText:refNumberString];
	}
	
	if (customTitleString!=nil) {
		titleItem.title = customTitleString;
	} else {
        titleItem.title = @"Please input number";
	}
	
    // adjust the position of input field in 4-inch iphones
    float screenOffset = 0.0;
    CGRect screenBounds = [[UIScreen mainScreen] bounds];
    if (screenBounds.size.height == SCREEN_HEIGHT_4_INCH) {
        screenOffset = SCREEN_OFFSET_4_INCH;
    }
    
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_START_ALPHA];
	[[self view] setFrame:CGRectMake(0,200 + screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
	[UIView beginAnimations:nil context:nil];
	[UIView setAnimationDuration:SELECT_VIEW_ANIMATION_DURATION];
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_END_ALPHA];
	[[self view] setFrame:CGRectMake(0,47+65 + screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
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


- (void)dealloc {
	NSLog(@"SelectNumber : dealloc");
	[numberInput release];
	[titleLabel release];
	[titleItem release];
    [super dealloc];
}


- (IBAction)checkSelection {
	NSLog(@"numberInput value = %d",[numberInput.text intValue]);
	if ([[numberInput text] length]>0) {
		[refNumberString setString:[numberInput text]];
	}
	[refCaller inputFinishedThenReloadData];
	[[self view] removeFromSuperview];
}

- (IBAction)cancelSelection {
	[refCaller inputFinishedThenReloadData];
	[[self view] removeFromSuperview];
}

- (IBAction)changeNumberHandler:(id)sender {
	NSLog(@"changeNumber = %@",sender);
}


@end
