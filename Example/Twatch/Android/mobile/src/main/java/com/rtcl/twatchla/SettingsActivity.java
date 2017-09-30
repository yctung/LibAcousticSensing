package com.rtcl.twatchla;

import android.app.Activity;
import android.os.Bundle;

/**
 * Created by arunganesan on 9/13/17.
 */

public class SettingsActivity extends Activity {

    public static String KEY_PREF_MODE = "pref_mode";
    public static String KEY_PREF_SERVER = "pref_server";
    public static String KEY_PREF_PORT = "pref_port";
    public static String KEY_PREF_AUTO = "pref_autostart";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);


        // Display the fragment as the main content.
        getFragmentManager().beginTransaction()
                .replace(android.R.id.content, new SettingsFragment())
                .commit();
    }
}