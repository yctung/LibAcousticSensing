/*
 * setting.c
 *
 *  Created on: Nov 10, 2017
 *      Author: eddyxd
 */
#include "devappwearable.h"

char *button_menu_names[] = {
	"192.168.1.1", "5566",
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
		snprintf(buf, 1023, "%s", button_menu_names[index]);
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

static void
btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	int btn_num = (int)data;

	printf("clicked event on Button:%d\n", btn_num);
}

static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}

static Evas_Object*
create_button_view(Evas_Object *parent)
{
	Evas_Object *btn, *box;
	char buf[64];

	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_padding_set(box, 0, 5 * elm_config_scale_get());
	evas_object_show(box);

	for (int i = 0 ; i < 10 ; i ++)
	{
		btn = elm_button_add(box);
		evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)i);
		snprintf(buf, sizeof(buf), "Default %d", i);
		elm_object_text_set(btn, buf);
		evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(250), ELM_SCALE_SIZE(200));
		evas_object_show(btn);
		elm_box_pack_end(box, btn);
	}

	return box;
}

void
_default_btn_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller, *circle_scroller, *layout;
	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;

	scroller = create_scroller(nf);
	layout = create_button_view(scroller);
	elm_object_content_set(scroller, layout);

	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	nf_it = elm_naviframe_item_push(nf, "Default Styles", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);
}

void
_bottom_btn_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *btn, *ly;
	Evas_Object *nf = (Evas_Object *)data;

	ly = elm_layout_add(nf);
	elm_layout_theme_set(ly, "layout", "bottom_button", "default");
	evas_object_show(ly);

	btn = elm_button_add(nf);
	elm_object_style_set(btn, "bottom");
	elm_object_text_set(btn, "BOTTOM");
	elm_object_part_content_set(ly, "elm.swallow.button", btn);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, NULL);
	evas_object_show(btn);

	elm_naviframe_item_push(nf, "Bottom", NULL, NULL, ly, NULL);
}

void
button_cb(void *data, Evas_Object *obj, void *event_info)
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
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _default_btn_cb, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _bottom_btn_cb, nf);

	elm_genlist_item_append(genlist, ptc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, NULL);

	elm_genlist_item_class_free(ttc);
	elm_genlist_item_class_free(itc);
	elm_genlist_item_class_free(ptc);

	nf_it = elm_naviframe_item_push(nf, "Button", NULL, NULL, genlist, "empty");
}




