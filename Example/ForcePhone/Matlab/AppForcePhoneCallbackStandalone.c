

//==================================================================
// This is the general callback can be called by Matlab/Android/iOS
// NOTE: this function take 2 arguments
//       (1) int type (2) double array
//       output
//==================================================================

#define CALLBACK_TYPE_ERROR
#define CALLBACK_TYPE_DATA
#define

// the real callback to process a single record of the sent sounds
void app_force_phone_data_callback(double *data, int data_len, double *output, int &output_len) {

}

#ifdef LINK_MATLAB
#include <math.h>
#include "mex.h"
#define	TYPE_IN	prhs[0]
#define	DATA_IN	prhs[1]
#endif


// TODO: add different function names for different OSes

#ifdef LINK_MATLAB
static void CALLBACK_FUNC_NAME()
// matlab delegate mex function
void mexFunction( int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
    // check for proper number of arguments
    if (nrhs != 2) {
	     mexErrMsgIdAndTxt("LibAS:callback:invalidNumInputs", "Two input arguments required.");
    } else if (nlhs > 1) {
	     mexErrMsgIdAndTxt("LibAS:callback:maxlhs", "Too many output arguments.");
    }

    // check the inputs
    if (!mxIsDouble(TYPE_IN)) {
        mexErrMsgIdAndTxt("MATLAB:callback:invalid inputs", "type should be a number");
    }

    // parse inputs and create a matrix for the return argument
    size_t
    YP_OUT = mxCreateDoubleMatrix( (mwSize)m, (mwSize)n, mxREAL);


    //
    double *yp;
    double *t,*y;
    size_t m,n;

    /* Assign pointers to the various parameters */
    yp = mxGetPr(YP_OUT);
    t = mxGetPr(T_IN);
    y = mxGetPr(Y_IN);

    /* Do the actual computations in a subroutine */
    yprime(yp,t,y);
    return;

}
#endif
