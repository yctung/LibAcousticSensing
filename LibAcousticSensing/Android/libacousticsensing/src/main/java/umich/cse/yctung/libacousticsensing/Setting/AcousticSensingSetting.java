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
        //this.pref = ((Activity)context).getPreferences(Context.MODE_PRIVATE);
        //

        this.pref = PreferenceManager.getDefaultSharedPreferences(context);
        //pref.edit().clear().commit();
        /*
        int temp1 = pref.getInt(KEY_SERVER_IP, 5566);
        pref.edit().putInt("PREF_KEY_SERVER_PORT", 8888).commit();
        int temp = pref.getInt("PREF_KEY_SERVER_PORT", 5566);
        */
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

    public int getServerPort() {
        //pref = PreferenceManager.getDefaultSharedPreferences(context);
        //return pref.getInt(KEY_SERVER_IP, 50005);
        return Integer.parseInt(pref.getString("PREF_KEY_SERVER_PORT", "100"));
    }
}
