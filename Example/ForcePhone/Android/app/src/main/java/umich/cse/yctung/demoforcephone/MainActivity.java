package umich.cse.yctung.demoforcephone;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.KeyEvent;
import android.view.View;
import android.view.inputmethod.EditorInfo;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Spinner;
import android.widget.TextView;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;
import umich.cse.yctung.libacousticsensing.Utils;

public class MainActivity extends AppCompatActivity {
    final static String AUTO_CONNECT_KEY = "DEVAPP_AUTO_CONNECT_KEY";
    final static int RETRY_WAIT = 1000; // ms
    AcousticSensingSetting ass;
    JNICallback jc;
    SharedPreferences sharedPref;
    final String TAG = "MainActivity";

    // UI elements
    Spinner spinnerMode, spinnerDemos;
    EditText editTextServerAddr, editTextServerPort;
    Button buttonStart;
    ImageButton buttonSetting, buttonRefresh;
    CheckBox checkAuto;
    TextView textViewDebugInfo;
    ProgressDialog progressConnecting;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //sharedPref = getPreferences(Context.MODE_ENABLE_WRITE_AHEAD_LOGGING);
        sharedPref = getPreferences(Context.MODE_PRIVATE);

        ass = new AcousticSensingSetting(this);

        // Link UI elements
        spinnerMode = (Spinner) findViewById(R.id.spinnerMode);
        //String[] modes = new String[]{"Remote Mode","Standalone Mode"};
        String[] modes = ass.getModeTexts();
        ArrayAdapter<String> modeAdapter = new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, modes);
        spinnerMode.setAdapter(modeAdapter);
        spinnerMode.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parentView, View selectedItemView, int position, long id) {
                // your code here
                Log.e(TAG, "onItemSelected, position = " + position);
                ass.setMode(position);
                updateUI();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parentView) {
                Log.e(TAG, "onNothingSelected");
                // your code here
                /*
                ass.setMode(0);
                updateUI();
                */
            }
        });

        spinnerDemos = (Spinner) findViewById(R.id.spinnerActivity);
        String[] demos = new String[]{"Test 1", "Test 2"};
        ArrayAdapter<String> demoAdapter = new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, demos);
        spinnerDemos.setAdapter(demoAdapter);

        editTextServerAddr = (EditText) findViewById(R.id.editTextServerAddr);
        editTextServerPort = (EditText) findViewById(R.id.editTextServerPort);

        // Commit the changes back into the shared preferences
        editTextServerAddr.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                ass.setServerAddr(charSequence.toString());
            }

            @Override
            public void afterTextChanged(Editable editable) {

            }
        });

        editTextServerAddr.setOnEditorActionListener(new TextView.OnEditorActionListener() {
            @Override
            public boolean onEditorAction(TextView textView, int i, KeyEvent keyEvent) {
                Log.v(TAG, "We should be editing the IP now... " + i);
                if (i == EditorInfo.IME_NULL || i == EditorInfo.IME_ACTION_DONE) {
                    ass.setServerAddr(textView.getText().toString());
                }
                return false;
            }
        });

        editTextServerPort.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                ass.setServerPort(charSequence.toString());
            }

            @Override
            public void afterTextChanged(Editable editable) {

            }
        });

        editTextServerPort.setOnEditorActionListener(new TextView.OnEditorActionListener() {
            @Override
            public boolean onEditorAction(TextView textView, int i, KeyEvent keyEvent) {
                if (i == EditorInfo.IME_NULL || i == EditorInfo.IME_ACTION_DONE) {
                    ass.setServerPort(textView.getText().toString());
                }
                return false;
            }
        });

        buttonStart = (Button) findViewById(R.id.btnStart);
        buttonStart.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onStartClicked();
            }
        });

        buttonSetting = (ImageButton) findViewById(R.id.buttonSetting);
        buttonSetting.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (ass != null) ass.showSettingActivity();
            }
        });

        buttonRefresh = (ImageButton) findViewById(R.id.buttonRefresh);
        buttonRefresh.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onRefreshClicked();
            }
        });

        checkAuto = (CheckBox) findViewById(R.id.checkAuto);
        checkAuto.setChecked(sharedPref.getBoolean(AUTO_CONNECT_KEY, false));
        checkAuto.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
                sharedPref.edit().putBoolean(
                        AUTO_CONNECT_KEY,
                        b
                ).commit();
            }
        });

        textViewDebugInfo = (TextView) findViewById(R.id.textDebugInfo);

        progressConnecting = new ProgressDialog(MainActivity.this);
        progressConnecting.setMessage("Connecting");


        //asc = new AcousticSensingController(this, this);
    }

    @Override
    public void onResume() {
        super.onResume();
        updateUI();
    }

    void updateUI() {
        if (ass != null) {
            spinnerMode.setSelection(ass.getParseMode());
            editTextServerAddr.setText(ass.getServerAddr());
            editTextServerPort.setText(ass.getServerPort());
        }

        checkAuto.setEnabled(true);

        if (spinnerMode.getSelectedItemPosition() == ass.PARSE_MODE_REMOTE) { // remote mode
            spinnerMode.setEnabled(true);
            editTextServerAddr.setEnabled(true);
            editTextServerPort.setEnabled(true);
        } else { // stand alone mode
            spinnerMode.setEnabled(true);
            editTextServerAddr.setEnabled(false);
            editTextServerPort.setEnabled(false);
        }

        buttonStart.setEnabled(true);
        buttonStart.setText("Sense");
    }

    int userDataCodeToSend = 1;

    void onStartClicked() {
        Intent intent = new Intent(getApplicationContext(), DemoForceMonitorActivity.class);
        startActivity(intent);
    }

    void onRefreshClicked() {
        Utils.showYesAndNoAlertDialogWithCallback(this, "Refresh to default setting", "Do you want to refresh the setting to default values?", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                ass.resetToDefault();
                updateUI();
                //spinnerMode.setSelection(0);
            }
        });
        updateUI();
    }
}
