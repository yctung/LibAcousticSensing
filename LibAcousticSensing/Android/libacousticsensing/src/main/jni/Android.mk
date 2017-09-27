LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

TARGET_ARCH_ABI := all
LOCAL_MODULE	:= standalone
LOCAL_CFLAGS    := -DDEV_NDK=1
LOCAL_C_INCLUDES := $(LOCAL_PATH)
LOCAL_SRC_FILES := \
	libas_core.cpp \
	libas_utils.cpp \
	libas_test.cpp \
	kissfft/kiss_fft.c \
    kissfft/kiss_fftr.c
LOCAL_LDLIBS += -llog -ldl

include $(BUILD_SHARED_LIBRARY)

# set the min sdk for using ndk audio lib
# ref: http://stackoverflow.com/questions/29912960/how-to-use-native-opensl-es-in-android-studio
# APP_ABI := armeabi
# APP_PLATFORM := android-9
# TARGET_PLATFORM := android-9
