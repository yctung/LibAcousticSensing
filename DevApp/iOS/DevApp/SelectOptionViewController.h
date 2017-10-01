//
//  SelectOptionViewController.h
//  KingFongVer2
//
//  Created by Yu-Chih on 2/5/17.
//
//

#import <UIKit/UIKit.h>
#import "InputCallerDelegate.h"
#import "MyTapInterceptor.h"

@interface SelectOptionViewController : UIViewController <UIPickerViewDelegate,UIPickerViewDataSource> {
    IBOutlet UIPickerView *optionPicker;
    NSMutableArray *dataArray;
    NSInteger selectOptionIndex;
    id<InputCallerDelegate> refCaller;
    
    NSMutableString *refOptionString;
    MyTapInterceptor *tapInterceptor;
    IBOutlet UINavigationItem *titleItem;
}

@property (nonatomic, retain) UIPickerView *optionPicker;
@property (nonatomic, retain) NSMutableArray *dataArray;
@property (nonatomic, assign) id refCaller;
@property (nonatomic) NSInteger selectOptionIndex;

@property (nonatomic, assign) NSMutableString *refOptionString;
@property (nonatomic, retain) MyTapInterceptor *tapInterceptor;
@property (nonatomic, retain) IBOutlet UINavigationItem *titleItem;
- (void) updateDataArray: (NSArray*) array;
- (IBAction)checkSelection;
- (IBAction)cancelSelection;

@end
