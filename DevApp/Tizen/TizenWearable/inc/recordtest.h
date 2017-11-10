/*
 * recordtest.h
 *
 *  Created on: Sep 13, 2017
 *      Author: eddyxd
 */

#ifndef RECORDTEST_H_
#define RECORDTEST_H_

#include <dlog.h>
#include <tizen.h>
#include <app.h>
#include <efl_extension.h>
#include <Elementary.h>
#include <storage.h>
#include "utils.h"

void data_initialize(); // need to be called before record/play
void data_finalize();

void start_recordtest_async();

typedef enum {
    NONE,
    SYNC_RECORD,
    SYNC_PLAYBACK,
    ASYNC_RECORD,
    ASYNC_PLAYBACK,
} current_state_e;

#endif /* RECORDTEST_H_ */
