//
//  RecordSetting.h
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 10/4/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <AVFoundation/AVFoundation.h>
#import "AcousticSensingSetting.h"

@interface RecordSetting : NSObject {
    int recordFS;
    NSString *micDataSource; // Apple's setting of mic port
}

- (void)applyDeviceSensingSetting:(AcousticSensingSetting *)setting;
- (int) getRecordFS;
- (NSString *)getMicDataSource;
@end
