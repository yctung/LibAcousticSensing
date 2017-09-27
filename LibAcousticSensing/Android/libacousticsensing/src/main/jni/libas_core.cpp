//==========================================================================
// 2015/11/11: use the global variables to save overheads
// 2015/11/22: update reply mode for all detections
// 2016/07/21: update buffer to ring buffer -> so it can run infinite times
//==========================================================================

//=========================================================================================================
//         !!! NOTE !!! It is a shared preference -> modify it will affect both iOS and Android code
//=========================================================================================================

#include <string.h>
#include <stdarg.h>
#include <stdio.h>
#include <vector>
#include "libas_utils.h"
#include "libas_audio.h"

#ifndef DEV_NDK
#include "libas_core.h"
#endif

//------------------------------------------------------------------------
// 1. Audio related setting
// NOTE: this setting must be compatible to the matlab audio source setting
// NOTE: audio pilot/pulse setting is existed at audio.h
//------------------------------------------------------------------------
#define AUDIO_CH_MAX_CNT 2
#define AUDIO_SAMPLE_BYTE_CNT 2
#define AUDIO_BUFF_MAX_SIZE 500000
#define AUDIO_FS 48000
#define PULSE_DETECTION_MAX_RANGE_SAMPLES (800)
//#define AUDIO_REPEAT_CNT 5000
#define AUDIO_REPEAT_CNT 500
#define RING_IDX(x) (x%AUDIO_REPEAT_CNT)
#define AUDIO_PRE_FILTER_ENABLED false /* TODO: implement this */


// Optimized data processing setting -> only process the necessary data now
// NOTE only this antennal will be processed to data
//#define DETECT_CH_IDX (1)
int DETECT_CH_IDX = 1;

static bool sNeedToSearchPreamble = false;
static bool sNeedToRemovePreamble = false;
//-------------------------------------------------------------------------
// 2. Global control variables, start by g prefix
//-------------------------------------------------------------------------
struct AudioSource {
    int sampleRate;
    int chCnt;
    int repeatCnt;
    int preambleEndOffset;
    int preambleSyncRepeatCnt;
    //short[] signal;
    //short[] preamble;
    int signalSize;
    float *syncReversed;
    int syncSize;
};
AudioSource gAudioSource;

struct ParseSetting {
    int preambleSearchChIdx;
    int recordChCnt; // record channel count
};
ParseSetting gParseSetting;

char *gLogFolderPath;
float gAudioBufs[AUDIO_CH_MAX_CNT][AUDIO_BUFF_MAX_SIZE]; // TODO: reduce this size for saving energy
int gAudioBufEnd;

int gPilotLenToRemove;
int gAudioProcessIdx;

//-------------------------------------------------------------------------
// 3. Detection of some utility functions
//-------------------------------------------------------------------------
int LibFindPreamble();

//-------------------------------------------------------------------------
// 4. Public functions (JNI interfaced)
//-------------------------------------------------------------------------
// just test the debug method
JNI_FUNC_HEAD void JNI_FUNC_NAME(debugTest)(JNI_FUNC_NO_PARAM){
    debug("Here is the ndk debug message");
}

// function to init the audio source setting
static bool sAudioSourceIsSet = false;
JNI_FUNC_HEAD void JNI_FUNC_NAME(initAudioSource)(JNI_FUNC_PARAM int sampleRate, int chCnt, int repeatCnt,
              int preambleEndOffset, int preambleSyncRepeatCnt, jshortArray signalIn, jshortArray preambleIn, jshortArray syncIn){
    debug("--- initAudioSource ---");

    AudioSource *as = &gAudioSource; // global setting
    as->sampleRate = sampleRate;
    as->chCnt = chCnt;
    as->repeatCnt = repeatCnt;
    as->preambleEndOffset = preambleEndOffset;
    as->preambleSyncRepeatCnt = preambleSyncRepeatCnt;
    as->signalSize = env->GetArrayLength(signalIn);
    as->syncSize = env->GetArrayLength(syncIn);
    as->syncReversed = (float*)malloc(as->syncSize * sizeof(float));

    short* syncShort = env->GetShortArrayElements(syncIn, 0);
    convertShortArrayToFloatArray(as->syncReversed, syncShort, as->syncSize, true /* needToReverse*/);

#ifdef DEV_NDK
    env->ReleaseShortArrayElements(syncIn, syncShort,0);
#endif
    sAudioSourceIsSet = true;
}

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

    gAudioBufEnd = 0; // NOTE c++ starts from 0

    sNeedToSearchPreamble = true;
    if(sNeedToSearchPreamble){
        sNeedToRemovePreamble = true;
    }
    gPilotLenToRemove = -1;
    gAudioProcessIdx = 0;

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
}

static bool sAudioIsAdding = false;
#define ADD_AUDIO_RET_ERROR -1
#define ADD_AUDIO_RET_NO_PREAMBLE_FOUND -2
#define ADD_AUDIO_RET_NOTHING_TO_PROCESS 0
// a reference class used to pass memory between jni efficiently
struct AddAudioRet{
    int chCnt;
    int traceCnt;
    int sampleCnt;
    float ***data; // data[chIdx][traceIdx][sampleIdx]; -> reverse order of the Matlab data structure
};

// fucntion to add audio to buffers
// TODO: clean this code? now it is a direct copy from my Matlab code
#ifdef DEV_NDK
JNI_FUNC_HEAD jlong JNI_FUNC_NAME(addAudioSamples)(JNI_FUNC_PARAM jbyteArray audioToAdd){
    debug("--- addAudioSamples ---");
  	// ensure there is no racing condition on adding the audio (should not happen)
  	if(sAudioIsAdding){
  		  error("audio is added when another thread is also adding audio, racing condition. (too many processing on the main thread?)");
        return ADD_AUDIO_RET_ERROR;
  	}
  	sAudioIsAdding = true;

  	jbyte* audioToAddBytes = env->GetByteArrayElements(audioToAdd,0);
  	jsize audioToAddByteSize = env->GetArrayLength(audioToAdd);
#else
JNI_FUNC_HEAD int JNI_FUNC_NAME(addAudioSamples)(char* audioToAddBytes, int audioToAddByteSize){
#endif

    AudioSource *as = &gAudioSource;
    ParseSetting *ps = &gParseSetting;
  	int audioToAddSampleCnt	= audioToAddByteSize / (ps->recordChCnt * AUDIO_SAMPLE_BYTE_CNT);
  	debug("audioToAddByteSize = %d, audioToAddSampleCnt = %d",audioToAddByteSize, audioToAddSampleCnt);
  	debug("before add audio, gAudioBufEnd = %d", gAudioBufEnd);

  	// 1. parse byte arry into global audio buffers
  	int chIdx = 0;
  	for(int i = 0; i < audioToAddByteSize; i += AUDIO_SAMPLE_BYTE_CNT){
        // a. byte parsing
    		short shortValue = (short)((audioToAddBytes[i] & 0xFF) | ((audioToAddBytes[i+1] & 0xFF) << 8));
        //if (i < 10) debug("i = %d, chIdx = %d, shortValue = %d", i, chIdx, shortValue);
    		float floatValue = (float)shortValue;

    		// b. assign value to right position
    		gAudioBufs[chIdx][gAudioBufEnd] = floatValue;

        // c. update indexs
        chIdx = (chIdx + 1) % ps->recordChCnt;
        if(chIdx == ps->recordChCnt - 1){ // reach the last channel component
            gAudioBufEnd = gAudioBufEnd+1;
        }
  	}

  	debug("after add audio, gAudioBufEnd = %d, gPilotLenToRemove = %d", gAudioBufEnd, gPilotLenToRemove);
  	debug("first few added element is: (%f,%f), (%f,%f)", gAudioBufs[0][0], gAudioBufs[0][1], gAudioBufs[1][0], gAudioBufs[1][1]);

#ifdef DEV_NDK // release byte array
  	env->ReleaseByteArrayElements(audioToAdd, audioToAddBytes,0);
#endif

  	// 2. search pilot if need in the first packet
    // NOTE: sometimes, even we can find the preamble, we mgiht not receive enough audio to remove it
  	if (sNeedToSearchPreamble && gAudioBufEnd >= AUDIO_SAMPLE_TO_FIND_PILOT){
        debug("*** get enough audio data to search preamble ***");
        int pilotEndOffset = LibFindPreamble();
    		debug("pilotEndOffset = %d", pilotEndOffset);
    		if(pilotEndOffset < 0){
            warn("[WARN]: unable to find pilot");
    			  sAudioIsAdding = false;
    			  return ADD_AUDIO_RET_NO_PREAMBLE_FOUND;
    		}
    		gPilotLenToRemove = pilotEndOffset + as->preambleEndOffset;
    		sNeedToSearchPreamble = false;
  	}

  	// 3. remove preamble if receive enough audio data
  	if (!sNeedToSearchPreamble && sNeedToRemovePreamble && gAudioBufEnd > gPilotLenToRemove){
  		  debug("*** get enough audio data to remove preamble ***");
  		  int newAudioBufEnd = gAudioBufEnd - gPilotLenToRemove;
    		debug("old end = %d, new end = %d", gAudioBufEnd, newAudioBufEnd);

    		debugToMatlabFile1D(&gAudioBufs[0][0], gAudioBufEnd, (char*)"audio_before_remove", gLogFolderPath);
    		for(int chIdx = 0; chIdx < ps->recordChCnt; chIdx++){
    			   memmove(&gAudioBufs[chIdx][0], &gAudioBufs[chIdx][gPilotLenToRemove], newAudioBufEnd * sizeof(float));
    		}
    		gAudioBufEnd = newAudioBufEnd;
    		debugToMatlabFile1D(&gAudioBufs[0][0], gAudioBufEnd, (char*)"audio_after_remove", gLogFolderPath);

    		sNeedToRemovePreamble = false;
  	}

  	// 4. start cut the audio data for processing
  	if (!sNeedToSearchPreamble && !sNeedToRemovePreamble && gAudioBufEnd > as->signalSize){
  		  debug("*** get enough data to process ***");
  		  int repeatToProcess = gAudioBufEnd / as->signalSize; // NOTE: c++ use the largest quotient -> no need floor
  		  int lenToProcess = repeatToProcess * as->signalSize;
  	    int newAudioBufEnd = gAudioBufEnd - lenToProcess;

  		  debug("repeatToProcess = %d",repeatToProcess);
        // TODO: add a ch mask to save memory and time (e.g., only process the 1st channel)
        AddAudioRet *ret = 0;

        // allocate ret structure if need
        if (repeatToProcess > 0) {
            ret = (AddAudioRet *)malloc(sizeof(AddAudioRet));
            ret->chCnt = ps->recordChCnt;
            ret->traceCnt = repeatToProcess;
            ret->sampleCnt = as->signalSize;
            /*
            ret->data = (float ***)malloc(ps->recordChCnt * sizeof(float **));
            for (int chIdx = 0; chIdx < ps->recordChCnt; chIdx++) {
                *(ret->data + chIdx) = (float **)malloc(repeatToProcess * sizeof(float *));
                for (int repeatIdx = 0; repeatIdx < repeatToProcess; repeatIdx++){
                    *(*(ret->data + chIdx) + repeatIdx) = (float *)malloc(as->signalSize * sizeof(float));
                }
            }
            */
        }

        // process data
        for (int repeatIdx = 0; repeatIdx < repeatToProcess; repeatIdx++){
            for (int chIdx = 0; chIdx < ps->recordChCnt; chIdx++){
                // TODO: new a data structure to save these audio data
      					float *audioToProcess = &gAudioBufs[chIdx][repeatIdx * as->signalSize];

      					char debugFileName[100];
      					sprintf(debugFileName,"audio_%d_%d",gAudioProcessIdx,chIdx);
      					debugToMatlabFile1D(audioToProcess, as->signalSize, debugFileName, gLogFolderPath);

                //memcpy(*(*(ret->data + chIdx) + repeatIdx), audioToProcess, as->signalSize);

      				  // udpate data buffer indexs
                if(chIdx == ps->recordChCnt - 1){ // end of this repeatation
                    gAudioProcessIdx++;
      					}
            }
        }

    		// update global audio buf (i.e., remove the processed audio from buf)
    		for(int chIdx = 0; chIdx < ps->recordChCnt; chIdx++){
    			   memmove(&gAudioBufs[chIdx][0], &gAudioBufs[chIdx][lenToProcess], newAudioBufEnd * sizeof(float));
    		}
    		gAudioBufEnd = newAudioBufEnd;

  		  sAudioIsAdding = false;
  		  //return gAudioProcessIdx; // indicate audio is processed in this time
        debug("sizeof(ret) = %d, sizeof(jlong) = %d", sizeof(ret), sizeof(jlong));

        jlong retLong = (jlong)(& (* ret));
        debug("retLong (output) = %ld", retLong);
        AddAudioRet *temp = (AddAudioRet *)retLong;
        debug("temp's chCnt %d, traceCnt %d, sampleCnt = %d", temp->chCnt, temp->traceCnt, temp->sampleCnt);
        return retLong; // return the memory address of the ret structure
  	}

  	sAudioIsAdding = false;
  	return ADD_AUDIO_RET_NOTHING_TO_PROCESS;
}

// just a dummy fucntion to test if the passing by address of addAudioRet works
JNI_FUNC_HEAD void JNI_FUNC_NAME(debugDumpAddAudioRet)(JNI_FUNC_PARAM jlong addAudioRet) {
    AddAudioRet *r = (AddAudioRet *)addAudioRet;
    debug("addAudioRet (input) = %ld", addAudioRet);
    //debug("ret's chCnt %d, traceCnt %d, sampleCnt = %d", r->chCnt, r->traceCnt, r->sampleCnt);
}


//-------------------------------------------------------------------------
// 6. Utility functions
// TODO: update my new version of preamable detect (more robust)
//-------------------------------------------------------------------------
#define FIND_PREAMBLE_RET_ERROR -1
int LibFindPreamble(){
  	debug("---LibFindPreamble---");
    AudioSource *as = &gAudioSource;
    ParseSetting *ps = &gParseSetting;

  	if (ps->preambleSearchChIdx < 0 || ps->preambleSearchChIdx >= ps->recordChCnt) {
  		  error("[ERROR]: ps->preambleSearchChIdx = %d", ps->preambleSearchChIdx);
        return FIND_PREAMBLE_RET_ERROR;
  	}

  	// 1. make convolvution of audio and show results
  	float *signal = &gAudioBufs[ps->preambleSearchChIdx][0];
  	int signalLen = AUDIO_SAMPLE_TO_FIND_PILOT;

  	debug("preambleSearchChIdx = %d, signal = (%f,%f,%f,%f)", ps->preambleSearchChIdx, signal[0], signal[1], signal[2], signal[3]);


  	int conValidSize = gAudioBufEnd;
  	float *con = (float *)malloc(sizeof(float) * conValidSize);

  	debugToMatlabFile1D(signal, signalLen, (char*)"preamble_signal", gLogFolderPath);

  	// NOTE: this convolve is "same" version and it only estimate convolve according the dest size
  	makeConvolveInDestSize(signal, signalLen, as->syncReversed, as->syncSize, con, conValidSize, true);

  	debugToMatlabFile1D(con, conValidSize, (char*)"preamble_con", gLogFolderPath);

  	float conMean, conStd;
  	estimateMeanAndStd(con, conValidSize, &conMean, &conStd);
  	debug("conMean = %f, conStd = %f", conMean, conStd);

  	float thres = conMean + AUDIO_PILOT_SEARCH_THRES_FACTOR * conStd;

  	int window = AUDIO_PILOT_SEARCH_PEAK_WINDOW;

#define PEAK_CNT_MAX 100
  	int peakIdxs[PEAK_CNT_MAX];
  	int peakCnt = 0;

  	// 2. search valie peaks
  	//float valueInWindow = 0;
  	int i = 0;
  	while(i < conValidSize - window){
        if(con[i] > thres){ // process the detection
      			debug("find con > thres at %d", i);
      			// serach the max value in the next window
      			int maxIdx = -1;
      			float maxValue = -1;
      			for(int j=i;j<i+window;j++){
        				if(con[j]>maxValue){
          					maxIdx = j;
          					maxValue = con[j];
        				}
      			}
      			debug("maxIdx = %d", maxIdx);
      			// update the peak to a vector
      			if(peakCnt >= PEAK_CNT_MAX){
                error("[ERROR]: peakCnt = %d >= PEAK_CNT_MAX", peakCnt);
      			} else {
        				peakIdxs[peakCnt] = maxIdx;
        				peakCnt ++;
      			}
      			i = i + window - 1; // skip this window
    		} else { // keep search
    			i++;
    		}
  	}

  	warn("peakCnt = %d, AUDIO_PILOT_REPEAT_CNT = %d", peakCnt, AUDIO_PILOT_REPEAT_CNT);

  	// 3. check if the pilot meets need
  	if(peakCnt==AUDIO_PILOT_REPEAT_CNT){
  	//if(peakCnt==AUDIO_PILOT_REPEAT_CNT || peakCnt==AUDIO_PILOT_REPEAT_CNT-1 ){ //TODO: update it, currently we allow one peak missing for samsung
    		int pilotEndOffset = peakIdxs[peakCnt - 1] - as->syncSize / 2 + AUDIO_PILOT_REPEAT_DIFF;
    		pilotEndOffset += 1; // NOTE: c++ index compensition -> remove one additional sample -> just heuristics
    		return pilotEndOffset;
  	}
  	return FIND_PREAMBLE_RET_ERROR;
}
