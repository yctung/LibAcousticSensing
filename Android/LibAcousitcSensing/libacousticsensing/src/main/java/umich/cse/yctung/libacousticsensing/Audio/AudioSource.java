package umich.cse.yctung.libacousticsensing.Audio;

/**
 * Created by Yu-Chih Tung on 1/31/17.
 * AudioSource is just a container to store the sensing audio data
 */
public class AudioSource {
    int chCnt; // number of channel
    int fs; // sample rate
    int repeatCnt;
    short[] signal;
    short[] pilot;
    String payloadName;
    String pilotName;

    public AudioSource(short[] pilot, short[] signal, int fs, int chCnt, int repeatCnt) {
        this.pilot = pilot;
        this.signal = signal;
        this.fs = fs;
        this.chCnt = chCnt;
        this.repeatCnt = repeatCnt;
    }
}
