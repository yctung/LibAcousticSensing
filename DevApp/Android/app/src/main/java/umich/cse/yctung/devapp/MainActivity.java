package umich.cse.yctung.devapp;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
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

import static umich.cse.yctung.devapp.Constant.SERVER_ADDR_KEY;
import static umich.cse.yctung.devapp.Constant.SERVER_PORT_KEY;
import static umich.cse.yctung.devapp.Constant.DEFAULT_SERVER_ADDR;
import static umich.cse.yctung.devapp.Constant.DEFAULT_SERVER_PORT;

public class MainActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    final static String KEY_AUTO_CONNECT = "KEY_AUTO_CONNECT";
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
        String[] modes = new String[]{"Remote Mode","Standalone Mode"};
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, modes);
        spinnerMode.setAdapter(adapter);
        spinnerMode.setSelection(0);
        spinnerMode.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parentView, View selectedItemView, int position, long id) {
                // your code here
                updateUI();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parentView) {
                // your code here
            }
        });

        editTextServerAddr = (EditText)findViewById(R.id.editTextServerAddr);
        //editTextServerAddr.setText(sharedPref.getString(SERVER_ADDR_KEY, DEFAULT_SERVER_ADDR));
        //editTextServerAddr.setText("10.0.0.12");
        editTextServerAddr.setText("35.3.119.219");
        editTextServerPort = (EditText)findViewById(R.id.editTextServerPort);
        //editTextServerPort.setText(String.format("%d", sharedPref.getInt(SERVER_PORT_KEY, DEFAULT_SERVER_PORT)));
        editTextServerPort.setText("50005");



        // Commit the changes back into the shared preferences
        editTextServerAddr.setOnEditorActionListener(new TextView.OnEditorActionListener() {
            @Override
            public boolean onEditorAction(TextView textView, int i, KeyEvent keyEvent) {
                Log.v(TAG, "We should be editing the IP now... " + i);
                if (i == EditorInfo.IME_NULL || i == EditorInfo.IME_ACTION_DONE) {
                    sharedPref.edit().putString(
                            SERVER_ADDR_KEY,
                            textView.getText().toString()
                    ).commit();
                }
                return false;
            }
        });

        editTextServerPort.setOnEditorActionListener(new TextView.OnEditorActionListener() {
            @Override
            public boolean onEditorAction(TextView textView, int i, KeyEvent keyEvent) {
                if (i == EditorInfo.IME_NULL || i == EditorInfo.IME_ACTION_DONE) {
                    sharedPref.edit().putInt(
                            SERVER_PORT_KEY,
                            Integer.parseInt(textView.getText().toString())
                    ).commit();
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
                connect();
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
        checkAuto.setChecked(sharedPref.getBoolean(KEY_AUTO_CONNECT, false));
        checkAuto.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
                sharedPref.edit().putBoolean(
                        KEY_AUTO_CONNECT,
                        b
                ).commit();
                if (b) { // start auto connecting when people clicked this option
                    connect();
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
    }

    void updateUI() {
        //editTextServerPort.setText(String.format("%d", sharedPref.getInt(SERVER_PORT_KEY, DEFAULT_SERVER_PORT)));
        /*
        if (ass != null) {
            int port = ass.getServerPort();
            editTextServerPort.setText(String.format("%d", port));
        }



        if (spinnerMode.getSelectedItemPosition() == 0) {
            // remote mode
            checkAuto.setEnabled(true);
            editTextServerAddr.setEnabled(true);
            editTextServerPort.setEnabled(true);

            buttonConnect.setText("Connect");

        } else {
            // stand alone mode
            checkAuto.setEnabled(false);
            editTextServerAddr.setEnabled(false);
            editTextServerPort.setEnabled(false);

            buttonConnect.setText("Start");

            // TODO: try to init Audio to see if it is ok to sense
            buttonSense.setText("Start Sensing");
        }

        if (asc == null || !asc.isReadyToSense()) {
            // not ready to sense yet
            //buttonSense.setEnabled(false);
        } else {
            // ok to sense
            buttonSense.setEnabled(true);
        }

        */

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
        if (asc == null || !asc.isReadyToSense()) { // need to start sensing
            boolean initResult = false;
            if (spinnerMode.getSelectedItemPosition()==0) { // remote mode
                initResult = asc.initAsSlaveMode(editTextServerAddr.getText().toString(),Integer.parseInt(editTextServerPort.getText().toString()));
            } else { // standalone mode
                initResult = asc.initAsStandaloneMode("audio_source.json", "signal.dat", "preamble.dat", "sync.dat");
            }

            if (!initResult) {
                textViewDebugInfo.setText("Init fails");
                return;
            }

            asc.startSensingWhenPossible();
            buttonSense.setText("Stop");
        } else { // need to stop sensing
            asc.stopSensingNow();
            buttonSense.setText("Start");
        }
    }

    void connect() {
        progressConnecting.show();
    }

    void retryToConnectIfNeed() {

    }

    void onRefreshClicked() {
        Utils.showYesAndNoAlertDialogWithCallback(this, "Refresh to default setting", "Do you want to refresh the setting to default values?", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                sharedPref.edit().putString(SERVER_ADDR_KEY, DEFAULT_SERVER_ADDR).commit();

                spinnerMode.setSelection(0);
                editTextServerAddr.setText(sharedPref.getString(SERVER_ADDR_KEY, DEFAULT_SERVER_ADDR));
                editTextServerPort.setText(String.format("%d",sharedPref.getInt(SERVER_PORT_KEY, DEFAULT_SERVER_PORT)));
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
        if (sharedPref.getBoolean(KEY_AUTO_CONNECT, false)) {
            // auto connect mode -> do nothing
        } else {
            // update the connect result

            updateUI();
        }
    }

    @Override
    public void sensingEnd() {

    }

    @Override
    public void sensingStarted() {

    }

    @Override
    public void updateSensingProgress(int percent) {

    }

    @Override
    public void serverClosed() {

    }

    @Override
    public void updateResult(int argInt, float argFloat) {

    }

    @Override
    public void dataJNICallback(long retAddr) {
        jc.dataCallback(retAddr);
    }
}
