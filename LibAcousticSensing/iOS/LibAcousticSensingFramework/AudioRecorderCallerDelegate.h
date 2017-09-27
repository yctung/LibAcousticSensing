//
//  AudioRecorderCallerDelegate.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/25/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <Foundation/Foundation.h>

@protocol AudioRecorderCallerDelegate <NSObject>
- (void)audioRecorded:(UInt32)byteSize audioData:(void *)audioData;

@end
