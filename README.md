# LibAS
LibAcousticSensing (LibAS) is a cross-platform framework to facilitate the development of acoustic sensing applications. Some interesting demo video of LibAS can be found at [here](https://youtu.be/cnep7fFyJhc) and [here](https://youtu.be/At8imJVRDq4).

## Notice
I will make a major update soon. This update is currently in the separate branch called mobisys. For people wanna know how to convert their project from the Remote mode to Standalone mode, please check the mobisys branch. Since there are some API updates that might be inconsistent to the current branch and we have some active developers are using the master branch, I will keep the master branch intact until the mobisys branch ready to be released.

## Feature
LibAS is designed to let its users focus on the design of **acoustic sensing algorithms** without learning much the tedious platform-dependent programming details.

- Sensing algorithms can be executed on real devices like Android/iOS/Tizen/Linux devices.
- Its **remote mode** allows you to design and test sensing algorithms purely by Matlab.
- Its **standalone mode** can help transfer the Matlab sensing algorithm into cross-platform supported libraries.

### What is Acoustic Sensing?
In short, acoustic sensing can turn your device (such as a smartphone) into a *sonar-like* system. In this way, your device can sense the environments by generating sensing sounds and analyzing the received sounds.
Various interesting applications (like [this](https://youtu.be/Wn3sRmQteY8) and [this](https://youtu.be/CQ-AirK7wLY)) can be implemented and deployed with acoustic sensing.

### Why We Need LibAS?
We notice there are various platform-dependent challenges that might prevent new developers from implementing their exciting acoustic sensing ideas. For example, it is non-trivial to learn a new programming language (like Java for Android and Obj-C for iOS), especially to deal with the real-time audio recording. Moreover, it is also challenging to prototype/validate your sensing algorithm directly by these system programming languages. So we design LibAS to **hide** most technical programming details from the developers. The following figure shows the difference of designing acoustic sensing algorithms with or without LibAS:

![LibAS Idea](Resource/figures/intro_idea.png?raw=true "LibAS idea")


# Remote Mode (Easy for New Users)
In LibAS's **remote mode**, you don't need to know anything about real-time audio recording/playing on devices. What you need to do is download one of our prebuilt DevApp to your device and this app will automatically stream whatever signal needed for acoustic sensing to a remote Matlab server. You can easily design your sensing algorithm in Matlab and control the connected device to sense. Please read the [LibAS's Matlab README](/LibAcousticSensing/Matlab/) for knowing the API details and its usage.

## Install

### Prerequisites
- Matlab 2014b or later (see [uicontrol compatibility](compatibility) for an earlier version)
- LibAS DevApp: [Google Play Store](https://play.google.com/store/apps/details?id=umich.cse.yctung.devapp), [Apple App Store](https://itunes.apple.com/us/app/libas-devapp/id1292387567?ls=1&mt=8), [Tizen Store](https://TODO-not-yet) or build it from the [DevApp source code](DevApp)
- Network connections between your Matlab machine and your DevApp-installed device

### Setup
Let's use our [Utility/FreqRespAnalysis](Utility/FreqRespAnalysis) as an example. In this example, Matlab server is programmed to ask the connected device to play several frequency sweeps for analyzing the frequency response between the device speakers and microphones. To set up this Matlab server, let's navigate to the example directory in your Matlab command window:

```
>> cd Utility/FreqRespAnalysis/Matlab
```

And then call the Setup.m function

```
>> Setup
```

***WARN: For the first using this app, you will see the following message after calling the*** ```Setup```. Please type Y and then restart your Matlab. (It is necessary for Matlab to load our customized java classes):

```
>> [WARNING]: JavaClassPath is not added yet!
>> Add this path will restart the Matlab.
>> Do you want to do this now?
>> (Y/N): Y
```

You are all set and can start running your fancy sensing algorithms with LibAS :)

## Usage

You now can use Matlab to control the connected device to sense by the following four steps as shown in the figure:
- (1) Execute ```Setup.m``` and ```FreqRespAnalysisMain.m```
- (2) Edit your server's address and port in the DevApp and click the connect button (you should see the red texts showing ```--- ACTION_CONNECT ---``` in Matlab when the connection is successful)
- (3) Click the ```Start Sensing``` button in the Matlab GUI
- (4) Now you hear screaming sound being played and see the the frequency response of your device being plotted
![Demo Freq Resp](Resource/figures/demo_freq_resp.png?raw=true "Demo Freq Resp")

You can also change the sound to play easily by editing the ```AudioSource``` class in the  ```FreqRespAnalysisMain.m```. Please refer to [LibAS's Matlab README](/LibAcousticSensing/Matlab/) for knowing how the code works.


## Troubleshooting
- If you can't build the connection in DevApp, try to ping your Matlab machine (e.g., adb shell ping 10.0.0.1) and ensure there is no firewall between your Matlab server and device
- If you keep seeing this Matlab error message ```'SensingServer' not found``` you might need to manually call ```import edu.umich.cse.yctung.*``` before using any ```SensingServer``` class
- If you can't hear any sound being played (the sound should be audible for this FreqRespAnalysis example), please check if your app has the permission to play/record sounds or if your device is muted.
- If you see some errors related to ```preamble is not synced```, which menas LibAS's current setting to find the start of sensing audio fails. Please use the other microphone/speaker to and test again. Feel free to file an issue if you can't solve it.


# Standalone Mode (Build Your App for Product)
***NOT COMPLETE YET***
## Troubleshooting
- If Android tell you ```Error:Execution failed for task ':libacousticsensing:compileReleaseNdk'. NDK not configured.``` you need to update your ```local.properties``` file to include your ndk path. For example, mine is: ```sdk.dir=/Users/yctung/Library/Android/ndk```


# Compatible devices
In theory, LibAS should be compatible with all Android, iOS, Tizen devices with microphone/speaker installed.
However, it might need to customized settings for different devices.
Followings include the devices we have used and tested in LibAS:

- Android: ```Samsung Galaxy S4/5/6/7/8, Note 4, Nexus 6P, Nexus 5X, HTC One, ASUS Zen Watch 3```
- iOS: ```iPhone 5c, iPhone 6s```
- Tizen: ```Samsung Gear S3```


# License
MIT License
