/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * convn.cpp
 *
 * Code generation for function 'convn'
 *
 */

/* Include files */
#include "ForcePhoneCallback.h"
#include "convn.h"

/* Function Definitions */
void convn(const double A[2400], const double B[1200], double C[2400])
{
  int iC;
  int iB;
  int i;
  int firstRowA;
  int b_i;
  int a_length;
  int cidx;
  int r;
  memset(&C[0], 0, 2400U * sizeof(double));
  iC = 0;
  iB = 0;
  for (i = 0; i < 1200; i++) {
    if (i < 600) {
      firstRowA = 600 - i;
    } else {
      firstRowA = 0;
    }

    if (i + 2400 <= 2999) {
      b_i = 2400;
    } else {
      b_i = 3000 - i;
    }

    a_length = b_i - firstRowA;
    cidx = iC;
    for (r = 1; r <= a_length; r++) {
      C[cidx] += B[iB] * A[firstRowA];
      firstRowA++;
      cidx++;
    }

    iB++;
    if (i >= 600) {
      iC++;
    }
  }
}

/* End of code generation (convn.cpp) */
