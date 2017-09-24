#include "libas_utils.h"
//=========================================================================================================
// 2015/02/07: move all common functions to here (include signal processing)
// 2015/02/19: update debugToMatlabFile2D to CVS form
// 2016/04/07: update it shared with my iOS code
//=========================================================================================================

//=========================================================================================================
//         !!! NOTE !!! It is a shared preference -> modify it will affect both iOS and Android code
//=========================================================================================================


// NOTE: different log function is only used for controlling log level
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

// this is my version of assert->dump the necessary message before crashing the program
void check(int condition, const char *s, ...){
	if(!condition){
    va_list va; va_start(va,s);
#ifdef DEV_NDK
		char buffer[DEBUG_STRING_BUFFER_SIZE];
		vsprintf(buffer,s,va);
		va_end(va);
		DEBUG_MACRO_ASSERT(buffer);
#else
		printf("NDK [ASSERT FAIL]: ");
		vprintf(s, va);
		printf("\n"); // automaticlaly change the line for visualzation
		va_end(va);
#endif
		assert(condition);
	}

}

float myAbs(float a){
	if(a>=0){
		return a;
	} else {
		return -1*a;
	}
}


void estimateMeanAndStd(float *s, int len, float *mean, float *std){
	float sumAvg = 0;
	float squareSumAvg = 0;

	for(int i=0;i<len;i++){
		sumAvg += s[i]/(float)len;
		squareSumAvg += s[i]*s[i]/(float)len;
	}

	*mean = sumAvg;
	*std = sqrt(squareSumAvg - sumAvg*sumAvg);
	debug("estimateMeanAndStd: sumAvg=%f, squareSumAvg=%f", sumAvg, squareSumAvg);
}

void convertShortArrayToFloatArray(float *f, short *s, int size, bool needToReverse) {
		for (int i = 0; i < size; i ++) {
				int target = needToReverse ? size - i - 1 : i;
				f[target] = ((float)s[i])/32767.0;
		}
}

/*
int estimateBinFreqs(float *&freqs, int &binStartFreqIdx, int &binEndFreqIdx, int sCol, int FS, float BIN_START, float BIN_END){
	float DF = ((float)FS)/((float)sCol);
	float* oriFreqs = (float*) malloc(sCol*sizeof(float));

	debug("makeFFTBins: DF = %f", DF);

	float oriFreqValue = -(FS/2);
	binStartFreqIdx = -1;
	binEndFreqIdx = -1;
	for (int i=0;i<sCol;i++){
		oriFreqs[i] = oriFreqValue;
		oriFreqValue += DF;
		//debug("oriFreqs[%d] = %f", i, oriFreqs[i]);
	}
	for (int i=0;i<sCol;i++){
		if(binStartFreqIdx == -1 && oriFreqs[i]>=BIN_START){
			binStartFreqIdx=i;
			break;
		}
	}
    for (int i=sCol-1;i>=0;i--){
		if(binEndFreqIdx == -1 && oriFreqs[i]<=BIN_END){
			binEndFreqIdx=i;
			break;
		}
	}
	int binCnt = binEndFreqIdx-binStartFreqIdx+1;
	debug("estimateBinFreqs: oriFreqs=[%f,%f], freqIdxs=[%d,%d] ,binCnt=%d", oriFreqs[0], oriFreqs[sCol-1], binStartFreqIdx, binEndFreqIdx, binCnt);
	freqs = (float*) malloc(binCnt*sizeof(float));
	memcpy(freqs, oriFreqs+binStartFreqIdx, binCnt*sizeof(float));

	// *** index is transfered to "shifted" range ***
	binStartFreqIdx = binStartFreqIdx - sCol/2;
	binEndFreqIdx = binEndFreqIdx - sCol/2;

	debug("estimateBinFreqs: return");

	return binCnt;
}

void makeFFTBins(float **s2D, float **&fftBins, int sCol, int sRow, int binStartFreqIdx, int binEndFreqIdx, int binCnt, const char *logFolderPath){
	debug("makeFFTBins: sCol = %d, sRow = %d, binCnt = %d, binStartFreqIdx = %d", sCol, sRow, binCnt, binStartFreqIdx);

	// 1. estimate the original freqs after FFT
	// *** moved to another standalone function ***
	//debugToMatlabFile1D(freqs, binCnt, "freqs", logFolderPath);

	// 2. make FFT
	kiss_fft_scalar zero;
	memset(&zero,0,sizeof(zero));
	kiss_fft_cpx* fft_out = (kiss_fft_cpx*) malloc(sCol* sizeof(kiss_fft_cpx));
	//kiss_fftr_cfg fft = kiss_fftr_alloc(sCol*2 ,0 ,0,0);
	kiss_fftr_cfg fft = kiss_fftr_alloc(sCol ,0 ,0,0);

	fftBins = (float **)malloc(sRow*sizeof(float*));
	for (int r=0; r<sRow; r++){
		//debug("makeFFTBins: r = %d", r);
		//debug("makeFFTBins: before fft");
		// b. FFT
		//kiss_fftr(fft, (kiss_fft_scalar*) fft_in, fft_out);
		kiss_fftr(fft, (kiss_fft_scalar*) s2D[r], fft_out);

		//debug("makeFFTBins: after fft");

		// c. parseFFT
		fftBins[r] = (float*)malloc(binCnt*sizeof(float));
		for (int binIdx=0; binIdx<binCnt; binIdx++){
			int fftIdx = binStartFreqIdx+binIdx;
			float rNow = fft_out[fftIdx].r;
			float iNow = fft_out[fftIdx].i;
			*(fftBins[r]+binIdx) = (float)sqrt(rNow*rNow + iNow*iNow);
		}
		//debug("makeFFTBins: after allocate to fftBins");
	}

	free(fft_out);
	free(fft); // free the memory used for kiss fft
}
*/

void normalize(float* dest, int destSize){
	float maxValue = 0;
	for(int i=0;i<destSize;i++){
		float absValue = myAbs(dest[i]);
		if(maxValue<absValue) maxValue = absValue;
	}

	for(int i=0;i<destSize;i++){
		dest[i] = dest[i]/maxValue;
	}
}

int getMaxIdx(float* target, int targetSize){
	float maxValue = 0;
	int maxIdx = -1;
	for(int i=0;i<targetSize;i++){
		if(target[i] > maxValue){
			maxValue = target[i];
			maxIdx = i;
		}
	}
	if(maxIdx==-1){
		debug("ERROR: can't find max value bigger than 0");
	}
	return maxIdx;
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



// this is equal to conv(...'valid') in matlab
void makeValidConvolve(float *source, int sourceSize, float *filter, int filterSize, float *dest, int destSize, bool returnAbs){
	int validSize = sourceSize - filterSize + 1;
	if(validSize != destSize){
		debug("ERROR: validSize != destSize, (%d,%d)", validSize, destSize);
	}
	for(int i=0;i<validSize;i++){
		float sum = 0;
		int sourceIdx = i;
		for(int filterIdx=filterSize-1;filterIdx>=0;filterIdx--){
			sum += source[sourceIdx]*filter[filterIdx];
			sourceIdx ++;
		}
		// flip sum if abs is required
		if(returnAbs && sum < 0) sum = -1*sum;

		dest[i] = sum;
	}
}

// this is equal to the filter function at matlab
void makeFilter(float *b, int bSize, float *a, int aSize, float *x, int xSize, float *y){
	int p = aSize-1;
	int q = bSize-1;
	int pq = p;
	if(q>p){pq = q;}
	float *u = (float*)malloc(sizeof(float)*(pq+xSize));
	memset(u, 0, sizeof(float)*(pq+xSize));

	for(int i = 0; i<xSize; i++){
		y[i] = b[0]*x[i]+u[i]; // update y

		int bIdx = 1;
		for(int j=i+1;j<i+q+1;j++){
			u[j] = u[j] + b[bIdx]*x[i];
			bIdx++;
		}

		int aIdx = 1;
		for(int j=i+1;j<i+p+1;j++){
			u[j] = u[j] - a[aIdx]*y[i];
			aIdx++;
		}

    }
}


// function to get only the necessary convolutions (abs)
float makeAbsConvInRange(float *source, int sourceSize, float *pulse, int pulseSize, float *dest, int destSize, int rangeStart, int rangeEnd){
	int rangeSize = rangeEnd - rangeStart;
	int rangeOffset = (int)((pulseSize-1)/2); // this is used to compensate the "same" option conv in matlab

	// 1. make some data format check
	if(rangeOffset > rangeStart){
		error("[ERROR]: rangeOffset > rangeStart");
		return -1;
	}
	if(sourceSize < pulseSize){
		error("[ERROR]: only support sourceSize >= pulseSize");
		return -1;
	}

	float sum = 0;
	for(int i = 0; i<rangeSize; i++){
		int pulseIdx = 0;
		float con = 0;
		for( int x = i+rangeStart-rangeOffset; x < sourceSize && pulseIdx < pulseSize; x++) {
			con += source[x]*pulse[pulseIdx];
			pulseIdx ++;
		}
		dest[i] = fabs(con);
		sum += fabs(con);
	}
	return sum;
}

// debug function to dump fire to matlab
void debugToMatlabFile2D(float** data, int col, int row, char* name, const char* path){
	if(SAVE_DEBUG_FILE){
		//debug("debugToMatlabFile2D: begin to write : %s", name);
		char filePathBuff[1000];
		sprintf(filePathBuff,"%sjni_%s.csv",path, name);
		FILE* f = fopen(filePathBuff,"w");
		//debug("debugToMatlabFile2D: f = %d", f);
		//fprintf(f, "jni_%s = [", name);
		for (int r=0;r<row;r++){
			for (int c=0;c<col;c++){
				fprintf(f, "%.2f",*(*(data+r)+c));
				if(c<col-1){
					fprintf(f,",");
				}
			}
			fprintf(f,"\n");
		}
		//fprintf(f,"];");
		fclose(f);
		//debug("debugToMatlabFile2D: end to write : %s", name);
	}
}

void debugToMatlabFile1D(float *data, int col, char* name, const char* path) {
	debugToMatlabFile2D(&data, col, 1, name, path);
}

// debug function to dump fire to matlab
void debugToMatlabFile2D(short** data, int col, int row, char* name, const char* path){
	if(SAVE_DEBUG_FILE){
		//debug("debugToMatlabFile2D: begin to write : %s", name);
		char filePathBuff[1000];
		sprintf(filePathBuff,"%sjni_%s.csv",path, name);
		FILE* f = fopen(filePathBuff,"w");
		//debug("debugToMatlabFile2D: f = %d", f);
		//fprintf(f, "jni_%s = [", name);
		for (int r=0;r<row;r++){
			for (int c=0;c<col;c++){
				fprintf(f, "%d",*(*(data+r)+c));
				if(c<col-1){
					fprintf(f,",");
				}
			}
			fprintf(f,"\n");
		}
		//fprintf(f,"];");
		fclose(f);
		//debug("debugToMatlabFile2D: end to write : %s", name);
	}
}

void debugToMatlabFile1D(short *data, int col, char* name, const char* path) {
	debugToMatlabFile2D(&data, col, 1, name, path);
}
