package umich.cse.yctung.libacousticsensing;

import android.app.Activity;
import android.content.Context;
import android.util.Log;

import umich.cse.yctung.libacousticsensing.Audio.AudioController;
import umich.cse.yctung.libacousticsensing.Audio.AudioControllerListener;
import umich.cse.yctung.libacousticsensing.Audio.AudioSource;
import umich.cse.yctung.libacousticsensing.Audio.AudioSetting;
import umich.cse.yctung.libacousticsensing.Network.NetworkController;
import umich.cse.yctung.libacousticsensing.Network.NetworkControllerListener;

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
    private AudioController ac;
    private AudioSource audioSource;
    private AudioSetting recordSetting;
    private AcousticSensingControllerListener listener;
    private Context context;
    public AcousticSensingController(AcousticSensingControllerListener listener, Context context) {
        this.listener=listener;
        this.context=context;
        nc=new NetworkController(this);
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

    public boolean initAsRealtimeMode() {
        return true;
    }

    public void startSensingWhenPossible() {
        if (parseMode==PARSE_MODE_REMOTE) {
            nc.connectToServer(serverIp, serverPort);
        } else {
            startSensingNow();
        }
    }

    private void startSensingNow() {
        recordSetting = new AudioSetting(audioMode);
        ac = new AudioController(context, this, audioSource, recordSetting);
        if (ac.init(audioSource, recordSetting)) {
            ac.startSensing();
        } else {
            Log.e(LOG_TAG, "Fail to init the AudioController");
        }
    }

//=================================================================================================
// Network callbacks
//=================================================================================================
    @Override
    public void isConnected(boolean success, String resp) {
        if (!success) listener.updateDebugStatus("Server connect fails, "+resp);
        else {
            // send init vars (let the server know the config of the device used for sensing)
            nc.sendSetAction(NetworkController.SET_TYPE_VALUE_STRING, "traceChannelCnt", "2".getBytes()); // TODO: modify it based on device
            nc.sendSetAction(NetworkController.SET_TYPE_STRING, "userDevice", Utils.getDeviceName().getBytes());
            // TODO: update other device property
            nc.sendInitAction(); // tell server that it is ready to start
            listener.updateDebugStatus("Server is connected, now wait server to send audio");
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
    public void audioReceivedFromServer(AudioSource audioSource) {
        this.audioSource = audioSource;
    }

    @Override
    public void resultReceviedFromServer(int result) {

    }

    @Override
    public void userStudyEnd() {

    }

    @Override
    public int consumeReceivedData(double dataReceived) {
        return 0;
    }

    @Override
    public void updateDebugStatus(String stringToShow) {

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
