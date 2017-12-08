#include "libas_devapp.h"




extern "C" void JNI_FUNC_NAME(debugTest)(JNI_FUNC_NO_PARAM) {
    debug("DevApp JNI is correctly imported");
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

extern "C" void JNI_FUNC_NAME(dataCallback)(JNI_FUNC_PARAM jlong retAddr) {
    AddAudioRet *r = (AddAudioRet *)retAddr;
    debug("retAddr (jlong) = %ld", retAddr);
    debug("ret's chCnt %d, traceCnt %d, sampleCnt = %d", r->chCnt, r->traceCnt, r->sampleCnt);

    int REPEAT_CNT = 5;

    float ret = 0;
    float a = 0.1*r->chCnt;
    float b = 0.1*r->traceCnt;
    float c = 0.1*r->sampleCnt;
    for (int repeatIdx = 0; repeatIdx < REPEAT_CNT; repeatIdx ++) {
        warn("dummy computation iternation %d", repeatIdx);
        for (int chIdx = 0; chIdx < r->chCnt; chIdx ++) {
            for (int traceIdx = 0; traceIdx < r->traceCnt; traceIdx ++) {
                for (int sampleIdx = 0; sampleIdx < r->sampleCnt; sampleIdx ++) {
                    // dummy computation to simluate the sonar app
                    //float *audioToProcess = *(*(r->data + chIdx) + traceIdx);
                    //float *audioToProcess = *(*r->data);
                    //makeConvolveInDestSize(AUDIO_PULSE_USED_TO_FILTER, AUDIO_PULSE_USED_LEN, AUDIO_PULSE_USED_TO_FILTER, AUDIO_PULSE_USED_LEN, &gConBufs[chIdx][traceIdx][0], PULSE_DETECTION_MAX_RANGE_SAMPLES, true);
                    for (int filterIdx = 0; filterIdx < 2400; filterIdx ++) {
                        ret += a*b;
                        a = b*c;
                        b = c;
                        c = a;
                        a = ret;
                    }
                }
            }
        }
    }


}


// Some copied utility functions
void debug(const char *s,...)
{
	if(SHOW_DEBUG_MESSAGE){
		va_list va; va_start(va,s);
#ifdef DEV_NDK
        char buffer[DEBUG_STRING_BUFFER_SIZE];
        vsprintf(buffer,s,va);
        va_end(va);
        DEBUG_MACRO(buffer);
#else
        // ref: http://stackoverflow.com/questions/8924831/iphone-debugging-real-device
        //NSLogv([NSString stringWithUTF8String:s], va); // dosn't work on c++
        printf("NDK: ");
        vprintf(s, va);
        printf("\n"); // automaticlaly change the line for visualzation
        va_end(va);
#endif
	}
}

void warn(const char *s,...)
{
    va_list va; va_start(va,s);
#ifdef DEV_NDK
    char buffer[DEBUG_STRING_BUFFER_SIZE];
	vsprintf(buffer,s,va);
    va_end(va);
	DEBUG_MACRO_WARN(buffer);
#else
    printf("NDK [WARN]: ");
    vprintf(s, va);
    printf("\n"); // automaticlaly change the line for visualzation
    va_end(va);
#endif
}

void error(const char *s,...)
{
    va_list va; va_start(va,s);
#ifdef DEV_NDK
    char buffer[DEBUG_STRING_BUFFER_SIZE];
	vsprintf(buffer,s,va);
    va_end(va);
	DEBUG_MACRO_ERROR(buffer);
#else
    printf("NDK [ERROR]: ");
    vprintf(s, va);
    printf("\n"); // automaticlaly change the line for visualzation
    va_end(va);
#endif
}

// this is equal to conv(...,'same') in matlab
// NOTE: this will only make the size of dest array convolve -> for speed optimization
void makeConvolveInDestSize(float *source, int sourceSize, float *filter, int filterSize, float *dest, int destSize, bool returnAbs){
	int validSize = destSize;

	int startPaddingSize = filterSize/2 -((filterSize+1)%2); // if filterSize is odd -> reduce one more startPadding for fitting matlab design
	int endPaddingSize = filterSize/2;
	int startPadding = 0;
	int endPadding = 0;
	int referIdx = 0; // the refer of original vector
	for(int i=0;i<validSize;i++){
		float sum = 0;
		int sourceIdx = referIdx;

		if(i<startPaddingSize){ // need start padding
			startPadding = startPaddingSize - i;
		} else {
			startPadding = 0;
		}

		if(i>=sourceSize-endPaddingSize){
			endPadding = i-sourceSize+endPaddingSize+1;
		} else {
			endPadding = 0;
		}

		//debug("i=%d, souceIdx=%d, sp=%d, ep=%d", i, sourceIdx, startPadding, endPadding);

		for(int filterIdx=filterSize-1-startPadding;filterIdx>=0+endPadding;filterIdx--){
			sum += source[sourceIdx]*filter[filterIdx];
			sourceIdx ++;
		}

		// flip sum if abs is required
		if(returnAbs && sum < 0) sum = -1*sum;
		dest[i] = sum;

		// only move the refer idx when no start padding is need
		if(startPadding == 0){
			referIdx++;
		}
	}
}
