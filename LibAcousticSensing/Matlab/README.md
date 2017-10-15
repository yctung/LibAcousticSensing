# LibAS Matlab Support
This guide will introduce how to use the Matlab support of LibAS. Specifically, we will include the following topics:
- How to design your remote Matlab code?
- How to transfer remote mode to standalone mode?
- LibAS Matlab API documents

# How to Deign Your Remote Sensing Code
This guide uses the *ObjectDetector* example to illustrate how to design your sensing algorithms with LibAS's Remote Matlab mode. Our *ObjectDetector* is a simple example to turn your smartphone into sonar-like devices that estimate the distance of nearby obstacles. Please check the example [README](/Example/ObjectDetector) file for more details for any further information.

In LibAS's remote mode, you just need to focus on designing two things:
- What signal to be sent for sensing? (in this example, is )
- How to process the the receive of each sent signal? (in this example, is applying a matched filter)
while the reset of processing, like how the sounds being played/recorded in real-time or how to know which segment of recorded sounds is the sound you just sent, will be handled by LibAS.

In the *ObjectDetector* example, the former is a 50ms chirp signal defined in the [ObjectDetectorMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) while the later is a matched filter specified in the [ObjectDetectorCallback.m](/Example/ObjectDetector/Matlab/ObjectDetectorCallback.m)

## Setup
How to install and set up LibAS's remote mode has been introduced in the whole project's [README](/README.md). Specifically, you will need our pre-built DevApp installed on your Android/iOS/Tizen devices, then use this app to connect the remote Matlab server.

## Main.m
In your main function. You need to firstly decide which signal to send. For the [ObjectDetectorMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) example, you can do:

```Matlab
% ... some signal settings ...
signal = zeros(PERIOD, 1);
time = (0:CHIRP_LEN-1)./FS;
signal(1:CHIRP_LEN) = chirp(time, CHIRP_FREQ_START, time(end), CHIRP_FREQ_END);
if APPLY_FADING_TO_SIGNAL == 1, % add fadding if necessary (make it inaudible but lose some SNR)
    signal(1:CHIRP_LEN) = ApplyFadingInStartAndEndOfSignal(signal(1:CHIRP_LEN), FADING_RATIO);
end
as = AudioSource('objectDetectSound', signal, FS, REPEAT_CNT, SIGNAL_GAIN);
```

After this, you can assign your own signal to the LibAS's ```AudioSource``` class and add some other properties:
```
as = AudioSource(signal, FS);
as.repeatCount = 100; // repeat the 50ms tone for 100 times
as.signalGain = 0.8; // gain to multiple on the signal when it is played
```

Once the AudioSource has been set, we can start create the ```SensingServer```. But remember to import our customized java classes and clean the previously established socket:
```
import edu.umich.cse.yctung.*
JavaSensingServer.closeAll(); % close all previous open socket

SERVER_PORT = 50005;
ss = SensingServer(SERVER_PORT, @YourCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % disable auto sensing
```

Note the ```YourCallback``` function assinged to your SensingServer is the one will be responsible to process the reception of each 50ms sound.


## Callback.m


# Remote to Standalone
TODO: add this part

# LibAS Matlab API
## Open API
Here are the common API you might need to build your remote sensing app with LibAS:
### AudioSource
AudioSource is a wrapper to let LibAS know what kind of sound and how it should be sent.

#### Constructor
```Matlab
  function obj = AudioSource(name, signal, FS, repeatCnt, signalGain, preambleSource)
```
If you skip some arguments, the default value will be used. For example, most of the time, you would not need to specify your own ```preambleSource```.

#### Properties
```Matlab
properties
    name;             % a name/label for AudioSource
    signal;           % signal, in the form of [# of samples, # of channels]
    FS;               % sample rate
    repeatCnt;        % how many times to play the signal
    chCnt;            % number of channel of the signal
    signalGain;       % the signal to be played = signal * signalGain
    preambleSource;   % preamble to know the start of signal
    preambleGain;     % gain to play the preamble    
end
```

#### Example
```Matlab
  as = AudioSource('exampleSoundName', sin(1./[1:48000]*pi), 48000, 100, 0.9);
```

## SensingServer

## TraceParser

## Internal API
Here are some API that I use internally. You might wanna check it if you like to change our LibAS code:
## Preamble Detection
TODO: add this part
