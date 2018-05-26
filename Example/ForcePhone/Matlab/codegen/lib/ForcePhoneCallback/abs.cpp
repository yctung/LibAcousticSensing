/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * abs.cpp
 *
 * Code generation for function 'abs'
 *
 */

/* Include files */
#include "ForcePhoneCallback.h"
#include "abs.h"

/* Function Definitions */
void b_abs(const double x_data[], const int x_size[1], double y_data[], int
           y_size[1])
{
  int k;
  y_size[0] = (short)x_size[0];
  for (k = 0; k + 1 <= x_size[0]; k++) {
    y_data[k] = std::abs(x_data[k]);
  }
}

/* End of code generation (abs.cpp) */
