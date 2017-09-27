package umich.cse.yctung.demoforcephone;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;

public class MainActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    AcousticSensingController asc;

    // UI elements
    Spinner spinnerMode;
    EditText editTextServerAddr, editTextServerPort;
    Button buttonStart;
    TextView textViewDebugInfo;
    // Internal status
    boolean isSensing;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        // Init internal status
        isSensing = false;

        // Link UI elements
        spinnerMode = (Spinner)findViewById(R.id.spinnerMode);
        String[] modes = new String[]{"Server-client Mode","Real-time Mode"};
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, modes);
        spinnerMode.setAdapter(adapter);
        spinnerMode.setSelection(0);

        editTextServerAddr = (EditText)findViewById(R.id.editTextServerAddr);
        editTextServerAddr.setText(Constant.DEFAULT_SERVER_ADDR);
        editTextServerPort = (EditText)findViewById(R.id.editTextServerPort);
        editTextServerPort.setText(String.format("%d",Constant.DEFAULT_SERVER_PORT));

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

    void onStartOrStopClicked() {
        if (!isSensing) { // need to start sensing
            if (spinnerMode.getSelectedItemPosition()==0) { // server-client mode
                boolean result = asc.initAsSlaveMode(editTextServerAddr.getText().toString(),Integer.parseInt(editTextServerPort.getText().toString()));
                if (!result) textViewDebugInfo.setText("Init fails");
                else {
                    asc.startSensingWhenPossible();
                }
            } else { // real-time mode

            }
            buttonStart.setText("Stop");
        } else { // need to stop sensing
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

    @Override
    public void dataJNICallback(long retAddr) {

    }
}
