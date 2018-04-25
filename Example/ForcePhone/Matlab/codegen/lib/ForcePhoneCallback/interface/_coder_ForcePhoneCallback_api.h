/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * _coder_ForcePhoneCallback_api.h
 *
 * Code generation for function '_coder_ForcePhoneCallback_api'
 *
 */

#ifndef _CODER_FORCEPHONECALLBACK_API_H
#define _CODER_FORCEPHONECALLBACK_API_H

/* Include files */
#include "tmwtypes.h"
#include "mex.h"
#include "emlrt.h"
#include <stddef.h>
#include <stdlib.h>
#include "_coder_ForcePhoneCallback_api.h"

/* Type Definitions */
#ifndef typedef_struct0_T
#define typedef_struct0_T

typedef struct {
  int16_T mode;
  int16_T CALLBACK_TYPE_ERROR;
  int16_T CALLBACK_TYPE_INIT;
  int16_T CALLBACK_TYPE_DATA;
  int16_T CALLBACK_TYPE_USER;
} struct0_T;

#endif                                 /*typedef_struct0_T*/

#ifndef typedef_struct1_T
#define typedef_struct1_T

typedef struct {
  int16_T code;
  int16_T valInt;
} struct1_T;

#endif                                 /*typedef_struct1_T*/

#ifndef typedef_struct2_T
#define typedef_struct2_T

typedef struct {
  int8_T initialized;
  int8_T valInt1;
  int8_T valInt2;
  real_T valDouble1;
  real_T valDouble2;
} struct2_T;

#endif                                 /*typedef_struct2_T*/

/* Variable Declarations */
extern emlrtCTX emlrtRootTLSGlobal;
extern emlrtContext emlrtContextGlobal;

/* Function Declarations */
extern void ForcePhoneCallback(struct0_T *context, int16_T type, real_T data
  [2400], struct1_T *user, struct2_T *ret);
extern void ForcePhoneCallback_api(const mxArray * const prhs[4], const mxArray *
  plhs[1]);
extern void ForcePhoneCallback_atexit(void);
extern void ForcePhoneCallback_initialize(void);
extern void ForcePhoneCallback_terminate(void);
extern void ForcePhoneCallback_xil_terminate(void);

#endif

/* End of code generation (_coder_ForcePhoneCallback_api.h) */
