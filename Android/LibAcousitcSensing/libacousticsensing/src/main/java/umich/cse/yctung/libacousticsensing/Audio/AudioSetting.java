package umich.cse.yctung.libacousticsensing.Audio;

import android.icu.text.AlphabeticIndex;
import android.media.AudioFormat;
import android.media.AudioRecord;
import android.media.MediaRecorder;
import android.util.Log;

/**
 * Created by Yu-Chih Tung on 2/1/17.
 */
public class AudioSetting {
    String TAG = "AudioSetting";
    int AudioSetting;
    public static int AUDIO_MODE_RECORD_ONLY=1;
    public static int AUDIO_MODE_PLAY_ONLY=2;
    public static int AUDIO_MODE_PLAY_AND_RECORD=AUDIO_MODE_RECORD_ONLY|AUDIO_MODE_PLAY_ONLY;

    private static final int RECORDER_TOTAL_BUFFER_SIZE = 480000;

    int audioMode;
    int recordChCnt;
    int recordFS;

    public AudioSetting(int audioMode) {
        recordChCnt = 2; // TODO: load from server
        this.audioMode = audioMode;
        this.recordFS = 48000;
    }

    public AudioRecord createNewAudioRecord() {
        // TODO: create recorder based on user's setting
        AudioRecord audioRecord = new AudioRecord(MediaRecorder.AudioSource.VOICE_RECOGNITION, recordFS, AudioFormat.CHANNEL_IN_STEREO, AudioFormat.ENCODING_PCM_16BIT, RECORDER_TOTAL_BUFFER_SIZE);
        // TODO: ensure this audioRecord is ready to record (usually different device might need different init setting), ref: http://stackoverflow.com/questions/4843739/audiorecord-object-not-initializing
        if (audioRecord.getState() == AudioRecord.STATE_INITIALIZED) return audioRecord;
        Log.e(TAG, "Unable to init AudioRecord class (forget to request the permission or using a wrong setting?)");
        return null;
    }

}
