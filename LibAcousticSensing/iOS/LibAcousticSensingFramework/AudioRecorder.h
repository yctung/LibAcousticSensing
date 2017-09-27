//
//  AudioRecorder.h
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/24/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#ifndef AudioRecorder_h
#define AudioRecorder_h


#import <Foundation/Foundation.h>
#import <AudioToolbox/AudioQueue.h>
#import <AudioToolbox/AudioFile.h>
#import "AudioRecorderCallerDelegate.h"

#define NUM_BUFFERS 10

typedef struct
{
    AudioStreamBasicDescription dataFormat;
    AudioQueueRef               queue;
    AudioQueueBufferRef         buffers[NUM_BUFFERS];
    AudioFileID                 audioFile;
    SInt64                      currentPacket;
    bool                        recording;
}RecordState;

void AudioInputCallback(void * inUserData,  // Custom audio metadata
                        AudioQueueRef inAQ,
                        AudioQueueBufferRef inBuffer,
                        const AudioTimeStamp * inStartTime,
                        UInt32 inNumberPacketDescriptions,
                        const AudioStreamPacketDescription * inPacketDescs);

@interface AudioRecorder : NSObject {
    RecordState recordState;
    id<AudioRecorderCallerDelegate> refCaller;
}

@property (nonatomic, retain) NSMutableData *dataToSave;
@property (nonatomic, retain) id<AudioRecorderCallerDelegate> refCaller;

- (id)initWithCaller:(id<AudioRecorderCallerDelegate>) callerIn;
- (void)setupAudioFormat:(AudioStreamBasicDescription*)format;
- (void)startRecording;
- (void)stopRecording;
- (void)feedSamplesToEngine:(UInt32)audioDataBytesCapacity audioData:(void *)audioData;

@end

#endif /* AudioRecorder_h */
