package umich.cse.yctung.demoforcephone;

/**
 * Created by yctung on 9/28/17.
 * Just a wrapper of our Android code
 */

public class JNICallback {
    static {
        System.loadLibrary("jnicallback");
    }

    private native void debugTest();

    public JNICallback() {
        debugTest();
    }

}
