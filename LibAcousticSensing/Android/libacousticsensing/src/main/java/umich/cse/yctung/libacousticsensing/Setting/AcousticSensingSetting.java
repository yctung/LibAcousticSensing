package umich.cse.yctung.libacousticsensing.Setting;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.preference.PreferenceFragment;
import android.preference.PreferenceManager;

import umich.cse.yctung.libacousticsensing.Constant;

/**
 * Created by yctung on 9/29/17.
 * a wrapper to bridge shared preference and the real sensing setting
 */

public class AcousticSensingSetting {
    public final static String KEY_SERVER_IP = "LIBAS_SERVER_IP";

    Context context;
    SharedPreferences pref;

    String getServerIP() {
        return pref.getString(KEY_SERVER_IP, "hahaha");
    }

    public AcousticSensingSetting(Context context) {
        this.context = context;
        //this.pref = context.PreferenceManager.getDefaultSharedPreferences(context);
        this.pref = ((Activity)context).getPreferences(Context.MODE_WORLD_WRITEABLE);
    }

    public void showSettingActivity() {
        Intent i = new Intent(context.getApplicationContext(), AcousticSensingSettingActivity.class);
        context.startActivity(i);
        /*
        ((Activity)context).getFragmentManager()
                .beginTransaction()
                .replace(android.R.id.content, new AcousticSensingSettingFragment())
                .commit();
                */
    }

    public int getServerPort() {
        return pref.getInt("PREF_KEY_SERVER_PORT", 50005);
    }
}
