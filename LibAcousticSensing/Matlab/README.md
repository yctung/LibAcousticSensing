# LibAS Matlab Support
This guide will introduce how to use the Matlab support of LibAS. Specifically, we will include the following topics:
- How to design your remote sensing code?
- How to transfer remote mode to standalone mode?
- LibAS Matlab documents

# How to Deign Your Remote Sensing Code
This guide uses the *ObjectDetector* example to illustrate how to design your sensing algorithms with LibAS's Remote Matlab mode. Our *ObjectDetector* is a simple example to turn your smartphone into sonar-like devices that estimate the distance of nearby obstacles. Please check the example [README](/Example/ObjectDetector) file for more details for any further information.

In LibAS's remote mode, you just need to focus on designing two things:
- What signal to be sent for sensing? (in this example, is )
- How to process the the receive of each sent signal? (in this example, is applying a matched filter)
while the reset of processing, like how the sounds being played/recorded in real-time or how to know which segment of recorded sounds is the sound you just sent, will be handled by LibAS.

In the *ObjectDetector* example, the former is a 50ms chirp signal defined in the [ObjectDetectMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) while the later is a matched filter specified in the [ObjectDetectorCallback.m](/Example/ObjectDetector/Matlab/ObjectDetectorCallback.m)

## Setup
How to install and set up LibAS's remote mode has been introduced in the whole project's [README](/README.md). Specifically, you will need our pre-built DevApp installed on your Android/iOS/Tizen devices, then use this app to connect the remote Matlab server.

## Main.m
In your main function. You need to firstly decide which signal to send. For example, you can assign:

```
FS = 48000; // Sample rate
period = 0.05; // 50ms
signalDuration = 0.001 // 1ms signal duration (i.e., 49mins remain silent)
time = 0:1/PS.FS:4;
signal = chirp(time, 0, time(end), 24000);
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
TODO: add this part of guide

# LibAS Matlab API
## Open API

### AudioSource
AudioSource is a wrapper to let LibAS know what kind of sound and how it should be sent.

#### Constructor
```
  function obj = AudioSource(name, signal, FS, repeatCnt, signalGain, preambleSource)
```
#### Example
```
  as = AudioSource('exampleSoundName', sin(1./[1:48000]*pi), 48000, 100, 0.9);
```

## SensingServer

## TraceParser

## Internal API

## Preamble Detection
