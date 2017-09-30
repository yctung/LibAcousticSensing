package umich.cse.yctung.libacousticsensing.Setting;

import android.content.Context;
import android.os.Bundle;
import android.preference.CheckBoxPreference;
import android.preference.PreferenceActivity;
import android.preference.PreferenceCategory;
import android.preference.PreferenceScreen;

/**
 * Created by eddyxd on 9/30/17.
 */

public class AcousticSensingSettingActivity extends PreferenceActivity {

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
        PreferenceScreen screen = getPreferenceManager().createPreferenceScreen(this);

        PreferenceCategory category = new PreferenceCategory(this);
        category.setTitle("category name");

        screen.addPreference(category);

        CheckBoxPreference checkBoxPref = new CheckBoxPreference(this);
        checkBoxPref.setTitle("title");
        checkBoxPref.setSummary("summary");
        checkBoxPref.setChecked(true);

        category.addPreference(checkBoxPref);
        setPreferenceScreen(screen);
        */
    }
}
