package umich.cse.yctung.libacousticsensing;

/**
 * Created by Yu-Chih Tung on 11/19/15.
 */
public interface AcousticSensingControllerListener {
    public void updateDebugStatus(boolean status, String stringToShow); // Note this function needs to be write run on UI thread
    public void showToast(String stringToShow);
    public void sensingEnd();
    public void sensingStarted();
    public void updateSensingProgress(int percent);
    public void serverClosed();
    public void updateResult(int argInt, float argFloat);
}
