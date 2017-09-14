package com.rtcl.twatchla;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Shader;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.preference.PreferenceManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.widget.ImageButton;
import android.widget.TextView;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;


public class MainActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    AcousticSensingController asc;
    SharedPreferences sharedPref;
    final String TAG = "MainActivity";

    // UI elements
    ImageButton buttonStart;
    TextView textViewDebugInfo;

    // Internal status
    // XXX Who turns this on?
    boolean isSensing;


    enum Status { STOPPED, CONNECTING, RUNNING, ERROR };


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        this.requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.simplified_layout);
        PreferenceManager.setDefaultValues(this, R.xml.preferences, false);
        fixBackgroundRepeat(findViewById(R.id.wrapperLayout));


        isSensing = false;
        sharedPref = getPreferences(Context.MODE_PRIVATE);


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

        //textViewDebugInfo = (TextView)findViewById(R.id.textDebugInfo);

        asc=new AcousticSensingController(this,this);
        updateStatus(Status.STOPPED);
    }



    int userDataCodeToSend = 1;
    void onUserDataClicked() {
        if (asc.isConnected()) {
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
                boolean result = asc.initAsSlaveMode(serverAddr, Integer.parseInt(serverPort));
                if (!result) {
                    textViewDebugInfo.setText("Init fails");
                    updateStatus(Status.ERROR);
                }
                else asc.startSensingWhenPossible();
            } else { // real-time mode
                // Real-time mode is disabled for now.
                updateStatus(Status.STOPPED);
            }

            updateStatus(Status.RUNNING);
            //buttonStart.setText("Stop");
        } else { // need to stop sensing
            //buttonStart.setText("Start");
            updateStatus(Status.STOPPED);
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
    public void updateStatus (Status status) {
        if (status == Status.STOPPED)
            buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.stopped));

        else if (status == Status.CONNECTING)
            buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.connecting));

        else if (status == Status.RUNNING)
            buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.running));

        else if (status == Status.ERROR)
            buttonStart.setImageDrawable(getResources().getDrawable(R.drawable.error));
    }


    //=================================================================================================
    //  Acoustic sensing callbacks
    //=================================================================================================
    @Override
    public void updateDebugStatus(final String stringToShow) {
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
    public void updateSensingProgress(int percent) {

    }

    @Override
    public void updateResult(int argInt, float argFloat) {

    }
}
