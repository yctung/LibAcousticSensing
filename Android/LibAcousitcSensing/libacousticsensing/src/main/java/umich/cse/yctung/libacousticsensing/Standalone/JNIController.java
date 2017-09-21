package umich.cse.yctung.libacousticsensing.Standalone;

/**
 * Created by yctung on 9/20/17.
 */
public class JNIController {
    static {
        System.loadLibrary("standalone");
    }

    // NOTE: these JNI functions can't be recognized by AndroidStudio (but they existed)
    //       because I am using the old script to compile ndk files manually
    public native void testNDK();

    public JNIController(String logFolderPath){

    }
}
