/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * ForcePhoneCallback_types.h
 *
 * Code generation for function 'ForcePhoneCallback'
 *
 */

#ifndef FORCEPHONECALLBACK_TYPES_H
#define FORCEPHONECALLBACK_TYPES_H

/* Include files */
#include "rtwtypes.h"

/* Type Definitions */
typedef struct {
  int mode;
  int CALLBACK_TYPE_ERROR;
  int CALLBACK_TYPE_INIT;
  int CALLBACK_TYPE_DATA;
  int CALLBACK_TYPE_USER;
} struct0_T;

typedef struct {
  int code;
  int valInt;
} struct1_T;

typedef struct {
  signed char initialized;
  signed char valInt1;
  signed char valInt2;
  double valDouble1;
  double valDouble2;
} struct2_T;

typedef struct {
  double FS;
  short USER_CODE_TOUCH_START;
  short USER_CODE_TOUCH_END;
  double detectChIdx;
  double detectRangeStart;
  double detectRangeEnd;
  double detectEnabled;
  double vibLatest;
  double vibRef;
  double touched;
  double signalToCorrelate[1200];
} struct_T;

#endif

/* End of code generation (ForcePhoneCallback_types.h) */
