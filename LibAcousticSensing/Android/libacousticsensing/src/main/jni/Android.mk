LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

TARGET_ARCH_ABI := all
LOCAL_MODULE	:= standalone
LOCAL_CFLAGS    := \
	-DDEV_NDK=1 \
	-DDEBUG_TAG=\"LibAS-NDK\" \
	-DSHOW_DEBUG_MESSAGE=true \
	-DSAVE_DEBUG_FILE=false

LOCAL_C_INCLUDES := \
	$(LOCAL_PATH)/../../../../../C/ \
	$(LOCAL_PATH)/../../../../../C/utils
LOCAL_SRC_FILES := \
	../../../../../C/libas_core.cpp \
	../../../../../C/utils/libas_utils.cpp

LOCAL_LDLIBS += -llog -ldl

include $(BUILD_SHARED_LIBRARY)
