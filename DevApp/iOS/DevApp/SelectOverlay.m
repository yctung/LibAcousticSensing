//
//  SelectOverlay.m
//  KingFongVer2
//
//  Created by eddyxd don on 4/8/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import "SelectOverlay.h"
#import "AppConstant.h"
#import "AppDelegate.h"

@implementation SelectOverlay
@synthesize refCaller;

- (id)init {
	return [self initWithFrame:CGRectMake(0,0,320,480)];
}

- (id)initWithFrame:(CGRect)frame {
    if ((self = [super initWithFrame:frame])) {
        // Initialization code
		self.backgroundColor = [UIColor blackColor];
		self.opaque = 0;
		self.alpha = 0.5;
		[self addTarget:self action:@selector(overlayPressed) forControlEvents:UIControlEventTouchDown];
    }
    return self;
}

- (void)overlayPressed{
	AppDelegate *refDelegate = [[UIApplication sharedApplication] delegate];
	[self removeFromSuperview];
	for(UIView *subview in [[refDelegate window] subviews]){
		if([subview tag]==INPUT_VIEW_TAG){
			[subview removeFromSuperview];
		}
	}
}

- (void)show {
	if (refCaller==nil) {
		NSLog(@"SelectOverlay : Error : refCaller is undefined");
		return;
	}
	[[[refCaller view] superview] addSubview:self];
}

- (void)disapper {
	[self removeFromSuperview];
}

- (void)dealloc {
    [super dealloc];
}


@end
