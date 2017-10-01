//
//  SelectOptionViewController.m
//  KingFongVer2
//
//  Created by Yu-Chih on 2/5/17.
//
//

#import "SelectOptionViewController.h"
#import "AppConstant.h"

@implementation SelectOptionViewController

@synthesize optionPicker;
@synthesize dataArray;
@synthesize selectOptionIndex;
@synthesize refCaller;
@synthesize refOptionString;
@synthesize tapInterceptor;
@synthesize titleItem;

// The designated initializer.  Override if you create the controller programmatically and want to perform customization that is not appropriate for viewDidLoad.
- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil {
    if ((self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil])) {
        // Custom initialization
        selectOptionIndex = 0;
        dataArray = [[NSMutableArray alloc] initWithObjects:@"a",@"b",@"c", nil];
        
        //2. overload a gesture reconizer in contentShow webView to intercept the tap actions
        tapInterceptor = [[MyTapInterceptor alloc] init];
        tapInterceptor.touchesBeganCallback = ^(NSSet * touches, UIEvent * event) {
            NSLog(@"FUCK");
            //[optionPicker selectRow:0 inComponent:1 animated:YES];
            [optionPicker removeGestureRecognizer:tapInterceptor];
        };
        tapInterceptor.touchesEndedCallback = ^(NSSet * touches, UIEvent * event) {
            NSLog(@"FUCK2");
        };
    }
    return self;
}

- (void)viewDidLoad {
    [super viewDidLoad];
    [optionPicker addGestureRecognizer:tapInterceptor];
    // Do any additional setup after loading the view from its nib.
}

- (void)viewDidAppear:(BOOL)animated {
    [super viewDidAppear:animated];
    
    
    // adjust the position of input field in 4-inch iphones
    float screenOffset = 0.0;
    CGRect screenBounds = [[UIScreen mainScreen] bounds];
    if (screenBounds.size.height == SCREEN_HEIGHT_4_INCH) {
        screenOffset = SCREEN_OFFSET_4_INCH;
    }
    
    
    [[self view] setAlpha:SELECT_VIEW_ANIMATION_START_ALPHA];
    [[self view] setFrame:CGRectMake(0,300+65+screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
    [UIView beginAnimations:nil context:nil];
    [UIView setAnimationDuration:SELECT_VIEW_ANIMATION_DURATION];
    [[self view] setAlpha:SELECT_VIEW_ANIMATION_END_ALPHA];
    [[self view] setFrame:CGRectMake(0,112+65+screenOffset,SELECT_VIEW_ANIMATION_WIDTH,SELECT_VIEW_ANIMATION_HEIGHT)];
    [UIView commitAnimations];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)updateDataArray: (NSArray*) array {
    [dataArray setArray:array];
    [optionPicker selectRow:0 inComponent:0 animated:NO];
}


//---- picker view part -----
- (NSInteger)numberOfComponentsInPickerView:(UIPickerView *)pickerView;
{
    return 1;
}

- (void)pickerView:(UIPickerView *)pickerView didSelectRow:(NSInteger)row inComponent:(NSInteger)component
{
    NSLog(@"select : row %d in component %d", (int)row, (int)component);
    selectOptionIndex = row;
    [optionPicker addGestureRecognizer:tapInterceptor];
}

- (NSInteger)pickerView:(UIPickerView *)pickerView numberOfRowsInComponent:(NSInteger)component;
{
    return [dataArray count];
}


- (UIView *)pickerView:(UIPickerView *)pickerView viewForRow:(NSInteger)row forComponent:(NSInteger)component reusingView:(UIView *)view {
    UILabel *retval = (id)view;
    if (!retval) {
        retval= [[[UILabel alloc] initWithFrame:CGRectMake(0.0f, 0.0f, [pickerView rowSizeForComponent:component].width-10, [pickerView rowSizeForComponent:component].height)] autorelease];
    }
    
    [retval setText:[dataArray objectAtIndex:row]];
    retval.font = [UIFont systemFontOfSize:15];
    return retval;
}

/*
 - (CGFloat)pickerView:(UIPickerView *)pickerView widthForComponent:(NSInteger)component {
 NSInteger adjustWidth;
 
 adjustWidth = -40;
 
	switch(component) {
 case 0: return 140 + adjustWidth;
 case 1: return 150 - adjustWidth;
 default: return 200;
 }
 //NOT REACHED
 return 200;
 }
 */

- (CGFloat)pickerView:(UIPickerView *)pickerView rowHeightForComponent:(NSInteger)component {
    return 35;
}

//-----------------------------
- (IBAction)checkSelection {
    [refOptionString setString:[dataArray objectAtIndex:selectOptionIndex]];
    [refCaller inputFinishedThenReloadData];
    [[self view] removeFromSuperview];
}

- (IBAction)cancelSelection {
    [refCaller inputFinishedThenReloadData];
    [[self view] removeFromSuperview];
}

@end
