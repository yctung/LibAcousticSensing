# LibAS
LibAcousticSensing (LibAS) is a cross-platform framework to facilitate the development of acoustic sensing applications. Some interesting demo video of LibAS can be found at [here](https://youtu.be/cnep7fFyJhc) and [here](https://youtu.be/At8imJVRDq4).

## Feature
LibAS is designed to let its users focus on the design of **acoustic sensing algorithms** without learning much the tedious platform-dependent programming details.

- Sensing algorithms can be executed on real devices like Android/iOS/Tizen/Linux devices.
- Its **remote mode** allows you to design and test sensing algorithms purely by Matlab.
- Its **standalone mode** can help transfer the Matlab sensing algorithm into cross-platform supported libraries.

### What is Acoustic Sensing?
In short, acoustic sensing can turn your device (such as a smartphone) into a *sonar-like* system. In this way, your device can sense the environments by generating sensing sounds and analyzing the received sounds.
Various interesting applications (like [this](https://youtu.be/Wn3sRmQteY8) and [this](https://youtu.be/CQ-AirK7wLY)) can be implemented and deployed with acoustic sensing.

### Why We Need LibAS?
We notice there are various platform-dependent challenges that might prevent new developers from implementing their exciting acoustic sensing ideas. For example, it is non-trivial to learn a new programming language (like Java for Android and Obj-C for iOS), especially use them to deal the real-time audio recording. Moreoever, it is also challenging to prototype/validate your sensing algorithm directly by these programming languages. So we design LibAS to **hide** these technical programming details from the developers. The following figure shows the different workflows to design acoustic sensing algorithms with/without LibAS:

![LibAS Idea](Resource/figures/intro_idea.png?raw=true "LibAS idea")


# Remote Mode (Easy for New Users)
In LibAS's **remote mode**, you don't need to know anything about real-time audio recording/playing on devices. What you need to do is download one of our prebuilt DevApp to your device and this app will automatically streams what ever signal needed for acoustic senisng controlled by a remote Matlab server.

## Install

### Prerequisites
- Matlab (I am using 2016a)
- LibAS DevApp: [Google Play Store](https://play.google.com/store/apps/details?id=umich.cse.yctung.devapp), [Apple App Store](https://TODO-not-yet), [Tizen Store](https://TODO-not-yet) or build it from the [DevApp source code](DevApp)
- Network connections between your Matlab machine and your DevApp-installed device

### DevApps (Android/iOS/Tizen)
You can download our prebuild DevApp here:

-- Android: [Google Play Store](https://play.google.com/store/apps/details?id=umich.cse.yctung.devapp)
-- iOS (TODO: update it)
-- Tizen (TODO: update it)

### Matlab
Let's use the XXX application as an example. In this example, you will be able to ask your device to play a frequency sweep and record the sweep in Matlab. To do so, let's go to your Matlab command window and first navigate to the directory of:

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
![Demo Freq Resp](Resource/figures/demo_freq_resp.png?raw=true "Demo Freq Resp")

Please refer to [the project's README](Utility/XXX) for code explainnation.


## Troubleshooting
- If you can't make the connection, try to ping your devices (e.g., adb shell ping xxx.xxx.xxx.xxx) and ensure there is no firewall between your devices
- If you keep seeing this Matlab error message ```'SensingServer' not found``` you might need to manually call ```import edu.umich.cse.yctung.*``` before using any ```SensingServer``` class
- If you see some errors related to ```preamble is not synced```, which menas the current setting to find the start of sensing audio is not applicalbe to your device. Please change the speaker/microphone issues and test again and feel free to file an issue if you can't solve it.
- If you can't hear any sound being played (the sound should be audible for this FreqRespAnalysis example), please check if your app has the permission to play/record sounds or if your device is muted.

# Standalone Mode (Build Your App for Product)
***NOT COMPLETE YET***
## Troubleshooting
- If Android tell you ```Error:Execution failed for task ':libacousticsensing:compileReleaseNdk'. NDK not configured.``` you need to update your ```local.properties``` file to include your ndk path. For example, mine is: ```sdk.dir=/Users/yctung/Library/Android/ndk```



# Compatible devices
In theory, LibAS should be compatible to all Android/Tizen/iOS/Linux devices with microphone/speaker installed.
However, it might need to customized settings for certain devices.
Followings include the devices we have used and tested in LibAS:

- Android: Samsung Galaxy S4/5/6/7/8, Note 4, Nexus 6P, Nexus 5X, HTC One, ASUS Zen Watch 3
- iOS: iPhone 5c, iPhone 6s
- Tizen: Samsung Gear S3


# License
MIT License
