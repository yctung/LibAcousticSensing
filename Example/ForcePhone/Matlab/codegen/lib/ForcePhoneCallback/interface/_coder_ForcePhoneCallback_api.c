/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * _coder_ForcePhoneCallback_api.c
 *
 * Code generation for function '_coder_ForcePhoneCallback_api'
 *
 */

/* Include files */
#include "tmwtypes.h"
#include "_coder_ForcePhoneCallback_api.h"
#include "_coder_ForcePhoneCallback_mex.h"

/* Variable Definitions */
emlrtCTX emlrtRootTLSGlobal = NULL;
emlrtContext emlrtContextGlobal = { true,/* bFirstTime */
  false,                               /* bInitialized */
  131451U,                             /* fVersionInfo */
  NULL,                                /* fErrorFunction */
  "ForcePhoneCallback",                /* fFunctionName */
  NULL,                                /* fRTCallStack */
  false,                               /* bDebugMode */
  { 2045744189U, 2170104910U, 2743257031U, 4284093946U },/* fSigWrd */
  NULL                                 /* fSigMem */
};

/* Function Declarations */
static struct0_T b_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u,
  const emlrtMsgIdentifier *parentId);
static int16_T c_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u, const
  emlrtMsgIdentifier *parentId);
static int16_T d_emlrt_marshallIn(const emlrtStack *sp, const mxArray *type,
  const char_T *identifier);
static real_T (*e_emlrt_marshallIn(const emlrtStack *sp, const mxArray *data,
  const char_T *identifier))[2400];
static struct0_T emlrt_marshallIn(const emlrtStack *sp, const mxArray *context,
  const char_T *identifier);
static const mxArray *emlrt_marshallOut(const struct2_T u);
static real_T (*f_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u, const
  emlrtMsgIdentifier *parentId))[2400];
static struct1_T g_emlrt_marshallIn(const emlrtStack *sp, const mxArray *user,
  const char_T *identifier);
static struct1_T h_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u,
  const emlrtMsgIdentifier *parentId);
static int16_T i_emlrt_marshallIn(const emlrtStack *sp, const mxArray *src,
  const emlrtMsgIdentifier *msgId);
static real_T (*j_emlrt_marshallIn(const emlrtStack *sp, const mxArray *src,
  const emlrtMsgIdentifier *msgId))[2400];

/* Function Definitions */
static struct0_T b_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u,
  const emlrtMsgIdentifier *parentId)
{
  struct0_T y;
  emlrtMsgIdentifier thisId;
  static const char * fieldNames[5] = { "mode", "CALLBACK_TYPE_ERROR",
    "CALLBACK_TYPE_INIT", "CALLBACK_TYPE_DATA", "CALLBACK_TYPE_USER" };

  static const int32_T dims = 0;
  thisId.fParent = parentId;
  thisId.bParentIsCell = false;
  emlrtCheckStructR2012b(sp, parentId, u, 5, fieldNames, 0U, &dims);
  thisId.fIdentifier = "mode";
  y.mode = c_emlrt_marshallIn(sp, emlrtAlias(emlrtGetFieldR2017b(sp, u, 0, 0,
    "mode")), &thisId);
  thisId.fIdentifier = "CALLBACK_TYPE_ERROR";
  y.CALLBACK_TYPE_ERROR = c_emlrt_marshallIn(sp, emlrtAlias(emlrtGetFieldR2017b
    (sp, u, 0, 1, "CALLBACK_TYPE_ERROR")), &thisId);
  thisId.fIdentifier = "CALLBACK_TYPE_INIT";
  y.CALLBACK_TYPE_INIT = c_emlrt_marshallIn(sp, emlrtAlias(emlrtGetFieldR2017b
    (sp, u, 0, 2, "CALLBACK_TYPE_INIT")), &thisId);
  thisId.fIdentifier = "CALLBACK_TYPE_DATA";
  y.CALLBACK_TYPE_DATA = c_emlrt_marshallIn(sp, emlrtAlias(emlrtGetFieldR2017b
    (sp, u, 0, 3, "CALLBACK_TYPE_DATA")), &thisId);
  thisId.fIdentifier = "CALLBACK_TYPE_USER";
  y.CALLBACK_TYPE_USER = c_emlrt_marshallIn(sp, emlrtAlias(emlrtGetFieldR2017b
    (sp, u, 0, 4, "CALLBACK_TYPE_USER")), &thisId);
  emlrtDestroyArray(&u);
  return y;
}

static int16_T c_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u, const
  emlrtMsgIdentifier *parentId)
{
  int16_T y;
  y = i_emlrt_marshallIn(sp, emlrtAlias(u), parentId);
  emlrtDestroyArray(&u);
  return y;
}

static int16_T d_emlrt_marshallIn(const emlrtStack *sp, const mxArray *type,
  const char_T *identifier)
{
  int16_T y;
  emlrtMsgIdentifier thisId;
  thisId.fIdentifier = (const char *)identifier;
  thisId.fParent = NULL;
  thisId.bParentIsCell = false;
  y = c_emlrt_marshallIn(sp, emlrtAlias(type), &thisId);
  emlrtDestroyArray(&type);
  return y;
}

static real_T (*e_emlrt_marshallIn(const emlrtStack *sp, const mxArray *data,
  const char_T *identifier))[2400]
{
  real_T (*y)[2400];
  emlrtMsgIdentifier thisId;
  thisId.fIdentifier = (const char *)identifier;
  thisId.fParent = NULL;
  thisId.bParentIsCell = false;
  y = f_emlrt_marshallIn(sp, emlrtAlias(data), &thisId);
  emlrtDestroyArray(&data);
  return y;
}
  static struct0_T emlrt_marshallIn(const emlrtStack *sp, const mxArray *context,
  const char_T *identifier)
{
  struct0_T y;
  emlrtMsgIdentifier thisId;
  thisId.fIdentifier = (const char *)identifier;
  thisId.fParent = NULL;
  thisId.bParentIsCell = false;
  y = b_emlrt_marshallIn(sp, emlrtAlias(context), &thisId);
  emlrtDestroyArray(&context);
  return y;
}

static const mxArray *emlrt_marshallOut(const struct2_T u)
{
  const mxArray *y;
  static const char * sv0[5] = { "initialized", "valInt1", "valInt2",
    "valDouble1", "valDouble2" };

  const mxArray *b_y;
  const mxArray *m0;
  y = NULL;
  emlrtAssign(&y, emlrtCreateStructMatrix(1, 1, 5, sv0));
  b_y = NULL;
  m0 = emlrtCreateNumericMatrix(1, 1, mxINT8_CLASS, mxREAL);
  *(int8_T *)emlrtMxGetData(m0) = u.initialized;
  emlrtAssign(&b_y, m0);
  emlrtSetFieldR2017b(y, 0, "initialized", b_y, 0);
  b_y = NULL;
  m0 = emlrtCreateNumericMatrix(1, 1, mxINT8_CLASS, mxREAL);
  *(int8_T *)emlrtMxGetData(m0) = u.valInt1;
  emlrtAssign(&b_y, m0);
  emlrtSetFieldR2017b(y, 0, "valInt1", b_y, 1);
  b_y = NULL;
  m0 = emlrtCreateNumericMatrix(1, 1, mxINT8_CLASS, mxREAL);
  *(int8_T *)emlrtMxGetData(m0) = u.valInt2;
  emlrtAssign(&b_y, m0);
  emlrtSetFieldR2017b(y, 0, "valInt2", b_y, 2);
  b_y = NULL;
  m0 = emlrtCreateDoubleScalar(u.valDouble1);
  emlrtAssign(&b_y, m0);
  emlrtSetFieldR2017b(y, 0, "valDouble1", b_y, 3);
  b_y = NULL;
  m0 = emlrtCreateDoubleScalar(u.valDouble2);
  emlrtAssign(&b_y, m0);
  emlrtSetFieldR2017b(y, 0, "valDouble2", b_y, 4);
  return y;
}

static real_T (*f_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u, const
  emlrtMsgIdentifier *parentId))[2400]
{
  real_T (*y)[2400];
  y = j_emlrt_marshallIn(sp, emlrtAlias(u), parentId);
  emlrtDestroyArray(&u);
  return y;
}
  static struct1_T g_emlrt_marshallIn(const emlrtStack *sp, const mxArray *user,
  const char_T *identifier)
{
  struct1_T y;
  emlrtMsgIdentifier thisId;
  thisId.fIdentifier = (const char *)identifier;
  thisId.fParent = NULL;
  thisId.bParentIsCell = false;
  y = h_emlrt_marshallIn(sp, emlrtAlias(user), &thisId);
  emlrtDestroyArray(&user);
  return y;
}

static struct1_T h_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u,
  const emlrtMsgIdentifier *parentId)
{
  struct1_T y;
  emlrtMsgIdentifier thisId;
  static const char * fieldNames[2] = { "code", "valInt" };

  static const int32_T dims = 0;
  thisId.fParent = parentId;
  thisId.bParentIsCell = false;
  emlrtCheckStructR2012b(sp, parentId, u, 2, fieldNames, 0U, &dims);
  thisId.fIdentifier = "code";
  y.code = c_emlrt_marshallIn(sp, emlrtAlias(emlrtGetFieldR2017b(sp, u, 0, 0,
    "code")), &thisId);
  thisId.fIdentifier = "valInt";
  y.valInt = c_emlrt_marshallIn(sp, emlrtAlias(emlrtGetFieldR2017b(sp, u, 0, 1,
    "valInt")), &thisId);
  emlrtDestroyArray(&u);
  return y;
}

static int16_T i_emlrt_marshallIn(const emlrtStack *sp, const mxArray *src,
  const emlrtMsgIdentifier *msgId)
{
  int16_T ret;
  static const int32_T dims = 0;
  emlrtCheckBuiltInR2012b(sp, msgId, src, "int16", false, 0U, &dims);
  ret = *(int16_T *)emlrtMxGetData(src);
  emlrtDestroyArray(&src);
  return ret;
}

static real_T (*j_emlrt_marshallIn(const emlrtStack *sp, const mxArray *src,
  const emlrtMsgIdentifier *msgId))[2400]
{
  real_T (*ret)[2400];
  static const int32_T dims[1] = { 2400 };

  emlrtCheckBuiltInR2012b(sp, msgId, src, "double", false, 1U, dims);
  ret = (real_T (*)[2400])emlrtMxGetData(src);
  emlrtDestroyArray(&src);
  return ret;
}
  void ForcePhoneCallback_api(const mxArray * const prhs[4], const mxArray *
  plhs[1])
{
  struct0_T context;
  int16_T type;
  real_T (*data)[2400];
  struct1_T user;
  struct2_T ret;
  emlrtStack st = { NULL,              /* site */
    NULL,                              /* tls */
    NULL                               /* prev */
  };

  st.tls = emlrtRootTLSGlobal;

  /* Marshall function inputs */
  context = emlrt_marshallIn(&st, emlrtAliasP((const mxArray *)prhs[0]),
    "context");
  type = d_emlrt_marshallIn(&st, emlrtAliasP((const mxArray *)prhs[1]), "type");
  data = e_emlrt_marshallIn(&st, emlrtAlias((const mxArray *)prhs[2]), "data");
  user = g_emlrt_marshallIn(&st, emlrtAliasP((const mxArray *)prhs[3]), "user");

  /* Invoke the target function */
  ForcePhoneCallback(&context, type, *data, &user, &ret);

  /* Marshall function outputs */
  plhs[0] = emlrt_marshallOut(ret);
}

void ForcePhoneCallback_atexit(void)
{
  emlrtStack st = { NULL,              /* site */
    NULL,                              /* tls */
    NULL                               /* prev */
  };

  mexFunctionCreateRootTLS();
  st.tls = emlrtRootTLSGlobal;
  emlrtEnterRtStackR2012b(&st);
  emlrtLeaveRtStackR2012b(&st);
  emlrtDestroyRootTLS(&emlrtRootTLSGlobal);
  ForcePhoneCallback_xil_terminate();
}

void ForcePhoneCallback_initialize(void)
{
  emlrtStack st = { NULL,              /* site */
    NULL,                              /* tls */
    NULL                               /* prev */
  };

  mexFunctionCreateRootTLS();
  st.tls = emlrtRootTLSGlobal;
  emlrtClearAllocCountR2012b(&st, false, 0U, 0);
  emlrtEnterRtStackR2012b(&st);
  emlrtFirstTimeR2012b(emlrtRootTLSGlobal);
}

void ForcePhoneCallback_terminate(void)
{
  emlrtStack st = { NULL,              /* site */
    NULL,                              /* tls */
    NULL                               /* prev */
  };

  st.tls = emlrtRootTLSGlobal;
  emlrtLeaveRtStackR2012b(&st);
  emlrtDestroyRootTLS(&emlrtRootTLSGlobal);
}

/* End of code generation (_coder_ForcePhoneCallback_api.c) */
