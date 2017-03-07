//
//  AcousticController.m
//  AudioAnalysis
//
//  Created by Yu-Chih Tung on 10/30/15.
//  Copyright © 2015 Yu-Chih Tung. All rights reserved.
//

#import "AcousticController.h"
//#import "AppDelegate.h"
#import "Constant.h"

@implementation AcousticController
@synthesize refCaller, surveyBaseFolderPath, currentRecordedSampleCnt;

- (id)initAudioToPlay:(NSString *)audioSourceName WithCaller:(id<AcousticControllerCallerDelegate>) caller withNetworkController:(NetworkController*) networkController{
    self = [super init];
    if (self) {
        // 1. connect refernece
        refCaller = caller;
        refNetworkController = networkController;
        currentRecordedSampleCnt = 0;
        
        // 2. config trace/file directory
        // TODO: update the save feature
        [self resetTraceFolder];
        if (C_TRACE_SAVE_TO_FILE) {
            NSMutableString *matlabSetting = [[NSMutableString alloc] init];
            [matlabSetting appendFormat:@"%@\n", [audioSourceName stringByDeletingPathExtension]];
            [matlabSetting appendFormat:@"%d\n", C_RECORDER_CHANNEL];
            [matlabSetting appendFormat:@"%f\n", C_PLAYER_VOL];
            [matlabSetting appendFormat:@"%d\n", C_DEVICE_IDX_IPHONE];
            NSString *matlabFilePath = [surveyBaseFolderPath stringByAppendingPathComponent:@"matlab.txt"];
            [matlabSetting writeToFile:matlabFilePath atomically:YES encoding:NSUTF8StringEncoding error:nil];
        }
        
        
        // 3. config audio session
        [self setUpSession];
        
        // 4. init audio player
        NSString *audioSourcePath = [NSString stringWithFormat:@"%@/%@", [[NSBundle mainBundle] resourcePath], audioSourceName];
        NSURL *url = [NSURL fileURLWithPath: audioSourcePath];
        NSError *error;
        audioPlayer = [[[AVAudioPlayer alloc] initWithContentsOfURL:url error:&error] retain];
        // TODO: load audio data from server
        
        audioPlayer.numberOfLoops = 0;
        [audioPlayer setDelegate:self];
        [audioPlayer setVolume:C_PLAYER_VOL];
        if (C_PLAYER_VOL!=1) {
            NSLog(@"[WARN]: volume is less than 1");
        }
        
        // 5. init audio recorder
        audioRecorder = [[[AudioRecorder alloc] initWithCaller:self] retain];
        
        // 6. init audio trace saver (optional)
        if(C_TRACE_SAVE_TO_FILE){
            NSString *audioTraceFilePath = [surveyBaseFolderPath stringByAppendingPathComponent:[NSString stringWithFormat:@"%@audio.txt", C_TRACE_AUDIO_PREFIX] ];
            audioTraceSaver = [[[TraceSaver alloc] initWithFilePath:audioTraceFilePath] retain];
        }
    }
    return self;
}
- (void)dealloc {
    [audioPlayer release];
    [audioRecorder release];
    [audioTraceSaver release];
    [super dealloc];
}

// this function "remove" the previous trace folder and create a new one
- (void)resetTraceFolder{
    /*
    AppDelegate *app = (AppDelegate*)[[UIApplication sharedApplication] delegate];
    NSFileManager *fileManager = [NSFileManager defaultManager];
    NSError *error = nil;
    NSDictionary *attr = [NSDictionary dictionaryWithObject:NSFileProtectionComplete forKey:NSFileProtectionKey];
    
    // delete older folder if need
    NSLog(@"appFolderPath = %@", app.appFolderPath);
    */
    NSArray *paths = NSSearchPathForDirectoriesInDomains(NSDocumentDirectory,NSUserDomainMask, YES);
    NSString *systemPath = [paths objectAtIndex:0]; // use the document path as system path for iphon
    NSString *appFolderPath = [[systemPath stringByAppendingPathComponent:C_APP_FOLDER_NAME] retain];
    
    NSLog(@"appFolderPath = %@", appFolderPath);
    
    NSFileManager *fileManager = [NSFileManager defaultManager];
    NSError *error = nil;
    NSDictionary *attr = [NSDictionary dictionaryWithObject:NSFileProtectionComplete forKey:NSFileProtectionKey];
    
    surveyBaseFolderPath = [[appFolderPath stringByAppendingPathComponent:C_DEBUG_FOLDER] retain];
    [fileManager removeItemAtPath:surveyBaseFolderPath error:&error];
    if (error){
        NSLog(@"[ERROR] Unable remove directory path: %@", [error localizedDescription]);
    }
    
    // create a new one
    [fileManager createDirectoryAtPath:surveyBaseFolderPath withIntermediateDirectories:YES attributes:attr error:&error];
    if (error){
        NSLog(@"[ERROR] Unable create directory path: %@", [error localizedDescription]);
    }
}

// this is just a fucntion for debugging
- (void)startSurveyButDontPlaySound{
    [audioRecorder startRecording];
}


- (void)startSurvey{
    if (audioPlayer.isPlaying) {
        NSLog(@"[ERROR]: acoustic is triggered when audio is playing!!!");
    } else {
        [audioRecorder startRecording];
        [audioPlayer play];
    }
}

- (void)stopSurvey{
    [audioRecorder stopRecording];
    //[audioPlayer stop];
    [audioPlayer pause];
    audioPlayer.currentTime = 0;
    
    if (C_TRACE_SAVE_TO_FILE && audioTraceSaver!= nil && [audioTraceSaver getIsOpened]) {
        [audioTraceSaver waitAllDataBeingSavedAndStop];
    }
    
    [refCaller onSurveyEnd];
}
- (void)finalizeSurvey{
    // TODO: pop out some UI options
}


//====================================================================================================
// Start of callback functions
//====================================================================================================
- (void)audioRecorded:(UInt32)byteSize audioData:(void *)audioData{
    // update recorded sample count
    currentRecordedSampleCnt += byteSize/2; // each sample is 2 bytes and there is only 1 channel
    
    // *** jsut for debug ***
    /*
    uint8_t* temp = audioData;
    for(int i =0;i<20; i++){
        NSLog(@"temp = %d", temp[i]);
    }
    */
    
    // send data if need
    if (C_TRACE_SEND_TO_NETWORK && refNetworkController!=nil && [refNetworkController getIsConnected]) {
        [refNetworkController sendData:byteSize audioData:audioData];
    }
    
    
    // save data if necessary
    if (C_TRACE_SAVE_TO_FILE && audioTraceSaver!= nil && [audioTraceSaver getIsOpened]) {
        [audioTraceSaver write:[NSData dataWithBytes:audioData length:byteSize]];
    }
    
    // call the caller callback to update UI (optional)
    [refCaller audioRecorded:byteSize audioData:audioData currentRecordedSampleCnt:currentRecordedSampleCnt];
}

- (void)audioPlayerDidFinishPlaying:(AVAudioPlayer *)player successfully:(BOOL)flag {
    [self stopSurvey];
}

//====================================================================================================
// Start of audio related functions
//====================================================================================================
- (void) setUpSession {
    // Init audio with record capability
    AVAudioSession *audioSession = [AVAudioSession sharedInstance];
    //[audioSession setCategory:AVAudioSessionCategoryRecord error:nil];
    NSError *error = nil;
    
    if(![audioSession setCategory:AVAudioSessionCategoryPlayAndRecord error:&error]){
        NSLog(@"setCategory failed");
    }
    NSLog(@"setUpSession: category = %@", [audioSession category]);
    
    
    // use AVAudioSession
    // ref: http://stackoverflow.com/questions/21682502/audiosessionsetproperty-deprecated-in-ios-7-0-so-how-set-kaudiosessionproperty-o
    /*
     if (![session setCategory:AVAudioSessionCategoryPlayback
     withOptions:AVAudioSessionCategoryOptionMixWithOthers
     error:&setCategoryError]) {
     // handle error
     }*/
    // disable gain controller
    NSLog(@"before set -> mode:%@",audioSession.mode);
    if(![audioSession setMode:AVAudioSessionModeMeasurement error:&error]){
        NSLog(@"ERROR: set mode:%@ failed",audioSession.mode);
    }
    NSLog(@"after set -> mode:%@",audioSession.mode);
    
    // NOTE: seems unable to set input gain -> always 1
    NSLog(@"before set -> gain:%f", audioSession.inputGain);
    if(![audioSession setInputGain:0.5 error:&error]){
        NSLog(@"ERROR: set mode:%@ failed",audioSession.mode);
    }
    NSLog(@"before set -> gain:%f", audioSession.inputGain);
    
    NSLog(@"preferredInputNumberOfChannels: %ld", (long)audioSession.preferredInputNumberOfChannels);
    NSLog(@"preferredSampleRate: %f", audioSession.preferredSampleRate);
    
    // tuning microphone
    NSArray* inputs = [audioSession availableInputs];
    // Locate the Port corresponding to the built-in microphone.
    AVAudioSessionPortDescription* builtInMicPort = nil;
    for (AVAudioSessionPortDescription* port in inputs)
    {
        NSLog(@"portType = %@", port.portType);
        if ([port.portType isEqualToString:AVAudioSessionPortBuiltInMic])
        {
            builtInMicPort = port;
            break;
        }
    }
    
    NSLog(@"There are %u data sources for port :\"%@\"", (unsigned)[builtInMicPort.dataSources count], builtInMicPort);
    NSLog(@"%@", builtInMicPort.dataSources);
    
    AVAudioSessionDataSourceDescription* frontDataSource = nil;
    for (AVAudioSessionDataSourceDescription* source in builtInMicPort.dataSources)
    {
        NSLog(@"source.orientation = %@", source.orientation);
        // change here to select the target port
        //if ([source.orientation isEqual:AVAudioSessionOrientationFront]){
        if ([source.orientation isEqual:AVAudioSessionOrientationBack]){
            //if ([source.orientation isEqual:AVAudioSessionOrientationBottom]){
            frontDataSource = source;
            break;
        }
    } // end data source iteration
    if (frontDataSource)
    {
        NSLog(@"Currently selected source is \"%@\" for port \"%@\"", builtInMicPort.selectedDataSource.dataSourceName, builtInMicPort.portName);
        NSLog(@"Attempting to select source \"%@\" on port \"%@\"", frontDataSource, builtInMicPort.portName);
        // Set a preference for the front data source.
        if(![builtInMicPort setPreferredDataSource:frontDataSource error:&error]){
            NSLog(@"setPreferredDataSource failed");
        }
    }
    // Make sure the built-in mic is selected for input. This will be a no-op if the built-in mic is
    // already the current input Port.
    if(![audioSession setPreferredInput:builtInMicPort error:&error]){
        NSLog(@"setPreferredInput failed");
    }
    
    // setup prefered sample rate
    double preferredSampleRate = 48000;
    
    NSLog(@"before set -> preferredSampleRate:%f", audioSession.preferredSampleRate);
    if(![audioSession setPreferredSampleRate:preferredSampleRate error:&error]){
        NSLog (@"error setting sample rate %@", error);
    }
    NSLog(@"after set -> preferredSampleRate:%f", audioSession.preferredSampleRate);
    
    
    // setup speaker (optional)
    //set the audioSession override
    if (C_PLAYER_USE_BOTTOM_SPEAKER) {
        NSLog(@"[WARN]: sound is played by bottom speaker -> might not fit my original setting");
        if (![audioSession overrideOutputAudioPort:AVAudioSessionPortOverrideSpeaker error:&error]) {
            NSLog(@"setup speaker failed");
        }
    }

    
    // NOTE: this part should be set after all session setting are ALL DONE
    if(![audioSession setActive:YES error:&error]){
        NSLog(@"setActive failed");
    }
    
    
}


@end
