package umich.cse.yctung.devapp;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.SharedPreferences;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
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
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;
import umich.cse.yctung.libacousticsensing.Utils;

public class MainActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    final static String AUTO_CONNECT_KEY = "DEVAPP_AUTO_CONNECT_KEY";
    final static int RETRY_WAIT = 1000; // ms
    AcousticSensingController asc;
    AcousticSensingSetting ass;
    JNICallback jc;
    SharedPreferences sharedPref;
    final String TAG = "MainActivity";

    // UI elements
    Spinner spinnerMode;
    EditText editTextServerAddr, editTextServerPort;
    Button buttonSense, buttonUserData, buttonConnect;
    ImageButton buttonSetting, buttonRefresh;
    CheckBox checkAuto;
    TextView textViewDebugInfo;
    ProgressDialog progressConnecting;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        sharedPref = getPreferences(Context.MODE_ENABLE_WRITE_AHEAD_LOGGING);

        ass = new AcousticSensingSetting(this);

        // Link UI elements
        spinnerMode = (Spinner)findViewById(R.id.spinnerMode);
        //String[] modes = new String[]{"Remote Mode","Standalone Mode"};
        String[] modes = ass.getModeTexts();
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, modes);
        spinnerMode.setAdapter(adapter);
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

        editTextServerAddr = (EditText)findViewById(R.id.editTextServerAddr);
        editTextServerPort = (EditText)findViewById(R.id.editTextServerPort);

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

        buttonUserData = (Button)findViewById(R.id.btnUserData);
        buttonUserData.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onUserDataClicked();
            }
        });
        buttonUserData.setVisibility(View.INVISIBLE); // TODO: add this function back

        buttonSense = (Button)findViewById(R.id.btnStart);
        buttonSense.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onStartOrStopClicked();
            }
        });

        buttonConnect = (Button) findViewById(R.id.buttonConnect);
        buttonConnect.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onInitOrFinalizeClicked();
            }
        });


        buttonSetting = (ImageButton)findViewById(R.id.buttonSetting);
        buttonSetting.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (ass != null) ass.showSettingActivity();
            }
        });

        buttonRefresh = (ImageButton)findViewById(R.id.buttonRefresh);
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
                if (b) { // start auto connecting when people clicked this option
                    onInitOrFinalizeClicked();
                }
            }
        });

        textViewDebugInfo = (TextView)findViewById(R.id.textDebugInfo);

        progressConnecting = new ProgressDialog(MainActivity.this);
        progressConnecting.setMessage("Connecting");


        jc = new JNICallback();
        jc.debugTest();
        asc = new AcousticSensingController(this, this);
    }

    @Override
    public void onResume() {
        super.onResume();
        updateUI();
        retryInitIfNeed();
    }

    void updateUI() {
        if (ass != null) {
            spinnerMode.setSelection(ass.getParseMode());
            editTextServerAddr.setText(ass.getServerAddr());
            editTextServerPort.setText(ass.getServerPort());
        }
        if (asc == null || !asc.isReadyToSense()) {
            // not ready to sense yet
            buttonConnect.setEnabled(true);
            checkAuto.setEnabled(true);

            if (spinnerMode.getSelectedItemPosition() == ass.PARSE_MODE_REMOTE) { // remote mode
                spinnerMode.setEnabled(true);
                editTextServerAddr.setEnabled(true);
                editTextServerPort.setEnabled(true);
            } else { // stand alone mode
                spinnerMode.setEnabled(false);
                editTextServerAddr.setEnabled(false);
                editTextServerPort.setEnabled(false);
            }

            buttonConnect.setText("Connect/init");
            buttonSense.setEnabled(false);
        } else {
            // ok to sense
            buttonConnect.setEnabled(false);
            checkAuto.setEnabled(false);
            spinnerMode.setEnabled(false);
            editTextServerAddr.setEnabled(false);
            editTextServerPort.setEnabled(false);

            buttonConnect.setText("Disconnect/reset");
            buttonSense.setEnabled(true);

            if (!asc.isSensing()) {
                buttonSense.setText("Sense");
            } else {
                buttonSense.setText("Stop");
            }
        }
    }

    int userDataCodeToSend = 1;
    void onUserDataClicked() {
        if (asc != null && asc.isReadyToSense()) {
            asc.sendUserData("ukn",userDataCodeToSend, 0.0f, 0.0f);
            // update next user data to send
            userDataCodeToSend = userDataCodeToSend == 1 ? 0 : 1;
        }
    }

    void onStartOrStopClicked() {
        if (asc == null || !asc.isReadyToSense()) { // not ready to sense yet
            Log.e(TAG, "Not ready to sense yet");
            return;
        }

        if (!asc.isSensing()) {
            asc.startSensingWhenPossible();
        } else { // need to stop sensing
            asc.stopSensingNow();
        }
        updateUI();
    }

    void onInitOrFinalizeClicked() {
        if (asc == null || !asc.isReadyToSense()) {
            initIfPossible();
        } else {
            finalzeIfPossible();
        }
        updateUI();
    }

    void initIfPossible() {
        if (asc == null || asc.isReadyToSense()) {
            Log.e(TAG, "Unable to init when the sensing controller has be initialized");
            return;
        }

        // TODO: init by setting
        boolean initResult = asc.init(ass);

        if (!initResult) {
            textViewDebugInfo.setText("Init fails");
            return;
        }

        if (ass.getParseMode() == AcousticSensingSetting.PARSE_MODE_REMOTE) {
            progressConnecting.show();
        }
    }

    void retryInitIfNeed() {
        // If auto start, then call the click function again after some time
        Boolean autostart = sharedPref.getBoolean(AUTO_CONNECT_KEY, false);
        if (autostart) {
            Log.v(TAG, "Attempting to auto start.");
            Handler handler = new Handler();
            handler.postDelayed(new Runnable() {
                @Override
                public void run() {
                    initIfPossible();
                }
            }, RETRY_WAIT);
        }
    }

    void finalzeIfPossible() {
        // TODO: finialize the sensing controller
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

//=================================================================================================
//  Acoustic sensing callbacks
//=================================================================================================
    @Override
    public void updateDebugStatus(boolean status, final String stringToShow) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                textViewDebugInfo.setText(stringToShow);
            }
        });
    }

    @Override
    public void showToast(String stringToShow) {

    }

    @Override
    public void isConnected(boolean success, String resp) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                progressConnecting.dismiss();
                if (sharedPref.getBoolean(AUTO_CONNECT_KEY, false)) {
                    // auto connect mode -> do nothing
                    retryInitIfNeed();
                }
                updateUI();
            }
        });
    }

    @Override
    public void sensingEnd() {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                updateUI();
            }
        });
    }

    @Override
    public void sensingStarted() {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                updateUI();
            }
        });
    }

    @Override
    public void updateSensingProgress(int percent) {

    }

    @Override
    public void serverClosed() {
        // TODO: remote server is closed by some reason -> need to stop and clean everything

    }

    @Override
    public void updateResult(int argInt, float argFloat) {

    }

    @Override
    public void dataJNICallback(long retAddr) {
        jc.dataCallback(retAddr);
    }
}
