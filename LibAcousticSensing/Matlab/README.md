# LibAS Remote Matlab Server

## Setup

## Remote Mode
LibAS allows developers to focus on **what kind of sound signal to be played for sensing** and **how to process the reception of each sent signal**. For example, if the purpose of application is to estimate the distance of nearby object, just like SONAR, you can just send a short tone in every 50ms and just monitor what is time of delay to recieve the echo of this tone in each 50ms. In our remote mode, you can achieve it by creating your own **Main** and **Callback** functions as shown in the following:

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
