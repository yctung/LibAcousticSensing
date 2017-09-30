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

Once you finish this step you can start explore the utility of LibAS :)

## Usage

Once you have both app installed you can following 4 steps to let


Please refer to [the project's README](Utility/XXX) for code explainnation.


## Troubleshooting
- If you can't make the connection, try to ping your devices (e.g., adb shell ping xxx.xxx.xxx.xxx) and ensure there is no firewall between your devices
- If you keep seeing this Matlab error message ```'SensingServer' not found``` you might need to manually call ```import edu.umich.cse.yctung.*``` before using any ```SensingServer``` class
- If you see some errors related to ```preamble is not synced```, which menas the current setting to find the start of sensing audio is not applicalbe to your device. Please change the speaker/microphone issues and test again and feel free to file an issue if you can't solve it.
- If you can't hear any sound being played (the sound should be audible for this FreqRespAnalysis example), please check if your app has the permission to play/record sounds or if your device is muted.

# Usage: Standalone Mode (a.k.a. Real App for Product)


## Troubleshooting
- If Android tell you ```Error:Execution failed for task ':libacousticsensing:compileReleaseNdk'. NDK not configured.``` you need to update your ```local.properties``` file to include your ndk path. For example, mine is: ```sdk.dir=/Users/yctung/Library/Android/ndk```



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
MIT License
