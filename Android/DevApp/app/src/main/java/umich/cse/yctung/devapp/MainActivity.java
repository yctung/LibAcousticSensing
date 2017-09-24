package umich.cse.yctung.devapp;

import android.content.Context;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.KeyEvent;
import android.view.View;
import android.view.inputmethod.EditorInfo;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;

import static umich.cse.yctung.devapp.Constant.SERVER_ADDR_KEY;
import static umich.cse.yctung.devapp.Constant.SERVER_PORT_KEY;
import static umich.cse.yctung.devapp.Constant.DEFAULT_SERVER_ADDR;
import static umich.cse.yctung.devapp.Constant.DEFAULT_SERVER_PORT;

public class MainActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    AcousticSensingController asc;
    SharedPreferences sharedPref;
    final String TAG = "MainActivity";

    // UI elements
    Spinner spinnerMode;
    EditText editTextServerAddr, editTextServerPort;
    Button buttonStart, buttonUserData;
    TextView textViewDebugInfo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        sharedPref = getPreferences(Context.MODE_PRIVATE);

        // Link UI elements
        spinnerMode = (Spinner)findViewById(R.id.spinnerMode);
        String[] modes = new String[]{"Remote Mode","Standalone Mode"};
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, modes);
        spinnerMode.setAdapter(adapter);
        spinnerMode.setSelection(0);

        editTextServerAddr = (EditText)findViewById(R.id.editTextServerAddr);
        editTextServerAddr.setText(sharedPref.getString(SERVER_ADDR_KEY, DEFAULT_SERVER_ADDR));
        editTextServerPort = (EditText)findViewById(R.id.editTextServerPort);
        editTextServerPort.setText(String.format("%d",sharedPref.getInt(SERVER_PORT_KEY, DEFAULT_SERVER_PORT)));



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

        buttonStart = (Button)findViewById(R.id.btnStart);
        buttonStart.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onStartOrStopClicked();
            }
        });

        textViewDebugInfo = (TextView)findViewById(R.id.textDebugInfo);

        asc=new AcousticSensingController(this,this);
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
            buttonStart.setText("Stop");
        } else { // need to stop sensing
            asc.stopSensingNow();
            buttonStart.setText("Start");
        }
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
}
