//  2016/05/08: Note this is only for iOS (working as how Androd to link jni functions)

#ifndef acoustic_detection_h
#define acoustic_detection_h

#include "libas_utils.h"


#ifdef __cplusplus
extern "C" {
#endif
    int appleTest(int a, int b);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(deviceSettingGeneralInit)(JNI_FUNC_PARAM int detectChIdxIn);
    JNI_FUNC_HEAD int JNI_FUNC_NAME(addAudioSamples)(char* audioToAddBytes, int audioToAddByteSize);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(detectionInit)(JNI_FUNC_PARAM char* logFolderPathIn);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(detectionCheckStatus)(JNI_FUNC_NO_PARAM);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(enablePseReply)(JNI_FUNC_NO_PARAM);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(enableSseReply)(JNI_FUNC_NO_PARAM);
    JNI_FUNC_HEAD void JNI_FUNC_NAME(disableReply)(JNI_FUNC_NO_PARAM);
    JNI_FUNC_HEAD bool JNI_FUNC_NAME(isReplyReadyToFetch)(JNI_FUNC_NO_PARAM);
    JNI_FUNC_HEAD float JNI_FUNC_NAME(fetchReply)(JNI_FUNC_NO_PARAM);
    
#ifdef __cplusplus
}
#endif

#endif
