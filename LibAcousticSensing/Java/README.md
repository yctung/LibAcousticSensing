# Java LibAS and Command Line Interface
This a port of LibAS on Java. We use the Javax library to play/record sensing sounds.
Thus, this porting theoretically can be executed on any device (Mac/Windows/Linux) that support Java/Javax and have speakers/microphones installed.

# Install

## Prerequisites
You need to ensure Java is installed and Javax is supported in your device.
Here is the link to install from the [official Java site](https://java.com/en/download/).

You will know Java is installed by executing the following command:
```
java -version
```

## Install
Just download our [release .jar](release) file to your device. Or you can also include this jar library into your own program (just like how our Android/iOS/Tizen LibAS work)

## Usage
You can find the usage of this .jar file by the ```-h``` option:
```
java -jar libas.jar -h

    usage: LibAS
     -d,--dump           Dump current setting
     -h,--help           Help
     -m,--mode <arg>     Sensing Mode: remote|standalone
     -s,--server <arg>   Server: address:port
```

For example, to connect a Matlab server on 192.168.0.1:50001, you can use the following command:
```
java -jar libas.jar -m remote -s 192.168.0.1:50001
```
Once you have used our libas.jar once, the setting will be kept in the pref.json file. Thus, you might just use ```java -jar libas.jar``` to connect the same server next time.

Note, our Java command-line interface only allows the **remote** sensing mode now.
So it is required to setup a Matlab server as introduced in [README](/LibAcousticSensing/Matlab) of LibAS Matlab. We will integrate the **standalone** mode soon from our Android implementation.

## Compile to Your Own Project
You can also easily integrate this jar library to your own project to use LibAS. Since this LibAS Java is modified from our Android version, most public interface remains the same. The only difference is you don't need to pass the ```Context``` anymore since it is not the Android.

## Limitation
Even though this Java LibAS should be executed on any Java/Javax-supported device,
different devices might have their own limitations on using the built-in microphones/speakers.
Unfortunately, we can't tune LibAS against every Java-supported devices (like what we did for the Android/iPhone/Tizen) since there are just too many.
Followings are some tips to make acoustic sensing app work:
- **Mac**: Even most MACs have two microphones, one is used only for noise cancellation. We suggest you turn off the ``ambient noise reduction`` in your ``System Preferences -> Sound -> Input`` setting.

Any pull request to automatically solve these device-dependent issues is welcome!
