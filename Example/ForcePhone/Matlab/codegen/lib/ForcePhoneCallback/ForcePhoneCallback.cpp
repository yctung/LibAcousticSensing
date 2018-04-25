/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * ForcePhoneCallback.cpp
 *
 * Code generation for function 'ForcePhoneCallback'
 *
 */

/* Include files */
#include "ForcePhoneCallback.h"
#include "mean.h"
#include "abs.h"
#include "convn.h"
#include "ForcePhoneCallback_data.h"

/* Function Definitions */
void ForcePhoneCallback(const struct0_T *context, int type, const double data
  [4800], const struct1_T *user, struct2_T *ret)
{
  int i0;
  int i1;
  double dv0[4800];
  int tmp_size[1];
  int loop_ub;
  double tmp_data[2400];
  double b_tmp_data[2400];
  int b_tmp_size[1];
  double vib;

  /*  This callback only focuses on handling the data, no GUI anymore */
  /*  To convert this to the offline mode, use the */
  ret->initialized = -1;
  ret->valInt1 = 0;
  ret->valInt2 = 0;
  ret->valDouble1 = 0.0;
  ret->valDouble2 = 0.0;

  /* ret = 0; */
  if (type == context->CALLBACK_TYPE_INIT) {
    PS.touched = 0.0;
  } else if (type == context->CALLBACK_TYPE_DATA) {
    /*  estimate vibration by sound correlation */
    if (PS.detectRangeStart > PS.detectRangeEnd) {
      i0 = 0;
      i1 = 0;
    } else {
      i0 = (int)PS.detectRangeStart - 1;
      i1 = (int)PS.detectRangeEnd;
    }

    convn(data, PS.signalToCorrelate, dv0);
    tmp_size[0] = i1 - i0;
    loop_ub = i1 - i0;
    for (i1 = 0; i1 < loop_ub; i1++) {
      tmp_data[i1] = dv0[(i0 + i1) + 2400 * ((int)PS.detectChIdx - 1)];
    }

    b_abs(tmp_data, tmp_size, b_tmp_data, b_tmp_size);
    vib = mean(b_tmp_data, b_tmp_size);
    PS.vibLatest = vib;
    if (PS.touched == 1.0) {
      ret->initialized = 1;
      ret->valDouble1 = fabs(vib - PS.vibRef) / PS.vibRef;

      /* ret = 0.5; */
    }
  } else {
    if (type == context->CALLBACK_TYPE_USER) {
      if (user->code == PS.USER_CODE_TOUCH_START) {
        PS.touched = 1.0;
        PS.vibRef = PS.vibLatest;
      } else {
        if (user->code == PS.USER_CODE_TOUCH_END) {
          PS.touched = 0.0;
        }
      }
    }
  }
}

/* End of code generation (ForcePhoneCallback.cpp) */
