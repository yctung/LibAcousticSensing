//
//  AudioRecorder.m
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/24/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import <Foundation/Foundation.h>
#include <AudioToolbox/AudioToolbox.h>
#import "AudioRecorder.h"
#import "LibConstant.h"

@import AVFoundation;

#define AUDIO_DATA_TYPE_FORMAT float

@implementation AudioRecorder

@synthesize refCaller;
void *refToSelf;

void AudioInputCallback(void * inUserData,  // Custom audio metadata
                        AudioQueueRef inAQ,
                        AudioQueueBufferRef inBuffer, /*The audio queue buffer containing the incoming audio data to record.*/
                        const AudioTimeStamp * inStartTime,
                        UInt32 inNumberPacketDescriptions,
                        const AudioStreamPacketDescription * inPacketDescs) {
    
    RecordState * recordState = (RecordState*)inUserData;
    
    AudioRecorder *rec = (AudioRecorder *) refToSelf;
    
    // do the real processing
    [rec feedSamplesToEngine:inBuffer->mAudioDataByteSize audioData:inBuffer->mAudioData];
    
    // enqueue buffer -> so it can be used again
    AudioQueueEnqueueBuffer(recordState->queue, inBuffer, 0, NULL);
}

- (id)initWithCaller:(id<AudioRecorderCallerDelegate>) callerIn{
    self = [super init];
    if (self) {
        refToSelf = (void *)(self);
        refCaller = callerIn;
    }
    return self;
}


// function to update AuidoFormat
- (void)setupAudioFormat:(AudioStreamBasicDescription*)format {
    /* /// original float setting
    format->mSampleRate = 96000.0;
    format->mFormatID = kAudioFormatLinearPCM;
    format->mFormatFlags = kAudioFormatFlagsNativeFloatPacked;
    format->mFramesPerPacket  = 1;
    format->mChannelsPerFrame = 1;
    format->mBytesPerFrame    = sizeof(Float32);
    format->mBytesPerPacket   = sizeof(Float32);
    format->mBitsPerChannel   = sizeof(Float32) * 8;
    */

    format->mSampleRate = C_RECORDER_SAMPLERATE;
    format->mFormatID = kAudioFormatLinearPCM;
    format->mFormatFlags = kLinearPCMFormatFlagIsSignedInteger | kLinearPCMFormatFlagIsPacked;
    format->mFramesPerPacket  = 1;
    format->mChannelsPerFrame = 1; // set it to 2 for stereo recording
    format->mBitsPerChannel   = 16;
    format->mBytesPerFrame    =
    format->mBytesPerPacket   = format->mChannelsPerFrame*sizeof(SInt16);

    /*
     float gain = 20;
     NSError* error;
     AVAudioSession *audioSession;
     audioSession = [AVAudioSession sharedInstance];
     if (self.audioSession.isInputGainSettable) {
     BOOL success = [self.audioSession setInputGain:gain
     error:&error];
     if (!success){} //error handling
     } else {
     NSLog(@"ios6 - cannot set input gain");
     }

     */
    
    // control gain setting by AudioSessionSetProperty (deprecated)
    /*Float64 float64=16000.0;
    int size = sizeof(float64);
    OSStatus status = AudioSessionSetProperty (kAudioSessionProperty_PreferredHardwareSampleRate, size, &float64);
     */
    
}


- (void)startRecording {
    [self setupAudioFormat:&recordState.dataFormat];
    
    recordState.currentPacket = 0;
    
    OSStatus status;
    status = AudioQueueNewInput(&recordState.dataFormat,
                                AudioInputCallback, /* here is the place to hook callback function */
                                &recordState,
                                CFRunLoopGetCurrent(),
                                kCFRunLoopCommonModes,
                                0,
                                &recordState.queue);
    
    if (status == 0) {
        
        for (int i = 0; i < NUM_BUFFERS; i++) {
            //int bufferSize = 256;
            //int bufferSize = 256*256;
            int bufferSize = 4800*1;
            AudioQueueAllocateBuffer(recordState.queue, bufferSize, &recordState.buffers[i]);
            AudioQueueEnqueueBuffer(recordState.queue, recordState.buffers[i], 0, nil);
        }
        
        recordState.recording = true;
        
        status = AudioQueueStart(recordState.queue, NULL);
    } else {
        NSLog(@"satus = %@",[self OSStatusToStr:status]);
    }
}

- (void)stopRecording {
    recordState.recording = false;
    
    AudioQueueStop(recordState.queue, true);
    
    for (int i = 0; i < NUM_BUFFERS; i++) {
        AudioQueueFreeBuffer(recordState.queue, recordState.buffers[i]);
    }
    
    AudioQueueDispose(recordState.queue, true);
    AudioFileClose(recordState.audioFile);
}

- (void)feedSamplesToEngine:(UInt32)audioDataBytesCapacity audioData:(void *)audioData {
    [refCaller audioRecorded:audioDataBytesCapacity audioData:audioData];
}

// just a helper to dump error message based on returned OSStatus value
- (NSString *)OSStatusToStr:(OSStatus)st
{
    switch (st) {
        case kAudioFileUnspecifiedError:
            return @"kAudioFileUnspecifiedError";
            
        case kAudioFileUnsupportedFileTypeError:
            return @"kAudioFileUnsupportedFileTypeError";
            
        case kAudioFileUnsupportedDataFormatError:
            return @"kAudioFileUnsupportedDataFormatError";
            
        case kAudioFileUnsupportedPropertyError:
            return @"kAudioFileUnsupportedPropertyError";
            
        case kAudioFileBadPropertySizeError:
            return @"kAudioFileBadPropertySizeError";
            
        case kAudioFilePermissionsError:
            return @"kAudioFilePermissionsError";
            
        case kAudioFileNotOptimizedError:
            return @"kAudioFileNotOptimizedError";
            
        case kAudioFileInvalidChunkError:
            return @"kAudioFileInvalidChunkError";
            
        case kAudioFileDoesNotAllow64BitDataSizeError:
            return @"kAudioFileDoesNotAllow64BitDataSizeError";
            
        case kAudioFileInvalidPacketOffsetError:
            return @"kAudioFileInvalidPacketOffsetError";
            
        case kAudioFileInvalidFileError:
            return @"kAudioFileInvalidFileError";
            
        case kAudioFileOperationNotSupportedError:
            return @"kAudioFileOperationNotSupportedError";
            
        case kAudioFileNotOpenError:
            return @"kAudioFileNotOpenError";
            
        case kAudioFileEndOfFileError:
            return @"kAudioFileEndOfFileError";
            
        case kAudioFilePositionError:
            return @"kAudioFilePositionError";
            
        case kAudioFileFileNotFoundError:
            return @"kAudioFileFileNotFoundError";
            
        default:
            return @"unknown error";
    }
}

@end