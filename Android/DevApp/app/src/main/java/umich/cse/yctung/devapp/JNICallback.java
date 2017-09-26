package umich.cse.yctung.devapp;

/**
 * Created by yctung on 9/24/17.
 */
public class JNICallback {
    static {
        System.loadLibrary("jni_callback");
    }

    native void debugTest();
    native void dataCallback(long retAddr);
}
