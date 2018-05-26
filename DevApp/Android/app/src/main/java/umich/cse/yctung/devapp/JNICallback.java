package umich.cse.yctung.devapp;

import umich.cse.yctung.libacousticsensing.AcousticSensingResult;

/**
 * Created by yctung on 9/24/17.
 */
public class JNICallback {
    static {
        System.loadLibrary("jni_callback");
    }

    native void debugTest();
    native AcousticSensingResult dataCallback(long retAddr);
}
