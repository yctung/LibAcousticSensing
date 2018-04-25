//==========================================================================
// 2015/11/11: use the global variables to save overheads
// 2015/11/22: update reply mode for all detections
// 2016/07/21: update buffer to ring buffer -> so it can run infinite times
//==========================================================================

//=========================================================================================================
//         !!! NOTE !!! It is a shared preference -> modify it will affect both iOS and Android code
//=========================================================================================================
#include "forcephone.h"

//-------------------------------------------------------------------------
// 2. Global control variables, start by g prefix
//-------------------------------------------------------------------------
struct AudioSource {
    int sampleRate;
    int chCnt;
    int repeatCnt;
    float *signalReversed;
    int signalSize;
};
AudioSource gAudioSource;

struct ParseSetting {
    int preambleSearchChIdx;
    int recordChCnt; // record channel count
};
ParseSetting gParseSetting;

char *gLogFolderPath;


//-------------------------------------------------------------------------
// 4. Public functions (JNI interfaced)
//-------------------------------------------------------------------------
// just test the debug method
JNI_FUNC_HEAD void JNI_FUNC_NAME(debugTest)(JNI_FUNC_NO_PARAM){
    debug("Here is the ndk debug message");
}

// DEPRECATED: we now use the setting directly from Matlab
// function to init the audio source setting
static bool sAudioSourceIsSet = false;
// TODO: find a better "cross-platform" function signature
#ifdef DEV_NDK
JNI_FUNC_HEAD void JNI_FUNC_NAME(initAudioSource)(JNI_FUNC_PARAM int sampleRate, int chCnt, int repeatCnt,
              int preambleEndOffset, int preambleSyncRepeatCnt, jshortArray signalIn, jshortArray preambleIn, jshortArray syncIn){
    debug("--- initAudioSource ---");

    AudioSource *as = &gAudioSource; // global setting
    as->sampleRate = sampleRate;
    as->chCnt = chCnt;
    as->repeatCnt = repeatCnt;
    as->signalSize = env->GetArrayLength(signalIn);
    as->signalReversed = (float*)malloc(as->signalSize * sizeof(float));

    short* signalShort = env->GetShortArrayElements(signalIn, 0);
    convertShortArrayToFloatArray(as->signalReversed, signalShort, as->signalSize, true /* needToReverse*/);
#ifdef DEV_NDK
    env->ReleaseShortArrayElements(signalIn, signalShort, 0);
#endif
    sAudioSourceIsSet = true;
}
#endif

// function to init the parse setting
// TODO: let more setting be initialized here
static bool sParseSettingIsSet = false;
JNI_FUNC_HEAD void JNI_FUNC_NAME(initParseSetting)(JNI_FUNC_PARAM int recordChCnt, int preambleSearchChIdxMatlab){
    debug("--- initParseSetting ---");
    ParseSetting *ps = &gParseSetting;
    ps->recordChCnt = recordChCnt;
    ps->preambleSearchChIdx = preambleSearchChIdxMatlab - 1; // we need -1 because Matlab index starts at 1

    if (ps->preambleSearchChIdx >= ps->recordChCnt) {
        warn("illegal preambleSearchChIdx = %d, set it to 0", ps->preambleSearchChIdx);
        ps->preambleSearchChIdx = 0;
    }
    sParseSettingIsSet = true;
}

// functions allocate global variables -> must be called before other function is called
static bool sSenseSettingIsSet = false;
#ifdef DEV_NDK
JNI_FUNC_HEAD void JNI_FUNC_NAME(initSenseSetting)(JNI_FUNC_PARAM jstring logFolderPathIn){
#else
JNI_FUNC_HEAD void JNI_FUNC_NAME(initSenseSetting)(JNI_FUNC_PARAM char* logFolderPathIn){
#endif
    debug("--- initSenseSetting ---");
    const char *logFolderPath;
#ifdef DEV_NDK
    logFolderPath = env->GetStringUTFChars(logFolderPathIn, 0);
#else
    logFolderPath = logFolderPathIn;
#endif

    gLogFolderPath = (char*)malloc(strlen(logFolderPath) * sizeof(char));
    strcpy(gLogFolderPath, logFolderPath);
    debug("gLogFolderPath = %s", gLogFolderPath);

    // init Matlab code setting
    //ForcePhoneCallback_initialize();

#ifdef DEV_NDK // release resources
    env->ReleaseStringUTFChars(logFolderPathIn, logFolderPath);
#endif
    sSenseSettingIsSet = true;
}

// function determines if it is ready to sense
JNI_FUNC_HEAD bool JNI_FUNC_NAME(isReadyToSense)(JNI_FUNC_NO_PARAM) {
    return sAudioSourceIsSet && sParseSettingIsSet && sSenseSettingIsSet;
}

// function to check detection status (debug only)
JNI_FUNC_HEAD void JNI_FUNC_NAME(debugShowStatus)(JNI_FUNC_NO_PARAM){
    debug("--- detectionCheckStatus ---");
	  debug("gLogFolderPath = %s", gLogFolderPath);
	  debug("isReadyToSense = %d", sAudioSourceIsSet && sParseSettingIsSet && sSenseSettingIsSet);
}

// function clean global variables
JNI_FUNC_HEAD void JNI_FUNC_NAME(finalize)(JNI_FUNC_NO_PARAM){
    debug("--- detectionClean ---");
    // TODO: implement this function
    sAudioSourceIsSet = false;
    sParseSettingIsSet = false;
    sSenseSettingIsSet = false;
    ForcePhoneCallback_terminate();
}


// NOTE: this strctu should be consistent to the strcture in the libas_core.cpp
struct AddAudioRet {
    int chCnt;
    int traceCnt;
    int sampleCnt;
    float ***data; // data[chIdx][traceIdx][sampleIdx]; -> reverse order of the Matlab data structure
};

#define AUDIO_CH_CNT_MAX 2
#define AUDIO_REPEAT_CNT 500
#define PULSE_DETECTION_MAX_RANGE_SAMPLES (2400)
float gConBufs[AUDIO_CH_CNT_MAX][AUDIO_REPEAT_CNT][PULSE_DETECTION_MAX_RANGE_SAMPLES];

JNI_FUNC_HEAD void JNI_FUNC_NAME(dataCallback)(JNI_FUNC_PARAM jlong retAddr) {
    AddAudioRet *r = (AddAudioRet *)retAddr;
    debug("retAddr (jlong) = %ld", retAddr);
    debug("ret's chCnt %d, traceCnt %d, sampleCnt = %d", r->chCnt, r->traceCnt, r->sampleCnt);

    // TODO: fetch the audio for processing by the audio setting
    float *audioToProcess = &r->data[0][0][0];

}