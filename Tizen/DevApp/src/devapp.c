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


static void _audio_io_stream_read_cb(audio_in_h handle, size_t nbytes, void *userdata)
{
	appdata_s *ad = userdata;
	const void *buffer = NULL;
	if (nbytes > 0) {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "stream_read_cb is called, nbytes = %d", nbytes);

		//nbytes *= 2; // just for debug

		int error_code = audio_in_peek(handle, &buffer, &nbytes);
		myassert(error_code, 0, "audio_in_peek() failed");

		fwrite(buffer, sizeof(char), nbytes, ad->fout);

		//memcpy(ad->input_buffer+ad->input_buffer_idx, buffer, sizeof(char)*nbytes);
		ad->input_buffer_idx += sizeof(char)*nbytes;
		dlog_print(DLOG_DEBUG, LOG_TAG, "stream_read_cb is called, input_buffer_idx = %d", ad->input_buffer_idx);

		error_code = audio_in_drop(handle); // remove audio data from internal buffer
		myassert(error_code, 0, "audio_in_drop() failed!");
	}
}

//=============================================================================================
// Network related functions
// ref: http://www.cs.rpi.edu/~moorthy/Courses/os98/Pgms/socket.html
//=============================================================================================
static void _keep_reading_socket(void *userdata) {
	appdata_s *ad = userdata;
	// keep reading data
	dlog_print(DLOG_DEBUG, LOG_TAG, "_keep_reading_socket starts");
	int n;
	char action = -1;
	while (1) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "wait to read action");
		n = read(ad->sockfd, &action, 1);
		dlog_print(DLOG_DEBUG, LOG_TAG, "n = %d, action = %d", n, action);
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

	// TODO: send socket init arguments to server

	// read socket in another thread
	ecore_thread_run(_keep_reading_socket, NULL, NULL, ad);
}

//=============================================================================================
// Audio related utility functions
//=============================================================================================
static void start_audio_playing(appdata_s *ad) {
	// 1. load audio to play
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
}

static void stop_audio_playing(appdata_s *ad) {

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


