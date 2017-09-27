#include <devapp.h>

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *button;
} appdata_s;


#define STATUS_WAIT_INIT 0
#define STATUS_WAIT_SENSING 1
#define STATUS_WAIT_STOP 2

#define STATUS_DEFAULT STATUS_WAIT_INIT

static int status = STATUS_DEFAULT;


static void button_clicked_request_cb(void *data, Evas_Object *obj, void *event_info) {
	dlog_print(DLOG_DEBUG, LOG_TAG, "button is clicked");
	appdata_s *ad = data;

	//------------------------------------------------
	// 1. wait to init the audio device
	//------------------------------------------------
	if (status == STATUS_WAIT_INIT) {

		libas_init(true);

		if (libas_is_ready_for_sensing()) {
			status = STATUS_WAIT_SENSING;
			elm_object_text_set(ad->button, "<aligh=center>Start</align>");
		} else {
			elm_object_text_set(ad->button, "<aligh=center>Fail, retry?</align>");
		}
	//------------------------------------------------
	// 2. wait to start sensing
	//------------------------------------------------
	} else if (status == STATUS_WAIT_SENSING) {
		libas_start_sensing();

		status = STATUS_WAIT_STOP;
		elm_object_text_set(ad->button, "<aligh=center>Stop</align>");
	//------------------------------------------------
	// 3. wait to stop sensing
	//------------------------------------------------
	} else if (status == STATUS_WAIT_STOP) {
		libas_stop_sensing();

		status = STATUS_WAIT_SENSING;
		elm_object_text_set(ad->button, "<aligh=center>Start</align>");
	}
}

/*
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
*/

static void button_clicked_test_cb(void *data, Evas_Object *obj, void *event_info) { // this is for only testing mode
	dlog_print(DLOG_DEBUG, LOG_TAG, "button is clicked for test");
	appdata_s *ad = data;
	if (status == STATUS_WAIT_SENSING) { // need to start sensing
		//data_initialize();
		//start_recordtest_async();
		status = STATUS_WAIT_SENSING;
		elm_object_text_set(ad->button, "<aligh=center>Test recording</align>");
	} else {
		//data_finalize();
		status = STATUS_WAIT_STOP;
		elm_object_text_set(ad->button, "<aligh=center>Test stopped</align>");
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

#ifdef IS_TESTING_RECORD // no need to allocate audio input/out by ourselves
	ad->button = elm_button_add(ad->conform);
	elm_object_text_set(ad->button, "<aligh=center>Test</align>");
	elm_object_content_set(ad->conform, ad->button);
	evas_object_smart_callback_add(ad->button, "clicked", button_clicked_test_cb, ad);
	dlog_print(DLOG_DEBUG, LOG_TAG, "button is added");

	evas_object_show(ad->win);
	//data_initialize();
	return; // early return
#endif

	ad->button = elm_button_add(ad->conform);
	elm_object_text_set(ad->button, "<aligh=center>Init</align>");
	//evas_object_size_hint_weight_set(ad->button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->button);
	evas_object_smart_callback_add(ad->button, "clicked", button_clicked_request_cb, ad);
	dlog_print(DLOG_DEBUG, LOG_TAG, "button is added");

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


