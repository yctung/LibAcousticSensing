package umich.cse.yctung.libacousticsensing;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.media.AudioManager;
import android.os.Build;
import android.util.Log;

import java.io.IOException;
import java.io.InputStream;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Random;

/**
 * Created by eddyxd on 4/25/16.
 */
public class Utils {

    static SimpleDateFormat dateFormat;
    public static String getTime(){
        if (dateFormat==null) dateFormat = new SimpleDateFormat("yyyy-MM-dd_HH-mm-ss");
        Calendar c = Calendar.getInstance();
        int mseconds = c.get(Calendar.MILLISECOND);
        String currentDateandTime = dateFormat.format(new Date()) + String.format("-%04d", mseconds);
        return currentDateandTime;
    }

    // Get device information, ref: http://stackoverflow.com/questions/1995439/get-android-phone-model-programmatically
    public static String getDeviceName() {
        String manufacturer = Build.MANUFACTURER;
        String model = Build.MODEL;
        String result;
        if (model.toUpperCase().startsWith(manufacturer.toUpperCase())) {
            //result = capitalize(model);
            result = model.toUpperCase();
        } else {
            //result = capitalize(manufacturer) + "-" + model;
            result = (manufacturer+"-"+model).toUpperCase();
        }
        return result.replace(" ", ""); // remove unsecure strings to ensure this can be sent via URL
    }

    private static String capitalize(String s) {
        if (s == null || s.length() == 0) {
            return "";
        }
        char first = s.charAt(0);
        if (Character.isUpperCase(first)) {
            return s;
        } else {
            return Character.toUpperCase(first) + s.substring(1);
        }
    }

    public static String[] doubleArrayToStringArray(double[] dataArray) {
        String[] resultArray = new String[dataArray.length];
        for(int i=0;i<dataArray.length;i++){
            resultArray[i] = String.format("%.1f", dataArray[i]);
        }
        return resultArray;
    }

    public static void showSimpleAlertDialog(final Activity activity, final String title, final String message){
        showSimpleAlertDialogWithCallback(activity, title, message, new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int id) {
                // dummy callback
            }
        });
    }

    public static void showYesAndNoAlertDialogWithCallback(final Activity activity, final String title, final String message, final DialogInterface.OnClickListener okCallback){
        activity.runOnUiThread(new Runnable() {
            @Override
            public void run() {
                AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(activity);

                // set title
                alertDialogBuilder.setTitle(title);//.setIcon(R.drawable.icon_100);

                // set dialog message
                alertDialogBuilder
                        .setMessage(message)
                        .setCancelable(false)
                        .setPositiveButton("Yes",okCallback)
                        .setNegativeButton("No",null);

                // create alert dialog
                AlertDialog alertDialog = alertDialogBuilder.create();

                // show it
                alertDialog.show();
            }
        });
    }

    public static void showSimpleAlertDialogWithCallback(final Activity activity, final String title, final String message, final DialogInterface.OnClickListener okCallback){
        activity.runOnUiThread(new Runnable() {
            @Override
            public void run() {
                AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(activity);

                // set title
                alertDialogBuilder.setTitle(title);//.setIcon(R.drawable.icon_100);

                // set dialog message
                alertDialogBuilder
                        .setMessage(message)
                        .setCancelable(false)
                        .setPositiveButton("Got it",okCallback);

                // create alert dialog
                AlertDialog alertDialog = alertDialogBuilder.create();

                // show it
                alertDialog.show();
            }
        });
    }

    public static ProgressDialog createProgressDialog(Activity activity){
        ProgressDialog progress = new ProgressDialog(activity);
        progress.setMessage("Please wait :) ");
        progress.setProgressStyle(ProgressDialog.STYLE_SPINNER);
        progress.setIndeterminate(true);
        progress.setCancelable(false);
        return progress;
    }

    // read audio files from assets
    public static short[] readBinaryAudioDataFromAsset(Context context, String fileName){
        short [] data;
        try {
            InputStream is = context.getAssets().open(fileName);

            byte[] fileBytes=new byte[is.available()];
            int arraySize = is.available()/2; // short take 2 bytes
            data = new short[arraySize];
            is.read(fileBytes, 0, is.available()); // read all buffer into bytebuffer
            ByteBuffer.wrap(fileBytes).order(ByteOrder.LITTLE_ENDIAN).asShortBuffer().get(data);

            return data;
        } catch (IOException e) {
            e.printStackTrace();
            Log.e(Constant.LOG_TAG, "[ERROR]: unable to load asset = "+fileName);
        }

        return null;
    }

    public static void updateSystemVol(Context context, float vol){
        final AudioManager audioManager = (AudioManager) context.getSystemService(Context.AUDIO_SERVICE);
        //mode.setRingerMode(AudioManager.RINGER_MODE_NORMAL);

        int maxVolValue = audioManager.getStreamMaxVolume(audioManager.STREAM_MUSIC);
        int targetValue = (int) Math.round(maxVolValue*vol);
        int currentVolValue = audioManager.getStreamVolume(audioManager.STREAM_MUSIC);
        if(currentVolValue!=targetValue) {
            audioManager.setStreamVolume(AudioManager.STREAM_MUSIC, targetValue, 0);
            int checkVolValue = audioManager.getStreamVolume(audioManager.STREAM_MUSIC);
            Log.d(Constant.LOG_TAG, "Set the new volume as vol = " + targetValue + ", set reuslt = " + checkVolValue);
        }

    }

    // Implementing Fisher–Yates shuffle
    // ref: http://stackoverflow.com/questions/1519736/random-shuffling-of-an-array
    public static void shuffleArray(byte[] ar)
    {
        // If running on Java 6 or older, use `new Random()` on RHS here
        Random rnd = new Random();
        for (int i = ar.length - 1; i > 0; i--)
        {
            int index = rnd.nextInt(i + 1);
            // Simple swap
            byte a = ar[index];
            ar[index] = ar[i];
            ar[i] = a;
        }
    }
}
