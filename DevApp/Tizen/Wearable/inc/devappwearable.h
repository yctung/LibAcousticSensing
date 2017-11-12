#ifndef __devappwearable_H__
#define __devappwearable_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <app_preference.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "devapp"

#if !defined(PACKAGE)
#define PACKAGE "umich.cse.yctung.libas.devapppwearable"
#endif

// some UI definitions
#define ELM_DEMO_EDJ "/opt/usr/apps/umich.cse.yctung.libas.devapppwearable/res/ui_controls.edj"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *layout;
	Evas_Object *nf;
	Evas_Object *label;
	Eext_Circle_Surface *circle_surface;
} appdata_s;

void setting_cb(void *data, Evas_Object *obj, void *event_info);
void button_cb(void *data, Evas_Object * obj, void *event_info);

#endif /* __devappwearable_H__ */
