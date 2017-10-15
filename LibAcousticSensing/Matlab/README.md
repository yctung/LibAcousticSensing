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
In your Matlab main function. You need to firstly decide which signal to send. For the [ObjectDetectorMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) example, the sent signal is:

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

Once the AudioSource has been set, we can start create the ```SensingServer```. But remember to import our customized java classes and clean the previously established socket:

```Matlab
import edu.umich.cse.yctung.*
JavaSensingServer.closeAll(); % close all previous open socket

SERVER_PORT = 50005;
ss = SensingServer(SERVER_PORT, @YourCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % disable auto sensing
```

Note the ```YourCallback``` argument should be replaced by your own real callback function. In the [ObjectDetectorMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) example, it should be assigned by ```@ObjectDetectorCallback```.
For most sensing apps, we assign ```startSensingAfterConnectionInit = 0;``` to let developers manually click the ```Start Sensing``` button in the GUI. Setting ```startSensingAfterConnectionInit = 1;``` will automatically send the sensing sounds when the device is connected.

## Callback.m
The callback function signature should be consistent with:
```
function [] = ObjectDetectorCallback( server, type, data )
```
where the ```server``` argument is the reference to your sensing server of this callback,
which is useful when you want to get some information of the sensing server.

The ```type``` argument can be either the ```SensingServer.CALLBACK_TYPE_DATA``` or ```SensingServer.CALLBACK_TYPE_USER```.
- ```type == SensingServer.CALLBACK_TYPE_USER```: the callback function need to handle some customized events defined based on the application. This is the way to enable the extension of customized behavior of processing functions.
For example, you can use LibAS's Android API to send this customized event to the sensing server for triggering some special processing if you want (e.g., change the sensing mode...etc).

- ```type == SensingServer.CALLBACK_TYPE_DATA```, it is the time to process the recorded sensing signal contained in the ```data``` argument.

The ```data``` argument is a 3-dimension matrix including the recorded sensing signals. The size of ```data``` equals to ```SIGNAL_LEN * TRACE_CNT * CH_CNT``` where the first dimension equals to length of your sensing signal, the second dimension represents how many repetitions of sensing signal are received and wait to process this time (usually 1), and the last dimension represents how many channels are recorded (usually 2 in Android, 1 in iOS and other wearables).




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
