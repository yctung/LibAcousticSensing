LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

TARGET_ARCH_ABI := all
LOCAL_MODULE	:= jnicallback
LOCAL_CFLAGS    := -DDEV_NDK=1
LOCAL_C_INCLUDES := \
	$(LOCAL_PATH) \
	$(LOCAL_PATH)/../
LOCAL_SRC_FILES := \
	../test_ext.cpp \
	forcephone.cpp \
	libas_utils.cpp

LOCAL_LDLIBS += -llog -ldl

include $(BUILD_SHARED_LIBRARY)
