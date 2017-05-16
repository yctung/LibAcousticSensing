//
//  AcousticSensingController.m
//  LibAcousticSensingFramework
//
//  Created by Yu-Chih on 2/6/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "AcousticSensingController.h"
#import "AcousticControllerCallerDelegate.h"
#import "FrameworkCheck.h"
#import "AcousticController.h"
#import "NetworkController.h"
#import "AcousticController.h"
#import "NetworkControllerCallerDelegate.h"

@interface AcousticSensingController()
@property (nonatomic) int audioMode;
@property (nonatomic) int parseMode;
@property (nonatomic, retain) NSString *myString;
@property (nonatomic) int serverPort;
@property (nonatomic, retain) NSString* serverIp;
@property (nonatomic, retain) NetworkController* nc;
@property (nonatomic, retain) AcousticController* ac;
@property (nonatomic, retain) id<AcousticControllerCallerDelegate> refCaller;
@end



@implementation AcousticSensingController
@synthesize nc, ac, refCaller;

// Private constants
// ref: http://stackoverflow.com/questions/17228334/what-is-the-best-way-to-create-constants-in-objective-c
static int const PARSE_MODE_OFFLINE=1; // TOOD: implement the jni parser
static int const PARSE_MODE_REMOTE=2;  // This mode
static int const PARSE_MODE_DEFAULT=PARSE_MODE_REMOTE;


static int const AUDIO_MODE_DEFAULT=-1; // TODO: update this property if need
- (id) initWithCaller:(id<AcousticSensingControllerCallerDelegate>) callerIn {
    self = [super init];
    if (self) {
        refCaller = callerIn;
        [self updateDebugStatus:@"initWithCaller"];
        
        nc = [[NetworkController alloc] initWithCaller: self];
        // init my acoustic controller
        ac = [[AcousticController alloc] initAudioToPlay:[NSString stringWithFormat:@"%@%@%@",C_AUDIO_SOURCE_PREFIX,C_AUDIO_SOURCE,C_AUDIO_SOURCE_SUFFIX ] WithCaller:self withNetworkController:nc];
        
    }
    return self;
}

- (BOOL) setAsSlaveModeWithServerIp: (NSString*) serverIp andPort: (int) serverPort {
    self.serverIp=serverIp;
    self.serverPort=serverPort;
    self.parseMode=PARSE_MODE_REMOTE;
    self.audioMode=AUDIO_MODE_DEFAULT; // TODO: decide if it is set in java or matlab
    return true;
}


- (void) startSensingWhenPossible {
    if (self.parseMode==PARSE_MODE_REMOTE) {
        [nc connectServerWithIp:self.serverIp andPort:self.serverPort];
    } else {
        //startSensingNow();
    }
}

- (void) startSensingNow {
    [ac startSurvey];
}

// fucntion to show the customized dialog for initialization
// ref: http://stackoverflow.com/questions/10389635/uialertview-with-two-textfields-and-two-buttons
- (void) createInitModeDialogWithIp: (NSString*) serverIpDefault andPort: (int) serverPortDefault {
    UIAlertView *av = [[UIAlertView alloc] initWithTitle:@"Please select init mode" message:@"IP address / port" delegate:self cancelButtonTitle:@"Cancel" otherButtonTitles:@"OK", nil];
    [av setAlertViewStyle:UIAlertViewStyleLoginAndPasswordInput];
    
    // Alert style customization
    [[av textFieldAtIndex:1] setSecureTextEntry:NO];
    //[[av textFieldAtIndex:0] setPlaceholder:serverIpDefault];
    //[[av textFieldAtIndex:1] setPlaceholder:[NSString stringWithFormat:@"%d",serverPortDefault]];
    [[av textFieldAtIndex:0] setText:serverIpDefault];
    [[av textFieldAtIndex:1] setText:[NSString stringWithFormat:@"%d",serverPortDefault]];
    [av show];
}

- (void)alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{
    if (buttonIndex == 0)
    {
        //Code for Cancel button -> do nothing
    }
    if (buttonIndex == 1)
    {
        //Code for Ok button -> update IP address and connect to server
        NSString *serverIp = [[alertView textFieldAtIndex:0] text];
        int serverPort = [[[alertView textFieldAtIndex:1] text] intValue];
        BOOL result = [self setAsSlaveModeWithServerIp:serverIp andPort:serverPort];
        if (!result) {
            NSLog(@"[ERROR]: Init fails");
        } else {
            [self startSensingWhenPossible];
        }
    }
}

- (void)updateDebugStatus:(NSString*) status {
    // TODO: fix this werid warning ....
    [refCaller updateDebugStatus: status];
}

//==================================================================================================
//	Netowrk controller callbacks
//==================================================================================================
- (void)isConnected:(BOOL)success withResp:(NSString*) resp{
    if (success) {
        //[labelStatus setText:@"Connected"];
        
        [nc sendSetValueStringAction:@"traceChannelCnt" andStringToSet:@"1"];
        [nc sendSetStringAction:@"userDevice" andStringToSet:@"iPhone"];
        //[networkController sendSetValueStringAction:@"isAppleTrace" andStringToSet:@"1"];
        [nc sendInitAction];
        
        // start sensing if need
        /*
        if (needToStartSensingAfterNetworkConnected) {
            [self startSensing];
            needToStartSensingAfterNetworkConnected = NO;
        }
        
        // start sending check code if need
        if (needToStartCheckSqueezeAfterNetworkConnected) {
            [self startCheckSqueezeRightNow];
            needToStartCheckSqueezeAfterNetworkConnected = NO;
        }
        */
    } else {
        //[labelStatus setText:[NSString stringWithFormat:@"Fail to connect: %@", resp]];
        
    }
}

- (int)consumeReceivedData:(NSData*) dataReceived{
    return 0;
}


//=================================================================================================
//  Audio callbacks
//=================================================================================================
- (void)audioRecorded:(UInt32)byteSize audioData:(void *)audioData currentRecordedSampleCnt:(UInt32) currentRecordedSampleCnt {
    
}
- (void)onSurveyEnd {
    
}

@end
