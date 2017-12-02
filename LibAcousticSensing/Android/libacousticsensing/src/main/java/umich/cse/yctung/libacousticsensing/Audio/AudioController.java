package umich.cse.yctung.libacousticsensing.Audio;

import android.content.Context;
import android.media.AudioFormat;
import android.media.AudioManager;
import android.media.AudioRecord;
import android.media.AudioTrack;
import android.media.MediaRecorder;
import android.media.audiofx.AutomaticGainControl;
import android.media.audiofx.NoiseSuppressor;
import android.os.Handler;
import android.os.Message;
import android.os.Process;
import android.util.Log;

import umich.cse.yctung.libacousticsensing.Constant;
import umich.cse.yctung.libacousticsensing.Utils;

/**
 * Created by eddyxd on 1/22/17.
 */
public class AudioController {
    private String LOG_TAG = Constant.LOG_TAG+"_AudioController";
    final static boolean SHOW_DEBUG_INFO_TIME_MESSAGE=true;
    final static boolean SHOW_DEBUG_INFO_AUDIO_RECORDING=true;

    private static final int RECORDER_BYTE_PER_ELEMENT = 2; // 2 bytes in 16bit format
    private static final int RECORDER_BUFFER_ELEMENTS = 4800*2; // this is the size of audio buffer elements *** WARN: this number must be a multiple of  ***
    //private static final int RECORDER_BUFFER_ELEMENTS = 4800*4; // this is the size of audio buffer elements *** WARN: this number must be a multiple of  ***


    private static final int MESSAGE_TO_START_PLAY = 1;
    private static final int MESSAGE_TO_STOP_RECORD = 2;
    private static final int MESSAGE_PLAY_IS_STOPPED = 3;
    private static final int MESSAGE_RECORD_IS_STOPPED = 4;

    private static final int DELAY_TO_START_PLAY = 200; // ms, time to wait recordering thread before playing
    private static final int DELAY_TO_STOP_RECORD = 200; // ms, time to wait before actually ask recording thread to stop (so the last few signals will never lose)

    Context context;
    AudioSource audioSource;
    RecordSetting audioSetting;
    AudioControllerListener listener;

    // Android audio interfaces
    AudioRecord audioRecord;
    AudioTrack audioTrack;
    SensingTimer sensingTimer;

    // Internal status
    boolean keepSensing;
    //boolean isPlayingAndRecording;
    boolean startAndKeepRecording;
    boolean isRecording;
    boolean isPlaying;
    int delaySoundByOnce = -1;
    public long audioTotalRecordedSampleCnt = -1; // TODO: check the overflow issue


    public AudioController(Context context, AudioControllerListener listener, AudioSource audioSource, RecordSetting recordSetting) {
        this.context = context;
        this.listener = listener;
        sensingTimer = new SensingTimer();
        setAudioSource(audioSource);
        this.audioSetting = recordSetting;

        //setAudioSetting(recordSetting);
    }

    // this method is separated from constructor so the same AudioController can be used more than once
    public void setAudioSource(AudioSource audioSource) {
        this.audioSource = audioSource;
        int PLAYER_TOTAL_BUFFER_SIZE = 960*4*2; // just for debug, TODO: update to a better value

        // TODO: modify the stream type based on audioSource

        audioTrack = new AudioTrack(AudioManager.STREAM_MUSIC, audioSource.sampleRate, AudioFormat.CHANNEL_OUT_MONO, AudioFormat.ENCODING_PCM_16BIT, PLAYER_TOTAL_BUFFER_SIZE, AudioTrack.MODE_STREAM);

        while( audioTrack.getState()==AudioTrack.STATE_UNINITIALIZED ){
            Log.e(LOG_TAG, "audioTrackState cant be initialized -> wait next try!");
            audioTrack = new AudioTrack(AudioManager.STREAM_MUSIC, audioSource.sampleRate, AudioFormat.CHANNEL_OUT_MONO, AudioFormat.ENCODING_PCM_16BIT, PLAYER_TOTAL_BUFFER_SIZE, AudioTrack.MODE_STREAM);
        }
    }

    // this method is separated from constructor so the same AudioController can be used more than once
    /*
    public void setAudioSetting(RecordSetting audioSetting) {
        this.audioSetting = audioSetting;
        audioRecord = audioSetting.createNewAudioRecord();
    }
    */

    public boolean init(AudioSource audioSource, RecordSetting recordSetting) {
        if (keepSensing||isPlaying||isRecording) {
            Log.e(LOG_TAG, "[ERROR]: unable to init because the previous sensing is not stopped yet (forget to stop it?)");
            return false;
        }

        this.audioSetting = recordSetting; // TOOD: move it to a better way

        // *** WARN: uncomment this just for testing AGC ***
        //audioRecord = new AudioRecord(MediaRecorder.AudioSource.VOICE_RECOGNITION, recordSetting.recordFS, AudioFormat.CHANNEL_IN_STEREO, AudioFormat.ENCODING_PCM_16BIT, recordSetting.RECORDER_TOTAL_BUFFER_SIZE);
        audioRecord = new AudioRecord(recordSetting.audioSource, recordSetting.recordFS, AudioFormat.CHANNEL_IN_STEREO, AudioFormat.ENCODING_PCM_16BIT, recordSetting.RECORDER_TOTAL_BUFFER_SIZE);
        Log.w(LOG_TAG, "AudioSource = " + recordSetting.audioSource);

        // check noise supressor if need
        if (NoiseSuppressor.isAvailable()) {
            NoiseSuppressor nc = NoiseSuppressor.create(audioRecord.getAudioSessionId());
            if (nc != null) {
                //Log.d(LOG_TAG,"nc before enable = "+nc.getEnabled());
                //nc.setEnabled(true);
                //Log.d(LOG_TAG, "nc before enable = "+nc.getEnabled());
            }
        }

        if (AutomaticGainControl.isAvailable()) {
            AutomaticGainControl agc = AutomaticGainControl.create(audioRecord.getAudioSessionId());
            if (agc != null) {
            /*
            Log.d(LOG_TAG,"agc before disabled = "+agc.getEnabled());
            agc.setEnabled(false);
            Log.d(LOG_TAG, "agc before disabled = "+agc.getEnabled());
            */
            }
        }

        // *** END OF WARN: uncomment this just for testing AGC ***

        //audioRecord = new AudioRecord(MediaRecorder.AudioSource.VOICE_RECOGNITION, recordSetting.recordFS, AudioFormat.CHANNEL_IN_STEREO, AudioFormat.ENCODING_PCM_16BIT, recordSetting.RECORDER_TOTAL_BUFFER_SIZE);


        if (audioRecord.getState() != AudioRecord.STATE_INITIALIZED) {
            Log.e(LOG_TAG, "Unable to init AudioRecord class (forget to request the permission or using a wrong setting?)");
            return false;
        }

        keepSensing = false;
        startAndKeepRecording = false;
        isPlaying = false;
        isRecording = false;
        audioTotalRecordedSampleCnt = 0;
        return true;
    }

    public void startSensing() {
        keepSensing = true;
        startRecordAndThenPlayAudio();
    }

    public void stopSensing() {
        keepSensing = false; // NOTE: set this flag will enforce the play & recording thread to stop
        Log.w(LOG_TAG, "wait audio playing and recording terminate ...");
        while (isPlaying||isRecording);
        Log.w(LOG_TAG, "audio playing and recording has terminated!");
    }


    public void delaySoundBy (int delayBySamples) {
        Log.e(LOG_TAG, "Received delay samples in AC: " + delayBySamples);
        if (!isPlaying) return;
        delaySoundByOnce = delayBySamples;
    }

    /*
    public void destroy() {
        stopSensing();
        if (audioRecord!=null) {
            audioRecord.stop();
            audioRecord.release();
            audioRecord = null;
        }
        audioTrack.stop();
        audioTrack.release();
        audioTrack = null;
    }*/
//=================================================================================================
//  Internal help functions
//=================================================================================================
    private void startRecordAndThenPlayAudio() {
        // NOTE: it is necessary to ensure the audio is recording before playing the audio
        if (audioSetting.audioMode== RecordSetting.AUDIO_MODE_PLAY_AND_RECORD) {
            startRecording();
            sensingTimer.sendMessageDelayed(Message.obtain(null, MESSAGE_TO_START_PLAY), DELAY_TO_START_PLAY);
        } else if (audioSetting.audioMode== RecordSetting.AUDIO_MODE_PLAY_ONLY) {
            startPlaying();
        } else if (audioSetting.audioMode== RecordSetting.AUDIO_MODE_RECORD_ONLY) {
            startRecording();
        } else {
            Log.e(LOG_TAG, "[ERROR]: undefined audioMode="+audioSetting.audioMode);
        }
    }

    private void sensingEnd() {
        // TODO: tune the audio record/play to the begin
        // TODO: move the folder?

        keepSensing = false;
        listener.onAudioRecordAndPlayEnd();
    }
//=================================================================================================
//  Audio play related
//=================================================================================================
    private void startPlaying() {
        if(SHOW_DEBUG_INFO_TIME_MESSAGE) Log.d(LOG_TAG, "startPlaying() is called" + Utils.getTime());
        new Thread(new Runnable() {
            @Override
            public void run() {
                android.os.Process.setThreadPriority(android.os.Process.THREAD_PRIORITY_URGENT_AUDIO);
                if(audioTrack==null){
                    Log.e(LOG_TAG, "[ERROR]: try to play a null audio track -> click the button too often?");
                    while(audioTrack==null) Log.e(LOG_TAG, "[ERROR]: wait mAudioTrack!=null");
                    Log.e(LOG_TAG, "[ERROR]: wait mAudioTrack!=null successfull, play it now");
                }
                isPlaying = true;
                audioTrack.play();
                keepAudioPlaying();
            }
        }).start();
    }
    private void keepAudioPlaying() {
        // NOTE the write is a block call, ref: http://stackoverflow.com/questions/38291469/android-audiotrack-write-blocks-for-the-whole-period-of-playback
        int writeCnt;
        writeCnt = audioTrack.write(audioSource.preamble, 0, audioSource.preamble.length);
        if (writeCnt!=audioSource.preamble.length) Log.e(LOG_TAG,"[ERROR]: wrong size of preamble is played by audioTrack, writeCnt="+writeCnt);
        // TODO: check if there will be a delay between several audioTrack write executions
        int playCnt=0;
        while (keepSensing) {
            if (audioSource.repeatCnt>0&&playCnt>=audioSource.repeatCnt) { // end of repeat audio playing
                break;
            }
            writeCnt = audioTrack.write(audioSource.signal, 0, audioSource.signal.length);
            if (delaySoundByOnce != -1) {
                Log.e(LOG_TAG, "Actually delaying sound in AC play loop: " + delaySoundByOnce);
                audioTrack.write(new short[delaySoundByOnce], 0, delaySoundByOnce);
                delaySoundByOnce = -1;
            }

            playCnt++;
        }
        isPlaying = false;
        Log.d(LOG_TAG, "Reach the end of keepAudioPlaying()");
        sensingTimer.sendMessage(Message.obtain(null, MESSAGE_PLAY_IS_STOPPED));
    }

//=================================================================================================
//  Audio record related
//=================================================================================================
    private void startRecording() {
        if(SHOW_DEBUG_INFO_TIME_MESSAGE) Log.d(LOG_TAG, "startRecording() is called at: " + Utils.getTime());
        new Thread(new Runnable() {
            @Override
            public void run() {
                android.os.Process.setThreadPriority(Process.THREAD_PRIORITY_URGENT_AUDIO);
                startAndKeepRecording = true; // it is a dummy flag now, try to design it carefully when there is something weird for the fisrt few sample recorded
                keepAudioRecording();
            }
        }).start();
    }
    private void keepAudioRecording() {
        byte[] byteBuffer = new byte[RECORDER_BUFFER_ELEMENTS * RECORDER_BYTE_PER_ELEMENT];
        audioTotalRecordedSampleCnt = 0; // init this log value to 0 for every recording
        audioRecord.startRecording();

        // start recording infinite loop (stop when playing is done)
        while(keepSensing){
            // start to record only when startAndKeepRecording is triggered
            if(startAndKeepRecording){
                int byteRead = audioRecord.read(byteBuffer, 0, RECORDER_BUFFER_ELEMENTS*RECORDER_BYTE_PER_ELEMENT);
                if(SHOW_DEBUG_INFO_AUDIO_RECORDING) Log.d(LOG_TAG, "byteRead = " + byteRead);
                if (byteRead > 4) {
                    Log.w(LOG_TAG, "First 4 bytes = (" + byteBuffer[0] + "," + byteBuffer[1] + "," + byteBuffer[2] + "," + byteBuffer[3] + ")");
                }
                if(byteRead != RECORDER_BUFFER_ELEMENTS * RECORDER_BYTE_PER_ELEMENT) Log.e(LOG_TAG, "[ERROR]: byteRead in audioRecord not matched! = "+byteRead);
                audioTotalRecordedSampleCnt += byteRead / (audioSetting.recordChCnt*RECORDER_BYTE_PER_ELEMENT); // only recorded the number of "sample" in each channel as a reference point
                listener.audioRecorded(byteBuffer.clone(), audioTotalRecordedSampleCnt);
                // TODO: save audio to file if need
                if(SHOW_DEBUG_INFO_AUDIO_RECORDING) Log.d(LOG_TAG, "end of one record");

                // check if need to stop
                if (!startAndKeepRecording || !keepSensing) {
                    Log.d(LOG_TAG, "recording need to stop");
                    if (startAndKeepRecording) {
                        startAndKeepRecording = false;
                        break;
                    }
                }
            } else {
                // do nothing, just clear the audio record buffer
                audioRecord.read(byteBuffer, 0, RECORDER_BUFFER_ELEMENTS * RECORDER_BYTE_PER_ELEMENT);
            }
        }

        // stop recording
        // *** just for debug ***
        // ref: http://stackoverflow.com/questions/5139739/android-audiorecord-wont-initialize-2nd-time
        audioRecord.stop();
        audioRecord.release();
        audioRecord = null;
        Log.w(LOG_TAG, "audioRecord is released");
    }

//=================================================================================================
//  Internal timer to help schedule (add delay) between executions
//=================================================================================================
    private class SensingTimer extends Handler {
        public void handleMessage(Message msg) {
            super.handleMessage(msg);
            if (SHOW_DEBUG_INFO_AUDIO_RECORDING) Log.d(LOG_TAG, "RecordTimer: get a message (what,arg1,arg2) = (" + msg.what + "," + msg.arg1 + "," + msg.arg2 + ")" + Utils.getTime());

            if (msg.what == MESSAGE_TO_START_PLAY) {
                startPlaying();
            } else if (msg.what == MESSAGE_PLAY_IS_STOPPED) {
                if (!isRecording) sensingEnd();
                else sensingTimer.sendMessageDelayed(Message.obtain(null, MESSAGE_TO_STOP_RECORD), DELAY_TO_STOP_RECORD);
            } else if (msg.what == MESSAGE_TO_STOP_RECORD) {
                startAndKeepRecording = false; // set it to false will force the recording thread to stop
            } else if (msg.what == MESSAGE_RECORD_IS_STOPPED) {
                if (!isPlaying) sensingEnd();
            } else {
                Log.e(LOG_TAG, "[ERROR]: undefined message type = "+msg.what);
            }
        }
    }

}
