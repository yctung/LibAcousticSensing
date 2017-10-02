//
//  SettingTableViewController.h
//  DevApp
//
//  Created by Yu-Chih on 10/1/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <LibAcousticSensingFramework/AcousticSensingSettingEditorDelegate.h>
#import <LibAcousticSensingFramework/AcousticSensingSetting.h>

typedef NS_ENUM(NSInteger, CellTagType) {
    CellTagUndefined,
    CellTagMode,
    CellTagServerAddress,
    CellTagServerPort,
    CellTagMicSource,
    CellTagSpeakerSource,
    CellTagResetToDefault
};

@interface SettingTableViewController : UITableViewController <AcousticSensingSettingEditorDelegate> {
    AcousticSensingSetting *ass;
    UISegmentedControl *modeSegmentControl;
}


//@property (retain, nonatomic) IBOutlet UITableView *tableView;

@end
