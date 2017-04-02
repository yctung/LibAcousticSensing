package umich.cse.yctung.demoforcephone;

import android.content.Context;
import android.media.AudioManager;
import android.media.MediaRecorder;
import android.util.Log;

/**
 * Created by eddyxd on 4/25/16.
 * Note this D class means device-specific setting -> needs to be consistent to the matlab setting
 */
public class D {
    // constant setting
    static final int CODE_ANDROID = 1;

    // NOTE this setting must meet the REPLY_MODE setting in JNI/cpp
    public static final int DETECT_PSE = 1;
    public static final int DETECT_SSE = 2;
    public static final int DETECT_LOC = 3; // EchoTag location sensing
    public static final int DETECT_DEFAULT = DETECT_PSE;

    static Context context;

    // Detection mode setting
    public static int detectMode = DETECT_DEFAULT;


    // Matlab-shared setting variables
    public static int code = CODE_ANDROID; // android default code
    public static String name = null;
    public static String modelName = null;
    public static int FS = -1;
    public static int PSE_DETECT_CH_IDX = -1; // *** WARN: c++/java is counted from 0 -> need to minus 1
    public static int SSE_DETECT_CH_IDX = -1;

    // Android-only setting variables
    public static double PLAYER_VOL = Constant.DEFAULT_VOL;
    public static double SYSTEM_VOL = 0.5;
    public static int RECORD_SOURCE = MediaRecorder.AudioSource.MIC;

    // Application setting varaibles
    public static double appPressureButtonThres = 0.9;
    public static double appPressureEngineSoundScaleMax = 0.4;

    public static int BIG_MOTION_DETECT_IN_RANGE_SAMPLE_SIZE = 48000*1; // i.e. 1 sec
    public static double BIG_MOTION_DETECT_IN_ACC_METRIC_THRE = 0.5;
    public static double BIG_MOTION_DETECT_IN_ACC_MAX_THRE = 1.0;
    public static double BIG_MOTION_DETECT_IN_GYRO_METRIC_THRE = 1.0;
    public static double BIG_MOTION_DETECT_IN_GYRO_MAX_THRE = 2.5;
    public static int BIG_MOTION_DETECT_MAX_RESET_DELAY = 1500; // ms

    // set the setting based on input modelName
    static void initBasedOnModelName(String modelNameIn){
        modelName = modelNameIn;

        if(modelName.equals("SAMSUNG-SM-G925A") || modelName.indexOf("SAMSUNG-SM-G925")>=0) { // S6
            D.initSamsungAfterS6();
        } else if(modelName.equals("SAMSUNG-SM-G935A") || modelName.indexOf("SAMSUNG-SM-G935")>=0) { // S7 edge (all versions)
            D.initSamsungAfterS6();
            //D.initDefault(); // just for debug
        } else if(modelName.equals("SAMSUNG-SM-G930V") || modelName.indexOf("SAMSUNG-SM-G930")>=0){ // S7 (not edge)
            D.initSamsungS7();
        } else if(modelName.equals("SAMSUNG-SM-N920A")) { // Note 5
            D.initSamsungAfterS6();
        } else if(modelName.equals("HUAWEI-NEXUS6P")) {
            initNexus6p();
        } else {
            D.initDefault();
        }

    }

    // basic setting (default setting based on Note4)
    static void initDefault(){
        code = getCode(CODE_ANDROID);
        name = "Default";
        PSE_DETECT_CH_IDX = 2; // Note matlab starts by 1 , but java/c++ starts by 0
        SSE_DETECT_CH_IDX = 1;
    }



    static void initSamsungAfterS6(){
        D.initDefault(); // init the default parameters not being modified
        code = getCode((char)2);
        name = "SamsungAfterS6";
        PSE_DETECT_CH_IDX = 1; // Note matlab starts by 1 , but java/c++ starts by 0
        SSE_DETECT_CH_IDX = 2;
        RECORD_SOURCE = MediaRecorder.AudioSource.CAMCORDER;
        appPressureButtonThres = 0.4;
    }

    // This is for Samsung test
    static void initSamsungS7(){
        D.initDefault(); // init the default parameters not being modified
        code = getCode((char)3);
        name = "SamsungS7";
        PSE_DETECT_CH_IDX = 1; // Note matlab starts by 1 , but java/c++ starts by 0
        SSE_DETECT_CH_IDX = 2;
        RECORD_SOURCE = MediaRecorder.AudioSource.CAMCORDER;
        appPressureButtonThres = 0.4;
        appPressureEngineSoundScaleMax = 0.3;
    }

    static void initS7Edge(){ // prof shin's phone
        D.initSamsungAfterS6(); // init the default parameters not being modified
        name = "S7";
        appPressureButtonThres = 0.4;
    }

    static void initNexus6p(){
        D.initDefault();
        code = getCode((char)4);
        name = "Nexus6p";
        appPressureButtonThres = 0.6;
        appPressureEngineSoundScaleMax = 0.3;
    }

    static int getCode(int codeIn){
        if(Constant.FORCE_TO_USE_TOP_SPEAKER){
            return (codeIn + 100);
        } else {
            return codeIn;
        }
    }

    /*
    static int getJNIDetectChIdx(){
        return PSE_DETECT_CH_IDX - 1;
    }*/

    // must be set after the init
    public static void configBasedOnSetting(int mode, Context context){
        detectMode = mode;

        // config based on setting
        final AudioManager audioManager = (AudioManager) context.getSystemService(Context.AUDIO_SERVICE);
        //mode.setRingerMode(AudioManager.RINGER_MODE_NORMAL);

        int maxVolValue = audioManager.getStreamMaxVolume(audioManager.STREAM_MUSIC);
        int targetValue = (int) Math.round(maxVolValue*SYSTEM_VOL);
        int currentVolValue = audioManager.getStreamVolume(audioManager.STREAM_MUSIC);
        if(currentVolValue!=targetValue) {
            audioManager.setStreamVolume(AudioManager.STREAM_MUSIC, targetValue, 0);
            int checkVolValue = audioManager.getStreamVolume(audioManager.STREAM_MUSIC);
            Log.d(Constant.LOG_TAG, "Set the new volume as vol = " + targetValue + ", set reuslt = " + checkVolValue);
        }
    }
}
