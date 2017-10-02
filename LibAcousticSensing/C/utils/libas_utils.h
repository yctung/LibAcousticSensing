//=========================================================================================================
//         !!! NOTE !!! It is a shared preference -> modify it will affect both iOS and Android code
//=========================================================================================================

#ifdef DEV_NDK
#include <jni.h>
#include <android/log.h>
#include <vector>
#endif

#include <assert.h>
#include <string.h>
#include <stdarg.h>
#include <stdio.h>
#include <stdlib.h>

// how to include stl in c
// ref: http://iphonedevsdk.com/forum/iphone-sdk-development/16528-how-include-stl-xcode.html
// NEED TO:
//project->build setting ->apple LLVM compiler3.0 - language
//change to "Objective-C++" at "Compile Sources As" :-)
#include <math.h>
//#include <string>
//#include <sstream>
//#include <iostream>

// global control variables
#ifndef SHOW_DEBUG_MESSAGE
#define SHOW_DEBUG_MESSAGE true
#endif

#ifndef SAVE_DEBUG_FILE
#define SAVE_DEBUG_FILE true
#endif

#ifndef DEBUG_TAG
#define DEBUG_TAG "LibAS-NDK"
#endif

//using namespace std;
#ifdef DEV_NDK

// NOTE: remember to define other module's function name before include this lib
#ifndef JNI_FUNC_NAME
#define JNI_FUNC_NAME(name) Java_umich_cse_yctung_libacousticsensing_Standalone_JNIController_ ## name
#endif

#define JNI_FUNC_HEAD extern "C"
#define JNI_FUNC_PARAM JNIEnv *env, jobject obj,
#define JNI_FUNC_NO_PARAM JNIEnv *env, jobject obj

#else

#define JNI_FUNC_NAME(name) JniShared_ ## name
#define JNI_FUNC_HEAD
#define JNI_FUNC_PARAM
#define JNI_FUNC_NO_PARAM
//#define jstring std::string
#endif

#define DEBUG_MACRO(x) __android_log_print(ANDROID_LOG_DEBUG, DEBUG_TAG, "%s", x);
#define DEBUG_MACRO_WARN(x) __android_log_print(ANDROID_LOG_WARN, DEBUG_TAG, "[WARN]: %s", x);
#define DEBUG_MACRO_ERROR(x) __android_log_print(ANDROID_LOG_ERROR, DEBUG_TAG, "[ERROR]: %s", x);
#define DEBUG_MACRO_ASSERT(x) __android_log_print(ANDROID_LOG_ERROR, DEBUG_TAG, "[ASSERT FAIL]: %s", x);
#define DEBUG_STRING_BUFFER_SIZE 1024

void debug(const char *s,...);
void warn(const char *s,...);
void error(const char *s,...);
void check(const int result, const char *s,...);
int getMaxIdx(float*, int);
void estimateMeanAndStd(float *s, int len, float *mean, float *std);
/*
int estimateBinFreqs(float *&freqs, int &binStartFreqIdx, int &binEndFreqIdx, int sCol, int FS, float BIN_START, float BIN_END);
void makeFFTBins(float **s2D, float **&fftBins, int sCol, int sRow, int binStartFreqIdx, int binEndFreqIdx, int binCnt, const char *logFolderPath);
*/
void convertShortArrayToFloatArray(float *f, short *s, int size, bool needToReverse);

void makeConvolveInDestSize(float*, int, float *, int , float *, int , bool);
void makeFilter(float *, int , float *, int , float *, int , float *);
float makeAbsConvInRange(float *source, int sourceSize, float *pulse, int pulseSize, float *dest, int destSize, int rangeStart, int rangeEnd);
void debugToMatlabFile2D(float** data, int col, int row, char* name, const char* path);
void debugToMatlabFile1D(float *data, int col, char* name, const char* path);
//void debugToMatlabFile2D(short** data, int col, int row, char* name, const char* path);
//void debugToMatlabFile1D(short *data, int col, char* name, const char* path);
void normalize(float* dest, int destSize);
float myAbs(float a);
