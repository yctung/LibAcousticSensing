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
	public AudioController(AudioControllerListener listener, AudioSource audioSource, RecordSetting recordSetting) {
		// ref: http://stackoverflow.com/questions/25798200/java-record-mic-to-byte-array-and-play-sound
		// TODO: init based on the setting
		this.listener = listener;
		this.audioSource = audioSource;
		this.recordSetting = recordSetting;
	}
	
	public boolean init(AudioSource audioSource, RecordSetting recordSetting) {
		// TODO: init based on the setting
		
		
		// init player
		try {
			AudioFormat format = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED,FS, 16, 1, 2, FS, false);
	        DataLine.Info dataLineInfo = new DataLine.Info(SourceDataLine.class, format);
	        player = (SourceDataLine) AudioSystem.getLine(dataLineInfo);
	        player.open(format);
		} catch (LineUnavailableException e) {
			e.printStackTrace();
			Log.e(TAG, "init player error: " + e.getMessage());
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
    	/*
        if (audioSetting.audioMode== RecordSetting.AUDIO_MODE_PLAY_AND_RECORD) {
            startRecording();
            sensingTimer.sendMessageDelayed(Message.obtain(null, MESSAGE_TO_START_PLAY), DELAY_TO_START_PLAY);
        } else if (audioSetting.audioMode== RecordSetting.AUDIO_MODE_PLAY_ONLY) {
            startPlaying();
        } else if (audioSetting.audioMode== RecordSetting.AUDIO_MODE_RECORD_ONLY) {
            startRecording();
        } else {
            Log.e(LOG_TAG, "[ERROR]: undefined audioMode="+audioSetting.audioMode);
        }*/
    	startPlaying();
    }
	
	ByteArrayOutputStream out;
	public void startRecording() {
		//AudioFormat format = new AudioFormat(FS, 16, 1, true, true);
		AudioFormat format = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED,FS, 16, 1, 2, FS, false);
		System.out.print("Encodie = "+format.getEncoding());
		
		//AudioFormat format = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED, 48000.0f, 16, 1, true, true);
	    TargetDataLine microphone;
		try {
	        microphone = AudioSystem.getTargetDataLine(format);

	        // dump mixer information
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
	        
	        DataLine.Info info = new DataLine.Info(TargetDataLine.class, format);
	        microphone = (TargetDataLine) AudioSystem.getLine(info);
	        microphone.open(format);

	        out = new ByteArrayOutputStream();
	        int numBytesRead;
	        int CHUNK_SIZE = 1024;
	        ByteArrayOutputStream fileOut = new ByteArrayOutputStream();
	        byte[] data = new byte[microphone.getBufferSize() / 5];
	        microphone.start();

	        int bytesRead = 0;
	        DataLine.Info dataLineInfo = new DataLine.Info(SourceDataLine.class, format);
	        while (bytesRead < FS*5) {
	            numBytesRead = microphone.read(data, 0, CHUNK_SIZE);
	            bytesRead += numBytesRead;
	            fileOut.write(data,0,numBytesRead);
	            out.write(data,0,numBytesRead);
	            // write the mic data to a stream for use later
	            //out.write(data, 0, numBytesRead); 
	            // write mic data to stream for immediate playback
	            //speakers.write(data, 0, numBytesRead);
	        }
	        microphone.close();
	        
			FileOutputStream fos = new FileOutputStream("test.bin");
			fileOut.writeTo(fos);
			fos.close();
	    } catch (LineUnavailableException e) {
	        e.printStackTrace();
	    } catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
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
        if (writeCnt!=audioSource.preamble.length) Log.e(TAG,"[ERROR]: wrong size of preamble is played by audioTrack, writeCnt="+writeCnt);
		
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
