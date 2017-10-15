# LibAS Matlab Support
This guide will introduce how to use the Matlab support of LibAS. Specifically, we will include the following topics:
- How to design your remote sensing code?
- How to transfer remote mode to standalone mode?
- LibAS Matlab documents

# How to Deign Your Remote Sensing Code
This guide uses the *ObjectDetection* example to illustrate how to design your sensing algorithms with LibAS's Remote Matlab mode. Our *ObjectDetection* is a simple example to turn your smartphone into sonar-like devices that estimate the distance of nearby obstacles. Please check the example README file for more details for any further information.

In LibAS's remote mode, you just need to focus on designing two things:
- What signal to be sent for sensing? (in this example, is )
- How to process the the receive of each sent signal? (in this example, is applying a matched filter)

In the *ObjectDetector* example, the former is a 50ms chirp signal defined in the [ObjectDetectMain.m](Example/ObjectDetector/Matlab/ObjectDetectorMain.m) while the later is a matched filter specified in the [ObjectDetectorCallback.m](Example/ObjectDetector/Matlab/ObjectDetectorCallback.m)

## Setup
Set up Remote Mode has been introduced in the README file of the whole project. Specifically, you will need to install our pre-built [DevApp]() on your Android/iOS/Tizen devices, then use this app to connect the setup Matlab server.

## Remote Mode
LibAS allows developers to focus on **what kind of sound signal to be played for sensing** and **how to process the reception of each sent signal**. For example, if the purpose of application is to estimate the distance of nearby object, just like SONAR, you can just send a short tone in every 50ms and just monitor what is time of delay to receive the echo of this tone in each 50ms. In our remote mode, you can achieve it by creating your own **Main** and **Callback** functions as shown in the following:

### Your Main Function
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


### Your Callback Function


## Remote  to Standalone


## Classes

### AudioSource


### SensingServer

### TraceParser

## Internal LibAS Functions

### Preamble Detection
