LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

#include ../../OpenCV-2.4.7-android-sdk/sdk/native/jni/OpenCV.mk
#include /Users/eddyxd/Documents/workspace/OpenCV-2.4.7-android-sdk/sdk/native/jni/OpenCV.mk

# set the min sdk for using ndk audio lib
# ref: http://stackoverflow.com/questions/29912960/how-to-use-native-opensl-es-in-android-studio
APP_ABI := armeabi
APP_PLATFORM := android-9
TARGET_PLATFORM := android-9


LOCAL_MODULE	:= standalone
#LOCAL_CFLAGS	:= -Werror
LOCAL_CFLAGS    := -DDEV_NDK=1
# ref: https://stackoverflow.com/questions/7348997/android-ndk-how-to-let-gcc-to-use-additional-include-directories
LOCAL_C_INCLUDES := $(LOCAL_PATH) 
#LOCAL_C_INCLUDES += ../../../../../../C/LibAcousticSensing
#LOCAL_SRC_FILES := common.cpp acoustic_detection.cpp
LOCAL_SRC_FILES := \
	libas_core.cpp \
	libas_utils.cpp \
	libas_test.cpp \
	kissfft/kiss_fft.c \
    kissfft/kiss_fftr.c 
#	../../../../../../C/LibAcousticSensing/libas.cpp
LOCAL_LDLIBS += -lOpenSLES
LOCAL_LDLIBS += -llog -ldl

include $(BUILD_SHARED_LIBRARY)

