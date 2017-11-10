/*
 * libas.h
 *
 *  Created on: Sep 14, 2017
 *      Author: eddyxd
 */

#ifndef LIBAS_H_
#define LIBAS_H_

/* NOTE: LibAS requires the permission of the followings
 * <privilege>http://tizen.org/privilege/recorder</privilege>
 * <privilege>http://tizen.org/privilege/mediastorage</privilege>
 * <privilege>http://tizen.org/privilege/internet</privilege>
 * <privilege>http://tizen.org/privilege/externalstorage</privilege>
 */

#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <audio_io.h>
#include <sound_manager.h>
#include <storage.h>
#include "utils.h"


#define SAMPLE_RATE 48000
#define RECORDING_SEC 5

//#define SERVER_ADDR "192.168.100.193"
#define SERVER_ADDR "10.0.0.12"
//#define SERVER_ADDR "172.20.10.2"
#define SERVER_PORT 50005
#define SHOW_DEBUG_MSG false

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
#define LIBAS_REACTION_STOP_SENSING 4

#define LIBAS_CHECK_OK 255 // Tizen treats char -1 as 255 in comparison

static bool LIBAS_TRACE_SAVE_TO_FILE = true;

typedef struct libdata {
	bool is_remote_mode;


	audio_in_h input;
	audio_out_h output;

	void *output_buffer[882000];
	int output_buffer_size;

	void *input_buffer[882000];
	int input_buffer_idx;
	int sockfd;

	// sensing audio
	void *pilot;
	int pilot_byte_size;
	void *signal;
	int signal_byte_size;

	// *** temporary, just for debug ***
	char base_path[200];
	FILE *fout;
	void *buffer;
	int buffer_size;
} libdata_s;

bool libas_is_ready_for_sensing();
void libas_init(bool);
void libas_start_sensing();
void libas_stop_sensing();

#endif /* LIBAS_H_ */
