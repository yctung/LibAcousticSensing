package umich.cse.yctung.libacousticsensing.Network;

import umich.cse.yctung.libacousticsensing.Audio.AudioSource;

/**
 * Created by Yu-Chih Tung on 10/15/15.
 * yctung: a callback function interface for classes using NetworkingController
 */
public interface NetworkControllerListener {
    void isConnected(boolean success, String resp);
    void serverAskStartSensing();
    void serverAskStopSensing();
    void audioReceivedFromServer(AudioSource audioSource);
    void audioDelayFromServer (int delayBySamples);
    void resultReceviedFromServer(int audioSampleCnt, int result);
    void userStudyEnd();
    int consumeReceivedData(double dataReceived);
    void updateDebugStatus(boolean status, String stringToShow);
    void error(String message);
    void serverClosed ();
}
