//
//  AudioPlayer.m
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 5/29/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "AudioPlayer.h"

@implementation AudioPlayer
@synthesize playState, audioSource, latestPlayBuffer, latestPlayBufferSize, latestPlayBufferOffset;

void *audioPlayerSelf; // TODO: find a better to reference objective c objects

void AudioOutputCallback(void* inUserData, AudioQueueRef outAQ, AudioQueueBufferRef outBuffer) {
    PlayState* playState = (PlayState*)inUserData;
    if(!playState->playing)
    {
        NSLog(@"Not playing, returning\n");
        return;
    }
    
    NSLog(@"AudioOutputCallback: packet %lld for playback\n", playState->currentPacket);
    
    AudioStreamPacketDescription* packetDescs = NULL;
    
    OSStatus status;
    
    AudioPlayer *aps = (AudioPlayer *) audioPlayerSelf;
    
    
    
    
    void* buffer = outBuffer->mAudioData;
    
    int bufferOffset = 0;
    int nbytesRemain = AUDIO_PLAYER_BUFFER_SIZE;
    
    // copy until the whole buffer is filled
    while (nbytesRemain > 0) {
        if (aps.latestPlayBufferSize - aps.latestPlayBufferOffset >= nbytesRemain) {
            // the bytes in the current play_buf is enough to fill the remain bytes in local buf to play
            memcpy(buffer+bufferOffset, aps.latestPlayBuffer+aps.latestPlayBufferOffset, nbytesRemain);
            
            aps.latestPlayBufferOffset += nbytesRemain;
            bufferOffset += nbytesRemain;
            nbytesRemain = 0; // break the loop
            
            if (aps.latestPlayBufferOffset == aps.latestPlayBufferSize) aps.latestPlayBufferOffset = 0;
        } else {
            // put part of data into buffer and wait the next round
            int nbytesToCopy = aps.latestPlayBufferSize - aps.latestPlayBufferOffset;
            memcpy(buffer+bufferOffset, aps.latestPlayBuffer+aps.latestPlayBufferOffset, nbytesToCopy);
            aps.latestPlayBufferOffset = 0; // return to the start
            nbytesRemain -= nbytesToCopy;
            bufferOffset += nbytesToCopy;
        }
        
        if (aps.latestPlayBuffer == [aps.audioSource.preamble bytes] && aps.latestPlayBufferOffset == 0) { // means the whole play_buffer is preamble and has been finished
            // switch pilot to signal buffer here
            aps.latestPlayBuffer = (void*)[aps.audioSource.signal bytes];
            aps.latestPlayBufferSize = (int)[aps.audioSource.signal length];
            aps.latestPlayBufferOffset = 0;
        }
    }
    
    outBuffer->mAudioDataByteSize = bufferOffset;
    
    
    /*
    void *ptr = [aps.audioSource.preamble bytes];
    NSLog(@"preamble len = %d", [aps.audioSource.preamble length]);
    memcpy(buffer, aps.latestPlayBuffer, AUDIO_PLAYER_BUFFER_SIZE);
    outBuffer->mAudioDataByteSize = AUDIO_PLAYER_BUFFER_SIZE;
    */
     
    status = AudioQueueEnqueueBuffer(outAQ, outBuffer, 0, packetDescs);
    
    if (status != 0) {
        NSLog(@"AudioPlayer: AudioQueueEnqueueBuffer fails, status = %d", (int)status);
        NSError *error = [NSError errorWithDomain:NSOSStatusErrorDomain code:status userInfo:nil];
        NSLog(@"%@",[error description]);
        NSLog(@"%@",error);
    }
}


- (id)initWithAudioSource:(AudioSource*) audioSourceIn {
    self = [super init];
    if (self) {
        audioPlayerSelf = (void *)(self);
        [self setAudioSource:audioSourceIn];
        
        latestPlayBufferOffset = 0;
        latestPlayBuffer = (void*)[audioSource.preamble bytes];
        latestPlayBufferSize = (int)[audioSource.preamble length];
    }
    return self;
}

- (void)setupAudioFormat:(AudioStreamBasicDescription*)format {
    format->mSampleRate = 48000;
    format->mFormatID = kAudioFormatLinearPCM;
    format->mFormatFlags = kLinearPCMFormatFlagIsSignedInteger | kLinearPCMFormatFlagIsPacked; // kLinearPCMFormatFlagIsBigEndian
    format->mFramesPerPacket  = 1;
    format->mChannelsPerFrame = 1; // set it to 2 for stereo playing
    format->mBitsPerChannel   = 16;
    format->mBytesPerFrame    =
    format->mBytesPerPacket   = format->mChannelsPerFrame*sizeof(SInt16);
    
    //format->mReserved = 0;
}

- (void)startPlaying {
    [self setupAudioFormat:&playState.dataFormat];
    playState.currentPacket = 0;
    
    OSStatus status;
    
    status = AudioQueueNewOutput(
                                 &playState.dataFormat,
                                 AudioOutputCallback,
                                 &playState,
                                 CFRunLoopGetCurrent(),
                                 kCFRunLoopCommonModes,
                                 0,
                                 &playState.queue);
    if(status == 0) // successfully initialized
    {
        playState.playing = true;
        for(int i = 0; i < AUDIO_PLAYER_NUM_BUFFERS && playState.playing; i++)
        {
            if(playState.playing)
            {
                //int bufferSize = 4800*1;
                AudioQueueAllocateBuffer(playState.queue, AUDIO_PLAYER_BUFFER_SIZE, &playState.buffers[i]);
                AudioOutputCallback(&playState, playState.queue, playState.buffers[i]);
            }
        }
        
        AudioQueueSetParameter(playState.queue, kAudioQueueParam_Volume, 1.0);
        
        if(playState.playing)
        {
            status = AudioQueueStart(playState.queue, NULL);
            if(status == 0)
            {
                NSLog(@"AudioPlayer: startPlaying succ");
                
            } else {
                NSLog(@"[ERROR] AudioPlayer: AudioQueueStart fails");
            }
        }
    } else {
        NSLog(@"ERROR] AudioPlayer: AudioQueueNewOutput fails");
    }
}

- (void)stopPlaying {
    playState.playing = false;
    
    AudioQueueStop(playState.queue, true);
    
    for (int i = 0; i < AUDIO_PLAYER_NUM_BUFFERS; i++) {
        AudioQueueFreeBuffer(playState.queue, playState.buffers[i]);
    }
    
    AudioQueueDispose(playState.queue, true);
    AudioFileClose(playState.audioFile);
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
