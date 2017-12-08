package com.rtcl.twatchla;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Shader;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.os.Handler;
import android.preference.PreferenceManager;
import android.provider.SyncStateContract;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.widget.ImageButton;
import android.widget.TextView;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSettingActivity;


public class MainActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    AcousticSensingSetting ass;
    AcousticSensingController asc;
    SharedPreferences sharedPref;
    final String TAG = "MainActivity";

    // UI elements
    ImageButton buttonStart;
    TextView textViewDebugInfo;
    JNICallback jc;

    // Internal status
    // XXX Who turns this on?
    boolean isSensing;

    final Handler handler = new Handler();

    enum Status { STOPPED, CONNECTING, WAITING, ERROR, SENSING };


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        ass = new AcousticSensingSetting(this);

        this.requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.simplified_layout);
        PreferenceManager.setDefaultValues(this, R.xml.preferences, false);
        fixBackgroundRepeat(findViewById(R.id.wrapperLayout));

        isSensing = false;
        sharedPref = PreferenceManager.getDefaultSharedPreferences(this);


        // Wire settings button
        findViewById(R.id.settings).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(MainActivity.this, SettingsActivity.class));
            }
        });






        // Wire user data upload button
        findViewById(R.id.mail).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onUserDataClicked();
            }
        });


        // Wire start-stop button
        buttonStart = (ImageButton)findViewById(R.id.status);
        buttonStart.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onStartOrStopClicked();
            }
        });

        //s = (TextView)findViewById(R.id.textDebugInfo);

        jc = new JNICallback();
        //jc.debugTest();
        asc=new AcousticSensingController(this,this);
        updateStatus(Status.STOPPED);
        restartIfAutostart();
    }

    int userDataCodeToSend = 1;
    void onUserDataClicked() {
        if (asc.isReadyToSense()) {
            asc.sendUserData("ukn",userDataCodeToSend, 0.0f, 0.0f);
            // update next user data to send
            userDataCodeToSend = userDataCodeToSend == 1 ? 0 : 1;
        }
    }

    void onStartOrStopClicked() {
        Log.v(TAG, "Clicked!");
        if (!isSensing) { // need to start sensing
            updateStatus(Status.CONNECTING);
            String mode = sharedPref.getString(SettingsActivity.KEY_PREF_MODE, "");
            String[] modeEntries = getResources().getStringArray(R.array.mode_entries);
            String serverAddr = sharedPref.getString(SettingsActivity.KEY_PREF_SERVER, "");
            String serverPort = sharedPref.getString(SettingsActivity.KEY_PREF_PORT, "");

            if (mode.equals(modeEntries[0])) { // Server-client mode
                ass.setMode(AcousticSensingSetting.PARSE_MODE_REMOTE);
                ass.setServerAddr(serverAddr);
                ass.setServerPort(serverPort);
                

                //boolean result = asc.initAsSlaveMode(serverAddr, Integer.parseInt(serverPort));
                boolean result = asc.init(ass);
                if (!result) {
                    //textViewDebugInfo.setText("Init fails");
                    updateStatus(Status.ERROR);
                    restartIfAutostart();
                } else {
                    updateStatus(Status.CONNECTING);
                }
            }

            //buttonStart.setText("Stop");
        } else { // need to stop sensing
            //buttonStart.setText("Start");
            turnOffConnection();
        }
    }

    public void turnOffConnection () {
        updateStatus(Status.STOPPED);
        isSensing = false;
        restartIfAutostart();
    }


    /**
     * If autostart is enabled, we will re-call the start/stop function.
     * This should be called every time we end execution somehow.
     * Either from error or from turning off the connection.
     */
    private void restartIfAutostart () {
        // If auto start, then call the click function again after some time
        Boolean autostart = sharedPref.getBoolean(SettingsActivity.KEY_PREF_AUTO, false);
        if (autostart) {
            Log.v(TAG, "Attempting to auto start.");

            handler.postDelayed(new Runnable() {
                @Override
                public void run() {
                    onStartOrStopClicked();
                }
            }, Constant.RETRY_EVERY);
        }
    }


    // https://stackoverflow.com/questions/4336286/tiled-drawable-sometimes-stretches
    public static void fixBackgroundRepeat(View view) {
        Drawable bg = view.getBackground();
        if (bg != null) {
            if (bg instanceof BitmapDrawable) {
                BitmapDrawable bmp = (BitmapDrawable) bg;
                bmp.mutate(); // make sure that we aren't sharing state anymore
                bmp.setTileModeXY(Shader.TileMode.REPEAT, Shader.TileMode.REPEAT);
            }
        }
    }

    /**
     * Update the status message. Pass in the enum and update the image of the image button.
     * @param status
     */
    public void updateStatus (final Status status) {
        runOnUiThread(new Runnable() {
            @Override
            public void run () {
                if (status == Status.STOPPED)
                    buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.stopped));

                else if (status == Status.CONNECTING)
                    buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.connecting));

                else if (status == Status.SENSING)
                    buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.running));

                else if (status == Status.ERROR)
                    buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.error));

                else if (status == Status.WAITING)
                    buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.waiting));
            }
        });
    }


    public void showMessage (final String message) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                ((TextView)findViewById(R.id.debugMessages)).setText(message);
            }
        });
    }


    //=================================================================================================
    //  Acoustic sensing callbacks
    //=================================================================================================
    @Override
    public void updateDebugStatus(final boolean status, final String stringToShow) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                //textViewDebugInfo.setText(stringToShow);
                Log.e(TAG, stringToShow);
                showMessage(stringToShow);
                //updateStatus(Status.WAITING);
                // This could be caused by error.
                //if (!status) turnOffConnection();
                //else {
                //    updateStatus(Status.WAITING);
                //}
            }
        });
    }

    @Override
    public void showToast(String stringToShow) {
        Log.e(TAG, "Show toast: " + stringToShow);
        showMessage(stringToShow);
    }

    @Override
    public void sensingStarted () {
        Log.e(TAG, "Sensing started.");
        updateStatus(Status.SENSING);
        showMessage("Sensing started");
    }

    @Override
    public void sensingEnd() {
        Log.e(TAG, "Sensing end");
        updateStatus(Status.WAITING);
        showMessage("Sensing ended");
    }

    @Override
    public void serverClosed () {
        Log.e(TAG, "Server is resetting.");
        showMessage("Server is resetting");
        turnOffConnection();
    }

    @Override
    public void updateSensingProgress(int percent) {
        Log.e(TAG, "Sensing update: " + percent);
    }

    @Override
    public void updateResult(int argInt, float argFloat) {
        Log.e(TAG, "Update result");
    }

    @Override
    public void dataJNICallback(long retAddr) {

    }

    @Override
    public void isConnected(final boolean success, String s) {
        if (success) {
            updateStatus(Status.WAITING);
            //asc.startSensingWhenPossible();
            isSensing = true;
        } else {
            turnOffConnection();
        }
    }
}
