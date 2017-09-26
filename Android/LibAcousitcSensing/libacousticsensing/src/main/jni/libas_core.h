//  2016/05/08: Note this is only for iOS (working as how Androd to link jni functions)

#ifndef acoustic_detection_h
#define acoustic_detection_h

#include "libas_utils.h"


#ifdef __cplusplus
extern "C" {
#endif
    int appleTest(int a, int b);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(initAudioSource)(JNI_FUNC_PARAM int sampleRate, int chCnt, int repeatCnt,
                  int preambleEndOffset, int preambleSyncRepeatCnt, jshortArray signalIn, jshortArray preambleIn, jshortArray syncIn);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(initParseSetting)(JNI_FUNC_PARAM int recordChCnt, int preambleSearchChIdxMatlab);
    JNI_FUNC_HEAD bool JNI_FUNC_NAME(isReadyToSense)(JNI_FUNC_NO_PARAM);
    //JNI_FUNC_HEAD jlong JNI_FUNC_NAME(addAudioSamples)(char* audioToAddBytes, int audioToAddByteSize);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(debugShowStatus)(JNI_FUNC_NO_PARAM);
#ifdef __cplusplus
}
#endif

#endif
