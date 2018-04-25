package umich.cse.yctung.demoforcephone;

/**
 * Created by yctung on 9/28/17.
 * Just a wrapper of our Android code
 */

public class JNICallback {
    static {
        System.loadLibrary("jnicallback");
    }

    public native void dataCallback(long retAddr);
    public native void debugTest();

    public JNICallback() {
        debugTest();
    }

}
