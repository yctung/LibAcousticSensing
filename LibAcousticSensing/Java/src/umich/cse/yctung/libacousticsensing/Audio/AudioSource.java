package umich.cse.yctung.libacousticsensing.Audio;

import java.nio.ByteBuffer;

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

    // used in Java, since it needs the bytes
    public byte[] signalBytes;
    public byte[] preambleBytes;

    // this is the instructor (incomplete) called in the remote mode
    public AudioSource(short[] preamble, short[] signal, int sampleRate, int chCnt, int repeatCnt) {
        this.preamble = preamble;
        this.signal = signal;
        this.sampleRate = sampleRate;
        this.chCnt = chCnt;
        this.repeatCnt = repeatCnt;
        
        // TODO: need to convert it to the big/little endian based on OS (!?)
        preambleBytes = shortArrayToByteArray(preamble, true /* little endian */);
        signalBytes = shortArrayToByteArray(signal, true /* little endian */);
    }

    
    byte[] shortArrayToByteArray(short[] s, boolean isLittleEndian) {
    	byte[] b = new byte[s.length * 2];
    	
    	for (int sIdx = 0, bIdx = 0; sIdx < s.length; sIdx ++, bIdx += 2) {
    		if (isLittleEndian) {
    			b[bIdx] = (byte)(s[sIdx] & 0x00FF);
        		b[bIdx + 1] = (byte)((s[sIdx] & 0xFF00) >> 8);
    		} else {
    			b[bIdx] = (byte)((s[sIdx] & 0xFF00) >> 8); 
        		b[bIdx + 1] = (byte)(s[sIdx] & 0x00FF);
    		}
    	}
    	
    	return b;
    }
}

