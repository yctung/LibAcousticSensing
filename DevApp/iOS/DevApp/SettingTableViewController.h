//
//  SettingTableViewController.h
//  DevApp
//
//  Created by Yu-Chih on 10/1/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "InputCallerDelegate.h"
#import <LibAcousticSensingFramework/AcousticSensingSetting.h>

@class InputViewControllerCollection;

typedef NS_ENUM(NSInteger, CellTagType) {
    CellTagUndefined,
    CellTagMode,
    CellTagServerAddress,
    CellTagServerPort,
    CellTagMicSource,
    CellTagSpeakerSource
};

@interface SettingTableViewController : UITableViewController <InputCallerDelegate> {
    InputViewControllerCollection *inputCollection;
    
    NSMutableString *serverAddressString;
    AcousticSensingSetting *ass;
}


//@property (retain, nonatomic) IBOutlet UITableView *tableView;

@end
