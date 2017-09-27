package umich.cse.yctung.libacousticsensing.Audio;

import com.google.gson.annotations.SerializedName;

/**
 * Created by Yu-Chih Tung on 1/31/17.
 * AudioSource is just a container to store the sensing audio data
 * it also contains the setting of how the player should play the data
 */
public class AudioSource {
    @SerializedName("id")
    public String id;
    public int sampleRate; // sample rate
    public int chCnt; // number of channel
    public int repeatCnt;
    public int preambleEndOffset;
    public String preambleName;
    public int preambleSyncRepeatCnt;

    public short[] signal;
    public short[] preamble;
    public short[] sync;


    // this is the instructor (incomplete) called in the remote mode
    public AudioSource(short[] preamble, short[] signal, int sampleRate, int chCnt, int repeatCnt) {
        this.preamble = preamble;
        this.signal = signal;
        this.sampleRate = sampleRate;
        this.chCnt = chCnt;
        this.repeatCnt = repeatCnt;
    }

    // in the stand alone mode, this class will be initialized by the serialized json file
}

