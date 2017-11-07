# LibAS Matlab Support
This guide will introduce how to use the Matlab support of LibAS. Specifically, we will cover the following topics:
- How to design your remote Matlab code?
- How to transfer remote mode to standalone mode?
- LibAS Matlab API documents

# How to Deign Your Remote Sensing Code
This guide uses the *ObjectDetector* example to illustrate how to design your sensing algorithms with LibAS's Matlab **remote mode**. Our *ObjectDetector* is a simple example to turn your smartphone into a sonar-like device that can estimate the distance toward nearby obstacles. Please check the example [README](/Example/ObjectDetector) file for any further information.

In LibAS's **remote mode**, you just need to focus on designing two things:
- What signal to be sent for sensing?
- How to process the the receive of each sent signal?
while the reset of processing, like how the sounds being played/recorded in real-time or how to know which segment of recorded sounds is the sound you just sent, will be handled by LibAS.

For the *ObjectDetector* example, the former is a 50ms chirp signal defined in the [ObjectDetectorMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) while the later is a matched filter specified in the [ObjectDetectorCallback.m](/Example/ObjectDetector/Matlab/ObjectDetectorCallback.m)

## Setup
How to install and set up LibAS's remote mode has been introduced in the whole project's [README](/README.md). Specifically, you will need our pre-built DevApp installed on your Android/iOS/Tizen devices, then use the installed app to connect your Matlab remote server.

## Main.m
In your Matlab main function. You need to firstly decide which signal to send. For the [ObjectDetectorMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) example, the sent signal is defined as:

```
% ... some signal settings ...
signal = zeros(PERIOD, 1);
time = (0:CHIRP_LEN-1)./FS;
signal(1:CHIRP_LEN) = chirp(time, CHIRP_FREQ_START, time(end), CHIRP_FREQ_END);
if APPLY_FADING_TO_SIGNAL == 1, % add fadding if necessary (make it inaudible but lose some SNR)
    signal(1:CHIRP_LEN) = ApplyFadingInStartAndEndOfSignal(signal(1:CHIRP_LEN), FADING_RATIO);
end
as = AudioSource('objectDetectSound', signal, FS, REPEAT_CNT, SIGNAL_GAIN);
```

Once the AudioSource has been set, we can start create the ```SensingServer```, but remember to import our customized java classes and clean the previously established socket first:

```
import edu.umich.cse.yctung.*
JavaSensingServer.closeAll(); % close all previous open socket

SERVER_PORT = 50005;
ss = SensingServer(SERVER_PORT, @YourCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % disable auto sensing when connected
```

Note the ```@YourCallback``` argument should be replaced by your real callback function. In the [ObjectDetectorMain.m](/Example/ObjectDetector/Matlab/ObjectDetectorMain.m) example, the callback is assinged to ```@ObjectDetectorCallback```.
For most sensing apps, we usually assign ```startSensingAfterConnectionInit = 0;``` to let developers manually click the ```Start Sensing``` button in the GUI. Setting ```startSensingAfterConnectionInit = 1;``` will automatically send the sensing sounds when the device is connected.

## Callback.m
The callback function signature should be consistent with:
```
function [] = ObjectDetectorCallback( server, type, data )
```
where the ```server``` argument is the reference to your sensing server of this callback,
which is useful when you want to get some information of the sensing server.

The ```type``` argument can be either the ```SensingServer.CALLBACK_TYPE_DATA``` or ```SensingServer.CALLBACK_TYPE_USER```.
- ```type == SensingServer.CALLBACK_TYPE_USER```: the callback function need to handle some customized events defined based on your application. This is the way to enable the customized behavior of in the callback functions.
For example, you can use LibAS's Android API to send this customized event to the sensing server for triggering some special processing if you want (e.g., change the sensing mode...etc).

- ```type == SensingServer.CALLBACK_TYPE_DATA```: it is the time to process the recorded sensing signal contained in the ```data``` argument.

The ```data``` argument is a 3-dimension matrix including the recorded sensing signals. The size of ```data``` equals to ```SIGNAL_LEN * TRACE_CNT * CH_CNT``` where the first dimension equals to length of your sensing signal, the second dimension represents how many repetitions of sensing signal are received and need to process this time (usually 1), and the last dimension represents how many channels are recorded (usually 2 in Android, 1 in iOS and other wearables).
For example, if you want to know what is the first 50~100 samples of sensing signal being latest recorded in channel 2, you should access it by ```data(50:100, end, 2)```.

While there are many GUI codes that might be confusing in the example of [ObjectDetectorCallback.m](/Example/ObjectDetector/Matlab/ObjectDetectorCallback.m),
the core processing block of this callback is only applying a matched filter
to identify the reflection of the sensing signal as shown in the following:

```
  % find detected objects by matched filter
  % where the PS.signalToCorrelate is the reverse of sensing signal
  % and PS.detectRangeStart:PS.detectRangeEnd are determined by the GUI
  cons = convn(data, PS.signalToCorrelate, 'same');
  detects = abs(cons(PS.detectRangeStart:PS.detectRangeEnd, :, :));
```

After the processing is done, it is optional to return the result as a matrix.
This matrix will be returned to the connected device, thus facilitating the design
of real user experience of your applications via the remote mode.

## (Optional) Save and Replay


## (Optional) Customized Preamble
***Preamble*** set in the ```AudioSource``` is a critical component for LibAS
to know when the sensing sounds are played, thus able to segment the correct parts
in the recorded signals.
However, You might notice the preamble detection fails. It is common,
since each device might have different behaviors depending on the which microphone, speaker,
or even the sensing signal are used. This section shows how to customize your preamble to avoid this issue.
Further details can be found in the [Utility/PreambleSyncTuning](/Utility/PreambleSyncTuning/Matlab):
```
PREAMBLE_TYPE = 'CHIRP';            % only support chirp preambles now
PREAMBLE_FREQS = [22000, 15000];    % [start freq, end freq] in Hz
PREAMBLE_LENS = [500, 1000];        % [length of real signals, length of single repeatition]
PREAMBLE_FS = 48000;                % sample rate (should be consistent to the sensing signals)
PREAMBLE_REPEAT_CNT = 10;           % number of sync to be played
PREAMBLE_START_OFFSET = 4800;       % number of silent samples before the preamble is played
PREAMBLE_END_OFFSET = 4800;         % number of silent samples after the preamble is played
PREAMBLE_FADING_RATIO = -1;         % -1 menas no fading
preamble = PreambleBuilder(PREAMBLE_TYPE, PREAMBLE_FREQS, PREAMBLE_LENS, PREAMBLE_FS, PREAMBLE_REPEAT_CNT, PREAMBLE_START_OFFSET, PREAMBLE_END_OFFSET, PREAMBLE_FADING_RATIO);
% ... some signal setting ...
as = AudioSource('dummySound', signal, FS, REPEAT_CNT, SIGNAL_GAIN, preamble);
```

## (Optional) Multiple Devices
LibAS supports the control of multiple devices by adding the ```slave servers``` in our remote API.
In this case, multiple devices can be controlled for sensing easily. For example, [Example/DopplerDetector](Example/DopplerDetector/Matlab) demonstrates the example of sending a inaudible
sound from a device to another device for monitoring what is the change of distance between two devices based on
Doppler effect. In this example, two sensing server are created, one is called ```txss``` while another one is ```rxss```.
The ```txss``` which responsible to send the sensing sound is added as a slave device/server to ```rxss``` which is responsible to analyze the sensing results:
```
  rxss.addSlaveServer(txss);
```


# Remote to Standalone
TODO: add this part

# LibAS Matlab API
## Open API
Here are the common API you might need to build your remote sensing app with LibAS:
### AudioSource.m
AudioSource is a wrapper to let LibAS know what kind of sound and how the sound should be sent.

- Constructor:
```
  function obj = AudioSource(name, signal, FS, repeatCnt, signalGain, preambleSource)
```
If you skip some arguments, the default value will be used. For example, most of the time, you would not need to specify your own ```preambleSource```.

- Example:
```
  as = AudioSource('exampleSoundName', sin(1./[1:48000]*pi), 48000, 100, 0.9);
```

- Properties:
```
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

### SensingServer.m
SensingServer is the main controller to for LibAS device API to connect:

- Constructor:
```
  function obj = SensingServer(port, callback, deviceAudioMode, audioSource)
```
- Example:
```
  ss = SensingServer(50005, @YourCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, AudioSource('YourAudioSource', signal));
```

- Properties (only useful properties listed):
```
properties
    audioSource;                      % reference of AudioSource object
    traceParser;                      % reference of TraceParser object
    jss;                              % reference of JavaSensingServer object
    startSensingAfterConnectionInit;  % flag to allow sensing starts automatically
    % ...
end
```

Note you can access the whole recorded audio by ```ss.traceParser.audioBuf```

## Internal API
Here are some API that I use internally. You might wanna check it if you like to change our LibAS code:

### TraceParser.m
TraceParser is an internal class preprocessing the recorded sensing signals for the user-defined callback.

- Properties:
```
properties
    audioBuf;           % the whole recorded audio buffer
    audioBufEnd;        % the end index of the recorded audio buffer
    % ...
end
```

## Preamble Detection
TODO: add this part
