package umich.cse.yctung.libacousticsensing.Standalone;

import umich.cse.yctung.libacousticsensing.Audio.AudioSource;

/**
 * Created by yctung on 9/20/17.
 */
public class JNIController {
    static {
        System.loadLibrary("standalone");
    }

    // NOTE: these JNI functions can't be recognized by AndroidStudio (but they existed)
    //       because I am using the old script to compile ndk files manually
    private native void initAudioSource(int sampleRate, int chCnt, int repeatCnt, int preambleEndOffset, int preambleSyncRepeatCnt, short[] signal, short[] preamble, short[] sync);
    private native void initParseSetting(int recordChCnt, int preambleSearchChIdxMatlab);
    private native void initSenseSetting(String logFolderPath);
    public native boolean isReadyToSense();
    public native long addAudioSamples(byte[] audioToAdd);
    public native void debugDumpAddAudioRet(long addAudioRet);

    public JNIController(String logFolderPath){
        initSenseSetting(logFolderPath);
    }

    private void setAudioSource(AudioSource audioSource) {
        initAudioSource(
                audioSource.sampleRate,
                audioSource.chCnt,
                audioSource.repeatCnt,
                audioSource.preambleEndOffset,
                audioSource.preambleSyncRepeatCnt,
                audioSource.signal,
                audioSource.preamble,
                audioSource.sync
        );
    }

    public boolean init(AudioSource audioSource) {
        setAudioSource(audioSource);
        initParseSetting(2/*TODO: read from parsing config*/, 1/* 1st channel (follow matlab's convention of indexing by 1)*/);
        // TODO: update sensing setting
        return isReadyToSense();
    }
}
