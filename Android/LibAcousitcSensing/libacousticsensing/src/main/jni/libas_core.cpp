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
#define AUDIO_CH_CNT_MAX 2
int AUDIO_CH_CNT = 2; // make it to varaible to cope with different amount of device setting
#define AUDIO_SAMPLE_BYTE_CNT 2
#define AUDIO_BUFF_MAX_SIZE 500000
#define AUDIO_FS 48000
#define PULSE_DETECTION_MAX_RANGE_SAMPLES (800)
//#define AUDIO_REPEAT_CNT 5000
#define AUDIO_REPEAT_CNT 500
#define RING_IDX(x) (x%AUDIO_REPEAT_CNT)

#define AUDIO_PRE_FILTER_ENABLED true


// Optimized data processing setting -> only process the necessary data now
// NOTE only this antennal will be processed to data
//#define DETECT_CH_IDX (1) 
int DETECT_CH_IDX = 1;

//#define DETECT_RANGE_START (600-1) 
// NOTE the begin index must be minused by 1 because C++ starts from 0
//#define DETECT_RANGE_END (620)

// *** start of Nexus6p setting ***
#define DETECT_RANGE_START (597-1)
#define DETECT_RANGE_END (607)
// *** end of Nexus6p setting ***

#define DETECT_RANGE_SIZE (DETECT_RANGE_END-DETECT_RANGE_START)

//int pseChIdx = 1; // NOTE: this means using the bottom microphone

// this is the length of pressure estimate input into squeeze detector
#define SQUEEZE_LEN_TO_CHECK (30)

// reply mode definition
int REPLY_NONE      = 0;    // server will not reply
int REPLY_PSE       = 1;    // server will reply sensed pressure resutls
int REPLY_SSE       = 2;    // server will reply sensed squeeze results
int REPLY_TVG       = 3;
int REPLY_ODE       = 4;    // server will reply object detection results


bool NEED_TO_SEARCH_PILOT;
bool NEED_TO_REMOVE_PILOT;
int gReplyMode;
//-------------------------------------------------------------------------
// 2. Global control variables, start by g prefix
//-------------------------------------------------------------------------
bool gIsInitialized = false;
float gAudioBufs[AUDIO_CH_CNT_MAX][AUDIO_BUFF_MAX_SIZE]; // TODO: reduce this size for saving energy
int gAudioBufEnd;
int gPilotLenToRemove;
int gAudioProcessIdx;
char *gLogFolderPath;

// Note: there is no convolve buf anymore -> save memory and processing time -> only get necessary data into buffer
// only uncomment it for debugging mode
float gConBufs[AUDIO_CH_CNT_MAX][AUDIO_REPEAT_CNT][PULSE_DETECTION_MAX_RANGE_SAMPLES];
float gDataBuf[AUDIO_REPEAT_CNT][DETECT_RANGE_SIZE];
float gDataSumBuf[AUDIO_REPEAT_CNT];
float gReplyBuf[AUDIO_REPEAT_CNT];
// !!! WARN: everything fetches the above buffer with the AUDIO_REPEAT_CNT dimension should use RING_IDX to protect the index being in range !!!
// !!!       Moreover, the AUDIO_REPEAT_CNT should be set larger than the buffer queued length caused by any operation !!! 


int gReplyProcessIdx; // indicate the end of gReplyBuf
int gReplyStartRefAudioIdx; // pressure senstive enable ref idx
int gReplyLastFetchedIdx; // indicates the last index of data being fatched by "Java"

//-------------------------------------------------------------------------
// 3. declare. Some utility functions
//-------------------------------------------------------------------------
int LibFindPilot();
void LibEnableReply(int mode);
void LibDisableReply();
void LibUpdatePseResultToReplyBuf();
void LibUpdateSseResultToReplyBuf();
int LibSqueezeDetect(float *s);

//-------------------------------------------------------------------------
// 4. Detection control functions (Java interfaced)
//-------------------------------------------------------------------------
int appleTest(int a, int b){
    return a+b;
}


// just test the debug method
JNI_FUNC_HEAD void JNI_FUNC_NAME(debugTest)(JNI_FUNC_NO_PARAM){
	debug("I am Fuck ndk debug message");
}

// function to reconfig the audio detection setting based on device-specific setting
JNI_FUNC_HEAD void JNI_FUNC_NAME(deviceSettingGeneralInit)(JNI_FUNC_PARAM int detectChIdxIn){
	debug("--- detectionInit ---");
	debug("detectChIdxIn = %d", detectChIdxIn);
    if(detectChIdxIn < 0){
        debug("detectChIdxIn == -1 -> single audio mode");
        AUDIO_CH_CNT = 1;
        warn("Since it is the single stream mode -> force other setting (AUDIO_CH_IDX_TO_FIND_PILOT, DETECT_CH_IDX) to use only the valid single channel");
        DETECT_CH_IDX = 0; // only able to use the first stream since there is only one stream
        AUDIO_CH_IDX_TO_FIND_PILOT = 0;
    } else {
        DETECT_CH_IDX = detectChIdxIn;
    }
}

// functions allocate global variables -> must be called before other function is called
#ifdef DEV_NDK
JNI_FUNC_HEAD void JNI_FUNC_NAME(detectionInit)(JNI_FUNC_PARAM jstring logFolderPathIn){
#else
JNI_FUNC_HEAD void JNI_FUNC_NAME(detectionInit)(JNI_FUNC_PARAM char* logFolderPathIn){
#endif
	debug("--- detectionInit ---");
	gIsInitialized = true;
	gAudioBufEnd = 0; // NOTE c++ starts from 0
	NEED_TO_SEARCH_PILOT = true;
	if(NEED_TO_SEARCH_PILOT){
		NEED_TO_REMOVE_PILOT = true;
	}
	gPilotLenToRemove = -1;
	gAudioProcessIdx = 0;

	// init reply related variables
	gReplyMode = REPLY_NONE;
	gReplyProcessIdx = 0;
	gReplyStartRefAudioIdx = 0;
	gReplyLastFetchedIdx = 0;

    const char *logFolderPath;
#ifdef DEV_NDK
    logFolderPath = env->GetStringUTFChars(logFolderPathIn, 0);
#else
    // just get data from normal string
    // ref: http://stackoverflow.com/questions/19223360/implicit-instantiation-of-undefined-template-stdbasic-stringchar-stdchar
    //logFolderPath = logFolderPathIn.c_str();
    logFolderPath = logFolderPathIn;
#endif
    gLogFolderPath = (char*)malloc(sizeof(char)*strlen(logFolderPath));
    strcpy(gLogFolderPath, logFolderPath);
	debug("gLogFolderPath = %s",gLogFolderPath);

#ifdef DEV_NDK
	// release resources
    env->ReleaseStringUTFChars(logFolderPathIn, logFolderPath);
#endif
}

// function to check detection status (debug only)
JNI_FUNC_HEAD void JNI_FUNC_NAME(detectionCheckStatus)( JNI_FUNC_NO_PARAM ){
	debug("--- detectionCheckStatus ---");
	debug("gLogFolderPath = %s",gLogFolderPath);
	debug("gIsInitialized = %d", gIsInitialized);
}

// function clean global variables
JNI_FUNC_HEAD void JNI_FUNC_NAME(detectionClean)( JNI_FUNC_NO_PARAM ){
	debug("--- detectionClean ---");
	gIsInitialized = false;
}

int addAudioLock = 0;
// fucntion to add audio to buffers
#ifdef DEV_NDK
JNI_FUNC_HEAD int JNI_FUNC_NAME(addAudioSamples)(JNI_FUNC_PARAM jbyteArray audioToAdd){
	debug("--- addAudioSamples ---");
	// ensure there is no racing condition on adding the audio (should not happen)
	if(addAudioLock > 0){
		error("audio is added when another thread is adding audio, racing condition. (too many processing on the main thread?)");
	} else {
		addAudioLock = 1;
	}


	jbyte* audioToAddBytes = env->GetByteArrayElements(audioToAdd,0);
	jsize audioToAddByteSize = env->GetArrayLength(audioToAdd);
#else
JNI_FUNC_HEAD int JNI_FUNC_NAME(addAudioSamples)(char* audioToAddBytes, int audioToAddByteSize){
#endif
    
    // *** just for debug ***
    /*
    uint8_t* temp = (uint8_t*) audioToAddBytes;
    for(int i=0;i<10;i++){
        
        debug("NDK-temp = %d", temp[i]);
    }
     */
    
	int audioToAddSampleCnt	= audioToAddByteSize/(AUDIO_CH_CNT*AUDIO_SAMPLE_BYTE_CNT);
	debug("audioToAddByteSize = %d, audioToAddSampleCnt = %d",audioToAddByteSize, audioToAddSampleCnt);	
	debug("before add audio, gAudioBufEnd = %d", gAudioBufEnd);

	// 1. parse byte arry into global audio buffers
	int chIdx = 0;
	for(int i=0;i<audioToAddByteSize;i+=2){
		// a. byte parsing
		short shortValue = (short)((audioToAddBytes[i] & 0xFF) | ((audioToAddBytes[i+1] & 0xFF) << 8));
		float floatValue = (float)shortValue;

		// b. assign value to right position
		gAudioBufs[chIdx][gAudioBufEnd] = floatValue;	

		// c. update indexs
        if(DETECT_CH_IDX>=0){ // DETECT_CH_IDX = -1 menas parsing the single channle audio
            chIdx = (chIdx+1)%AUDIO_CH_CNT;
            if(chIdx == AUDIO_CH_CNT-1){ // reach the last channel component
                gAudioBufEnd = gAudioBufEnd+1;
            }
        } else {
            gAudioBufEnd = gAudioBufEnd+1;
        }
	}
	debug("after add audio, gAudioBufEnd = %d, gPilotLenToRemove = %d", gAudioBufEnd, gPilotLenToRemove);
	debug("first few added element is: (%f,%f), (%f,%f)", gAudioBufs[0][0], gAudioBufs[0][1], gAudioBufs[1][0], gAudioBufs[1][1]);
	// release byte array
#ifdef DEV_NDK
	env->ReleaseByteArrayElements(audioToAdd, audioToAddBytes,0);	
#endif

	// 2. search pilot if need in the first packet
	if (NEED_TO_SEARCH_PILOT && gAudioBufEnd >= AUDIO_SAMPLE_TO_FIND_PILOT){	
		int pilotEndOffset = LibFindPilot();
		debug("pilotEndOffset = %d", pilotEndOffset);
		if(pilotEndOffset <0 ){
			warn("[WARN]: unable to find pilot");

			addAudioLock = 0;
			return -1;
		}
		gPilotLenToRemove = pilotEndOffset + AUDIO_PILOT_END_OFFSET;
		NEED_TO_SEARCH_PILOT = false;
	}

	// 3.remove pilot if receive enough audio data
	if (!NEED_TO_SEARCH_PILOT && NEED_TO_REMOVE_PILOT && gAudioBufEnd > gPilotLenToRemove){
		debug("*** get enough data to remove ***");
		int newAudioBufEnd = gAudioBufEnd - gPilotLenToRemove;
		debug("old end = %d, new end = %d", gAudioBufEnd, newAudioBufEnd);

		debugToMatlabFile1D(&gAudioBufs[0][0], gAudioBufEnd, (char*)"audio_before_remove", gLogFolderPath);
		for(int chIdx = 0; chIdx < AUDIO_CH_CNT; chIdx++){
			memmove(&gAudioBufs[chIdx][0], &gAudioBufs[chIdx][gPilotLenToRemove], newAudioBufEnd*sizeof(float));
		}
		gAudioBufEnd = newAudioBufEnd;
		debugToMatlabFile1D(&gAudioBufs[0][0], gAudioBufEnd, (char*)"audio_after_remove", gLogFolderPath);

		NEED_TO_REMOVE_PILOT = false;
	}

	// 4. start cut the audio data for processing
	if (!NEED_TO_SEARCH_PILOT && !NEED_TO_REMOVE_PILOT && gAudioBufEnd > AUDIO_SINGLE_REPEAT_LEN){
		debug("*** get enough data to process ***");
		int repeatToProcess = gAudioBufEnd/AUDIO_SINGLE_REPEAT_LEN; // NOTE: c++ use the largest quotient -> no need floor
		int lenToProcess = repeatToProcess*AUDIO_SINGLE_REPEAT_LEN;
		int newAudioBufEnd = gAudioBufEnd - lenToProcess;

		float audioTemp[AUDIO_SINGLE_REPEAT_LEN]; // just a temp buffer to save filtered data

		debug("repeatToProcess = %d",repeatToProcess);
		//audioToProcess = audioBuf(1:lenToProcess,:);
		//audioToProcess = reshape(audioToProcess, [SINGLE_REPEAT_LEN, repeatToProcess, traceChannelCnt]);
		// process data
		for(int repeatIdx = 0; repeatIdx<repeatToProcess; repeatIdx++){
			for(int chIdx = 0; chIdx < AUDIO_CH_CNT; chIdx++){

				// optimization -> only prcess the channel used for detection
				if(chIdx == DETECT_CH_IDX){
					float *audioToProcess = &gAudioBufs[chIdx][repeatIdx*AUDIO_SINGLE_REPEAT_LEN];

					char debugFileName[100]; 
					sprintf(debugFileName,"audio_%d_%d",gAudioProcessIdx,chIdx); 
					debugToMatlabFile1D(audioToProcess, AUDIO_SINGLE_REPEAT_LEN, debugFileName, gLogFolderPath);

					// filter data if need	
					if (AUDIO_PRE_FILTER_ENABLED){
						makeFilter(AUDIO_PRE_FILTER_B, AUDIO_PRE_FILTER_LEN, AUDIO_PRE_FILTER_A, AUDIO_PRE_FILTER_LEN, audioToProcess, AUDIO_SINGLE_REPEAT_LEN, audioTemp);
						sprintf(debugFileName,"audio_filtered_%d_%d",gAudioProcessIdx,chIdx); 
						debugToMatlabFile1D(audioTemp, AUDIO_SINGLE_REPEAT_LEN, debugFileName, gLogFolderPath);
						// redirect audioToProcess to the filtered array
						audioToProcess = audioTemp;
					}
					
					// build match filtered result
					// only do it when debugging -> too costly!!!
					#ifdef DEBUG_DUMP_CON
					makeConvolveInDestSize(audioToProcess, AUDIO_SINGLE_REPEAT_LEN, AUDIO_PULSE_USED_TO_FILTER, AUDIO_PULSE_USED_LEN, &gConBufs[chIdx][RING_IDX(gAudioProcessIdx)][0], PULSE_DETECTION_MAX_RANGE_SAMPLES, true);	
					sprintf(debugFileName,"con_%d_%d",gAudioProcessIdx,chIdx); 
					debugToMatlabFile1D(&gConBufs[chIdx][RING_IDX(gAudioProcessIdx)][0], PULSE_DETECTION_MAX_RANGE_SAMPLES, debugFileName, gLogFolderPath);
					#endif

					// do data processing (use optimizaed algorithm)
					gDataSumBuf[RING_IDX(gAudioProcessIdx)] = makeAbsConvInRange(audioToProcess, AUDIO_SINGLE_REPEAT_LEN, AUDIO_PULSE_USED, AUDIO_PULSE_USED_LEN, &gDataBuf[RING_IDX(gAudioProcessIdx)][0], DETECT_RANGE_SIZE, DETECT_RANGE_START, DETECT_RANGE_END);
					sprintf(debugFileName,"data_%d", gAudioProcessIdx);
					debugToMatlabFile1D(&gDataBuf[RING_IDX(gAudioProcessIdx)][0], DETECT_RANGE_SIZE, debugFileName, gLogFolderPath);
				}

				// udpate data buffer indexs
				if(chIdx == AUDIO_CH_CNT-1){ // end of this repeatation
					gAudioProcessIdx++;
					if(gAudioProcessIdx >= AUDIO_REPEAT_CNT){
						//error("[ERROR]: gAudioProcessIdx >= AUDIO_REPEAT_CNT (conBufs size is too small?)");
						debug("gAudioProcessIdx >= AUDIO_REPEAT_CNT, but it is ok now with RING_IDX, gAudioProcessIdx = %d",gAudioProcessIdx);
					} 
				}	
			}

			// make reply processing if need
			if(gReplyMode > REPLY_NONE){ //means there is something to process
				if(gReplyMode == REPLY_PSE){
					LibUpdatePseResultToReplyBuf();
				}else if(gReplyMode == REPLY_SSE){
					LibUpdateSseResultToReplyBuf();
				} else {
					error("[ERROR]: undefined gReplyMode = %d",gReplyMode);
				}
			}
		}


		// update global audio buf (i.e., remove the processed audio from buf)
		for(int chIdx = 0; chIdx < AUDIO_CH_CNT; chIdx++){
			memmove(&gAudioBufs[chIdx][0], &gAudioBufs[chIdx][lenToProcess], newAudioBufEnd*sizeof(float));
		}
		gAudioBufEnd = newAudioBufEnd;


		addAudioLock = 0;
		return gAudioProcessIdx; // indicate audio is processed in this time
	}

	addAudioLock = 0;
	return 0; // 0 means normal
}



JNI_FUNC_HEAD void JNI_FUNC_NAME(enablePseReply)(JNI_FUNC_NO_PARAM) {
	LibEnableReply(REPLY_PSE);
}

JNI_FUNC_HEAD void JNI_FUNC_NAME(enableSseReply)(JNI_FUNC_NO_PARAM) {
	LibEnableReply(REPLY_SSE);
}

JNI_FUNC_HEAD void JNI_FUNC_NAME(disableReply)(JNI_FUNC_NO_PARAM) {
	LibDisableReply();
}

JNI_FUNC_HEAD bool JNI_FUNC_NAME(isReplyReadyToFetch)(JNI_FUNC_NO_PARAM) {
	return gReplyLastFetchedIdx < gReplyProcessIdx;
}

JNI_FUNC_HEAD float JNI_FUNC_NAME(fetchReply)(JNI_FUNC_NO_PARAM) {
	float replyToFetch = gReplyBuf[RING_IDX(gReplyLastFetchedIdx)];
	gReplyLastFetchedIdx++;
	return replyToFetch;
}


//-------------------------------------------------------------------------
// 5. Application-specific functions
//-------------------------------------------------------------------------
void LibEnableReply(int mode){
	debug("--- LibEnableReply ---");

	if(gReplyMode > REPLY_NONE){
		warn("[WARN]: reply is enable twice (forget to disable it?)");
	}

	// init reply buf setting
	gReplyMode = mode;
	gReplyProcessIdx = 0;
	gReplyLastFetchedIdx = 0;

	if(gAudioProcessIdx==0){
		warn("[WARN]: gAudioProcessIdx == 0, nothing is recorded yet, set gReplyStartRefAudioIdx to 0");
		gReplyStartRefAudioIdx = 0;
	} else {
		gReplyStartRefAudioIdx = gAudioProcessIdx-1;
	}
	debug("gReplyStartRefAudioIdx=%d", gReplyStartRefAudioIdx);
}

void LibDisableReply(){
	debug("--- LibDisableReply ---");
	gReplyMode = REPLY_NONE;

	// dump reply reuslt for debugging
	debugToMatlabFile1D(gDataSumBuf, gAudioProcessIdx, (char*)"dataSum", gLogFolderPath);
	//debugToMatlabFile1D(gReplyBuf, gReplyProcessIdx, (char*)"reply", gLogFolderPath);
}

void LibUpdatePseResultToReplyBuf(){
	debug("--- LibUpdatePseResultToReplyBuf ---");
	debug("gReplyProcessIdx=%d, gReplyStartRefAudioIdx=%d, gAudioProcessIdx=%d",gReplyProcessIdx, gReplyStartRefAudioIdx, gAudioProcessIdx);


	for(int audioProcessIdxNow = gReplyStartRefAudioIdx+gReplyProcessIdx; audioProcessIdxNow<gAudioProcessIdx; audioProcessIdxNow++ ){
		// use dataSum as reference data for pse detections
		float dataNow = gDataSumBuf[RING_IDX(audioProcessIdxNow)];	
		float dataRef = gDataSumBuf[RING_IDX(gReplyStartRefAudioIdx)];
	
		float result = myAbs((dataNow-dataRef)/dataRef);

		// *** start of Nexus6p setting ***
		//float result = myAbs((dataNow-dataRef)/(log10(dataRef)*100000.0));
		// *** end of Nexus6p setting ***

		gReplyBuf[RING_IDX(gReplyProcessIdx)] = result;
		gReplyProcessIdx ++;
	}



	//int pseRange[] = {600-1,620}; // NOTE the begin index must be minused by 1 because C++ starts from 0
	//int pseChIdx = 1; // NOTE: this means using the bottom microphone
	//float dataNow=0, dataRef=0;
	// TODO: make it using the databuf
	// use preloaed data now
	/*
	for(int audioProcessIdxNow = gReplyStartRefAudioIdx+gReplyProcessIdx; audioProcessIdxNow<gAudioProcessIdx; audioProcessIdxNow++ ){
		debug("audioProcessIdxNow = %d", audioProcessIdxNow);	
		for(int i=pseRange[0];i<pseRange[1];i++){
			dataNow += gConBufs[pseChIdx][RING_IDX(audioProcessIdxNow)][i];
			dataRef += gConBufs[pseChIdx][RING_IDX(gReplyStartRefAudioIdx)][i]; 
		}
		float result = myAbs((dataNow-dataRef)/dataRef);

		gReplyBuf[RING_IDX(gReplyProcessIdx)] = result;
		gReplyProcessIdx ++;
	}
	*/
}

void LibUpdateSseResultToReplyBuf(){
	debug("--- LibUpdateSseResultToReplyBuf ---");
	debug("gReplyProcessIdx=%d, gReplyStartRefAudioIdx=%d, gAudioProcessIdx=%d",gReplyProcessIdx, gReplyStartRefAudioIdx, gAudioProcessIdx);

	for(int audioProcessIdxNow = gReplyStartRefAudioIdx+gReplyProcessIdx; audioProcessIdxNow<gAudioProcessIdx; audioProcessIdxNow++ ){
		float result = -1; // not ready
		float dataNow = gDataSumBuf[RING_IDX(audioProcessIdxNow)];	
		result = dataNow;


		// skip the algorithm for squeeze detection now, because it is not working without tuning
		/*
		// only process result when there is enough traces
		if(audioProcessIdxNow>SQUEEZE_LEN_TO_CHECK){
			float *sToCheckSqueeze = &gDataSumBuf[RING_IDX(audioProcessIdxNow - SQUEEZE_LEN_TO_CHECK)];
			int squeezeStatus = LibSqueezeDetect(sToCheckSqueeze);
			result = (float) squeezeStatus;
		}
		*/

		gReplyBuf[RING_IDX(gReplyProcessIdx)] = result;
		gReplyProcessIdx ++;
	}


}

//-------------------------------------------------------------------------
// 6. Utility functions
//-------------------------------------------------------------------------
int LibFindPilot(){
	debug("---LibFindPilot---");
	if(AUDIO_CH_IDX_TO_FIND_PILOT > AUDIO_CH_CNT){
		error("[ERROR]: AUDIO_CH_IDX_TO_FIND_PILOT > AUDIO_CH_CNT");
	}

	// 1. make convolvution of audio and show results
	float *signal = &gAudioBufs[AUDIO_CH_IDX_TO_FIND_PILOT][0];
	int signalLen = AUDIO_SAMPLE_TO_FIND_PILOT; 

	debug("signal = (%f,%f,%f,%f)", signal[0], signal[1], signal[2], signal[3]);

	//int conValidSize = gAudioBufEnd -AUDIO_PILOT_LEN + 1;
	int conValidSize = gAudioBufEnd;
	float *con = (float*)malloc(sizeof(float)*conValidSize);

	debugToMatlabFile1D(signal, signalLen, (char*)"pilot_signal", gLogFolderPath);

	// NOTE: this convolve is "same" version and it only estimate convolve according the dest size
	makeConvolveInDestSize(signal, signalLen, AUDIO_PILOT_TO_FILTER, AUDIO_PILOT_LEN, con, conValidSize, true);
	
	debugToMatlabFile1D(con, conValidSize, (char*)"pilot_con", gLogFolderPath);

	float conMean, conStd;
	estimateMeanAndStd(con, conValidSize, &conMean, &conStd);
	debug("conMean = %f, conStd = %f", conMean, conStd);

	float thres = conMean + AUDIO_PILOT_SEARCH_THRES_FACTOR*conStd;

	int window = AUDIO_PILOT_SEARCH_PEAK_WINDOW; 

	int peakCntMax = 100;
	int *peakIdxs = (int*)malloc(sizeof(int)*peakCntMax);
	int peakCnt = 0;

	// 2. search valie peaks
	//float valueInWindow = 0;
	int i = 0;
	while(i<conValidSize-window){
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
			if(peakCnt > peakCntMax){
				error("[ERROR]: peakCnt > peakCntMax");
			} else {
				peakIdxs[peakCnt] = maxIdx;
				peakCnt ++;
			}
			i = i+window-1; // skip this window
		} else { // keep search
			i++;
		}
	}

	warn("peakCnt = %d, AUDIO_PILOT_REPEAT_CNT = %d", peakCnt, AUDIO_PILOT_REPEAT_CNT);

	// 3. check if the pilot meets need
	// if(peakCnt==AUDIO_PILOT_REPEAT_CNT){
	if(peakCnt==AUDIO_PILOT_REPEAT_CNT || peakCnt==AUDIO_PILOT_REPEAT_CNT-1 ){ //TODO: update it, currently we allow one peak missing for samsung
		int pilotEndOffset = peakIdxs[peakCnt-1] - AUDIO_PILOT_LEN/2 + AUDIO_PILOT_REPEAT_DIFF;
		pilotEndOffset += 1; // NOTE: c++ index compensition -> remove one additional sample -> just heuristics
		return pilotEndOffset; 
	}	
	return -1;	
}

// squeeze setting
bool USE_TWO_END_CORRECT = true;
bool NEED_ABS = true; // is it necessary in the end
int PEAK_WIN = 8;
float PEAK_HARD_THRES_HIGH			= 0.3;
float PEAK_HARD_THRES_LOW			= 0.2;

// *** WARN: soft thres can only be used in TWO_END_CORRECT mode ->
// otherwise the mean will be too high ***
float PEAK_SORT_THRES_RATIO_HIGH	= 0.15; // multiple of std to achieve for peak;
float PEAK_SORT_THRES_RATIO_LOW		= 0.1; // multiple of std to achieve for peak;
int PEAK_LOW_WIDTH_MAX				= 9; // with constrain of the peak values over low thres
int PEAK_LOW_WIDTH_MIN				= 2;
int CHECK_PEAK_CNT					= 2;
int CHECK_PEAK_DIFF_RANGE_MIN		= 6-1; // maltab index starts from 1 -> -1 to correct 
int CHECK_PEAK_DIFF_RANGE_MAX		= 25-1;
int CHECK_PEAK_OFFSET_START_RANGE_MIN = 0;
int CHECK_PEAK_OFFSET_START_RANGE_MAX = 40;
float CHECK_PEAK_RATIO_MIN			= 0.4; // 0.5 means peak should be twice as the edge
int PEAK_WIN_SIDE					= (int)(PEAK_WIN/2);


float sRatioTo2Ends[SQUEEZE_LEN_TO_CHECK];
// this function return the check status and update the audio buffer for squeeze processing
int LibSqueezeDetect(float *s){
	const int CHECK_STATUS_INIT = -1;
    const int CHECK_STATUS_PASS_PEAK_CNT = 0;
    const int CHECK_STATUS_PASS_PEAK_X_OFFSET_DIFF = 1;
    const int CHECK_STATUS_PASS_PEAK_X_OFFSET_START = 2;
    const int CHECK_STATIS_PASS_PEAK_RATIO_MIN = 3;
 
	int X_CNT = SQUEEZE_LEN_TO_CHECK;
        
    //----------------------------------------------------------------------
    // 1. convert to force ratio based on the first or two ends signals
    //----------------------------------------------------------------------
    for(int xNow = 0; xNow<X_CNT; xNow++){
        float disToStart = xNow;
        float disToEnd = X_CNT - (xNow+1) ;
        float sRef = (s[0]*disToEnd + s[X_CNT-1]*disToStart)/(disToStart+disToEnd);
        sRatioTo2Ends[xNow] = (s[xNow] - sRef)/sRef;
		if(NEED_ABS){
			sRatioTo2Ends[xNow] = fabs(sRatioTo2Ends[xNow]);
		}
	 }
    
	float *sCorrected = sRatioTo2Ends; // always assume it uses the 2 end normalziation
   
	//dump(sCorrected, X_CNT, (char*)"sCorrectedJNI");
 
    //----------------------------------------------------------------------
    // 2. get thre based on mean, std, and hard thres
	// NOTE: use HARD threshold now -> no need to estimate std
	//----------------------------------------------------------------------
    //float sCorrectedMean, sCorrectedStd;
    //estimateMeanAndStd(sCorrected, X_CNT, sCorrectedMean, sCorrectedStd);
	
    float PEAK_THRES_HIGH = PEAK_HARD_THRES_HIGH;
    float PEAK_THRES_LOW = PEAK_HARD_THRES_LOW;
    
    //assert(PEAK_THRES_HIGH>PEAK_THRES_LOW,'[ERROR]: PEAK_THRES_HIGH<PEAK_THRES_LOW');
    
    //----------------------------------------------------------------------
    // 3. find peaks based on my ad-hoc way
    //    : based on skip peak-width of data once the peak is found
    //----------------------------------------------------------------------
    float *sToFindPeak = sCorrected;


	int peakX[SQUEEZE_LEN_TO_CHECK];
    float peakY[SQUEEZE_LEN_TO_CHECK];
    int valleyXLeft[SQUEEZE_LEN_TO_CHECK];
    int valleyXRight[SQUEEZE_LEN_TO_CHECK];
    float peakR[SQUEEZE_LEN_TO_CHECK];
    int peakXIdx = 0;
    
    // new peak detection, considering the "concaved peak"
    int xNow = 0;
    while(xNow < X_CNT){
        // find the start of data bigger than high thres
        if(sToFindPeak[xNow] >= PEAK_THRES_HIGH){
            // search the end of left/right low peak reference
            int lowPeakLeftNow = xNow; 
			for(int xRef=xNow-1; xRef>=0; xRef++){
                if (sToFindPeak[xRef] > PEAK_THRES_LOW){
                    lowPeakLeftNow = xRef;
                } else {
                    break;
                }
            }

            int lowPeakRightNow = xNow;
            for(int xRef=xNow+1; xRef<X_CNT; xRef++){
                if (sToFindPeak[xRef] > PEAK_THRES_LOW){
                    lowPeakRightNow = xRef;
                } else {
                    break;
                }
            }

            int lowPeakWidth = lowPeakRightNow - lowPeakLeftNow + 1;
            int peakXNow = (int)round(((float)lowPeakRightNow + (float)lowPeakLeftNow)/2);
            
			bool isPeak = false;
            if(peakXNow-PEAK_WIN_SIDE>=0 && peakXNow+PEAK_WIN_SIDE<X_CNT && lowPeakWidth >= PEAK_LOW_WIDTH_MIN && lowPeakWidth <= PEAK_LOW_WIDTH_MAX){
                isPeak = true; // only consider peak with proper peak width and peakX
			}


			// update peak information
            if(isPeak){
                peakX[peakXIdx] = peakXNow;

				/*
                yInLowRange = sToFindPeak(lowPeakLeftNow:lowPeakRightNow);
                peakY(peakXIdx) = mean(yInLowRange(yInLowRange>PEAK_THRES_HIGH));
                peakYNow = peakY(peakXIdx);
				*/
				

				float peakYSum = 0, peakYNow;
				float sumCnt = 0;
				for(int i=lowPeakLeftNow; i<=lowPeakRightNow; i++){
					if(sToFindPeak[i]>PEAK_THRES_HIGH){ // only concern the peak over the "high" thres
						peakYSum += sToFindPeak[i];
						sumCnt ++;
					}
				}
				if(sumCnt >0){
					peakYNow = peakYSum/sumCnt;//use the mean of signals over peak as the peakY
				}
				peakY[peakXIdx] = peakYNow;
               
				// search the low value in two side as the vally value 
				/*
                [~,valleyXLeft(peakXIdx)] = min(sToFindPeak(peakXNow-PEAK_WIN_SIDE:peakXNow));
                valleyXLeft(peakXIdx) = valleyXLeft(peakXIdx) + peakXNow-PEAK_WIN_SIDE-1;
                [~,valleyXRight(peakXIdx)] = min(sToFindPeak(peakXNow:peakXNow+PEAK_WIN_SIDE));
                valleyXRight(peakXIdx) = valleyXRight(peakXIdx) + peakXNow - 1;
				*/
			
				float minValueLeft = sToFindPeak[peakXNow];	
				valleyXLeft[peakXIdx] = peakXIdx; // init by the peak value
				for(int i=peakXNow-PEAK_WIN_SIDE;i<=peakXNow;i++){
					if(sToFindPeak[i]<minValueLeft){ // search the min value
						valleyXLeft[peakXIdx] = i;
						minValueLeft = sToFindPeak[i];
					}
				}

				float minValueRight = sToFindPeak[peakXNow];
                valleyXRight[peakXIdx] = peakXIdx; // init by the peak value
				for(int i=peakXNow; i<=peakXNow+PEAK_WIN_SIDE;i++){
					if(sToFindPeak[i]<minValueRight){ // search the min value
						valleyXRight[peakXIdx] = i;
						minValueRight =  sToFindPeak[i];
					}
				}

                peakR[peakXIdx] = (sToFindPeak[valleyXLeft[peakXIdx]]+sToFindPeak[valleyXRight[peakXIdx]])/(peakYNow*2);
                peakXIdx = peakXIdx + 1; // update number of peak
            }

            // update the xNow after this peak detections
            xNow = lowPeakRightNow+1;
        } else {
            xNow = xNow+1;
        }
    }
    
    // resize peakX vector -> no need in c++
	int peakCnt = peakXIdx; // just need to remember the end of peaks
    
    //----------------------------------------------------------------------
    // 4. check peak statistics
    //    : need to pass each "test" before the next test
    //----------------------------------------------------------------------
    int checkStatus = CHECK_STATUS_INIT;
    
    // a. check peak cnt
    if(peakCnt == CHECK_PEAK_CNT){
        checkStatus = CHECK_STATUS_PASS_PEAK_CNT;
    }
    
    // b. check peak offset/diff
    if(checkStatus == CHECK_STATUS_PASS_PEAK_CNT){
		bool passAllPeakDiffTest = true;

		// NOTE: need at least 
		for(int peakIdxToCheck = 1; peakIdxToCheck<peakCnt; peakIdxToCheck++){
			int peakDiff = peakX[peakIdxToCheck]-peakX[peakIdxToCheck-1];
			if (peakDiff >= CHECK_PEAK_DIFF_RANGE_MIN && peakDiff <= CHECK_PEAK_DIFF_RANGE_MAX){
				// do nothing -> pass the test
			} else {
				passAllPeakDiffTest = false;
				break;
			}
		}

		if(passAllPeakDiffTest){
			checkStatus = CHECK_STATUS_PASS_PEAK_X_OFFSET_DIFF;
		}
    }
    
    // c. check peak offset/start and end
	// NOTE: this is not used anymore
    if(checkStatus == CHECK_STATUS_PASS_PEAK_X_OFFSET_DIFF){
        if (peakX[0] >= CHECK_PEAK_OFFSET_START_RANGE_MIN && peakX[0] <= CHECK_PEAK_OFFSET_START_RANGE_MAX){
            checkStatus = CHECK_STATUS_PASS_PEAK_X_OFFSET_START;
        }
    }
    
    // d. check peak ratios
    if(checkStatus == CHECK_STATUS_PASS_PEAK_X_OFFSET_START){
		bool passAllPeakRatioTest = true;
		for(int peakIdxToCheck = 0; peakIdxToCheck<peakCnt; peakIdxToCheck++){
            float peakRatio = peakR[peakIdxToCheck];
			if(peakRatio < CHECK_PEAK_RATIO_MIN){
				// do nothing -> pass the test
			} else {
				passAllPeakRatioTest = false;
				break;
			}
		}
        if(passAllPeakRatioTest){
            checkStatus = CHECK_STATIS_PASS_PEAK_RATIO_MIN;
        }
    }

	return checkStatus;
}


/*
extern "C" void Java_edu_umich_cse_audioanalysis_JniController_helloLog(JNIEnv *env, jobject obj, jstring logThis){
    const char * szLogThis = env->GetStringUTFChars(logThis, 0);
    debug("%s",szLogThis);

    env->ReleaseStringUTFChars(logThis, szLogThis);
}
*/
