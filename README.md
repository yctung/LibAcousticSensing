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
There are two usage of this sensing library. 
You can choose to use the remote sensing mode which only require you to install the pre-build app in your mobile devices and then control them by a remote Matlab server. 
For beginners using this toolkit in the first time, we suggest you try this remote mode because it will let you know how to do acoustic sensing with minimal overhead.

For people knows how the acoustic sensing goes and already know how LibAS works, they can include LibAS as a library into their projects. 
The benefit of this mode is they don't need to remote server and networking connection anymore and can ship their app as a standalone app. Please follow the **Standalone Mode** section for using this mode.

# Remote Mode (need Matlab)


# Standalone Mode (need to know Phone programing)

