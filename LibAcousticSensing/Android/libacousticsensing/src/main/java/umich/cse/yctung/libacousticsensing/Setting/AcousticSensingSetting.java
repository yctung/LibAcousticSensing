package umich.cse.yctung.libacousticsensing.Setting;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.media.MediaRecorder;
import android.preference.PreferenceManager;
import android.provider.MediaStore;
import android.util.Log;

import umich.cse.yctung.libacousticsensing.R;

/**
 * Created by yctung on 9/29/17.
 * a wrapper to bridge shared preference and the real sensing setting
 */

public class AcousticSensingSetting {
    private final static String TAG = "AcousticSensingSetting";

    // NOTE: the shared preference key here should match the one declared in the preferences.xml
    public final static String PARSE_MODE_KEY = "LIBAS_PARSE_MODE_KEY";
    public final static int PARSE_MODE_REMOTE = 0; // NOTE: need to start from 0
    public final static int PARSE_MDOE_STANDALONE = 1;
    private final static int PARSE_MODE_DEFAULT = PARSE_MODE_REMOTE;

    public final static String SERVER_ADDR_KEY = "LIBAS_SERVER_ADDR_KEY";
    private final static String SERVER_ADDR_DEFAULT = "10.0.0.12"; // my AP in Lab

    public final static String SERVER_IP_KEY = "LIBAS_SERVER_IP_KEY";
    private final static String SERVER_IP_DEFAULT = "50005"; // my AP in Lab

    public final static String RECORD_AUDIO_SOURCE_KEY = "LIBAS_RECORD_AUDIO_SOURCE_KEY";
    public final static int RECORD_AUDIO_SOURCE_RECOG = 0; // NOTE: need to start from 0
    public final static int RECORD_AUDIO_SOURCE_MIC = 1;
    public final static int RECORD_AUDIO_SOURCE_CAM = 2;
    private final static int RECORD_AUDIO_SOURCE_DEFAULT = RECORD_AUDIO_SOURCE_RECOG;

    Context context;
    SharedPreferences pref;

    String getServerIP() {
        return pref.getString(SERVER_IP_KEY, "hahaha");
    }

    public AcousticSensingSetting(Context context) {
        this.context = context;
        this.pref = PreferenceManager.getDefaultSharedPreferences(context);
    }

    public void resetToDefault() {
        // NOTE: we don't need to set each individual value in preference
        // TODO: this might ruin app's preference
        pref.edit().clear().commit();
    }

    public int getAudioSource() {
        String valueString = pref.getString(RECORD_AUDIO_SOURCE_KEY, String.format("%d", RECORD_AUDIO_SOURCE_DEFAULT));
        return Integer.parseInt(valueString);
    }

    public int getAudioSourceInAndroidRecorderFormat() {
        int as = getAudioSource();
        switch (as) {
            case RECORD_AUDIO_SOURCE_RECOG:
                return MediaRecorder.AudioSource.VOICE_RECOGNITION;
            case RECORD_AUDIO_SOURCE_MIC:
                return MediaRecorder.AudioSource.MIC;
            case RECORD_AUDIO_SOURCE_CAM:
                return MediaRecorder.AudioSource.CAMCORDER;
        }
        Log.e(TAG, "Undefined audio source = " + as);
        return MediaRecorder.AudioSource.DEFAULT;
    }

    public String[] getModeTexts() {
        String[] modeEntries = context.getResources().getStringArray(R.array.mode_entries);
        return modeEntries;
    }

    public int getParseMode() {
        String valueString = pref.getString(PARSE_MODE_KEY, String.format("%d", PARSE_MODE_DEFAULT)); // "0" or "1"
        return Integer.parseInt(valueString);
    }

    public void setMode(int mode) {
        if (mode != PARSE_MODE_REMOTE && mode != PARSE_MDOE_STANDALONE) {
            Log.e(TAG, "Wrong parse mode = " + mode);
            return;
        }
        pref.edit().putString(PARSE_MODE_KEY, String.format("%d", mode)).commit();
    }

    public String getServerAddr() {
        return pref.getString(SERVER_ADDR_KEY, SERVER_ADDR_DEFAULT);
    }

    public void setServerAddr(String addr) {
        pref.edit().putString(SERVER_ADDR_KEY, addr).commit();
    }

    public String getServerPort() {
        return pref.getString(SERVER_IP_KEY, SERVER_IP_DEFAULT);
    }

    public void setServerPort(String port) {
        pref.edit().putString(SERVER_IP_KEY, port).commit();
    }

    public void showSettingActivity() {
        //AcousticSensingSettingActivity.appContext = context;
        //AcousticSensingSettingFragment.appContext = context;

        Intent i = new Intent(context.getApplicationContext(), AcousticSensingSettingActivity.class);
        context.startActivity(i);
        /*
        ((Activity)context).getFragmentManager()
                .beginTransaction()
                .replace(android.R.id.content, new AcousticSensingSettingFragment())
                .commit();
                */
    }


}
