package umich.cse.yctung.libacousticsensing;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.pm.PackageManager;
import android.support.v4.app.ActivityCompat;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;

import com.google.gson.Gson;

import java.util.ArrayDeque;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import java.util.Vector;

import umich.cse.yctung.libacousticsensing.Audio.AudioController;
import umich.cse.yctung.libacousticsensing.Audio.AudioControllerListener;
import umich.cse.yctung.libacousticsensing.Audio.AudioSource;
import umich.cse.yctung.libacousticsensing.Audio.RecordSetting;
import umich.cse.yctung.libacousticsensing.Network.NetworkController;
import umich.cse.yctung.libacousticsensing.Network.NetworkControllerListener;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;
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
    private final static String LOG_TAG = "`";


    public int AUDIO_MODE_DEFAULT= RecordSetting.AUDIO_MODE_PLAY_AND_RECORD;
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
    private AcousticSensingSetting setting;
    private AudioSource audioSource;
    private RecordSetting recordSetting;
    private AcousticSensingControllerListener listener;
    private Context context;
    private boolean isSensing;
    private boolean needToStartSensingWhenReady;
    private LatencyAnalyzer la;
    private boolean needToAnalyzeLatency; // enable to save latency time stamps

    public AcousticSensingController(AcousticSensingControllerListener listener, Context context) {
        Constant.initGlobalConstant();
        Utils.requestPermissionsIfNeed(context);
        Utils.createLibFoldersIfNeed();

        isSensing = false;
        needToStartSensingWhenReady = false;

        this.listener = listener;
        this.context = context;
        nc = new NetworkController(this);
        jc = new JNIController(Constant.ndkTraceFolderName);

        // TODO: let remote server decide if we need to enable this (might have additonal overhead)
        needToAnalyzeLatency = true;
        la = new LatencyAnalyzer();
    }

    private boolean checkIfReadyToInit() {
        if (ActivityCompat.checkSelfPermission(context, android.Manifest.permission.READ_EXTERNAL_STORAGE) != PackageManager.PERMISSION_GRANTED
                || ActivityCompat.checkSelfPermission(context, android.Manifest.permission.RECORD_AUDIO) != PackageManager.PERMISSION_GRANTED) {
            //Utils.showSimpleAlertDialog();
            Utils.showSimpleAlertDialogWithCallback(
                    (Activity)context,
                    "Failed to request necessary permissions",
                    "LibAS need RECORD_AUDIO and WRITE_EXTERNAL_STORAGE permission to work",
                    new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialogInterface, int i) {
                            Utils.requestPermissionsIfNeed(context);
                        }
                    });
            return false;
        }
        // we might only be able to create folders at this time
        Utils.createLibFoldersIfNeed();
        return true;
    }

    /**
     * init with default value
     * @return
     */
    public boolean init(AcousticSensingSetting setting) {
        this.setting = setting;

        if (setting.getParseMode() == setting.PARSE_MODE_REMOTE) {
            return initAsRemoteMode(setting.getServerAddr(), Integer.parseInt(setting.getServerPort()));
        } else if (setting.getParseMode() == setting.PARSE_MDOE_STANDALONE) {
            // TODO: get these standalone callback setting from the AcousticSensingSetting
            return initAsStandaloneMode("audio_source.json", "signal.dat", "preamble.dat", "sync.dat");
        }
        return false;
    }

    private boolean initAsRemoteMode(String serverIp, int serverPort) {
        boolean readyToInit = checkIfReadyToInit();
        if (!readyToInit) return false;
        this.audioMode = AUDIO_MODE_DEFAULT; // TODO: decide if it is set in java or matlab
        nc.connectToServer(serverIp, serverPort);
        return true;
    }

    // This mode connect the JNI code in LibAcousticSensing, so no need matlab
    private boolean initAsStandaloneMode(String audioSourceSettingAsset, String signalAsset, String preambleToAddAsset, String preambleSyncAsset) {
        boolean readyToInit = checkIfReadyToInit();
        if (!readyToInit) return false;
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

        boolean ret = jc.init(audioSource);

        this.audioMode = AUDIO_MODE_DEFAULT; // TODO: decide if it is set in java or matlab

        listener.isConnected(true, "JNI is ready");

        return ret;
    }

    public void startSensingWhenPossible() {
        startSensingNow();
        // TODO: implement the logic to start sensing when the audio from the server is set and ready
        /*
        if (parseMode==PARSE_MODE_REMOTE) {
            // in rmote mode, sensing is possible only when the server is connected
            needToStartSensingWhenReady = true;
        } else {
            startSensingNow();
            listener.sensingStarted();
        }*/
    }

    private void startSensingNow() {
        recordSetting = new RecordSetting(AUDIO_MODE_DEFAULT);
        recordSetting.applyDeviceSensingSetting(setting);

        ac = new AudioController(context, this, audioSource /* include the playSetting */, recordSetting);
        if (ac.init(audioSource, recordSetting)) {
            ac.startSensing();
            isSensing = true;
            listener.sensingStarted();
        } else {
            Log.e(LOG_TAG, "Fail to init the AudioController");
        }
    }

    public void stopSensingNow() {
        if (ac != null) ac.stopSensing();
        isSensing = false;
        listener.sensingEnd();
        ac = null; // TODO: keep audio controller alive to save init delay

        if (needToAnalyzeLatency) {
            la.analyze();
            listener.updateDebugStatus(true, "Avg latency = " + la.resultAvgLatency);
            listener.showToast("Avg latency = " + la.resultAvgLatency);

            String resultToSet = la.getLatencyResult();
            if (setting.getParseMode() == setting.PARSE_MDOE_STANDALONE) {
                Utils.writeStringToFile("appCallbackLatencyResult = " + resultToSet + ";", Constant.libFolderPath + "latencyResult.m");
            } else if (nc != null && nc.isConnected()) {
                nc.sendSetAction(NetworkController.SET_TYPE_VALUE_STRING, "appCallbackLatencyResult", resultToSet.getBytes()); // TODO: modify it based on device
            }
        }
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
                        boolean result = asc.initAsRemoteMode(editTextServerAddr.getText().toString(),Integer.parseInt(editTextServerPort.getText().toString()));
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

    private boolean isConnected() {
        return nc.isConnected();
    }

    public boolean isReadyToSense() {
        if (setting == null) return false; // not init yet
        else if (setting.getParseMode() == setting.PARSE_MODE_REMOTE) return isConnected() && audioSource != null;
        else if (setting.getParseMode() == setting.PARSE_MDOE_STANDALONE) return jc.isReadyToSense() && audioSource != null;

        Log.e(LOG_TAG, "Undefined parseMode = " + parseMode);
        return false; // undefined
    }

    public boolean isSensing() {
        return isSensing;
    }
//=================================================================================================
// Network callbacks
//=================================================================================================
    @Override
    public void isConnected(boolean success, String resp) {
        if (!success) {
            listener.updateDebugStatus(false, "Server connect fails, "+resp);
        } else {
            // send init vars (let the server know the config of the device used for sensing)
            nc.sendSetAction(NetworkController.SET_TYPE_VALUE_STRING, "traceChannelCnt", "2".getBytes()); // TODO: modify it based on device
            nc.sendSetAction(NetworkController.SET_TYPE_STRING, "userDevice", Utils.getDeviceName().getBytes());
            // TODO: update other device property
            nc.sendInitAction(); // tell server that it is ready to start
            listener.updateDebugStatus(true, "Server is connected, now wait server to send audio");
        }
        listener.isConnected(success, resp);
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
    public void audioDelayFromServer(int delayBySamples) {
        // If we aren't currently playing, we will ignore this
        Log.e(LOG_TAG, "Received delay samples in ASC: " + delayBySamples);
        if (!isSensing) return;
        else ac.delaySoundBy(delayBySamples);
    }

    @Override
    public void resultReceviedFromServer(int audioSampleCnt, int result) {
        if (needToAnalyzeLatency) {
            la.addResultStamp(audioSampleCnt);
        }

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
        if (needToAnalyzeLatency) {
            la.addAudioStamp((int) audioTotalRecordedSampleCnt);
        }

        if (setting.getParseMode() == setting.PARSE_MODE_REMOTE && nc.isConnected()) {
            nc.sendDataRequest(data);
        } else if (setting.getParseMode() == setting.PARSE_MDOE_STANDALONE && jc.isReadyToSense()) {
            long ret = jc.addAudioSamples(data);
            if (ret == -1 || ret == -2) {
                listener.updateDebugStatus(false, "Failed to find preamble (try another microphone?)");
                stopSensingNow();
            } else if (ret != 0) { // has some data to return
                listener.dataJNICallback(ret /* return structure addr */);
                la.addResultStamp((int) audioTotalRecordedSampleCnt);
                // *** just debug ***
                Log.d(LOG_TAG, "ret = " + ret);
                jc.debugDumpAddAudioRet(ret);
            }
        }
    }
//=================================================================================================
// Latency analysis
//=================================================================================================
    private class LatencyAnalyzer {
        private class LatencyStamp {
            int sampleCnt;
            long time; // ms
            public LatencyStamp(int sampleCnt, long time) {
                this.sampleCnt = sampleCnt;
                this.time = time;
            }
        }
        Queue<LatencyStamp> audioStamps; // time stamps when the audio buffer is read
        Queue<LatencyStamp> resultStamps; // time stamps when the sensing results are updated

        public LatencyAnalyzer() {
            audioStamps = new LinkedList();
            resultStamps = new LinkedList();
        }

        public void addAudioStamp(int sampleCnt) {
            addStamp(sampleCnt, audioStamps);
        }

        public void addResultStamp(int sampleCnt) {
            addStamp(sampleCnt, resultStamps);
        }

        public double avgLatency = -1;

        public Vector<Integer> resultSampleCnts, resultLatencies;
        public double resultAvgLatency = -1;
        public void analyze() {

            LatencyStamp audioStamp;
            LatencyStamp resultStamp;

            int cnt = 0;
            double sum = 0;

            resultSampleCnts = new Vector<>();
            resultLatencies = new Vector<>();

            while(!audioStamps.isEmpty() && !resultStamps.isEmpty()) {
                audioStamp = audioStamps.peek();
                resultStamp = resultStamps.peek();

                if (audioStamp.sampleCnt == resultStamp.sampleCnt) { // find a match
                    long latency = resultStamp.time - audioStamp.time;
                    Log.d(LOG_TAG, "Find a matched latency record: " + latency + "(ms)");

                    cnt ++;
                    sum += latency;

                    resultSampleCnts.add(audioStamp.sampleCnt);
                    resultLatencies.add((int)latency);

                    audioStamps.poll();
                    resultStamps.poll();
                } else if (audioStamp.sampleCnt < resultStamp.sampleCnt) {
                    audioStamps.poll();
                } else {
                    resultStamps.poll();
                }
            }

            resultAvgLatency = cnt == 0 ? -1 : sum / cnt;
        }

        String getLatencyResult() {
            StringBuilder sb = new StringBuilder();
            sb.append("[");
            for (int i = 0; i < resultSampleCnts.size(); i++) {
                sb.append(resultSampleCnts.get(i));
                if (i != resultSampleCnts.size() - 1) sb.append(",");
            }
            sb.append(";");
            for (int i = 0; i < resultLatencies.size(); i++) {
                sb.append(resultLatencies.get(i));
                if (i != resultLatencies.size() - 1) sb.append(",");
            }
            sb.append("]");
            return sb.toString();
        }

        private void addStamp(int sampleCnt, Queue<LatencyStamp>target) {
            long now = System.currentTimeMillis();
            target.add(new LatencyStamp(sampleCnt, now));
        }
    }

}
