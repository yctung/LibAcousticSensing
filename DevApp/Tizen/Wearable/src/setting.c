// UI to input control elements

#include "devappwearable.h"

Elm_Theme *theme;

char *entry_menu_names[] = {
	"Single line entry", "Password entry", "Done",
	NULL
};

typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

static void
gl_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = (Elm_Object_Item *)event_info;
	elm_genlist_item_selected_set(it, EINA_FALSE);
}

static char *
_gl_menu_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];

	snprintf(buf, 1023, "%s", "Setting");
	return strdup(buf);
}

static char *
_gl_menu_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	item_data *id = (item_data *)data;
	int index = id->index;

	if (!strcmp(part, "elm.text")) {
		if (index == 0) { // IP
			char *addr;
			preference_get_string(DEVAPP_PREF_SERVER_ADDR_KEY, &addr);
			sprintf(buf, "IP=%s", addr);
		} else if (index == 1) { // port
			char *port;
			preference_get_string(DEVAPP_PREF_SERVER_PORT_KEY, &port);
			sprintf(buf, "port=%s", port);
		} else {
			//snprintf(buf, 1023, "%s", "Undefined");
			snprintf(buf, 1023, "%s", entry_menu_names[index]);
		}

		return strdup(buf);
	}
	return NULL;
}

static void
_gl_menu_del(void *data, Evas_Object *obj)
{
	// FIXME: Unrealized callback can be called after this.
	// Accessing Item_Data can be dangerous on unrealized callback.
	item_data *id = (item_data *)data;
	if (id) free(id);
}

Evas_Object *to_del;
static void response_cb(void *data, Evas_Object *obj, void *event_info)
{
	if (to_del) {
		evas_object_del(to_del);
		to_del = NULL;
	}
	evas_object_del(obj);
}

void maxlength_reached(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup;
	Evas_Object *nf = (Evas_Object *)data;
	appdata_s *ad;
	if (to_del) return;

	ad = (appdata_s *)data;

	popup = elm_popup_add(nf);
	elm_object_style_set(popup, "toast/circle");
	elm_popup_orient_set(popup, ELM_POPUP_ORIENT_BOTTOM);
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_popup_timeout_set(popup, 2.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, response_cb, NULL);
	evas_object_smart_callback_add(popup, "block,clicked", response_cb, NULL);
	evas_object_smart_callback_add(popup, "timeout", response_cb, NULL);
	elm_object_part_text_set(popup, "elm.text", "Maximum length reached");

	evas_object_show(popup);
	to_del = popup;
}



static Evas_Object *current_nf;
static void __entry_enter_click(void *data, Evas_Object *obj, void *event_info, char *key)
{
	const char* text = elm_entry_entry_get(obj);
	dlog_print(DLOG_INFO, LOG_TAG, "enter for key = %s is clicked, text = %s", key, text);
	preference_set_string(key, text);

	update_setting_genlist();
	update_main_genlist();

	elm_naviframe_item_pop(current_nf);
}

static void _setting_addr_entry_enter_click(void *data, Evas_Object *obj, void *event_info) {
	__entry_enter_click(data, obj, event_info, DEVAPP_PREF_SERVER_ADDR_KEY);
}

static void _setting_port_entry_enter_click(void *data, Evas_Object *obj, void *event_info) {
	__entry_enter_click(data, obj, event_info, DEVAPP_PREF_SERVER_PORT_KEY);
}

// internal function to create the entry
// we have a customized "index" argument since I don't know why Tizen stupidly don't assign the object item_data correctly
static void __single_line_entry_cb(void *data, Evas_Object *obj, void *event_info, int index)
{
	Evas_Object *entry;
	Evas_Object *layout;
	Evas_Object *scroller;
	Evas_Object *nf = (Evas_Object *)data;
	static Elm_Entry_Filter_Limit_Size limit_filter_data;
	// will not working..... TODO: know why...WTF
	/*
	item_data *id =  elm_object_item_data_get(obj);
	int index = -1;
	if (id != NULL) {
		index = id->index;
	}*/

	scroller = elm_scroller_add(nf);
	evas_object_size_hint_align_set(scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	layout = elm_layout_add(scroller);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "entry_layout");
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, 0.0);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, 0.0);

	entry = elm_entry_add(layout);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_scroller_policy_set(entry, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_smart_callback_add(entry, "maxlength,reached", maxlength_reached, nf);
	elm_entry_input_panel_layout_set(entry, ELM_INPUT_PANEL_LAYOUT_IP);

	limit_filter_data.max_char_count = 0;
	limit_filter_data.max_byte_count = 100;
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &limit_filter_data);
	elm_object_part_text_set(entry, "elm.guide", "input your text");
	char *toshow = "undefined";
	if (index == 0) { // server address
		preference_get_string(DEVAPP_PREF_SERVER_ADDR_KEY, &toshow);
		evas_object_smart_callback_add(entry, "activated", _setting_addr_entry_enter_click, NULL);
	} else if (index == 1) { // server port
		preference_get_string(DEVAPP_PREF_SERVER_PORT_KEY, &toshow);
		evas_object_smart_callback_add(entry, "activated", _setting_port_entry_enter_click, NULL);
	}
	elm_entry_entry_set(entry, toshow);

	elm_entry_cursor_end_set(entry);
	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);


	elm_object_part_content_set(layout, "entry_part", entry);
	elm_object_content_set(scroller, layout);

	elm_naviframe_item_push(nf, _("Single line entry"), NULL, NULL, scroller, "empty");
}

static void _setting_addr_entry_cb(void *data, Evas_Object *obj, void *event_info) {
	__single_line_entry_cb(data, obj, event_info, 0 /* server addr */);
}

static void _setting_port_entry_cb(void *data, Evas_Object *obj, void *event_info) {
	__single_line_entry_cb(data, obj, event_info, 1 /* server port */);
}

static void _setting_done_cb(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *nf = (Evas_Object *)data;
	elm_naviframe_item_pop(nf);
}

/* UI function to create entries */
void setting_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *genlist;
	Evas_Object *circle_genlist;
	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;
	Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *ttc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *ptc = elm_genlist_item_class_new();
	item_data *id;
	int index = 0;

	genlist = elm_genlist_add(nf);
	elm_genlist_mode_set(genlist, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(genlist, "selected", gl_selected_cb, NULL);

	circle_genlist = eext_circle_object_genlist_add(genlist, ad->circle_surface);
	eext_circle_object_genlist_scroller_policy_set(circle_genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_genlist, EINA_TRUE);

	ttc->item_style = "title";
	ttc->func.text_get = _gl_menu_title_text_get;
	ttc->func.del = _gl_menu_del;

	itc->item_style = "default";
	itc->func.text_get = _gl_menu_text_get;
	itc->func.del = _gl_menu_del;

	ptc->item_style = "padding";
	ptc->func.del = _gl_menu_del;

	elm_genlist_item_append(genlist, ttc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, NULL);

	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _setting_addr_entry_cb, nf);

	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _setting_port_entry_cb, nf);

	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _setting_done_cb, nf);

	elm_genlist_item_append(genlist, ptc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, NULL);

	elm_genlist_item_class_free(ttc);
	elm_genlist_item_class_free(itc);
	elm_genlist_item_class_free(ptc);

	assign_setting_genlist(genlist);

	current_nf = nf;
	nf_it = elm_naviframe_item_push(nf, "Entry", NULL, NULL, genlist, "empty");
}
