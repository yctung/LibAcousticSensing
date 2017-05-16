#include <devapp.h>


typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *button;
	audio_in_h input;
	audio_out_h output;
	void *buffer;
	int buffer_size;

	void *output_buffer[882000];
	int output_buffer_size;

	char base_path[200];
	void *input_buffer[882000];
	int input_buffer_idx;

	FILE *fout;

	int sockfd;

	// sensing audio
	void *pilot;
	int pilot_byte_size;
	void *signal;
	int signal_byte_size;
} appdata_s;

#define STATUS_WAIT_SENSING 0
#define STATUS_IS_SENSING 1
int status = STATUS_WAIT_SENSING;

bool myassert(int error_code, int error_code_ok, const char* msg) {
	if (error_code != error_code_ok) {
		dlog_print(DLOG_ERROR, LOG_TAG, msg);
		char* error_msg;
		error_msg = get_error_message(error_code);
		dlog_print(DLOG_ERROR, LOG_TAG, error_msg);
		return false;
	}
	return true;
}


//=============================================================================================
// Audio related utility functions
//=============================================================================================
static void _audio_io_stream_read_cb(audio_in_h handle, size_t nbytes, void *userdata)
{
	appdata_s *ad = userdata;
	const void *buffer = NULL;
	if (nbytes > 0) {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "stream_read_cb is called, nbytes = %d", nbytes);

		//nbytes *= 2; // just for debug

		int error_code = audio_in_peek(handle, &buffer, &nbytes);
		myassert(error_code, 0, "audio_in_peek() failed");

		// write to a file
		/*
		fwrite(buffer, sizeof(char), nbytes, ad->fout);
		//memcpy(ad->input_buffer+ad->input_buffer_idx, buffer, sizeof(char)*nbytes);
		ad->input_buffer_idx += sizeof(char)*nbytes;
		dlog_print(DLOG_DEBUG, LOG_TAG, "stream_read_cb is called, input_buffer_idx = %d", ad->input_buffer_idx);
		*/

		// write to socket
		int temp = htonl(nbytes);
		char check = -1;

		ad->buffer_size = 0;

		char action = LIBAS_ACTION_DATA;
		memcpy(ad->buffer, &action, sizeof(char));
		ad->buffer_size += sizeof(char);
		memcpy(ad->buffer+ad->buffer_size, &temp, sizeof(int));
		ad->buffer_size += sizeof(int);
		memcpy(ad->buffer+ad->buffer_size, buffer, nbytes);
		ad->buffer_size += nbytes;
		memcpy(ad->buffer+ad->buffer_size, &check, sizeof(char));
		ad->buffer_size += sizeof(char);

		int n = write(ad->sockfd, ad->buffer, ad->buffer_size);
		if (n < 0) {
			dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: write to socket fails, n = %d", n);
		} else if (n < ad->buffer_size) {
			dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: unable to write socket buffer completely, n = %d and buffer_size = %d", n, ad->buffer_size);
		}
		dlog_print(DLOG_DEBUG, LOG_TAG, "write to socket bytes n = %d / %d", n, ad->buffer_size);


		error_code = audio_in_drop(handle); // remove audio data from internal buffer
		myassert(error_code, 0, "audio_in_drop() failed!");
	}
}

// this need to be executed in a separate thread to avoid hanging the UI thread
// yctung: this would not work, it seems that I have overflowed the audio buffer
bool _need_to_keep_audio_playing = false;
static void _keep_audio_playing(appdata_s *ad) {
	// 1. enable audio playing
	dlog_print(DLOG_DEBUG, LOG_TAG, "_keep_audio_playing starts");
	_need_to_keep_audio_playing = true;
	int error_code = audio_out_prepare(ad->output);
	myassert(error_code, 0, "audio_out_prepare() fails");

	// 2. play pilot
	dlog_print(DLOG_DEBUG, LOG_TAG, "pilot_byte_size = %d", ad->pilot_byte_size);
	int bytes_number = audio_out_write(ad->output, ad->pilot, ad->pilot_byte_size);
	dlog_print(DLOG_DEBUG, LOG_TAG, "bytes_number being played = %d", bytes_number);


	// 3. play signal
	while(_need_to_keep_audio_playing) {
		//int bytes_number = audio_out_write(ad->output, ad->signal, ad->signal_byte_size);

		int bytes_number = audio_out_write(ad->output, ad->pilot, ad->pilot_byte_size);

		dlog_print(DLOG_DEBUG, LOG_TAG, "bytes_number being played = %d", bytes_number);

		if (bytes_number < 0) {
			char* error_msg;
			error_msg = get_error_message(bytes_number);
			dlog_print(DLOG_ERROR, LOG_TAG, error_msg);
		}

	}

	// 4. release audio interface
	error_code = audio_out_unprepare(ad->output);
	myassert(error_code, 0, "audio_out_unprepare() fails");
	dlog_print(DLOG_DEBUG, LOG_TAG, "_keep_audio_playing ends");
}

// callback for play audio asynchronously
void *_latest_play_buffer;
int _latest_play_buffer_size;
int _latest_play_buffer_offset;
void _audio_io_stream_write_cb(audio_out_h handle, size_t nbytes, void *userdata)
{
    appdata_s *ad = userdata;
    char * buffer = NULL;
    int buffer_offset = 0;
	if (nbytes > 0) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "_audio_io_stream_write_cb is called, nbytes = %d", nbytes);

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

    	  if (_latest_play_buffer == ad->pilot && _latest_play_buffer_offset == 0) { // means the whole play_buffer is pilot and has been finished
    		  // switch pilot to signal buffer here
    		  _latest_play_buffer = ad->signal;
    		  _latest_play_buffer_size = ad->signal_byte_size;
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


static void start_audio_playing(appdata_s *ad) {
	// method 1: play audio by a while loop in another thread -> fails after few seconds
	// ecore_thread_run(_keep_audio_playing, NULL, NULL, ad);


	// method 2: play audio in the callback manner
	_latest_play_buffer = ad->pilot;
	_latest_play_buffer_size = ad->pilot_byte_size;
	_latest_play_buffer_offset = 0;
	int error_code = audio_out_set_stream_cb(ad->output, _audio_io_stream_write_cb, ad);
	myassert(error_code, 0, "audio_out_set_stream_cb() fails");
	error_code = audio_out_prepare(ad->output);
	myassert(error_code, 0, "audio_out_prepare() fails");



	// 1. load audio to play
	/*
	char fin_path[200];
	sprintf(fin_path, "%s%s", ad->base_path, "audio.pcm");
	struct stat info;
	stat(fin_path, &info);
	ad->output_buffer_size = info.st_size;
	dlog_print(DLOG_DEBUG, LOG_TAG, "output_buffer_size = %d", ad->output_buffer_size);

	FILE *fin = fopen(fin_path, "rb");
	size_t res = fread(ad->output_buffer, sizeof(char), ad->output_buffer_size, fin);
	dlog_print(DLOG_DEBUG, LOG_TAG, "fread res = %d", res);
	fclose(fin);
	dlog_print(DLOG_DEBUG, LOG_TAG, "buffer = [%x,%x,%x,%x,...]", ad->output_buffer[0], ad->output_buffer[1], ad->output_buffer[2], ad->output_buffer[3]);


	// 2. play audio
	int error_code = audio_out_prepare(ad->output);
	myassert(error_code, 0, "audio_out_prepare() fails");

	int bytes_number = audio_out_write(ad->output, ad->output_buffer, ad->output_buffer_size);
	dlog_print(DLOG_DEBUG, LOG_TAG, "bytes_number being played = %d", bytes_number);

	// 3. release audio
	error_code = audio_out_unprepare(ad->output);
	myassert(error_code, 0, "audio_out_unprepare() fails");

	*/
}

static void stop_audio_playing(appdata_s *ad) {
	dlog_print(DLOG_DEBUG, LOG_TAG, "stop_audio_playing is called");
	_need_to_keep_audio_playing = false; // this flag force the audio playing loop to stop
}

static void start_audio_recording(appdata_s *ad) {
	// 1. create the file to record
	dlog_print(DLOG_DEBUG, LOG_TAG, ad->base_path);
	char fout_path[200];
	sprintf(fout_path, "%s%s", ad->base_path, "yctung_w.pcm");
	dlog_print(DLOG_DEBUG, LOG_TAG, fout_path);
	ad->input_buffer_idx = 0;

	ad->fout = fopen(fout_path, "w");
	if (!ad->fout) {
		dlog_print(DLOG_ERROR, LOG_TAG, "unable to open file for recording");
	}

	// 2. start async recording
	int error_code = audio_in_set_stream_cb(ad->input, _audio_io_stream_read_cb, ad);
	myassert(error_code, 0, "unable to set stream input callback");
	error_code = audio_in_prepare(ad->input);
	myassert(error_code, 0, "unable to prepare audio input");
}

static void stop_audio_recording(appdata_s *ad) {
	// 1. stop audio recording
	int error_code;
	error_code = audio_in_unprepare(ad->input);
	myassert(error_code, 0, "unable to unprepare audio input");

	error_code = audio_in_unset_stream_cb(ad->input);
	myassert(error_code, 0, "audio_in_unset_stream_cb fails");
	// NOTE: don't destroy the class here, so we can reuse the class for the next recording

	// 2. close the recorded file
	fwrite(ad->input_buffer, sizeof(char), ad->input_buffer_idx, ad->fout);
	fflush(ad->fout);
	fclose(ad->fout);
	ad->fout = NULL;
}

//=============================================================================================
// Network related functions
// ref: http://www.cs.rpi.edu/~moorthy/Courses/os98/Pgms/socket.html
//=============================================================================================

static int blockread(int sockfd, void* dest, int size) {
	int size_has_been_read = 0;
	while (size_has_been_read < size) {
		int n = read(sockfd, dest+size_has_been_read, size-size_has_been_read);
		size_has_been_read += n;
	}
	return size_has_been_read;
}

static void _keep_reading_socket(void *userdata) {
	appdata_s *ad = userdata;
	// keep reading data
	dlog_print(DLOG_DEBUG, LOG_TAG, "_keep_reading_socket starts");
	int n;
	char reaction = -1;
	while (1) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "wait to read action");
		n = read(ad->sockfd, &reaction, 1);
		dlog_print(DLOG_DEBUG, LOG_TAG, "n = %d, reaction = %d", n, reaction);
		if (n!=1) {
			// TODO: error handling
			dlog_print(DLOG_ERROR, LOG_TAG, "read reaction fails, n = %d ", n);
			break;
		}

		// parse reaction
		if (reaction == LIBAS_REACTION_ASK_SENSING) {
			dlog_print(DLOG_DEBUG, LOG_TAG, "reaction == LIBAS_REACTION_ASK_SENSING");
			start_audio_recording(ad); // remember to start recording before playing the sensing audio
			start_audio_playing(ad);
		} else if (reaction == LIBAS_REACTION_STOP_SENSING) {
			dlog_print(DLOG_DEBUG, LOG_TAG, "reaction == LIBAS_REACTION_STOP_SENSING");
			stop_audio_recording(ad);
			stop_audio_playing(ad);
		} else if (reaction == LIBAS_REACTION_SET_MEDIA) {
			dlog_print(DLOG_DEBUG, LOG_TAG, "reaction == LIBAS_REACTION_SET_MEDIA");
			int temp;
			n = blockread(ad->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read FS, n = %d", n);
			int FS = ntohl(temp);
			n = blockread(ad->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read chCnt, n = %d", n);
			int chCnt = ntohl(temp);
			n = blockread(ad->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read repeatCnt, n = %d", n);
			int repeatCnt = ntohl(temp);
			dlog_print(DLOG_DEBUG, LOG_TAG, "FS = %d, chCnt = %d, repeatCnt = %d", FS, chCnt, repeatCnt);

			// read pilot
			n = blockread(ad->sockfd, &temp, sizeof(int)); if (n!=sizeof(int)) dlog_print(DLOG_ERROR, LOG_TAG, "wrong # of byte read, n = %d", n);
			int shortToRead = ntohl(temp);
			ad->pilot_byte_size = sizeof(int16_t)*shortToRead;
			dlog_print(DLOG_DEBUG, LOG_TAG, "shortToRead = %d", shortToRead);

			int16_t *pilot = (int16_t *) malloc(sizeof(int16_t)*shortToRead);
			n = blockread(ad->sockfd, pilot, sizeof(int16_t)*shortToRead);
			dlog_print(DLOG_DEBUG, LOG_TAG, "pilot[0..2] = %d, %d, %d ...", pilot[0], pilot[1], pilot[2]);
			ad->pilot = pilot;

			// read signal
			n = blockread(ad->sockfd, &temp, sizeof(int));
			shortToRead = ntohl(temp);
			ad->signal_byte_size = sizeof(int16_t)*shortToRead;
			dlog_print(DLOG_DEBUG, LOG_TAG, "shortToRead = %d", shortToRead);

			int16_t *signal = (int16_t *) malloc(sizeof(int16_t)*shortToRead);
			n = blockread(ad->sockfd, signal, sizeof(int16_t)*shortToRead);
			dlog_print(DLOG_DEBUG, LOG_TAG, "signal[0..2] = %d, %d, %d ...", signal[0], signal[1], signal[2]);
			ad->signal = signal;

			char check;
			n = read(ad->sockfd, &check, 1);
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

static void connect_sensing_server(void *userdata) {
	appdata_s *ad = userdata;
	// open a client socket to connect
	struct sockaddr_in server_addr;
	struct hostent *server;
	ad->sockfd = socket(AF_INET, SOCK_STREAM, 0);
	server = gethostbyname(SERVER_ADDR);
	if (server == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Undefined host");
	}
	bzero((char*) &server_addr, sizeof(server_addr));
	server_addr.sin_family = AF_INET;
	bcopy((char*) server->h_addr, (char*) &server_addr.sin_addr.s_addr, server->h_length);
	server_addr.sin_port = htons(SERVER_PORT);

	if (connect(ad->sockfd, (struct sockaddr*) &server_addr, sizeof(server_addr)) < 0){
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
	      ad->sockfd,     // Socket descriptor
	      SOL_SOCKET, // To manipulate options at the sockets API level
	      SO_RCVTIMEO,// Specify the receiving or sending timeouts
	      ptr, // option values
	      sizeof(t)
	 );


	// read socket in another thread
	ecore_thread_run(_keep_reading_socket, NULL, NULL, ad);

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

	int n = write(ad->sockfd, buffer, buffer_size);
	if (n < 0) {
		dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: write to socket fails, n = %d", n);
	} else if (n < buffer_size) {
		dlog_print(DLOG_ERROR, LOG_TAG, "[ERROR]: unable to write socket buffer completely, n = %d and buffer_size = %d", n, buffer_size);
	}
	dlog_print(DLOG_DEBUG, LOG_TAG, "write to socket bytes n = %d / %d", n, buffer_size);

	// b. send init
	buffer[0] = LIBAS_ACTION_INIT;
	n = write(ad->sockfd, buffer, 1);
}



static void start_sensing(appdata_s *ad) {
	start_audio_recording(ad);
	start_audio_playing(ad);
}

static void stop_sensing(appdata_s *ad) {
	stop_audio_recording(ad);
	stop_audio_playing(ad);
}





static void button_clicked_request_cb(void *data, Evas_Object *obj, void *event_info) {
	dlog_print(DLOG_DEBUG, LOG_TAG, "button is clicked");
	appdata_s *ad = data;
	if (status == STATUS_WAIT_SENSING) { // need to start sensing
		//start_sensing(ad);
		connect_sensing_server(ad);
		status = STATUS_IS_SENSING;
		elm_object_text_set(ad->button, "<aligh=center>Sensing</align>");
	} else {
		//stop_sensing(ad);
		status = STATUS_WAIT_SENSING;
		elm_object_text_set(ad->button, "<aligh=center>Stopped</align>");
	}
}

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

// recording callback (called each time the data is avaialbe)
//void _audio_io_stream_

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

// ref: https://developer.tizen.org/ko/development/training/native-application/creating-applications-multimedia/audio-playback-and-recording?langredirect=1
int internal_storage_id = -1;
static bool
storage_cb(int storage_id, storage_type_e type, storage_state_e state, const char *path, void *user_data)
{
    if (type == STORAGE_TYPE_INTERNAL) {
        internal_storage_id = storage_id;

        return false;
    }

    return true;
}


static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
	ad->label = elm_label_add(ad->conform);
	elm_object_text_set(ad->label, "<align=center>Ker Tizen</align>");
	//evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->label);
	dlog_print(DLOG_DEBUG, LOG_TAG, "label is added");

	ad->button = elm_button_add(ad->conform);
	elm_object_text_set(ad->button, "<aligh=center>Start</align>");
	//evas_object_size_hint_weight_set(ad->button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->button);
	evas_object_smart_callback_add(ad->button, "clicked", button_clicked_request_cb, ad);
	dlog_print(DLOG_DEBUG, LOG_TAG, "button is added");

	//===========================================================
	//               test of audio in/out api
	//===========================================================
	int error_code = 0;

	error_code = audio_in_create(SAMPLE_RATE, AUDIO_CHANNEL_MONO, AUDIO_SAMPLE_TYPE_S16_LE, &ad->input);
	//error_code = audio_in_create(SAMPLE_RATE, AUDIO_CHANNEL_MONO, AUDIO_SAMPLE_TYPE_U8, &ad->input);
	myassert(error_code, AUDIO_IO_ERROR_NONE, "unable to create audio input");

	error_code = audio_out_create(SAMPLE_RATE, AUDIO_CHANNEL_MONO, AUDIO_SAMPLE_TYPE_S16_LE, SOUND_TYPE_SYSTEM, &ad->output);
	myassert(error_code, AUDIO_IO_ERROR_NONE, "unable to create audio output");


	error_code = audio_in_get_buffer_size(ad->input, &ad->buffer_size); // return the required buffer size for each "100ms"
	dlog_print(DLOG_DEBUG, LOG_TAG, "buffer_size = %d", ad->buffer_size);

	ad->buffer_size *= 10 * RECORDING_SEC; //
	ad->buffer = malloc(ad->buffer_size);

	// create a file to save the recorded data
	char io_stream_w_path[200];
	char *storage_path;

	error_code = storage_foreach_device_supported(storage_cb, NULL);
	myassert(error_code, 0, "unable to find storage id");

	error_code = storage_get_directory(internal_storage_id, STORAGE_DIRECTORY_SOUNDS, &storage_path);
	myassert(error_code, 0, "unable to get directory");
	//error_code = storage_get_directory()

	sprintf(ad->base_path, "%s/", storage_path);  // just copy to reference





	/*
	error_code = audio_in_prepare(ad->input);
	myassert(error_code, 0, "unable to prepare audio input");


	int bytes_number = audio_in_read(ad->input, ad->buffer, ad->buffer_size);
	dlog_print(DLOG_DEBUG, LOG_TAG, "read buffer byte = %d", bytes_number);


	error_code = audio_in_unprepare(ad->input);
	myassert(error_code, 0, "unable to unprepare audio input");


	// play by audio player
	error_code = audio_out_prepare(ad->output);
	myassert(error_code, 0, "unable to prepare audio output");

	bytes_number = audio_out_write(ad->output, ad->buffer, ad->buffer_size);
	dlog_print(DLOG_DEBUG, LOG_TAG, "write buffer byte = %d", bytes_number);

	error_code = audio_out_unprepare(ad->output);
	myassert(error_code, 0, "unable to unprepare audio output");
	*/

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}




static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}


