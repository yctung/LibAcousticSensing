package umich.cse.yctung.wear;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.os.Handler;
import android.support.wearable.activity.WearableActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import java.util.List;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;

import static java.lang.Math.abs;


public class MainActivity extends WearableActivity implements AcousticSensingControllerListener, SensorEventListener {
    private final static String TAG = "MainActivity";
    private final static String AUTO_CONNECT_KEY = "DEVAPP_AUTO_CONNECT_KEY";
    final static int RETRY_WAIT = 1000; // ms
    private TextView textDebug, textInfo;
    private Button buttonConnect;
    private ImageButton buttonSetting;

    private SharedPreferences sharedPref;

    AcousticSensingSetting ass;
    AcousticSensingController asc;

    long lastTrigger;
    int accCounter = 0;
    float [] circGreaterBuffer = new float[15];
    float [] prevValue = new float[3];
    float [] prevDelta = new float[3];
    final int USERDATACODE = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setAmbientEnabled();

        sharedPref = getPreferences(Context.MODE_ENABLE_WRITE_AHEAD_LOGGING);
        textDebug = (TextView) findViewById(R.id.textDebug);
        textInfo = (TextView) findViewById(R.id.textInfo);

        buttonConnect = (Button) findViewById(R.id.buttonStart);
        buttonConnect.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onInitOrFinalizeClicked();
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

        createDoubleTapThread();
        updateUI();
    }

    void onStartOrStopClicked() {
        boolean result = asc.init(ass);
        if (!result) updateDebugStatus(false, "Init fails");
        else {
            asc.startSensingWhenPossible();
        }
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
            textDebug.setText("Init fails");
            return;
        }
        //progressConnecting.show();
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

    void showSettingActivity() {
        Intent intent = new Intent(this, SettingActivity.class);
        startActivity(intent);
    }

    @Override
    public void onResume() {
        super.onResume();
        updateUI();
    }

    @Override
    public void onEnterAmbient(Bundle ambientDetails) {
        super.onEnterAmbient(ambientDetails);
        updateUI();
    }

    @Override
    public void onUpdateAmbient() {
        super.onUpdateAmbient();
        updateUI();
    }

    @Override
    public void onExitAmbient() {
        updateUI();
        super.onExitAmbient();
    }

    private void updateUI() {
        if (asc == null || !asc.isReadyToSense()) {
            // not ready to sense yet
            Log.v(TAG, "Disconnected");
            String serverInfo = "Server=" + ass.getServerAddr() + ":" + ass.getServerPort();
            textInfo.setText(serverInfo);
            buttonConnect.setText("Connect");
            buttonConnect.setEnabled(true);
        } else {
            // ok to sense
            Log.v(TAG, "Ready to sense");
            buttonConnect.setText("Disconnect");
            if (asc != null && asc.isSensing()) {
                textInfo.setText("Sensing...");
                Log.v(TAG, "Sensing!");
                buttonConnect.setEnabled(false);
            } else {
                textInfo.setText("Connected");
                buttonConnect.setEnabled(true);
            }
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
                textDebug.setText(stringToShow);
            }
        });
    }

    @Override
    public void showToast(String stringToShow) {

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

    }

    @Override
    public void updateResult(int argInt, float argFloat) {

    }

    @Override
    public void dataJNICallback(long retAddr) {

    }

    @Override
    public void isConnected(boolean success, String resp) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                updateUI();
            }
        });
    }






//=================================================================================================
//  Double Tap Sensing
//=================================================================================================
    private void createDoubleTapThread() {
        SensorManager mSensorManager;
        Sensor mSensor;
        mSensorManager = (SensorManager)getSystemService(Context.SENSOR_SERVICE);
        mSensor = mSensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);

        List<Sensor> deviceSensors = mSensorManager.getSensorList(Sensor.TYPE_ALL);
        //for (Sensor sensor : deviceSensors) {
            //Log.v(TAG, String.format("Sensor name: %s and type: %s", sensor.getName(), sensor.getStringType()));
        //}
        mSensorManager.registerListener(this, mSensor, SensorManager.SENSOR_DELAY_NORMAL);
        lastTrigger = 0;
    }


    final float MAG_THRESH = 0.1f;
    final int GREATER_THRESH = 6;

    @Override
    public void onSensorChanged(SensorEvent sensorEvent) {

        float xVal = abs((sensorEvent.values[0] - prevValue[0]) - prevDelta[0]);
        float yVal = abs((sensorEvent.values[1] - prevValue[1]) - prevDelta[1]);
        float zVal = abs((sensorEvent.values[2] - prevValue[2]) - prevDelta[2]);

        prevDelta[0] = sensorEvent.values[0] - prevValue[0];
        prevDelta[1] = sensorEvent.values[1] - prevValue[1];
        prevDelta[2] = sensorEvent.values[2] - prevValue[2];
        prevValue[0] = sensorEvent.values[0];
        prevValue[1] = sensorEvent.values[1];
        prevValue[2] = sensorEvent.values[2];

        if (xVal > MAG_THRESH && yVal > MAG_THRESH && zVal > MAG_THRESH)
            circGreaterBuffer[accCounter] = 1;
        else
            circGreaterBuffer[accCounter] = 0;

        int totalGreater = 0;
        for (int i = 0; i < circGreaterBuffer.length; i++)
            totalGreater += circGreaterBuffer[i];


        if (totalGreater > GREATER_THRESH) {
            long currTime = System.currentTimeMillis();
            if (currTime - lastTrigger > 250) {
                // We found a tap!
                lastTrigger = currTime;
                Toast.makeText(this, "Tap!!!", Toast.LENGTH_SHORT).show();
                if (asc.isReadyToSense()) {
                    asc.sendUserData("ukn", USERDATACODE, 0.0f, 0.0f);
                }
            }
        }

        accCounter = (accCounter + 1) % circGreaterBuffer.length;
    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int i) {

    }
}
