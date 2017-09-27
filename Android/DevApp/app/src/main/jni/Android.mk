LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)


TARGET_ARCH_ABI := all
LOCAL_MODULE	:= jni_callback
LOCAL_CFLAGS    := -DDEV_NDK=1
# ref: https://stackoverflow.com/questions/7348997/android-ndk-how-to-let-gcc-to-use-additional-include-directories
LOCAL_C_INCLUDES := $(LOCAL_PATH)
LOCAL_SRC_FILES := \
	libas_devapp.cpp

LOCAL_LDLIBS += -llog -ldl

include $(BUILD_SHARED_LIBRARY)

# set the min sdk for using ndk audio lib
# ref: http://stackoverflow.com/questions/29912960/how-to-use-native-opensl-es-in-android-studio
#APP_ABI := armeabi
#APP_PLATFORM := android-14
#TARGET_PLATFORM := android-14
