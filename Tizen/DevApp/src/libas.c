/*
 * libas.c
 *
 *  Created on: Sep 14, 2017
 *      Author: eddyxd
 */

#include "libas.h"

static libdata_s sld = {0, }; // static libdata (init as 0)


//=============================================================================================
// Some other utility functions
//=============================================================================================
static void _dump_thread_info() {
	DLOG_PRINT_DEBUG_MSG("Thread info: (active, pending, available, max) = (%d, %d, %d, %d)"
			, ecore_thread_active_get()
			, ecore_thread_pending_total_get()
			, ecore_thread_available_get()
			, ecore_thread_max_get());
}

//=============================================================================================
// Audio related internal functions
//=============================================================================================
static int _audio_read_total = 0;

// ref: https://developer.tizen.org/ko/development/training/native-application/creating-applications-multimedia/audio-playback-and-recording?langredirect=1
int internal_storage_id = -1;
static bool _storage_cb(int storage_id, storage_type_e type, storage_state_e state, const char *path, void *user_data)
{
    if (type == STORAGE_TYPE_INTERNAL) {
        internal_storage_id = storage_id;
        return false;
    }
    return true;
}

static bool _audio_device_is_ready = false;
static void _audio_init() {
	libdata_s *ld = &sld;

	if (ld->input != 0) { // has been initalized
		DLOG_PRINT_ERROR_MSG("_audio_init: audio has been initialized");
		return;
	}

	int error_code = 0;

	error_code = audio_in_create(SAMPLE_RATE, AUDIO_CHANNEL_MONO, AUDIO_SAMPLE_TYPE_S16_LE, &ld->input);
	CHECK_ERROR_AND_RETURN("audio_in_create", error_code);

	error_code = audio_out_create(SAMPLE_RATE, AUDIO_CHANNEL_MONO, AUDIO_SAMPLE_TYPE_S16_LE, SOUND_TYPE_SYSTEM, &ld->output);
	CHECK_ERROR_AND_RETURN("audio_out_create", error_code);

	error_code = audio_in_get_buffer_size(ld->input, &ld->buffer_size); // return the required buffer size for each "100ms"
	DLOG_PRINT_DEBUG_MSG("buffer_size = %d", ld->buffer_size);

	ld->buffer_size *= 10 * RECORDING_SEC; // just for debug
	ld->buffer = malloc(ld->buffer_size);

	// create a file to save the recorded data
	char io_stream_w_path[200]; // just for debug
	char *storage_path;

	error_code = storage_foreach_device_supported(_storage_cb, NULL);
	CHECK_ERROR_AND_RETURN("storage_foreach_device_supported", error_code);

	error_code = storage_get_directory(internal_storage_id, STORAGE_DIRECTORY_SOUNDS, &storage_path);
	CHECK_ERROR_AND_RETURN("storage_get_directory", error_code);

	sprintf(ld->base_path, "%s/", storage_path);  // just copy to reference

	_audio_device_is_ready = true;
}

static void _audio_finalize() {
	// TODO: release audio device
	_audio_device_is_ready = false;
}

// callback for play audio asynchronously
static void *_latest_play_buffer;
static int _latest_play_buffer_size;
static int _latest_play_buffer_offset;


// this need to be executed in a separate thread to avoid hanging the UI thread
// yctung: this would not work, it seems that I have overflowed the audio buffer
bool _need_to_keep_audio_playing = false;
static void _start_and_keep_audio_playing_sync(void *data) {
	DLOG_PRINT_DEBUG_MSG("_start_and_keep_audio_playing_sync starts");
	libdata_s *ld = &sld;

	// 1. enable audio playing
	_need_to_keep_audio_playing = true;
	int error_code = audio_out_prepare(ld->output);
	CHECK_ERROR_AND_RETURN("audio_out_prepare", error_code);

	// 2. play pilot
	DLOG_PRINT_DEBUG_MSG("pilot_byte_size = %d", ld->pilot_byte_size);
	int bytes_number = audio_out_write(ld->output, ld->pilot, ld->pilot_byte_size);
	DLOG_PRINT_DEBUG_MSG("bytes_number being played = %d", bytes_number);


	// 3. play signal
	while(_need_to_keep_audio_playing) {
		int bytes_number = audio_out_write(ld->output, ld->signal, ld->signal_byte_size);
		//int bytes_number = audio_out_write(ld->output, ld->pilot, ld->pilot_byte_size);

		DLOG_PRINT_DEBUG_MSG("bytes_number being played = %d", bytes_number);

		if (bytes_number < 0) {
			char* error_msg;
			error_msg = get_error_message(bytes_number);
			dlog_print(DLOG_ERROR, LOG_TAG, error_msg);
			break;
		}
	}

	// 4. release audio interface
	error_code = audio_out_unprepare(ld->output);
	CHECK_ERROR_AND_RETURN("audio_out_unprepare", error_code);

	DLOG_PRINT_DEBUG_MSG("_start_and_keep_audio_playing_sync ends");
}


static void _audio_io_stream_write_cb(audio_out_h handle, size_t nbytes, void *data)
{
    libdata_s *ld = &sld;

    char * buffer = NULL;
    int buffer_offset = 0;
	if (nbytes > 0) {
		if(SHOW_DEBUG_MSG) dlog_print(DLOG_DEBUG, LOG_TAG, "_audio_io_stream_write_cb is called, nbytes = %d", nbytes);

      // Allocate and reset a local buffer for reading the audio data from the file
      buffer = malloc(nbytes);

      // copy buffer from the audio received from Matlab server
      int nbytes_remain = nbytes;

      // copy until the whole buffer is filled
      while (nbytes_remain > 0) {
    	  if (_latest_play_buffer_size - _latest_play_buffer_offset >= nbytes_remain) {
    		  // the bytes in the current play_buf is enough to fill the remain bytes in local buf to play
    		  memcpy(buffer+buffer_offset, _latest_play_buffer+_latest_play_buffer_offset, nbytes_remain);
    		  _latest_play_buffer_offset += nbytes_remain;
    		  nbytes_remain = 0; // break the loop

    		  if (_latest_play_buffer_offset == _latest_play_buffer_size) _latest_play_buffer_offset = 0;
    	  } else {
    		  // put part of data into buffer and wait the next round
    		  int nbytes_tocopy = _latest_play_buffer_size - _latest_play_buffer_offset;
    		  memcpy(buffer+buffer_offset, _latest_play_buffer+_latest_play_buffer_offset, nbytes_tocopy);
    		  _latest_play_buffer_offset = 0; // return to the start
    		  nbytes_remain -= nbytes_tocopy;
    		  buffer_offset += nbytes_tocopy;
    	  }

    	  if (_latest_play_buffer == ld->pilot && _latest_play_buffer_offset == 0) { // means the whole play_buffer is pilot and has been finished
    		  // switch pilot to signal buffer here
    		  _latest_play_buffer = ld->signal;
    		  _latest_play_buffer_size = ld->signal_byte_size;
    		  _latest_play_buffer_offset = 0;
    	  }
      }


      // Copy the audio data from the local buffer to the internal output buffer (starts playback)
      int data_size = audio_out_write(handle, buffer, nbytes);

      if (data_size < 0)
      {
         dlog_print(DLOG_ERROR, LOG_TAG, "audio_out_write() failed! Error code = %d", data_size);
      }

      // Release the memory allocated to the local buffer
      free(buffer);
   }
}

static bool _play_use_callback = false;
static void _start_audio_playing(bool use_callback) {
	_play_use_callback = use_callback;

	libdata_s *ld = &sld;

	if (use_callback) {
		// method 1: play audio in the callback manner
		_latest_play_buffer = ld->pilot;
		_latest_play_buffer_size = ld->pilot_byte_size;
		_latest_play_buffer_offset = 0;
		int error_code = audio_out_set_stream_cb(ld->output, _audio_io_stream_write_cb, ld);
		CHECK_ERROR_AND_RETURN("audio_out_set_stream_cb", error_code);
		error_code = audio_out_prepare(ld->output);
		CHECK_ERROR_AND_RETURN("audio_out_prepare", error_code);
	} else {
		// method 2: play audio by a while loop in another thread -> fails after few seconds
		// NOTE: yctung: we always lose the audio player after few seconds of playing audios
		_dump_thread_info();
		ecore_thread_run(_start_and_keep_audio_playing_sync, NULL, NULL, ld);
		_dump_thread_info();
	}

}

static void _stop_audio_playing() {
	dlog_print(DLOG_DEBUG, LOG_TAG, "stop_audio_playing is called");

	libdata_s *ld = &sld;

	if (_play_use_callback) {
		int error_code;
		error_code = audio_out_unprepare(ld->output);
		CHECK_ERROR_AND_RETURN("audio_out_unprepare", error_code);
		error_code = audio_out_unset_stream_cb(ld->output);
		CHECK_ERROR_AND_RETURN("audio_out_unset_stream_cb", error_code);
	} else {
		_need_to_keep_audio_playing = false; // this flag force the audio playing loop to stop
	}
}


// this need to be executed in a separate thread to avoid hanging the UI thread
static bool _need_to_keep_audio_recording = false;
static void _start_and_keep_audio_recording_sync(void *data) {
	DLOG_PRINT_DEBUG_MSG("_start_and_keep_audio_recording_sync starts");
	libdata_s *ld = data;

	_need_to_keep_audio_recording = true;
	int error_code = audio_in_prepare(ld->input);
	CHECK_ERROR_AND_RETURN("audio_in_prepare", error_code);

	int buffer_header_offset = 0; // LibAS's reply format: action + data size
	int temp = 0; // it should be determined when the time that packet is sent
	char action = LIBAS_ACTION_DATA;
	memcpy(ld->buffer, &action, sizeof(char));
	buffer_header_offset += sizeof(char);
	memcpy(ld->buffer + buffer_header_offset, &temp, sizeof(int)); // dummy size for now
	buffer_header_offset += sizeof(int);

	while(_need_to_keep_audio_recording) {
		int bytes_to_record = 19200; // need to be > 0.1 second
		int bytes_recorded = audio_in_read(ld->input, ld->buffer + buffer_header_offset, bytes_to_record);
		_audio_read_total += bytes_recorded;
		DLOG_PRINT_DEBUG_MSG("bytes_recorded = %d/%d (%d)", bytes_recorded, bytes_to_record, _audio_read_total);

		if (bytes_recorded < 0) {
			char* error_msg;
			error_msg = get_error_message(bytes_recorded);
			DLOG_PRINT_ERROR_MSG("Fail to read audio, error = %s", error_msg);
			break;
		} else if (bytes_recorded < bytes_to_record) {
			DLOG_PRINT_ERROR_MSG("Fail to record the audio completely (%d/%d)", bytes_recorded, bytes_to_record);
			break;
		}

		// send the recorded audio over networking if necessary
		if (ld->is_remote_mode) {
			int data_size = bytes_recorded;
			temp = htonl(data_size);
			memcpy(ld->buffer + sizeof(char), &temp, sizeof(int)); // update header for data size
			char check = -1;
			memcpy(ld->buffer + buffer_header_offset + data_size, &check, sizeof(char)); // add check
			int bytes_to_send = buffer_header_offset + data_size + sizeof(char); // total size of the packet to send

			int bytes_sent = write(ld->sockfd, ld->buffer, bytes_to_send);
			DLOG_PRINT_DEBUG_MSG("bytes_sent = %d/%d", bytes_sent, bytes_to_send);

			if (bytes_sent < 0) {
				char* error_msg;
				error_msg = get_error_message(bytes_sent);
				DLOG_PRINT_ERROR_MSG("Fail to write socket, error = %s", error_msg);
				break;
			} else if (bytes_sent < bytes_to_send) {
				DLOG_PRINT_ERROR_MSG("Fail to write socket buffer completely (%d/%d)", bytes_sent, bytes_to_send);
				break;
			}
		}

	}

	error_code = audio_in_unprepare(ld->input);
	CHECK_ERROR_AND_RETURN("audio_in_unprepare", error_code);

	DLOG_PRINT_DEBUG_MSG("_start_and_keep_audio_recording_sync ends");
}

static bool _record_use_callback = false;
static void _start_audio_recording(bool use_callback) {
	DLOG_PRINT_DEBUG_MSG("_start_audio_recording(use_callback = %d)", use_callback);

	_record_use_callback = use_callback;
	libdata_s *ld = &sld;

	// 1. create the file to record
	dlog_print(DLOG_DEBUG, LOG_TAG, ld->base_path);
	char fout_path[200];
	sprintf(fout_path, "%s%s", ld->base_path, "yctung_w.pcm");
	dlog_print(DLOG_DEBUG, LOG_TAG, fout_path);
	ld->input_buffer_idx = 0;

	ld->fout = fopen(fout_path, "w");
	if (!ld->fout) {
		dlog_print(DLOG_ERROR, LOG_TAG, "unable to open file for recording");
	}

	// 2. start recording
	if (use_callback) {
		// method 1. start async recording by a callback manner
		/*
		int error_code = audio_in_set_stream_cb(ld->input, _audio_io_stream_read_cb, ad);
		CHECK_ERROR_AND_RETURN("audio_in_set_stream_cb", error_code);
		error_code = audio_in_prepare(ld->input);
		CHECK_ERROR_AND_RETURN("audio_in_prepare", error_code);
		*/
	} else {
		// method 2. start sync recording by polling the audio in a separate thread
		_dump_thread_info();
		ecore_thread_run(_start_and_keep_audio_recording_sync, NULL, NULL, (void *)ld);
		_dump_thread_info();
	}
}

static void _stop_audio_recording() {
	libdata_s *ld = &sld;
	int error_code;

	// 1. ask device to stop recording
	// NOTE: don't destroy the class here, so we can reuse the class for the next recording
	if (_record_use_callback) { // async mode
		error_code = audio_in_unprepare(ld->input);
		CHECK_ERROR_AND_RETURN("audio_in_unprepare", error_code)

		error_code = audio_in_unset_stream_cb(ld->input);
		CHECK_ERROR_AND_RETURN("audio_in_unset_stream_cb", error_code);
	} else {
		_need_to_keep_audio_recording = false; // stop sync recording
	}

	// 2. reset some audio recording status
	_audio_read_total = 0;

	// 3. close the recorded file
	fwrite(ld->input_buffer, sizeof(char), ld->input_buffer_idx, ld->fout);
	fflush(ld->fout);
	fclose(ld->fout);
	ld->fout = NULL;
}

//=============================================================================================
// Network related functions
// ref: http://www.cs.rpi.edu/~moorthy/Courses/os98/Pgms/socket.html
//=============================================================================================
static int _blockread(int sockfd, void* dest, int size) {
	int size_has_been_read = 0;
	while (size_has_been_read < size) {
		int n = read(sockfd, dest+size_has_been_read, size-size_has_been_read);
		size_has_been_read += n;
	}
	return size_has_been_read;
}

static void _keep_reading_socket() {
	libdata_s *ld = &sld;

	// keep reading data
	dlog_print(DLOG_DEBUG, LOG_TAG, "_keep_reading_socket starts");
	int n;
	char reaction = -1;
	while (1) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "wait to read action");
		n = read(ld->sockfd, &reaction, 1);
		dlog_print(DLOG_DEBUG, LOG_TAG, "n = %d, reaction = %d", n, reaction);
		if (n!=1) {
			// TODO: error handling
			dlog_print(DLOG_ERROR, LOG_TAG, "read reaction fails, n = %d ", n);
			break;
		}

		// parse reaction
		if (reaction == LIBAS_REACTION_ASK_SENSING) {
			dlog_print(DLOG_DEBUG, LOG_TAG, "reaction == LIBAS_REACTION_ASK_SENSING");
			libas_start_sensing();
		} else if (reaction == LIBAS_REACTION_STOP_SENSING) {
			dlog_print(DLOG_DEBUG, LOG_TAG, "reaction == LIBAS_REACTION_STOP_SENSING");
			libas_stop_sensing();
		} else if (reaction == LIBAS_REACTION_SET_MEDIA) {
			dlog_print(DLOG_DEBUG, LOG_TAG, "reaction == LIBAS_REACTION_SET_MEDIA");
			int temp;
			n = _blockread(ld->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read FS, n = %d", n);
			int FS = ntohl(temp);
			n = _blockread(ld->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read chCnt, n = %d", n);
			int chCnt = ntohl(temp);
			n = _blockread(ld->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read repeatCnt, n = %d", n);
			int repeatCnt = ntohl(temp);
			dlog_print(DLOG_DEBUG, LOG_TAG, "FS = %d, chCnt = %d, repeatCnt = %d", FS, chCnt, repeatCnt);

			// read pilot
			n = _blockread(ld->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read, n = %d", n);
			int shortToRead = ntohl(temp);
			ld->pilot_byte_size = sizeof(int16_t)*shortToRead;
			dlog_print(DLOG_DEBUG, LOG_TAG, "shortToRead = %d", shortToRead);

			int16_t *pilot = (int16_t *) malloc(sizeof(int16_t)*shortToRead);
			n = _blockread(ld->sockfd, pilot, sizeof(int16_t)*shortToRead);
			dlog_print(DLOG_DEBUG, LOG_TAG, "pilot[0..2] = %d, %d, %d ...", pilot[0], pilot[1], pilot[2]);
			ld->pilot = pilot;

			// read signal
			n = _blockread(ld->sockfd, &temp, sizeof(int));
			shortToRead = ntohl(temp);
			ld->signal_byte_size = sizeof(int16_t)*shortToRead;
			dlog_print(DLOG_DEBUG, LOG_TAG, "shortToRead = %d", shortToRead);

			int16_t *signal = (int16_t *) malloc(sizeof(int16_t)*shortToRead);
			n = _blockread(ld->sockfd, signal, sizeof(int16_t)*shortToRead);
			dlog_print(DLOG_DEBUG, LOG_TAG, "signal[0..2] = %d, %d, %d ...", signal[0], signal[1], signal[2]);
			ld->signal = signal;

			char check;
			n = read(ld->sockfd, &check, 1);
			dlog_print(DLOG_DEBUG, LOG_TAG, "check = %d/%d", check, LIBAS_CHECK_OK);

			if (check != LIBAS_CHECK_OK) {
				dlog_print(DLOG_ERROR, LOG_TAG, "wrong check = %d", check);
				break;
			}
		} else {
			dlog_print(DLOG_ERROR, LOG_TAG, "undefined reaction = %d", reaction);
			break;
		}
	}
	dlog_print(DLOG_DEBUG, LOG_TAG, "_keep_reading_socket ends");
}

static void _connect_sensing_server() {
	libdata_s *ld = &sld;

	// open a client socket to connect
	struct sockaddr_in server_addr;
	struct hostent *server;
	ld->sockfd = socket(AF_INET, SOCK_STREAM, 0);
	server = gethostbyname(SERVER_ADDR);
	if (server == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Undefined host");
	}
	bzero((char*) &server_addr, sizeof(server_addr));
	server_addr.sin_family = AF_INET;
	bcopy((char*) server->h_addr, (char*) &server_addr.sin_addr.s_addr, server->h_length);
	server_addr.sin_port = htons(SERVER_PORT);

	if (connect(ld->sockfd, (struct sockaddr*) &server_addr, sizeof(server_addr)) < 0){
		dlog_print(DLOG_ERROR, LOG_TAG, "connect fails");
		return;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "connect to server successfully");

	// set socket to blocking mode
	// ref: http://stackoverflow.com/questions/12773509/read-is-not-blocking-in-socket-programming
	struct timeval t;
	t.tv_sec = 0;
	t.tv_usec = 0;
	void *ptr = &t;
	setsockopt(
	      ld->sockfd,     // Socket descriptor
	      SOL_SOCKET, // To manipulate options at the sockets API level
	      SO_RCVTIMEO,// Specify the receiving or sending timeouts
	      ptr, // option values
	      sizeof(t)
	 );


	// read socket in another thread
	_dump_thread_info();
	ecore_thread_run(_keep_reading_socket, NULL, NULL, (void *)ld);
	_dump_thread_info();

	// send socket init arguments to server
	// NOTE: these command (including the INIT) needs to be sent after the receiving loops starts
	char buffer[100];
	int buffer_size = 0;
	// a. send channel setting
	//nc.sendSetAction(NetworkController.SET_TYPE_VALUE_STRING, "traceChannelCnt", "2".getBytes()); // TODO: modify it based on device
	char action = LIBAS_ACTION_SET;
	char check = -1;
	uint32_t type = LIBAS_SET_TYPE_VALUE_STRING;
	char* val1 = "traceChannelCnt";
	uint32_t size1 = strlen(val1);
	char* val2 = "1";
	int size2 = strlen(val2);
	int temp;

	// send header
	buffer[buffer_size++] = action;
	temp = htonl(type);
	memcpy(buffer+buffer_size, &temp, sizeof(int));
	buffer_size += sizeof(int);
	dlog_print(DLOG_DEBUG, LOG_TAG, "temp = %d", temp);

	temp = htonl(size1);
	memcpy(buffer+buffer_size, &temp, sizeof(int));
	buffer_size += sizeof(int);
	memcpy(buffer+buffer_size, val1, size1);
	buffer_size += size1;
	buffer[buffer_size++] = check;

	temp = htonl(size2);
	memcpy(buffer+buffer_size, &temp, sizeof(int));
	buffer_size += sizeof(int);
	memcpy(buffer+buffer_size, val2, size2);
	buffer_size += size2;
	buffer[buffer_size++] = check;

	int n = write(ld->sockfd, buffer, buffer_size);
	if (n < 0) {
		dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: write to socket fails, n = %d", n);
	} else if (n < buffer_size) {
		dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: unable to write socket buffer completely, n = %d and buffer_size = %d", n, buffer_size);
	}
	dlog_print(DLOG_DEBUG, LOG_TAG, "write to socket bytes n = %d / %d", n, buffer_size);

	// b. send init
	buffer[0] = LIBAS_ACTION_INIT;
	n = write(ld->sockfd, buffer, 1);
}

//=============================================================================================
//                          Public interfaces
//=============================================================================================
bool libas_is_ready_for_sensing() {
	return _audio_device_is_ready;
}

void libas_init(bool is_remote_mode) {
	DLOG_PRINT_DEBUG_MSG("libas_init(is_remote_mode = %d)", is_remote_mode);

	libdata_s *ld = &sld;
	ld->is_remote_mode = is_remote_mode;

	_dump_thread_info();
	DLOG_PRINT_DEBUG_MSG("set thread max = 4");
	ecore_thread_max_set(4);
	_dump_thread_info();


	_audio_init();
	if (is_remote_mode) {
		_connect_sensing_server();
	}
}

void libas_start_sensing() {
	DLOG_PRINT_DEBUG_MSG("libas_start_sensing()");

	if (!libas_is_ready_for_sensing()) {
		DLOG_PRINT_ERROR_MSG("libas_start_sensing() is called when not ready to sense");
		return;
	}
	_start_audio_recording(false);
	_start_audio_playing(false);
}

void libas_stop_sensing() {
	DLOG_PRINT_DEBUG_MSG("libas_stop_sensing()");

	_stop_audio_recording();
	_stop_audio_playing();
}


//=============================================================================================
// Deprecated -> dont use
//=============================================================================================
static void _audio_io_stream_read_cb(audio_in_h handle, size_t nbytes, void *userdata)
{
	libdata_s *ld = &sld;
	const void *buffer = NULL;
	if (nbytes > 0) {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "stream_read_cb is called, nbytes = %d", nbytes);

		//nbytes *= 2; // just for debug

		int error_code = audio_in_peek(handle, &buffer, &nbytes);
		CHECK_ERROR_AND_RETURN("audio_in_peek", error_code);
		_audio_read_total += nbytes;

		// write to a file
		/*
		fwrite(buffer, sizeof(char), nbytes, ld->fout);
		//memcpy(ld->input_buffer+ld->input_buffer_idx, buffer, sizeof(char)*nbytes);
		ld->input_buffer_idx += sizeof(char)*nbytes;
		dlog_print(DLOG_DEBUG, LOG_TAG, "stream_read_cb is called, input_buffer_idx = %d", ld->input_buffer_idx);
		*/

		// write to socket
		int temp = htonl(nbytes);
		char check = -1;


		// *** the following code send recorded audio to each packet -> too much overhead ***
		/*
		ld->buffer_size = 0;
		char action = LIBAS_ACTION_DATA;
		memcpy(ld->buffer, &action, sizeof(char));
		ld->buffer_size += sizeof(char);
		memcpy(ld->buffer+ld->buffer_size, &temp, sizeof(int));
		ld->buffer_size += sizeof(int);
		memcpy(ld->buffer+ld->buffer_size, buffer, nbytes);
		ld->buffer_size += nbytes;
		memcpy(ld->buffer+ld->buffer_size, &check, sizeof(char));
		ld->buffer_size += sizeof(char);

		int n = write(ld->sockfd, ld->buffer, ld->buffer_size);
		if (n < 0) {
			dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: write to socket fails, n = %d", n);
		} else if (n < ld->buffer_size) {
			dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: unable to write socket buffer completely, n = %d and buffer_size = %d", n, ld->buffer_size);
		}
		dlog_print(DLOG_DEBUG, LOG_TAG, "write to socket bytes n = %d / %d", n, ld->buffer_size);
		*/

		// aggregate the audio packets and send them only when its size becomes big enough (e.g., 2400)
		/*
		if (ld->buffer_size == 0) { // init a new packet into the buffer
			char action = LIBAS_ACTION_DATA;
			memcpy(ld->buffer, &action, sizeof(char));
			ld->buffer_size += sizeof(char);

			memcpy(ld->buffer+ld->buffer_size, &temp, sizeof(int)); // dummy size for now
			ld->buffer_size += sizeof(int);
		}

		memcpy(ld->buffer+ld->buffer_size, buffer, nbytes);
		ld->buffer_size += nbytes;



		if(ld->buffer_size >= 2400) {
			// update the correct buffer size and add check
			int data_size = htonl(ld->buffer_size - sizeof(char) - sizeof(int));
			memcpy(ld->buffer+sizeof(char), &data_size, sizeof(int)); // dummy size for now

			memcpy(ld->buffer+ld->buffer_size, &check, sizeof(char));
			ld->buffer_size += sizeof(char);

			int n = write(ld->sockfd, ld->buffer, ld->buffer_size);

			if (n < 0) {
				dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: write to socket fails, n = %d", n);
			} else if (n < ld->buffer_size) {
				dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: unable to write socket buffer completely, n = %d and buffer_size = %d", n, ld->buffer_size);
			}
			if(SHOW_DEBUG_MSG) dlog_print(DLOG_DEBUG, LOG_TAG, "write to socket bytes n = %d / %d", n, ld->buffer_size);

			ld->buffer_size = 0;
		}
		*/

		dlog_print(DLOG_DEBUG, LOG_TAG, "nbytes = %d,_audio_read_total = %d", nbytes, _audio_read_total);

		error_code = audio_in_drop(handle); // remove audio data from internal buffer
		CHECK_ERROR_AND_RETURN("audio_in_drop", error_code);
	}
}
