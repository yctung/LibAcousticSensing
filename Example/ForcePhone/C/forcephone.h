//  2016/05/08: Note this is only for iOS (working as how Androd to link jni functions)

#ifndef _forcephone_h_
#define _forcephone_h_

// NOTE: JNI_FUNC_NAME needs to be declared before include "libas_utils.h"
#ifdef DEV_NDK
#define JNI_FUNC_NAME(name) Java_umich_cse_yctung_demoforcephone_JNICallback_ ## name
#else
#define JNI_FUNC_NAME(name) haha_ ## name
#endif

#define haha 5

#include "libas_utils.h"

#ifdef __cplusplus
extern "C" {
#endif
    JNI_FUNC_HEAD void JNI_FUNC_NAME(debugTest)(JNI_FUNC_NO_PARAM);
    
#ifdef __cplusplus
}
#endif

#endif /* _forcephone_h_ */
