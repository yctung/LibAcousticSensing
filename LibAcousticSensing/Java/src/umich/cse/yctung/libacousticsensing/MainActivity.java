package umich.cse.yctung.libacousticsensing;

import umich.cse.yctung.libacousticsensing.Audio.AudioController;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;

// 2017/11/04: Only command line interface for testing LibAS

public class MainActivity implements AcousticSensingControllerListener {
	private String TAG = "MainActivity";
	AcousticSensingSetting ass;
	AcousticSensingController asc;
	
	// command line public interface to use this tester
	public static void main(String[] args) {
		//AudioController ac = new AudioController();
		//ac.start();
		//System.out.println("Hello World");
		MainActivity activity = new MainActivity();
	}
	
	public MainActivity() {
		// init acousitc sensing classes
		Log.d(TAG, "MainActivity()");
		ass = new AcousticSensingSetting();
		asc = new AcousticSensingController(this);
		boolean succ = asc.init(ass);
		/*
		if (succ) {
			asc.startSensingWhenPossible();
		}
		*/
	}

	@Override
	public void updateDebugStatus(boolean status, String stringToShow) {
		// TODO Auto-generated method stub
		Log.d(TAG, stringToShow);
	}

	@Override
	public void showToast(String stringToShow) {
		// TODO Auto-generated method stub
		Log.d(TAG, stringToShow);
	}

	@Override
	public void sensingEnd() {
		// TODO Auto-generated method stub
		Log.d(TAG, "sensingEnd()");
	}

	@Override
	public void sensingStarted() {
		// TODO Auto-generated method stub
		Log.d(TAG, "sensingStarted()");
	}

	@Override
	public void updateSensingProgress(int percent) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void serverClosed() {
		// TODO Auto-generated method stub
		Log.d(TAG, "serverClosed()");
	}

	@Override
	public void updateResult(int argInt, float argFloat) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void dataJNICallback(long retAddr) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void isConnected(boolean success, String resp) {
		// TODO Auto-generated method stub
		Log.d(TAG, "isConnected() = " + success + ": " + resp);
	}
}
