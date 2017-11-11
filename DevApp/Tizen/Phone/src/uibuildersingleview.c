#include "app_main.h"
#include <tizen.h>

int main(int argc, char **argv)
{
	int result = 0;
	app_data *app = uib_app_create();
	if (app)
	{
		result = uib_app_run(app, argc, argv);
		uib_app_destroy(app);
	}

	return result;
}

