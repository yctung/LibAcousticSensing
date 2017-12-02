/*
 * 2017/11/12: UI for showing the connection status, here is also the main class to use libas
 */
#include <devappwearable.h>
#include "libas.h"

static Evas_Object *label_status;
static Evas_Object *button_status;
static void updateStatus(char *status) {
	char buf[500];
	sprintf(buf, "<br/><br/><align=center> %s <br/><br/>(click to go back)<br/><br/>", status);
	//elm_object_text_set(label_status, buf);
	elm_object_text_set(button_status, buf);
}

static void _button_cb(void *data, Evas_Object *obj, void *event_info) {
	DLOG_PRINT_DEBUG_MSG("_button_cb");
	appdata_s *ad = (appdata_s *)data;
	elm_naviframe_item_pop(ad->nf);
}

static void _start_libas() {
	char *addr, *port;
	preference_get_string(DEVAPP_PREF_SERVER_ADDR_KEY, &addr);
	preference_get_string(DEVAPP_PREF_SERVER_PORT_KEY, &port);
	libas_init_as_remote_mode(addr, port);

	if (libas_is_ready_for_sensing()) {
		DLOG_PRINT_DEBUG_MSG("libas is ready to sense");
		updateStatus("connect success");
	} else {
		DLOG_PRINT_DEBUG_MSG("libas is not ready to sense");
		updateStatus("connect failed");
	}

}

void status_cb(void *data, Evas_Object * obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *nf = ad->nf;
	Evas_Object *scroller, *layout, *label, *button;

	/* Create Layout */
	layout = elm_layout_add(nf);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "elmdemo-test/scroller");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	/* Create Scroller */
	scroller = elm_scroller_add(layout);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	elm_object_style_set(scroller, "effect");
	evas_object_show(scroller);

	evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);

	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_AUTO, ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	/* Create Content */
	label = elm_label_add(scroller);
	elm_object_text_set(label, "<br/><br/><align=center>Undefined<br/><br/>");
	/*
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_label_wrap_width_set(label, 360);
	evas_object_size_hint_weight_set(label, 0.5, 0.5);
	evas_object_size_hint_align_set(label, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(label);
	label_status = label;
	*/

	button = elm_button_add(scroller);
	elm_object_text_set(button, "<aligh=center>Test</align>");
	evas_object_size_hint_weight_set(button, 0.5, 0.5);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(button);
	evas_object_smart_callback_add(button, "clicked", _button_cb, ad);
	button_status = button;

	elm_object_part_content_set(layout, "scroller", scroller);
	elm_object_content_set(scroller, button);

	Elm_Object_Item *it = elm_naviframe_item_push(nf, "Scroller", NULL, NULL, layout, "empty");
	elm_naviframe_item_title_enabled_set(it, EINA_FALSE, EINA_FALSE);

	/* Content Set*/
	elm_object_part_content_set(layout, "scroller", scroller);

	_start_libas();
}
