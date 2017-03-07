package umich.cse.yctung.libacousticsensing;

import android.app.Activity;
import android.content.DialogInterface;
import android.util.Log;

/**
 * Created by eddyxd on 9/28/15.
 * basic global variable class
 * )
 */
public class Constant {
    public final static String LOG_TAG = "LAS";
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

    //public static String SERVER_USER_STUDY_ADDR = "192.168.1.114"; // Home + MAC Air
    public static String SERVER_USER_STUDY_ADDR = "35.2.142.245"; // MWireless + MAC Air
    //public static String SERVER_USER_STUDY_ADDR = "141.212.110.161"; // OLAF
    //public static int SERVER_USER_STUDY_PORT_MIN = 50010;
    //public static int SERVER_USER_STUDY_PORT_MAX = 50030;
    public static int SERVER_USER_STUDY_PORT_MIN = 50070;
    public static int SERVER_USER_STUDY_PORT_MAX = 50090;
    public static boolean SERVER_USER_STUDY_TRY_RANDOM_SHUFFLE = true; // disalbe it will search the socket from SERVER_USER_STUDY_PORT_MIN to SERVER_USER_STUDY_PORT_MAX
    public static int SERVER_USER_STUDY_RETRY_CNT = 3; // # of times to search all valid server
    public static long SERVER_USER_STUDY_RETRY_WAIT = 500; // ms for wait for the next round of search -> total search time is about SERVER_USER_STUDY_RETRY_CNT*SERVER_USER_STUDY_RETRY_WAIT
    public static boolean EANBLE_QA_IN_THE_END_OF_USER_STUDY = true;
    public static String USER_STUDY_COMPLETE_CODE = "336689";

    public static int MAX_USER_STUDY_REQUEST_RETRY = 5;

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

    public static String systemPath;
    public static String appFolderName;
    public static String appFolderPath;

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
        check(activity, SERVER_USER_STUDY_ADDR.equals("141.212.110.161"),"Need to chnage IP to OLAF");
        check(activity, EANBLE_QA_IN_THE_END_OF_USER_STUDY, "Need to enable QA");
        check(activity, !TRACE_SAVE_TO_FILE, "No need to save trace");
    }

    public static void check(Activity activity, boolean result, String message){
        if(!result){
            errorWithDialog(activity, message);
        }
    }
}
