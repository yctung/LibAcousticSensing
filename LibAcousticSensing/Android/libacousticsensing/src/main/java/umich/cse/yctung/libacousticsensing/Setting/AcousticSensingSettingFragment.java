package umich.cse.yctung.libacousticsensing.Setting;

import android.os.Bundle;
import android.preference.PreferenceFragment;

import umich.cse.yctung.libacousticsensing.R;

/**
 * Created by yctung on 9/30/17.
 */

public class AcousticSensingSettingFragment extends PreferenceFragment {
    @Override
    public void onCreate (Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        // Load the preferences from an XML resource
        addPreferencesFromResource(R.xml.preferences);
    }
}
