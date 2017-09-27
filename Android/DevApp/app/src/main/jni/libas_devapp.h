#ifndef _LIBAS_DEVAPP_H_
#define _LIBAS_DEVAPP_H_

#include <jni.h>
#include <android/log.h>
#include <vector>
#include <assert.h>
#include <string.h>
#include <stdarg.h>
#include <stdio.h>
#include <stdlib.h>

#define DEBUG_TAG "DevApp-NDK"

#define SHOW_DEBUG_MESSAGE true

#define JNI_FUNC_NAME(name) Java_umich_cse_yctung_devapp_JNICallback_ ## name
#define JNI_FUNC_HEAD extern "C"
#define JNI_FUNC_PARAM JNIEnv *env, jobject obj,
#define JNI_FUNC_NO_PARAM JNIEnv *env, jobject obj

#define DEBUG_MACRO(x) __android_log_print(ANDROID_LOG_DEBUG, DEBUG_TAG, "%s", x);
#define DEBUG_MACRO_WARN(x) __android_log_print(ANDROID_LOG_WARN, DEBUG_TAG, "[WARN]: %s", x);
#define DEBUG_MACRO_ERROR(x) __android_log_print(ANDROID_LOG_ERROR, DEBUG_TAG, "[ERROR]: %s", x);
#define DEBUG_MACRO_ASSERT(x) __android_log_print(ANDROID_LOG_ERROR, DEBUG_TAG, "[ASSERT FAIL]: %s", x);
#define DEBUG_STRING_BUFFER_SIZE 1024

void debug(const char *s,...);
void warn(const char *s,...);
void error(const char *s,...);

extern "C" void JNI_FUNC_NAME(debugTest)(JNI_FUNC_NO_PARAM);
extern "C" void JNI_FUNC_NAME(dataCallback)(JNI_FUNC_PARAM jlong retAddr);


#endif /* _LIBAS_DEVAPP_H_ */
