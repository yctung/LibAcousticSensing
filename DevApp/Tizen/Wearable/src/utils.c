/*
 * utils.c
 *
 *  Created on: Nov 12, 2017
 *      Author: eddyxd
 */

#include <devappwearable.h>

static Evas_Object *main_genlist = NULL;
static Evas_Object *setting_genlist = NULL;

void update_genlist(Evas_Object *target_genlist, int index) {
	// refresh the item, ref: https://developer.tizen.org/ko/forums/native-application-development/how-refresh-my-genlist?langswitch=ko
	Elm_Object_Item *it = elm_genlist_nth_item_get(target_genlist, index);
	elm_genlist_item_fields_update(it, NULL, ELM_GENLIST_ITEM_FIELD_TEXT);
}

void update_main_genlist() {
	update_genlist(main_genlist, 0);
	update_genlist(main_genlist, 1);
}

void update_setting_genlist() {
	update_genlist(setting_genlist, 0);
	update_genlist(setting_genlist, 1);
	update_genlist(setting_genlist, 2);
}

void assign_main_genlist(Evas_Object *genlist) {
	main_genlist = genlist;
}

void assign_setting_genlist(Evas_Object *genlist) {
	setting_genlist = genlist;
}
