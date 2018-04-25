

# Standalone C Mode
LibAS provides the interface for connecting your (Matlab-generated) C algorithm
to physical devices. In short, this method allows you to execute your
Matlab sensing algorithm directly in the devices. You can either choose to
re-write the Matlab code directly in C or use the Matlab's codegen function.
We will use this ForcePhone example to demonstrate how to use the LibAS's Standalone C Mode.

## Matlab Code Generation
In Matlab, there is a "APP" called "Matlab Coder" that can help automatically
translate a Matlab function to C function.
There is a helpful video to explain how it works: https://www.mathworks.com/videos/matlab-to-iphone-and-android-made-easy-107779.html

## Export AudioSource
Since in the standalone mode, there is no connection to our Matlab server and your sensing setting.
You need to export the AudioSource as by the function called SaveAudioSourceAndParseSetting()
to save the settings being offline loaded on the standalone mode. Just copy all the generated
files to the phone asset folder.

## Add Generated Code to iOS


## Add Generated Code to Android
Java connects C code by Java Native Interface (JNI).
Since Java doesn't allow passing the C function (pointer) through the included
Java library, so we can't not handle all the JNI interface connection to you.
A workaround that LibAS is using is to provide a Java-callback interface but
passing the C-based memory space to avoid the expensive value-copy operations.
This ForcePhone example explain how to use LibAS's standalone mode in Android.

### Matlab Coder Project
We have created the template Matlab Coder Project (i.e., ./Matlab/ForcePhoneCallback.prj).
Please double-click this file in your Matlab workspace to config the details.
Create and define your own Matlab Coder Project is also easy, basically
you need to define a "pseudo" main function (e.g., ./Matlab/ForcePhoneStandaloneMain.m)
that defines the input structure and variable size. It is a necessary step
since C doesn't support function polymorphism like Matlab
(i.e., passing whatever argument structure and various dimension/size of array).
However, this problem can be easily fixed by utilizing a "pseudo" main function
that "pretend" to call Matlab function in a way that you want how it does in the C.

Once everything is done, the generated callback function is in ./Matlab/codegen.
Copy this folder to the ./C/codegen so we can later use it in the Android and iOS.


## Add Generated Code to other platforms (Tizen and Linux)
Our Linux platform using Java, so the principle of adding C code into it
is similar to our Android example. Also Tizen execute C code directly, so
the process to do it is similar to our iOS example

## Troubleshooting
- if you see the "undefined reference" in the JNI build, check if your Matlab is outputing the C++ source instead of C, some related reference: https://stackoverflow.com/questions/22159183/android-ndk-jni-undefined-reference-to-function-defined-in-custom-header-fil
