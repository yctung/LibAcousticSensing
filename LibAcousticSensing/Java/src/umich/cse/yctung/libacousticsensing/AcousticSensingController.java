package umich.cse.yctung.libacousticsensing;


import java.util.LinkedList;
import java.util.Queue;
import java.util.Vector;

import com.google.gson.Gson;

import umich.cse.yctung.libacousticsensing.Audio.AudioController;
import umich.cse.yctung.libacousticsensing.Audio.AudioControllerListener;
import umich.cse.yctung.libacousticsensing.Audio.AudioSource;
import umich.cse.yctung.libacousticsensing.Audio.RecordSetting;
import umich.cse.yctung.libacousticsensing.Network.NetworkController;
import umich.cse.yctung.libacousticsensing.Network.NetworkControllerListener;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;

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
    private final static String LOG_TAG = "SensingController";


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
    private AudioController ac;
    private AcousticSensingSetting setting;
    private AudioSource audioSource;
    private RecordSetting recordSetting;
    private AcousticSensingControllerListener listener;
    private boolean isSensing;
    private boolean needToStartSensingWhenReady;
    private LatencyAnalyzer la;
    private boolean needToAnalyzeLatency; // enable to save latency time stamps
    
    public AcousticSensingController(AcousticSensingControllerListener listener) {
        Constant.initGlobalConstant();
        //Utils.requestPermissionsIfNeed(context);
        Utils.createLibFoldersIfNeed();

        isSensing = false;
        needToStartSensingWhenReady = false;

        this.listener = listener;
        nc = new NetworkController(this);
        //jc = new JNIController(Constant.ndkTraceFolderName);
        
        // TODO: let remote server decide if we need to enable this (might have additonal overhead)
        needToAnalyzeLatency = true;
        la = new LatencyAnalyzer();
    }

    private boolean checkIfReadyToInit() {
        //TODO: check permission to write file / play record audio again here
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
            // return initAsStandaloneMode("audio_source.json", "signal.dat", "preamble.dat", "sync.dat");
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
    /*
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
        return ret;
    }
    */

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

        ac = new AudioController(this, audioSource /* include the playSetting */, recordSetting);
        if (ac.init(audioSource, recordSetting)) {
            ac.startSensing();
            isSensing = true;
            listener.sensingStarted();
        } else {
            Log.e(LOG_TAG, "Fail to init the AudioController");
        }
    }

    public void stopSensingNow() {
    	Log.d(LOG_TAG, "stopSensingNow()");
    	if (needToAnalyzeLatency) {
            la.analyze();
            Log.d(LOG_TAG, "Avg latency = " + la.resultAvgLatency);
            listener.updateDebugStatus(true, "Avg latency = " + la.resultAvgLatency);
            listener.showToast("Avg latency = " + la.resultAvgLatency);
            
            if (nc != null && nc.isConnected()) {
            	String resultToSet = la.getLatencyResult();
            	nc.sendSetAction(NetworkController.SET_TYPE_VALUE_STRING, "appCallbackLatencyResult", resultToSet.getBytes()); // TODO: modify it based on device
            }
        }
    	Log.d(LOG_TAG, "latency analysis ends");
    	
        if (ac != null) ac.stopSensing();
        
        
        
        isSensing = false;
        listener.sensingEnd();
        ac = null; // TODO: keep audio controller alive to save init delay
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
        //else if (setting.getParseMode() == setting.PARSE_MDOE_STANDALONE) return jc.isReadyToSense() && audioSource != null;

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
            nc.sendSetAction(NetworkController.SET_TYPE_VALUE_STRING, "traceChannelCnt", "1".getBytes()); // TODO: modify it based on device
            nc.sendSetAction(NetworkController.SET_TYPE_STRING, "userDevice", Utils.getDeviceName().getBytes());
            // TODO: update other device property
            nc.sendInitAction(); // tell server that it is ready to start
            listener.updateDebugStatus(true, "Server is connected, now wait server to send audio");
        }
        listener.isConnected(success, resp);
    }

    @Override
    public void serverAskStartSensing() {
    	// TODO: run on UI thread?
    	startSensingNow();
    }

    @Override
    public void serverAskStopSensing() {
    	// TODO: run on UI thread?
    	stopSensingNow();
    }

    @Override
    public void audioReceivedFromServer(AudioSource audioSource) {
        this.audioSource = audioSource;
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
            //Log.d(LOG_TAG, "send data of sampleCnt = " + audioTotalRecordedSampleCnt);
        }
    	
        if (setting.getParseMode() == setting.PARSE_MODE_REMOTE && nc.isConnected()) {
            nc.sendDataRequest(data);
        } 
        //else if (setting.getParseMode() == setting.PARSE_MDOE_STANDALONE && jc.isReadyToSense()) {
        //    long ret = jc.addAudioSamples(data);
        //    if (ret == -1 || ret == -2) {
        //        listener.updateDebugStatus(false, "Failed to find preamble (try another microphone?)");
        //        stopSensingNow();
        //    } else if (ret != 0) { // has some data to return
        //        listener.dataJNICallback(ret /* return structure addr */);
        //        // *** just debug ***
        //        Log.d(LOG_TAG, "ret = " + ret);
        //        jc.debugDumpAddAudioRet(ret);
        //    }
        //}
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
                     Log.d(LOG_TAG, "Find a matched latency record (" + 
                    		 audioStamp.sampleCnt + "," + 
                    		 audioStamp.time + "," +
                    		 resultStamp.time + "): " + 
                    		 latency + "(ms)");

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
