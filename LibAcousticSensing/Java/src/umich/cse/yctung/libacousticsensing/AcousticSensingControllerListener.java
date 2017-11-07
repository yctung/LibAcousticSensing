package umich.cse.yctung.libacousticsensing;

/**
 * Created by Yu-Chih Tung on 11/19/15.
 */
public interface AcousticSensingControllerListener {
    void updateDebugStatus(boolean status, String stringToShow); // Note this function needs to be write run on UI thread
    void showToast(String stringToShow);
    void sensingEnd();
    void sensingStarted();
    void updateSensingProgress(int percent);
    void serverClosed();
    void updateResult(int argInt, float argFloat);
    void dataJNICallback(long retAddr);
    void isConnected(boolean success, String resp);
}
