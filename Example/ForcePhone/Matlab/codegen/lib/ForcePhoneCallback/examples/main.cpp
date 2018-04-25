/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * main.cpp
 *
 * Code generation for function 'main'
 *
 */

/*************************************************************************/
/* This automatically generated example C main file shows how to call    */
/* entry-point functions that MATLAB Coder generated. You must customize */
/* this file for your application. Do not modify this file directly.     */
/* Instead, make a copy of this file, modify it, and integrate it into   */
/* your development environment.                                         */
/*                                                                       */
/* This file initializes entry-point function arguments to a default     */
/* size and value before calling the entry-point functions. It does      */
/* not store or use any values returned from the entry-point functions.  */
/* If necessary, it does pre-allocate memory for returned values.        */
/* You can use this file as a starting point for a main function that    */
/* you can deploy in your application.                                   */
/*                                                                       */
/* After you copy the file, and before you deploy it, you must make the  */
/* following changes:                                                    */
/* * For variable-size function arguments, change the example sizes to   */
/* the sizes that your application requires.                             */
/* * Change the example values of function arguments to the values that  */
/* your application requires.                                            */
/* * If the entry-point functions return values, store these values or   */
/* otherwise use them as required by your application.                   */
/*                                                                       */
/*************************************************************************/
/* Include files */
#include "ForcePhoneCallback.h"
#include "main.h"
#include "ForcePhoneCallback_terminate.h"
#include "ForcePhoneCallback_initialize.h"

/* Function Declarations */
static void argInit_2400x2_real_T(double result[4800]);
static int argInit_int32_T();
static double argInit_real_T();
static struct0_T argInit_struct0_T();
static struct1_T argInit_struct1_T();
static void main_ForcePhoneCallback();

/* Function Definitions */
static void argInit_2400x2_real_T(double result[4800])
{
  int idx0;
  int idx1;

  /* Loop over the array to initialize each element. */
  for (idx0 = 0; idx0 < 2400; idx0++) {
    for (idx1 = 0; idx1 < 2; idx1++) {
      /* Set the value of the array element.
         Change this value to the value that the application requires. */
      result[idx0 + 2400 * idx1] = argInit_real_T();
    }
  }
}

static int argInit_int32_T()
{
  return 0;
}

static double argInit_real_T()
{
  return 0.0;
}

static struct0_T argInit_struct0_T()
{
  struct0_T result;

  /* Set the value of each structure field.
     Change this value to the value that the application requires. */
  result.mode = argInit_int32_T();
  result.CALLBACK_TYPE_ERROR = argInit_int32_T();
  result.CALLBACK_TYPE_INIT = argInit_int32_T();
  result.CALLBACK_TYPE_DATA = argInit_int32_T();
  result.CALLBACK_TYPE_USER = argInit_int32_T();
  return result;
}

static struct1_T argInit_struct1_T()
{
  struct1_T result;

  /* Set the value of each structure field.
     Change this value to the value that the application requires. */
  result.code = argInit_int32_T();
  result.valInt = argInit_int32_T();
  return result;
}

static void main_ForcePhoneCallback()
{
  double dv1[4800];
  struct0_T r1;
  struct1_T r2;
  struct2_T ret;

  /* Initialize function 'ForcePhoneCallback' input arguments. */
  /* Initialize function input argument 'context'. */
  /* Initialize function input argument 'data'. */
  /* Initialize function input argument 'user'. */
  /* Call the entry-point 'ForcePhoneCallback'. */
  argInit_2400x2_real_T(dv1);
  r1 = argInit_struct0_T();
  r2 = argInit_struct1_T();
  ForcePhoneCallback(&r1, argInit_int32_T(), dv1, &r2, &ret);
}

int main(int, const char * const [])
{
  /* Initialize the application.
     You do not need to do this more than one time. */
  ForcePhoneCallback_initialize();

  /* Invoke the entry-point functions.
     You can call entry-point functions multiple times. */
  main_ForcePhoneCallback();

  /* Terminate the application.
     You do not need to do this more than one time. */
  ForcePhoneCallback_terminate();
  return 0;
}

/* End of code generation (main.cpp) */
