LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

TARGET_ARCH_ABI := all
LOCAL_MODULE	:= jnicallback
LOCAL_CFLAGS    := \
	-DDEV_NDK=1 \
	-DDEBUG_TAG=\"ForcePhone-NDK\" \
	-DSHOW_DEBUG_MESSAGE=true \
	-DSAVE_DEBUG_FILE=false

LOCAL_C_INCLUDES := \
	$(LOCAL_PATH)/../../../../../C/ \
	$(LOCAL_PATH)/../../../../../../../LibAcousticSensing/C/utils
LOCAL_SRC_FILES := \
	../../../../../C/forcephone.cpp \
	../../../../../../../LibAcousticSensing/C/utils/libas_utils.cpp
	#libas_utils.cpp
	#../../../../../../../LibAcousticSensing/C/utils/libas_utils.cpp
# NOTE: the libas_utils.cpp should be compiled after the forcephone.cpp

LOCAL_LDLIBS += -llog -ldl

include $(BUILD_SHARED_LIBRARY)
