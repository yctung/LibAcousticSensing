package umich.cse.yctung.libacousticsensing;

import android.app.Activity;
import android.content.DialogInterface;
import android.os.Environment;
import android.util.Log;

/**
 * Created by eddyxd on 9/28/15.
 * basic global variable class
 * )
 */
public class Constant {
    public final static String LOG_TAG = "LibAS"; // Global tag


    public final static String LIB_FOLDER_NAME = "LibAS";
    public final static String NDK_TRACE_FOLDER_NAME = "ndk";
    public static String libFolderPath = ""; // to be defined by initGlobalConstant
    public static String ndkTraceFolderName = ""; // to be defined by initGlobalConstant
    public static void initGlobalConstant() {
        String systemPath = Environment.getExternalStorageDirectory().getAbsolutePath() + "/";
        libFolderPath = systemPath + LIB_FOLDER_NAME + "/";
        ndkTraceFolderName = libFolderPath + NDK_TRACE_FOLDER_NAME + "/";
    }

    public static float DEFAULT_VOL = 1.0f;

    public final static String SETTING_JSON_FILE_NAME = "SafeSpeech.json";

    public static boolean TRACE_SAVE_TO_FILE = false;
    public static boolean TRACE_SEND_TO_NETWORK = true;
    public static boolean FORCE_TO_USE_TOP_SPEAKER = false;

    public static boolean HIDE_DEBUG_UI = true; // use it before release the app for tester

    // Networking setting
    //public static String SERVER_ADDR = "192.168.1.114"; // Home
    //public static String SERVER_ADDR = "10.0.0.12"; // Office
    public static String SERVER_ADDR = "35.2.167.67"; // MWireless
    public static int DETECTER_SERVER_PORT = 50009;

    public static boolean APP_RELEASE_TO_USER = false;




    public final static String INPUT_FOLDER = "AudioInput/";
    public final static String INPUT_PREFIX = "source_";
    public static final String OUTPUT_FOLDER = "DataOutput/";
    public static final String DEBUG_FOLDER = "DebugOutput/";
    public static final String JNI_LOG_FOLER = "log/";

    // detailed control variables -> most used for debug
    public static boolean SURVEY_DUMP_RAW_BYTE_DATA_TO_FILE = true; // data dumpted for matlab parser

    // contorl of survey mode (predict or train)
    public final static int SURVEY_MODE_TRAIN = 1;
    public final static int SURVEY_MODE_PREDICT = 2;

    public static void errorWithDialog(final Activity activity, final String message){
        Log.e(Constant.LOG_TAG, "[ERROR]: "+message);
        activity.runOnUiThread(new Runnable() {
            @Override
            public void run() {
                Utils.showSimpleAlertDialog(activity, "Error", message);
            }
        });
    }

    public static void errorWithDialogWithCallback(final Activity activity, final String message, final DialogInterface.OnClickListener callback){
        Log.e(Constant.LOG_TAG, "[ERROR]: "+message);
        activity.runOnUiThread(new Runnable() {
            @Override
            public void run() {
                Utils.showSimpleAlertDialogWithCallback(activity, "Error", message, callback);
            }
        });
    }

    // check if the set varaible is ok
    public static String isValidSetting(){
        // TODO: update setting rules

        return null; // return null means everything is ok
    }


    // This function check all the setting meets the final product guideline
    public static void appReleaseCheck(Activity activity){
        check(activity, !TRACE_SAVE_TO_FILE, "No need to save trace");
    }

    public static void check(Activity activity, boolean result, String message){
        if(!result){
            errorWithDialog(activity, message);
        }
    }
}
