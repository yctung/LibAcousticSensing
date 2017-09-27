package umich.cse.yctung.demoforcephone;

import android.Manifest;
import android.app.Dialog;
import android.content.pm.PackageManager;
import android.graphics.Color;
import android.os.Handler;
import android.os.Looper;
import android.os.Vibrator;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.TextView;

import umich.cse.yctung.libacousticsensing.AcousticSensingController;
import umich.cse.yctung.libacousticsensing.AcousticSensingControllerListener;

public class DemoSqueezeTuningActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    final static String LOG_TAG = "DemoSqueezeTuning";
    boolean needToUpdateResultText;
    TextView txtDebugStatus, txtResult;
    Vibrator vibe;
    AcousticSensingController asc;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_demo_squeeze_tuning);
        txtDebugStatus = (TextView) findViewById(R.id.txtDebugStatus);
        txtResult = (TextView) findViewById(R.id.txtResult);
        needToUpdateResultText = true;
        vibe = (Vibrator) getSystemService(getApplicationContext().VIBRATOR_SERVICE);
        asc=new AcousticSensingController(this,this);
    }

    @Override
    protected void onResume (){
        super.onResume();

        if (hasRecordAudioPermission()) {
            if (!asc.isReadyToSense()) {
                Dialog dialog = asc.createInitModeDialog(this, Constant.DEFAULT_SERVER_ADDR, Constant.DEFAULT_SERVER_PORT);
                dialog.show();
            }
        } else {
            requestRecordAudioPermission();
        }
    }

    final int REQUEST_RECORD_AUDIO = 1;
    private void requestRecordAudioPermission(){

        String requiredPermission = Manifest.permission.RECORD_AUDIO;

        // If the user previously denied this permission then show a message explaining why
        // this permission is needed
        if (ActivityCompat.shouldShowRequestPermissionRationale(this,
                requiredPermission)) {

            showToast("This app needs to record audio through the microphone....");
        }

        // request the permission.
        ActivityCompat.requestPermissions(this, new String[]{requiredPermission}, REQUEST_RECORD_AUDIO);
    }

    @Override
    protected void onPause (){
        super.onPause();
    }

    // request permission if need
    // ref: http://stackoverflow.com/questions/32217831/how-to-grant-more-permissions-to-android-shell-user
    private boolean hasRecordAudioPermission(){
        boolean hasPermission = (ContextCompat.checkSelfPermission(this,
                Manifest.permission.RECORD_AUDIO) == PackageManager.PERMISSION_GRANTED);

        Log.d(LOG_TAG,"Has RECORD_AUDIO permission? " + hasPermission);
        return hasPermission;
    }

    @Override
    public void onRequestPermissionsResult(int requestCode,
                                           String permissions[], int[] grantResults) {

        // This method is called when the user responds to the permissions dialog
    }


//=================================================================================================
//  Acoustic sensing callbacks
//=================================================================================================
    @Override
    public void updateDebugStatus(boolean status, final String stringToShow) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                txtDebugStatus.setText(stringToShow);
            }
        });
    }

    @Override
    public void showToast(String stringToShow) {

    }

    @Override
    public void sensingEnd() {

    }

    @Override
    public void sensingStarted() {

    }

    @Override
    public void updateSensingProgress(int percent) {

    }

    @Override
    public void serverClosed() {

    }

    @Override
    public void updateResult(final int argInt, float argFloat) {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                if (needToUpdateResultText) {
                    if (argInt == 3) {
                        txtResult.setText("Squeezed!!");
                        //vibe.vibrate(500);
                        needToUpdateResultText = false;


                        // ref: https://stackoverflow.com/questions/3072173/how-to-call-a-method-after-a-delay-in-android
                        /*
                        new Handler(Looper.getMainLooper()).postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                //Do something here
                                needToUpdateResultText = false;
                            }
                        }, 5000);
                        */
                        final Handler handler = new Handler();
                        handler.postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                //Do something after 100ms
                                needToUpdateResultText = true;
                                txtDebugStatus.setText("needToUpdateResultText = true");
                            }
                        }, 1500); // ms
                    } else {
                        txtResult.setText("Wait for result");
                    }
                }
            }
        });
    }

    @Override
    public void dataJNICallback(long retAddr) {

    }
}
