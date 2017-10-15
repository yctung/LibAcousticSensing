package umich.cse.yctung.wear;

import android.app.Dialog;
import android.content.Intent;
import android.os.Bundle;
import android.support.wearable.activity.WearableActivity;
import android.support.wearable.view.BoxInsetLayout;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;


public class MainActivity extends WearableActivity implements AcousticSensingControllerListener {

    private static final SimpleDateFormat AMBIENT_DATE_FORMAT =
            new SimpleDateFormat("HH:mm", Locale.US);

    private BoxInsetLayout mContainerView;
    private TextView textDebug, textInfo;
    private Button buttonStart;
    private ImageButton buttonSetting;

    AcousticSensingSetting ass;
    AcousticSensingController asc;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setAmbientEnabled();

        mContainerView = (BoxInsetLayout) findViewById(R.id.container);
        textDebug = (TextView) findViewById(R.id.textDebug);
        textInfo = (TextView) findViewById(R.id.textInfo);

        buttonStart = (Button) findViewById(R.id.buttonStart);
        buttonStart.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onStartOrStopClicked();
            }
        });

        buttonSetting = (ImageButton) findViewById(R.id.buttonSetting);
        buttonSetting.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showSettingActivity();
            }
        });



        ass = new AcousticSensingSetting(this);
        asc = new AcousticSensingController(this,this);

        updateDisplay();
    }

    void onStartOrStopClicked() {
        /*
        Dialog dialog = asc.createInitModeDialog(this, "35.2.141.147", 50005);
        dialog.show();
        */
        //boolean result = asc.initAsSlaveMode("192.168.0.108",50005);
        boolean result = asc.init(ass);
        if (!result) updateDebugStatus(false, "Init fails");
        else {
            asc.startSensingWhenPossible();
        }
    }

    void showSettingActivity() {
        Intent intent = new Intent(this, SettingActivity.class);
        startActivity(intent);
    }

    @Override
    public void onEnterAmbient(Bundle ambientDetails) {
        super.onEnterAmbient(ambientDetails);
        updateDisplay();
    }

    @Override
    public void onUpdateAmbient() {
        super.onUpdateAmbient();
        updateDisplay();
    }

    @Override
    public void onExitAmbient() {
        updateDisplay();
        super.onExitAmbient();
    }

    private void updateDisplay() {

        // update textInfo based on the current setting
        String info = "Server=" + ass.getServerAddr() + ":" + ass.getServerPort();
        textInfo.setText(info);
    }

//=================================================================================================
//  Acoustic sensing callbacks
//=================================================================================================
    @Override
    public void updateDebugStatus(boolean status, final String stringToShow) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                textDebug.setText(stringToShow);
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

    @Override
    public void isConnected(boolean success, String resp) {

    }

}
