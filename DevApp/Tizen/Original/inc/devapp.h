#ifndef __devapp_H__
#define __devapp_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <audio_io.h>
#include <sound_manager.h>
#include <storage.h>
#include "libas.h"
#include "recordtest.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "libas"

#if !defined(PACKAGE)
#define PACKAGE "edu.umich.edu.yctung.devapp"
#endif

// Flags for control logics
//#define IS_TESTING_RECORD

#endif /* __devapp_H__ */
