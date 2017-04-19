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

#define SERVER_ADDR "192.168.1.114"
#define SERVER_PORT 50005


// Types of actions (for packets sent from the server)
#define LIBAS_ACTION_CONNECT 1 	// ACTION_CONNECT format: | ACTION_CONNECT | xxx parater setting
#define LIBAS_ACTION_DATA 	 2 	// ACTION_DATA format: | ACTION_DATA | # of bytes to send | byte[] | -1
#define LIBAS_ACTION_CLOSE 	-1	// ACTION_CLOSE format: | ACTION_CLOSE |
#define LIBAS_ACTION_SET 	 3
#define LIBAS_ACTION_INIT 	 4
#define LIBAS_ACTION_SENSING_END 5
#define LIBAS_ACTION_USER	 6 	// used for sending application's user-defined variables

// Types of set actions (for packets sent to the server)
#define LIBAS_SET_TYPE_BYTE_ARRAY 	1
#define LIBAS_SET_TYPE_STRING 		2
#define LIBAS_SET_TYPE_DOUBLE 		3
#define LIBAS_SET_TYPE_INT 			4
#define LIBAS_SET_TYPE_VALUE_STRING 5 // sent value by string

// Types of receving packets from server
#define LIBAS_REACTION_SET_MEDIA 	1
#define LIBAS_REACTION_ASK_SENSING  2
#define LIBAS_REACTION_SET_RESULT 	3

#define LIBAS_CHECK_OK 255 // Tizen treate char -1 as 255 in comparison

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "devapp"

#if !defined(PACKAGE)
#define PACKAGE "edu.umich.edu.yctung.devapp"
#endif

#endif /* __devapp_H__ */
