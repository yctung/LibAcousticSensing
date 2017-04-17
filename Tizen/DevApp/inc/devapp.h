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

#define SAMPLE_RATE 44100
#define RECORDING_SEC 5

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "devapp"

#if !defined(PACKAGE)
#define PACKAGE "edu.umich.edu.yctung.devapp"
#endif

#endif /* __devapp_H__ */
