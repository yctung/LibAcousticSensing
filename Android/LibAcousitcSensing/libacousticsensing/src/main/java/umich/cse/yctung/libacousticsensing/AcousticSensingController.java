package umich.cse.yctung.libacousticsensing;

import android.Manifest;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.pm.PackageManager;
import android.support.v4.content.ContextCompat;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;

import com.google.gson.Gson;

import java.io.IOException;
import java.io.InputStream;

import umich.cse.yctung.libacousticsensing.Audio.AudioController;
import umich.cse.yctung.libacousticsensing.Audio.AudioControllerListener;
import umich.cse.yctung.libacousticsensing.Audio.AudioSource;
import umich.cse.yctung.libacousticsensing.Audio.AudioSetting;
import umich.cse.yctung.libacousticsensing.Network.NetworkController;
import umich.cse.yctung.libacousticsensing.Network.NetworkControllerListener;
import umich.cse.yctung.libacousticsensing.Standalone.JNIController;

/**
 * Created by Yu-Chih Tung on 1/22/17.
 * Main class to control the acoustic sensing lib
 * Has several mode: 1) remote (networking) mode, 2) offline mode
 * NOTE: only one instance can be initialized
 */
public class AcousticSensingController implements NetworkControllerListener, AudioControllerListener {
//=================================================================================================
// Constants
//=================================================================================================
    private final static String LOG_TAG = "AcousticSensingContr..";
    public int PARSE_MODE_OFFLINE=1; // TOOD: implement the jni parser
    public int PARSE_MODE_REMOTE=2;  // This mode
    public int PARSE_MODE_DEFAULT=PARSE_MODE_REMOTE;


    public int AUDIO_MODE_DEFAULT=AudioSetting.AUDIO_MODE_PLAY_AND_RECORD;
    public int LOG_MODE_SAVE_AUDIO_TO_FILE=1;
    public int LOG_MODE_DEFAULT=LOG_MODE_SAVE_AUDIO_TO_FILE;
//=================================================================================================
// Internal status
//=================================================================================================
    private int audioMode, parseMode, logMode;
    private int FS;
    private int serverPort;
    private String serverIp;
    private int playCnt=-1; // -1 means to play the audio infinitely
    private NetworkController nc;
    private JNIController jc;
    private AudioController ac;
    private AudioSource audioSource;
    private AudioSetting recordSetting;
    private AcousticSensingControllerListener listener;
    private Context context;
    public AcousticSensingController(AcousticSensingControllerListener listener, Context context) {
        this.listener = listener;
        this.context = context;
        nc = new NetworkController(this);
        jc = new JNIController("test");
        jc.testNDK();
    }

    /**
     * init with default value
     * @return
     */
    public boolean init() {
        return init(AUDIO_MODE_DEFAULT, PARSE_MODE_DEFAULT, LOG_MODE_DEFAULT, -1);
    }

    public boolean init(int audooMode, int parseMode, int logMode, int playCnt) {
        return true;
    }

    public boolean initAsSlaveMode(String serverIp, int serverPort) {
        this.serverIp=serverIp;
        this.serverPort=serverPort;
        this.parseMode=PARSE_MODE_REMOTE;
        this.audioMode=AUDIO_MODE_DEFAULT; // TODO: decide if it is set in java or matlab
        return true;
    }

    // This mode connect the JNI code in LibAcousticSensing, so no need matlab
    public boolean initAsStandaloneMode(String audioSourceSettingAsset, String signalAsset, String preambleToAddAsset, String preambleSyncAsset) {
        short[] signal = Utils.loadAudioFromAssetAsShort(context, signalAsset);
        short[] preamble = Utils.loadAudioFromAssetAsShort(context, preambleToAddAsset);
        short[] sync = Utils.loadAudioFromAssetAsShort(context, preambleSyncAsset);
        String json = Utils.loadJSONFromAsset(context, audioSourceSettingAsset);
        if (signal == null || preamble == null || sync == null || json == null) return false;

        Gson gson = new Gson();
        audioSource  = gson.fromJson(json, AudioSource.class);
        audioSource.signal = signal;
        audioSource.preamble = preamble;
        audioSource.sync = sync;

        return true;
    }

    public void startSensingWhenPossible() {
        if (parseMode==PARSE_MODE_REMOTE) {
            nc.connectToServer(serverIp, serverPort);
        } else {
            startSensingNow();
            listener.sensingStarted();
        }
    }

    private void startSensingNow() {
        recordSetting = new AudioSetting(audioMode);
        ac = new AudioController(context, this, audioSource, recordSetting);
        if (ac.init(audioSource, recordSetting)) {
            ac.startSensing();
            listener.sensingStarted();
        } else {
            Log.e(LOG_TAG, "Fail to init the AudioController");
        }
    }

    private void stopSensingNow() {
        if (ac != null) ac.stopSensing();
        listener.sensingEnd();
        ac = null; // TODO: keep audio controller alive to save init delay
    }

    // funtion to show the customized dialog for initailzation
    public Dialog createInitModeDialog(Activity activity, String serverIpDefault, int serverPortDefault) {
        AlertDialog.Builder builder = new AlertDialog.Builder(activity);
        final LayoutInflater inflater = activity.getLayoutInflater();
        final View view = inflater.inflate(R.layout.dialog_acoustic_sensing_controller_init, null);

        final EditText editTextServerAddr = (EditText)view.findViewById(R.id.editTextServerAddr);
        editTextServerAddr.setText(serverIpDefault);
        final EditText editTextServerPort = (EditText)view.findViewById(R.id.editTextServerPort);
        editTextServerPort.setText(String.format("%d",serverPortDefault));

        final Spinner spinnerMode = (Spinner)view.findViewById(R.id.spinnerMode);
        String[] modes = new String[]{"Server-client Mode","Real-time Mode"};
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(activity, R.layout.support_simple_spinner_dropdown_item, modes);
        spinnerMode.setAdapter(adapter);
        spinnerMode.setSelection(0);

        builder.setView(view)
                .setTitle("Please select init mode")
                // Add action buttons
                .setPositiveButton("Ok", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int id) {
                        AcousticSensingController asc = AcousticSensingController.this;
                        boolean result = asc.initAsSlaveMode(editTextServerAddr.getText().toString(),Integer.parseInt(editTextServerPort.getText().toString()));
                        if (!result) asc.updateDebugStatus(false, "Init fails");
                        else {
                            asc.startSensingWhenPossible();
                        }
                    }
                })
                .setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                    }
                });



        return builder.create();
    }

    public void sendUserData(String tag, int code, float arg0, float arg1) {
        int stamp = -1;
        if (ac!=null) stamp = (int) ac.audioTotalRecordedSampleCnt;
        nc.sendUserAction(stamp, tag, code, arg0, arg1, null);
    }

    public boolean isConnected() {
        return nc.isConnected();
    }
//=================================================================================================
// Network callbacks
//=================================================================================================
    @Override
    public void isConnected(boolean success, String resp) {
        if (!success) {
            listener.updateDebugStatus(false, "Server connect fails, "+resp);
        }
        else {
            // send init vars (let the server know the config of the device used for sensing)
            nc.sendSetAction(NetworkController.SET_TYPE_VALUE_STRING, "traceChannelCnt", "2".getBytes()); // TODO: modify it based on device
            nc.sendSetAction(NetworkController.SET_TYPE_STRING, "userDevice", Utils.getDeviceName().getBytes());
            // TODO: update other device property
            nc.sendInitAction(); // tell server that it is ready to start
            listener.updateDebugStatus(true, "Server is connected, now wait server to send audio");
        }
    }

    @Override
    public void serverAskStartSensing() {
        ((Activity)context).runOnUiThread(new Runnable() {
            @Override
            public void run() {
                startSensingNow();
            }
        });
    }

    @Override
    public void serverAskStopSensing() {
        ((Activity)context).runOnUiThread(new Runnable() {
            @Override
            public void run() {
                stopSensingNow();
            }
        });
    }

    @Override
    public void audioReceivedFromServer(AudioSource audioSource) {
        this.audioSource = audioSource;
    }

    @Override
    public void resultReceviedFromServer(int result) {
        listener.updateResult(result, 0.0f);
    }

    @Override
    /**
     * Called when the server shuts down. This is not just stopping the sensing. It actually
     * shuts down the network socket connection.
     */
    public void serverClosed () {
        nc.closeServerIfServerIsAlive();
        listener.serverClosed();
    }

    @Override
    public void userStudyEnd() {

    }

    @Override
    public int consumeReceivedData(double dataReceived) {
        return 0;
    }

    @Override
    public void updateDebugStatus(boolean status, String stringToShow) {

    }

    @Override
    public void error(String message) {

    }

//=================================================================================================
// Audio callbacks
//=================================================================================================
    @Override
    public void onAudioRecordAndPlayEnd() {
        if (nc.isConnected()) {
            nc.sendSensingEndAction();
        }
    }

    @Override
    public void audioRecorded(byte[] data, long audioTotalRecordedSampleCnt) {
        if (nc.isConnected()) {
            nc.sendDataRequest(data);
        }
    }
}
