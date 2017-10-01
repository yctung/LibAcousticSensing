//
//  InputTextViewController.m
//  KingFongVer2
//
//  Created by eddyxd don on 4/10/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import "InputTextViewController.h"
#import "AppConstant.h"

@implementation InputTextViewController
@synthesize inputText,refTextView,refCaller,titleItem;;

 // The designated initializer.  Override if you create the controller programmatically and want to perform customization that is not appropriate for viewDidLoad.
- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil {
    if ((self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil])) {
        // Custom initialization
    }
    return self;
}



- (void)viewDidAppear:(BOOL)animated {
	[super viewDidAppear:animated];
	
	[inputText setText:refTextView.text];
	[inputText becomeFirstResponder];
	
    // adjust the position of input field in 4-inch iphones
    float screenOffset = 0.0;
    CGRect screenBounds = [[UIScreen mainScreen] bounds];
    if (screenBounds.size.height == SCREEN_HEIGHT_4_INCH) {
        screenOffset = SCREEN_OFFSET_4_INCH;
    }
	
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_START_ALPHA];
	[[self view] setFrame:CGRectMake(0,100+screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
	[UIView beginAnimations:nil context:nil];
	[UIView setAnimationDuration:SELECT_VIEW_ANIMATION_DURATION];
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_END_ALPHA];
	[[self view] setFrame:CGRectMake(0,47+17+screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
	[UIView commitAnimations];
}


// Implement viewDidLoad to do additional setup after loading the view, typically from a nib.
- (void)viewDidLoad {
    [super viewDidLoad];
    /*
	[inputText setText:refTextView.text];
	[inputText becomeFirstResponder];
	
	
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_START_ALPHA];
	[[self view] setFrame:CGRectMake(0,100,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
	[UIView beginAnimations:nil context:nil];
	[UIView setAnimationDuration:SELECT_VIEW_ANIMATION_DURATION];
	[[self view] setAlpha:SELECT_VIEW_ANIMATION_END_ALPHA];
	[[self view] setFrame:CGRectMake(0,0,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
	[UIView commitAnimations];*/
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
    [super dealloc];
}

- (IBAction)checkInput {
	NSLog(@"height = %f",inputText.contentSize.height);
	[refTextView setText:inputText.text];
	[refCaller inputFinishedThenReloadData];
	[[self view] removeFromSuperview];
}
- (IBAction)cancelInput {
    [refCaller inputFinishedThenReloadData];
	[[self view] removeFromSuperview];
}


@end
