//
//  TraceSaver.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/30/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "TraceSaverCallerDelegate.h"

@interface TraceSaver : NSObject<NSStreamDelegate> {
    NSOutputStream *outputStream;
    NSMutableArray *dataWaitToSave;
    BOOL okToSaveDataDirectly;
    BOOL isOpened;
    int currentDataToSaveOffset;
    NSString *filePath;
}

@property (nonatomic, retain) id<TraceSaverCallerDelegate> refCaller;

-(id)initWithFilePath:(NSString*) filePath;
-(void) write:(NSData*) dataToSave;
-(BOOL)getIsOpened;
-(void)waitAllDataBeingSavedAndStop;
@end
