//
//  StandaloneCallback.m
//  ForcePhone
//
//  Created by Yu-Chih on 9/29/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "StandaloneCallback.h"
#import "forcephone.h"

@implementation StandaloneCallback

- (id) initWithLogFolderPath:(NSString*)logFolderPath {
    self = [super init];
    if (self){
        // 1. update audio and detect setting (based on device!!)
        // TODO: make it changed based on device setting
        int ASK_REAL_TIME_DETECTOR_TO_PARSE_SINGLE_CHANNEL = -1;
        int test = haha;
        JNI_FUNC_NAME(debugTest)();
        
        // NSString to C String
        // ref: http://stackoverflow.com/questions/6687808/how-to-convert-nsstring-to-c-string
        /*
        const char *logFolderPathCString = [logFolderPath UTF8String];
        JNI_FUNC_NAME(detectionInit)((char*)logFolderPathCString);
        JNI_FUNC_NAME(detectionCheckStatus)();
         */
        
    }
    return self;
}

@end
