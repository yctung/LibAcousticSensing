//
//  AudioPlayer.h
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 5/29/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//
//  ref: https://developer.apple.com/library/content/documentation/MusicAudio/Conceptual/AudioQueueProgrammingGuide/AQRecord/RecordingAudio.html#//apple_ref/doc/uid/TP40005343-CH4-SW1
//  ref: https://lists.apple.com/archives/coreaudio-api/2009/Apr/msg00191.html
//  ref: https://stackoverflow.com/questions/23076634/playing-pcm-data-using-audio-queues


#import <Foundation/Foundation.h>
#import <AudioToolbox/AudioQueue.h>
#import <AudioToolbox/AudioFile.h>
#import "AudioSource.h"

#ifndef AudioPlayer_h
#define AudioPlayer_h

#define AUDIO_PLAYER_NUM_BUFFERS 10
#define AUDIO_PLAYER_BUFFER_SIZE 16000
/*
typedef struct
{
    AudioStreamBasicDescription dataFormat;
    AudioQueueRef               queue;
    AudioQueueBufferRef         buffers[AUDIO_PLAYER_NUM_BUFFERS];
    AudioFileID                 audioFile;
    SInt64                      currentPacket;
    bool                        playing;
}PlayState;
*/
 
typedef struct
{
    AudioStreamBasicDescription   dataFormat;                    // 2
    AudioQueueRef                 queue;                         // 3
    AudioQueueBufferRef           buffers[AUDIO_PLAYER_NUM_BUFFERS]; // 4
    AudioFileID                   audioFile;                     // 5: useless dummy file id
    UInt32                        bufferByteSize;                // 6
    SInt64                        currentPacket;                 // 7
    UInt32                        mumPacketsToRead;              // 8
    AudioStreamPacketDescription  *packetDescs;                  // 9
    bool                          playing;                       // 10
}PlayState;

void AudioOutputCallback(
                         void* inUserData,
                         AudioQueueRef outAQ,
                         AudioQueueBufferRef outBuffer);


@interface AudioPlayer : NSObject {
    
}

- (id)initWithAudioSource:(AudioSource*) audioSource;
- (void)setupAudioFormat:(AudioStreamBasicDescription*)format;
- (void)startPlaying;
- (void)stopPlaying;

@property (nonatomic, retain) AudioSource* audioSource;
@property PlayState playState;
@property int latestPlayBufferSize;
@property int latestPlayBufferOffset;
@property void *latestPlayBuffer;

@end

#endif /* AudioPlayer_h */
