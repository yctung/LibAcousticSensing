package umich.cse.yctung.libacousticsensing.Setting;

import android.app.Activity;
import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.preference.PreferenceFragment;
import android.util.Log;

import umich.cse.yctung.libacousticsensing.R;

/**
 * Created by yctung on 9/30/17.
 */

public class AcousticSensingSettingFragment extends PreferenceFragment implements SharedPreferences.OnSharedPreferenceChangeListener {
    static String TAG = "SettingFragment";
    //static Context appContext;

    @Override
    public void onCreate (Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        // Load the preferences from an XML resource
        addPreferencesFromResource(R.xml.preferences);
        //addPreferencesFromIntent();
    }

    @Override
    public void onResume() {
        super.onResume();
        // Set up a listener whenever a key changes
        getPreferenceScreen().getSharedPreferences().registerOnSharedPreferenceChangeListener(this);
    }

    @Override
    public void onPause() {
        super.onPause();
        // Set up a listener whenever a key changes
        getPreferenceScreen().getSharedPreferences().unregisterOnSharedPreferenceChangeListener(this);
    }

    @Override
    public void onSharedPreferenceChanged(SharedPreferences sharedPreferences, String key) {
        // just update all
        Log.d(TAG, "key = " + key);

        /*
        ListPreference lp = (ListPreference) findPreference(PREF_YOUR_KEY);
        lp.setSummary("dummy"); // required or will not update
        lp.setSummary(getString(R.string.pref_yourKey) + ": %s");
         */
        //SharedPreferences appPref = ((Activity) appContext).getPreferences(Context.MODE_PRIVATE);
        //appPref.edit().putInt(key, 99999).commit();

    }
}
