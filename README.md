# LibAcousticSensing
LibAS (LibAcousticSensing) is a cross-platform toolkit to ease the development of acoustic sensing apps. 
If can let developers focus on design the sensing algorithm rather without learning the platform-specific programming details.
LibAS currently support Android/iOS/Tizen/Linux devices.
Some interesting demo video of LibAS can be found at: https://youtu.be/cnep7fFyJhc and https://youtu.be/At8imJVRDq4

# Preface: Acoustic Sensing
Since microphones and speakers have been installed in all smart phones, 
sensing by (inaudible) sounds, i.e., acoustic sensing, becomes a unique way to augment advanced sensing capability to human life.
It can remember where the phone is, know how user touch the phone, identify nearby objects, or even understand the user's gestures.
Few popular examples are like FingerIO (https://youtu.be/CQ-AirK7wLY) and ForcePhone (https://youtu.be/HioOAiMzxBM). 

# Usage
First, you need to clone this repo:
```
cd YOUR_SOURCE_FOLDER
git clone https://github.com/yctung/LibAcousticSensing
```
There are two ways of using this sensing library. 
You can choose to use the **remote mode** that only requires users to install the pre-build apps in devices and then controls them by a remote Matlab server. 
We suggest people first try this remote mode because it saves lots of time wasting on device-specific issues and process signals on low-level language, like C. 
For each sensing app, this mode only needs users to define (1) what is the sensing signal (2) how to process each reception of the sensing signals.

For people already knows how the acoustic sensing and LibAS work, they can choose to include LibAS as a library into their projects. 
The benefit of this mode is people can ship their app as a standalone app without networking connections. Please follow the "Standalone Mode" section for this usage.

Followings describe the folder structure of LibAS
```
|- Android (Android implementations)
|    |- LibAcousticSensing : core library for Android
|    |- DevApp             : pre-built app for remote sensing
|    \- DemoXXXX           : example of standalone app using LibAS
|- iOS (iOS implementation)
|    \- ...                : having the same structure as Android
|- Tizen
|    \- ...
|- Java (Linux implementation)
|    \- ...
\- Matlab (Remote sensing server)
     |- LibAcousticSensing : core sensing library functions
     |- DemoAAA
     |- DemoBBB
     \- .....   
```

# Remote Mode (need Matlab)
(TODO): add figures
The above figure shows the idea of LibAS Remote Mode. 
In this mode, users install the pre-built DevApp into their devices and connect to a Matlab sensing server by Internet.
Sensing (sound) signals are prepared and processed in Matlab, and then returned to the DevApp to make proper responses.
Refer [How to Use Remote Mode](Matlab/README.md) for the detailed guide.

# Standalone Mode (need to know Phone programing)

# Compatible devices
In theory, LibAS should be compatible to all Android/Tizen/iOS/Linux devices with microphone/speaker installed.
However, it might need to customized settings for certain devices. 
Followings include the devices we have used and tested in LibAS:
- Android
> Samsung Galaxy S4/5/6/7/8, Note 4, Nexus 6P, Nexus 5X, HTC One, ASUS Zen Watch 3
- iOS
> iPhone 5c, iPhone 6s
- Tizen
> Samsung Gear S3


# License

