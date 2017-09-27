package umich.cse.yctung.libacousticsensing.Audio;

public interface AudioControllerListener {
	void onAudioRecordAndPlayEnd();
	void audioRecorded(byte[] data, long audioTotalRecordedSampleCnt);
}
