package umich.cse.yctung.libacousticsensing.Setting;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.preference.CheckBoxPreference;
import android.preference.EditTextPreference;
import android.preference.PreferenceActivity;
import android.preference.PreferenceCategory;
import android.preference.PreferenceScreen;
import android.text.InputType;

/**
 * Created by eddyxd on 9/30/17.
 */

public class AcousticSensingSettingActivity extends PreferenceActivity {
    //public static Context appContext;
    /*
    AcousticSensingSetting ass;
    Context context;

    public AcousticSensingSettingActivity(AcousticSensingSetting acousticSensingSetting, Context context) {
        this.ass = acousticSensingSetting;
        this.context = context;
    }*/

    public void onCreate (Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getFragmentManager()
                .beginTransaction()
                .replace(android.R.id.content, new AcousticSensingSettingFragment())
                .commit();


        /*
        PreferenceScreen screen = getPreferenceManager().createPreferenceScreen(appContext);

        PreferenceCategory category = new PreferenceCategory(appContext);
        category.setTitle("category name");

        screen.addPreference(category);

        CheckBoxPreference checkBoxPref = new CheckBoxPreference(appContext);
        checkBoxPref.setTitle("title");
        checkBoxPref.setSummary("summary");
        checkBoxPref.setChecked(true);
        category.addPreference(checkBoxPref);

        EditTextPreference portPref = (EditTextPreference)findPreference("preference_name");
        portPref.getEditText().setInputType(InputType.TYPE_CLASS_NUMBER);
        category.addPreference(category);

        setPreferenceScreen(screen);
        */
    }
}
