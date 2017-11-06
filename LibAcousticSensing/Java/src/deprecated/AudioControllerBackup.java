package deprecated;
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


public class AudioControllerBackup {
	float FS=96000.0f; 
	public AudioControllerBackup() {
		// ref: http://stackoverflow.com/questions/25798200/java-record-mic-to-byte-array-and-play-sound
	}
	
	ByteArrayOutputStream out;
	public void start() {
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
	
	void play() {
		// containing the data
		try {
			AudioFormat format = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED,FS, 16, 1, 2, FS, false);
			AudioInputStream audioInputStream;
	        SourceDataLine sourceDataLine;
			byte audioData[] = out.toByteArray();
	        InputStream byteArrayInputStream = new ByteArrayInputStream(audioData);
	        audioInputStream = new AudioInputStream(byteArrayInputStream,format, audioData.length / format.getFrameSize());
	        DataLine.Info dataLineInfo = new DataLine.Info(SourceDataLine.class, format);
			sourceDataLine = (SourceDataLine) AudioSystem.getLine(dataLineInfo);
	        sourceDataLine.open(format);
	        sourceDataLine.start();
	        int cnt = 0;
	        byte tempBuffer[] = new byte[10000];
	        try {
	            while ((cnt = audioInputStream.read(tempBuffer, 0,tempBuffer.length)) != -1) {
	                if (cnt > 0) {
	                    // Write data to the internal buffer of
	                    // the data line where it will be
	                    // delivered to the speaker.
	                    sourceDataLine.write(tempBuffer, 0, cnt);
	                }// end if
	            }
	        } catch (IOException e) {
	            e.printStackTrace();
	        }
		} catch (LineUnavailableException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		AudioControllerBackup ac = new AudioControllerBackup();
		ac.start();
		System.out.println("Hello World");
		ac.play();
		System.out.println("Bye bye");
	}
}
