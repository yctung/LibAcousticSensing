package umich.cse.yctung.libacousticsensing.Audio;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;

import javax.sound.sampled.AudioFormat;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.DataLine;
import javax.sound.sampled.Line;
import javax.sound.sampled.LineUnavailableException;
import javax.sound.sampled.Mixer;
import javax.sound.sampled.SourceDataLine;
import javax.sound.sampled.TargetDataLine;

import umich.cse.yctung.libacousticsensing.Log;
import umich.cse.yctung.libacousticsensing.Utils;


public class AudioController {
	private final static String TAG = "AudioController"; 
	public static boolean SHOW_DEBUG_INFO_TIME_MESSAGE = false;
	public static boolean SHOW_DEBUG_INFO_AUDIO_RECORDING = false;
	
	private static final int RECORDER_BYTE_PER_ELEMENT = 2; // 2 bytes in 16bit format
    private static final int RECORDER_BUFFER_ELEMENTS = 4800*2; // this is the size of audio buffer elements *** WARN: this number must be a multiple of  ***
	
	// Internal status
    boolean keepSensing;
    boolean startAndKeepRecording;
    boolean isRecording;
    boolean isPlaying;
	public long audioTotalRecordedSampleCnt;
	
	//float FS=96000.0f;
	float FS=48000.0f;
	
	AudioControllerListener listener;
	AudioSource audioSource;
	RecordSetting recordSetting;
	
	SourceDataLine player;
	TargetDataLine recorder;
	public AudioController(AudioControllerListener listener, AudioSource audioSource, RecordSetting recordSetting) {
		// ref: http://stackoverflow.com/questions/25798200/java-record-mic-to-byte-array-and-play-sound
		// TODO: init based on the setting
		this.listener = listener;
		this.audioSource = audioSource;
		this.recordSetting = recordSetting;
	}
	
	public void dumpMixerInfo() {
		// dump mixer information
		try {
        Mixer.Info[] mixerInfos = AudioSystem.getMixerInfo();
        for (Mixer.Info info: mixerInfos){
        	Mixer m = AudioSystem.getMixer(info);
        	Line.Info[] lineInfos = m.getSourceLineInfo();
        	for (Line.Info lineInfo:lineInfos){
        		System.out.println (info.getName()+"---"+lineInfo);
        		Line line = m.getLine(lineInfo);
        		System.out.println("\t-----"+line);
        	}
        	lineInfos = m.getTargetLineInfo();
        	for (Line.Info lineInfo:lineInfos){
        		System.out.println (m+"---"+lineInfo);
        		Line line = m.getLine(lineInfo);
        		System.out.println("\t-----"+line);
        	}
        }
		} catch (LineUnavailableException e) {
			e.printStackTrace();
			Log.e(TAG, "Fail to get line: " + e.getMessage());
		}
	}
	
	public boolean init(AudioSource audioSource, RecordSetting recordSetting) {
		// TODO: init based on the setting
		dumpMixerInfo();
		
		// init recorder
		try {
			AudioFormat format = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED, FS, 16, 1, 2, FS, false);
			Log.d(TAG, "recorder encode = " + format.getEncoding());
	        
			// recorder = AudioSystem.getTargetDataLine(format); // seems not working
	        DataLine.Info info = new DataLine.Info(TargetDataLine.class, format);
	        recorder = (TargetDataLine) AudioSystem.getLine(info);
	        recorder.open(format);
	        Log.d(TAG, "recorder buffer size = " + recorder.getBufferSize());
	    } catch (LineUnavailableException e) {
	        e.printStackTrace();
	        Log.e(TAG, "init recorder failed: " + e.getMessage());
	        return false;
	    }
		
		// init player
		try {
			AudioFormat format = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED, FS, 16, 1, 2, FS, false);
	        DataLine.Info dataLineInfo = new DataLine.Info(SourceDataLine.class, format);
	        player = (SourceDataLine) AudioSystem.getLine(dataLineInfo);
	        player.open(format);
		} catch (LineUnavailableException e) {
			e.printStackTrace();
			Log.e(TAG, "init player failed: " + e.getMessage());
			return false;
		}
		
		return true;
	}
	
	public void startSensing() {
		//startRecording();
		//startPlaying();
		keepSensing = true;
        startRecordAndThenPlayAudio();
	}
	
	public void stopSensing() {
		keepSensing = false; // NOTE: set this flag will enforce the play & recording thread to stop
        Log.w(TAG, "wait audio playing and recording terminate ...");
        while (isPlaying||isRecording);
        Log.w(TAG, "audio playing and recording has terminated!");
	}
	
	
	
//=================================================================================================
//  Internal help functions
//=================================================================================================
	
    private void startRecordAndThenPlayAudio() {
        // NOTE: it is necessary to ensure the audio is recording before playing the audio
    	// TODO: add a small delay before playing to ensure we can capture the start of the preamble
    	startRecording();
    	startPlaying();
    }
	
//=================================================================================================
//  Audio record related
//=================================================================================================
	ByteArrayOutputStream out;
	private void startRecording() {
        if(SHOW_DEBUG_INFO_TIME_MESSAGE) Log.d(TAG, "startRecording() is called at: " + Utils.getTime());
        new Thread(new Runnable() {
            @Override
            public void run() {
                startAndKeepRecording = true; // it is a dummy flag now, try to design it carefully when there is something weird for the fisrt few sample recorded
                keepAudioRecording();
            }
        }).start();
    }
	
	private void keepAudioRecording() {
		byte[] byteBuffer = new byte[RECORDER_BUFFER_ELEMENTS * RECORDER_BYTE_PER_ELEMENT];
        audioTotalRecordedSampleCnt = 0; // init this log value to 0 for every recording
        recorder.start();

        // start recording infinite loop (stop when playing is done)
        while(keepSensing){
            // start to record only when startAndKeepRecording is triggered
            if(startAndKeepRecording){
                int byteRead = recorder.read(byteBuffer, 0, RECORDER_BUFFER_ELEMENTS*RECORDER_BYTE_PER_ELEMENT);
                if(SHOW_DEBUG_INFO_AUDIO_RECORDING) Log.d(TAG, "byteRead = " + byteRead);
                if (byteRead > 4 && SHOW_DEBUG_INFO_AUDIO_RECORDING) {
                    Log.w(TAG, "First 4 bytes = (" + byteBuffer[0] + "," + byteBuffer[1] + "," + byteBuffer[2] + "," + byteBuffer[3] + ")");
                }
                if(byteRead != RECORDER_BUFFER_ELEMENTS * RECORDER_BYTE_PER_ELEMENT) Log.e(TAG, "[ERROR]: byteRead in audioRecord not matched! = "+byteRead);
                //audioTotalRecordedSampleCnt += byteRead / (recordSetting.recordChCnt * RECORDER_BYTE_PER_ELEMENT); // only recorded the number of "sample" in each channel as a reference point
                audioTotalRecordedSampleCnt += byteRead / (1 * RECORDER_BYTE_PER_ELEMENT); // only recorded the number of "sample" in each channel as a reference point
                // TODO: modify audioTotalRecordedSampleCnt based on the real record setting
                
                
                listener.audioRecorded(byteBuffer.clone(), audioTotalRecordedSampleCnt);
                
                // TODO: save audio to file if need
                if(SHOW_DEBUG_INFO_AUDIO_RECORDING) Log.d(TAG, "end of one record");

                // check if need to stop
                if (!startAndKeepRecording || !keepSensing) {
                    Log.d(TAG, "recording need to stop");
                    if (startAndKeepRecording) {
                        startAndKeepRecording = false;
                        break;
                    }
                }
            } else {
                // do nothing, just clear the audio record buffer
                recorder.read(byteBuffer, 0, RECORDER_BUFFER_ELEMENTS * RECORDER_BYTE_PER_ELEMENT);
            }
        }

        // stop recording
        recorder.stop();
        recorder = null;
        Log.w(TAG, "audioRecord is released");
	}
	
//=================================================================================================
//  Audio play related
//=================================================================================================
	private void startPlaying() {
        if(SHOW_DEBUG_INFO_TIME_MESSAGE) Log.d(TAG, "startPlaying() is called" + Utils.getTime());
        new Thread(new Runnable() {
            @Override
            public void run() {
                isPlaying = true;
                player.start();
                keepAudioPlaying();
            }
        }).start();
    }
	
	
	void keepAudioPlaying() {
		int writeCnt;
		Log.d(TAG, "player.available() = " + +player.available());
        writeCnt = player.write(audioSource.preambleBytes, 0, audioSource.preambleBytes.length);
        if (writeCnt != audioSource.preambleBytes.length) Log.e(TAG,"[ERROR]: wrong size of preamble is played by audioTrack, writeCnt="+writeCnt);
		
        // TODO: check if there will be a delay between several audioTrack write executions
        int playCnt = 0;
        while (keepSensing) {
            if (audioSource.repeatCnt > 0 && playCnt >= audioSource.repeatCnt) { // end of repeat audio playing
                break;
            }
            writeCnt = player.write(audioSource.signalBytes, 0, audioSource.signalBytes.length);
            playCnt++;
        }
        isPlaying = false;
        Log.d(TAG, "Reach the end of keepAudioPlaying()");
        checkIfSensingEnd();
	}
	
	void checkIfSensingEnd() {
		if (!isPlaying && !isRecording) {
			sensingEnd();
		}
	}
	
	void sensingEnd() { // TODO: finalize
		// TODO: tune the audio record/play to the begin
        // TODO: move the folder?
        keepSensing = false;
        listener.onAudioRecordAndPlayEnd();
	}
	
	/*
	public static void main(String[] args) {
		AudioController ac = new AudioController();
		ac.start();
		System.out.println("Hello World");
		ac.play();
		System.out.println("Bye bye");
	}
	*/
}
