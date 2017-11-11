

#ifndef __VIEW_DATA_H__
#define __VIEW_DATA_H__

#include <Elementary.h>
#include "uib_views.h"

/**
 * @brief Forward declaration of model
 */
typedef struct _uib_view_data {
	Evas_Object* win;

	uib_view_context* view_main;
} uib_view_data;

static uib_view_data* view_data;

uib_view_data* get_uib_view_data();

#endif /* __VIEW_DATA_H__ */

