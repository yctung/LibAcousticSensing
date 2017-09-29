# LibAcousticSensing
LibAS (LibAcousticSensing) is a cross-platform framework to facilitate the development of acoustic sensing applications. Some interesting demo video of LibAS can be found at [here](https://youtu.be/cnep7fFyJhc) and [here](https://youtu.be/At8imJVRDq4).

## Feature
LibAS is designed to let its users focus on the design of **acoustic sensing algorithms** without knowing the tedious (but critical) platform-dependent programming details.

- LibAS supports acoustic sensing on Android/iOS/Tizen/Linux devices.
- LibAS supports a **remote mode** which users can easily test their algorithms designed in Matlab on real devices (with our pre-built app installed)
- LibAS also supports the **standalone mode** which helps to transfer your Matlab sensing algorithm into cross-platform supported C/C++ functions.

### What is Acoustic Sensing?
In short, acoustic sensing can turn your device (such as a smartphone) into a *sonar-like* system. In this way, your device can sense different environment characteristics/properties by generating different sensing sounds and designing different processing algorithms.
Since microphones and speakers are ususally installed in many existing devices, various interesting applications (like [this](https://youtu.be/Wn3sRmQteY8) and [this](https://youtu.be/CQ-AirK7wLY)) can be implemented and deployed with minimal deployment cost.

### Why We Need LibAS?
Based on our experience of developing several acoustic sensing apps, we notice there are various challenges that might prevent new developers from implementing their exciting acoustic sensing ideas. So LibAS is designed to solve these challenges as shown in the following:

- Different programming languages, like Java for Android, Obj-C for iOS, and C for Tizen are required to develop sensing app on real devices.
- Different audio recording/playing programming paradaigms, such as a delegated loop in Android or a callback-based buffer management in iOS, are requried to sense by acoustic sounds in real-time.
- Platform-dependent settings mater, but are usually negelactable by new developers. For example, automatic gain control (AGC) is harmful for most sensing apps, and it should be turned off by tuning different ```AudioSource``` rather than using the defualt ```AGC``` interface in Android.
- It is relatively hard to design and test the sensing algorithm directly by the device-supported programming language like Java or Obj-C. Instead, designing such algorithms in Matlab is efficient due to its wide support of several signal processing libraries and also the visualization interface.

The following figure shows how LibAS can reduce the development overheads of designing acoustic sensing applications:
[LibAS Introduction](Resource/figures/intro_idea.png?raw=true "LibAS Introduction")

# Usage: Remote Mode (a.k.a. Easy Mode for Demo)
In this mode, you don't need to know anything about real-time audio recording/playing on devices. What you need to do is download one of our [DevApp](DevApp) to your device and this app will automatically streams what ever signal needed for acoustic senisng controlled by a remote Matlab server.

## Install

### Prerequisites
- Matlab (I am using 2016a)
- Our DevApp for Android/iOS/Tizen installed in your device
- Network connections between your Matlab machine and your Android/iOS/Tizen device

### Your Mobile Device (or Any Android/Tizen/iOS Device)
You can download our prebuild DevApp here:

- Android (TODO: update it)
- iOS (TODO: update it)
- Tizen (TODO: update it)

### Your Laptop with Matlab Installed
Let's use the XXX application as an example. In this example, you will be able to ask your device to play a frequency sweep and record the sweep in Matlab. To do so, let's go to your Matlab commandline window and first navigate to the directory of:

```
cd Utility/XXX
```

And then call the Setup.m function

```
Setup
```

***WARN: For the first using this app, you will see the following message after calling the*** ```Setup```. Please type Y and to add the path and then ***restart*** your Matlab. (It is necessary because Matlab loads customized Java class on boot)

```
[WARNING]: JavaClassPath is not added yet!
Add this path will restart the Matlab.
Do you wanto do this now?
(Y/N): Y
```




## Troubleshooting
- If you can't make the connection, try to ping your devices (e.g., adb shell ping xxx.xxx.xxx.xxx) and ensure there is no firewall between your devices
- If you keep seeing this Matlab error message ```'SensingServer' not found``` you might need to manually call ```import edu.umich.cse.yctung.*``` before using any ```SensingServer``` class





# Usage: Standalone Mode (a.k.a. Real App for Product)


## Troubleshooting
- If Android tell you ```Error:Execution failed for task ':libacousticsensing:compileReleaseNdk'. NDK not configured.``` you need to update your ```local.properties``` file to include your ndk path. For example, mine is: ```sdk.dir=/Users/yctung/Library/Android/ndk```





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
