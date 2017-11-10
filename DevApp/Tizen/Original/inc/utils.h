/*
 * utils.h
 *
 *  Created on: Sep 14, 2017
 *      Author: eddyxd
 */

#ifndef UTILS_H_
#define UTILS_H_

// yctung: just some common macro useful for debug

#define _PRINT_MSG_LOG_BUFFER_SIZE_ 1024

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "libas"

#define PRINT_MSG(fmt, args...) do { char _log_[_PRINT_MSG_LOG_BUFFER_SIZE_]; \
    snprintf(_log_, _PRINT_MSG_LOG_BUFFER_SIZE_, fmt, ##args); dlog_print(DLOG_DEBUG, LOG_TAG, _log_); } while (0)

#define _DEBUG_MSG_LOG_BUFFER_SIZE_ 1024
#define DLOG_PRINT_DEBUG_MSG(fmt, args...) do { char _log_[_DEBUG_MSG_LOG_BUFFER_SIZE_]; \
    snprintf(_log_, _PRINT_MSG_LOG_BUFFER_SIZE_, fmt, ##args); \
    dlog_print(DLOG_DEBUG, LOG_TAG, _log_); } while (0)

#define DLOG_PRINT_ERROR_MSG(fmt, args...) do { char _log_[_DEBUG_MSG_LOG_BUFFER_SIZE_]; \
    snprintf(_log_, _PRINT_MSG_LOG_BUFFER_SIZE_, fmt, ##args); \
    dlog_print(DLOG_ERROR, LOG_TAG, _log_); } while (0)


#define DLOG_PRINT_ERROR(fun_name, error_code) dlog_print(DLOG_ERROR, LOG_TAG, \
        "%s() failed! Error: %s [code: %d]", \
        fun_name, get_error_message(error_code), error_code)

#define CHECK_ERROR(fun_name, error_code) if (error_code != 0) { \
    DLOG_PRINT_ERROR(fun_name, error_code); \
    }

#define CHECK_ERROR_AND_RETURN(fun_name, error_code) if (error_code != 0) { \
    DLOG_PRINT_ERROR(fun_name, error_code); \
    return; \
    }

/*
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
*/

#endif /* UTILS_H_ */
