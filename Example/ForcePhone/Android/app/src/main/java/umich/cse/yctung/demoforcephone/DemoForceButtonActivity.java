package umich.cse.yctung.demoforcephone;

import android.Manifest;
import android.app.Dialog;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Point;
import android.graphics.PorterDuff;
import android.graphics.PorterDuffXfermode;
import android.graphics.Rect;
import android.graphics.RectF;
import android.os.Bundle;
import android.os.Vibrator;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v4.view.ViewCompat;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.Display;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.AlphaAnimation;
import android.view.animation.Animation;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.RelativeLayout.LayoutParams;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ToggleButton;

import umich.cse.yctung.libacousticsensing.*;

public class DemoForceButtonActivity extends AppCompatActivity implements AcousticSensingControllerListener {
    final static String LOG_TAG = "DemoForceButtonActivity";

    // Demo settings
    static double BLUR_START_THRES_RATIO = 0.3; // only start blur the image when force = thres*(this ratio)
    static int CLOCK_ICON_SIZE = 300; //width = height = size
    static double CLOCK_ICON_SIZE_BLOB_MAX_SCALE = 2.0;
    static final boolean NEED_TO_MAKE_BLUR_BACKGROUND = false;
    static final boolean ENALBE_CLIABIRATION = false;
    public static double SELECT_HARD_PRESS_THRES_VALUES[] = {1.0, 0.9, 0.8, 0.7, 0.6, 0.5, 0.4, 0.3, 0.2, 0.1};


    // UI elements
    ImageView imageScreenBase;
    ImageView imageScreenBaseBlurred = null;
    ImageView imageClockIcon;
    ImageView imageClockIconBlob;
    ImageView imageClockAppTimer;
    ImageView imageOption;
    TextView txtDebugStatus;
    Vibrator vibe;
    Spinner spinnerHardPressThres;
    LinearLayout layoutHardPressThres;
    int screenWidth, screenHeight;
    RelativeLayout layout;

    // Sensing variables
    AcousticSensingController asc;
    JNICallback jc;
    boolean needToShowOptionWhenPressureIsHighEnough = false;
    boolean isOptionShown = false;
    boolean isAppShown = false;
    boolean dontMoveAppIcon = true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_exp_pressure_button);

        // get screen resolution -> so we can adapt the size of background based on resolution
        // ref: http://stackoverflow.com/questions/1016896/get-screen-dimensions-in-pixels
        Display display = getWindowManager().getDefaultDisplay();
        Point size = new Point();
        display.getSize(size);
        screenWidth = size.x;
        screenHeight = size.y;

        //LinearLayOut Setup
        layout = new RelativeLayout(this);
        android.view.ViewGroup.LayoutParams layoutParams;
        layout.setLayoutParams(new LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT));
        layout.setBackgroundColor(Color.BLACK);

        // Load image as bitmap instead
        /*
        bitmapScreenBase = BitmapFactory.decodeResource(getResources(), R.drawable.screen_s6_app_no_title_smaller);
        blurableBackgroundView = new BlurableBackgroundView(this);
        blurableBackgroundView.setUpBitmap(bitmapScreenBase);
        */

        //ImageView Setup
        imageScreenBase = new ImageView(this);
        imageScreenBase.setImageResource(R.drawable.screen_s6_app_no_title_300);
        //imageScreenBase.setImageResource(R.drawable.screen_base_small_no_title_smaller);
        //imageScreenBase.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT));
        imageScreenBase.setLayoutParams(new LayoutParams(screenWidth, screenHeight));
        imageScreenBase.setScaleType(ImageView.ScaleType.CENTER_CROP);
        imageScreenBase.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.d(LOG_TAG, "imageScreenBase is clicked");
                if (isOptionShown) {
                    makeOptionDisappear();
                }
            }
        });


        // add blured image
        if(NEED_TO_MAKE_BLUR_BACKGROUND) {
            imageScreenBaseBlurred = new ImageView(this);
            imageScreenBaseBlurred.setImageResource(R.drawable.screen_s6_app_no_title_100_blur);
            //imageScreenBase.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT));
            imageScreenBaseBlurred.setLayoutParams(new LayoutParams(screenWidth, screenHeight));
            imageScreenBaseBlurred.setScaleType(ImageView.ScaleType.CENTER_CROP);
            imageScreenBaseBlurred.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Log.d(LOG_TAG, "imageScreenBaseBlurred is clocked");
                    if (isOptionShown) {
                        makeOptionDisappear();
                    }
                }
            });
            imageScreenBaseBlurred.setImageAlpha(0);
        }


        imageClockAppTimer = new ImageView(this);
        imageClockAppTimer.setImageResource(R.drawable.clock_app_timer_small_no_title_smaller);
        //imageClockAppTimer.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT));
        imageClockAppTimer.setLayoutParams(new LayoutParams(screenWidth, screenHeight));
        imageClockAppTimer.setScaleType(ImageView.ScaleType.CENTER_CROP);
        //imageClockAppTimer.setVisibility(View.GONE);
        imageClockAppTimer.setImageAlpha(0);
        imageClockAppTimer.setClickable(false);
        //imageClockAppTimer.setVisibility(View.INVISIBLE);
        imageClockAppTimer.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.d(LOG_TAG, "imageClockAppTimer is poped");
                makeAppDisappear();
            }
        });


        imageClockIconBlob = new ImageView(this);
        imageClockIconBlob.setImageResource(R.drawable.clock_icon_blob);
        layoutParams = new LayoutParams(CLOCK_ICON_SIZE, CLOCK_ICON_SIZE);
        imageClockIconBlob.setLayoutParams(layoutParams);

        imageClockIcon = new ImageView(this);
        imageClockIcon.setImageResource(R.drawable.clock_icon);
        //layoutParams = new LayoutParams(300, 300);
        layoutParams = new LayoutParams(CLOCK_ICON_SIZE, CLOCK_ICON_SIZE);
        imageClockIcon.setLayoutParams(layoutParams);
        imageClockIcon.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                switch (event.getAction()) {
                    case MotionEvent.ACTION_DOWN: // need to move the ball
                        Log.d(LOG_TAG, "imageClockIcon is touched down");

                        makeBlur(0.0); // force blurred view disappered

                        needToShowOptionWhenPressureIsHighEnough = true;
                        //uc.startCheckPressure(new Point(0, 0));
                        // TODO: ask checking pressure
                        asc.sendUserData("pse",1,1.5f,-2.0f);

                        return true;
                        //break;
                    case MotionEvent.ACTION_UP:
                        Log.d(LOG_TAG, "imageClockIcon is touched up");
                        needToShowOptionWhenPressureIsHighEnough = false;
                        //uc.stopCheckPressure();
                        // TODO: stop checking pressure
                        asc.sendUserData("pse",0,0,0);

                        if (!isOptionShown) { // only show app image when option is not triggered
                            isAppShown = true;
                            imageClockAppTimer.setImageAlpha(255);
                            imageClockAppTimer.setClickable(true);
                            makeBlur(0.0); // force blurred view disappered
                        }

                        return true;
                        //break;
                }
                return false;
            }
        });





        imageOption = new ImageView(this);
        //imageOption.setImageResource(R.drawable.option_small);

        // Set rounded edge image
        // ref: http://stackoverflow.com/questions/20743859/imageview-rounded-corners
        //Create and load images (immutable, typically)
        Bitmap source = BitmapFactory.decodeResource(getResources(), R.drawable.option_hsa_round_edge);

        //Create a *mutable* location, and a canvas to draw into it
        Bitmap result = Bitmap.createBitmap(source.getWidth(), source.getHeight(), Bitmap.Config.ARGB_8888);
        Canvas canvas = new Canvas(result);
        Paint paint = new Paint(Paint.ANTI_ALIAS_FLAG);

        RectF rect = new RectF(0,0,source.getWidth(),source.getHeight());
        float radius = 50.0f;
        paint.setColor(Color.RED);
        canvas.drawRoundRect(rect, radius, radius, paint);
        paint.setXfermode(new PorterDuffXfermode(PorterDuff.Mode.SRC_IN));
        canvas.drawBitmap(source, 0, 0, paint);

        imageOption.setImageBitmap(result);



        layoutParams = new LayoutParams(1200, 600);
        //layoutParams = new LayoutParams(screenWidth, screenHeight);
        imageOption.setLayoutParams(layoutParams);
        imageOption.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                makeOptionDisappear();
            }
        });
        imageOption.setClickable(false);
        imageOption.setImageAlpha(0);

        // make dummy debugView
        txtDebugStatus = new TextView(this);
        txtDebugStatus.setText("hahahahaha");

        float debugComponentAlpha = 0.1f;

        // make spinner for selection
        spinnerHardPressThres = new Spinner(this);
        spinnerHardPressThres.setAlpha(debugComponentAlpha);
        String[] spinnerTitles = Utils.doubleArrayToStringArray(SELECT_HARD_PRESS_THRES_VALUES);
        ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(this,   android.R.layout.simple_spinner_item, spinnerTitles);
        spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item); // The drop down view
        spinnerHardPressThres.setAdapter(spinnerArrayAdapter);
        // TODO: check device value is in the list
        spinnerHardPressThres.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                double selectedThres = SELECT_HARD_PRESS_THRES_VALUES[position];
                D.appPressureButtonThres = selectedThres;
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });

        // set the default value
        int spinnerPosition = 0;
        for(int i =0;i<SELECT_HARD_PRESS_THRES_VALUES.length; i++){
            if(SELECT_HARD_PRESS_THRES_VALUES[i]==D.appPressureButtonThres){
                spinnerPosition = i;
                break;
            }
        }
        if (spinnerPosition>0) { // otherwise -> use the first value by default
            spinnerHardPressThres.setSelection(spinnerPosition);
        }

        TextView txtHardPressThres = new TextView(this);
        txtHardPressThres.setText("thres: ");
        txtHardPressThres.setAlpha(debugComponentAlpha);

        //Switch switch = new Switch(this);
        // make toggle for selecting if button can be moved
        ToggleButton toggle = new ToggleButton(this);
        toggle.setChecked(false);
        toggle.setAlpha(debugComponentAlpha);
        toggle.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked) {
                    // The toggle is enabled
                    dontMoveAppIcon = false;
                } else {
                    // The toggle is disabled
                    dontMoveAppIcon = true;
                }
            }
        });


        layoutHardPressThres = new LinearLayout(this);
        layoutHardPressThres.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT));
        layoutHardPressThres.setOrientation(LinearLayout.HORIZONTAL);
        layoutHardPressThres.addView(toggle);
        layoutHardPressThres.addView(txtHardPressThres);
        layoutHardPressThres.addView(spinnerHardPressThres);






        // align this control to the bottom
        // ref: http://stackoverflow.com/questions/11409559/android-how-to-insert-a-bottom-aligned-view-without-layout-xml
        RelativeLayout.LayoutParams params = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT);
        params.addRule(RelativeLayout.ALIGN_PARENT_BOTTOM, layoutHardPressThres.getId());
        layoutHardPressThres.setLayoutParams(params);


        // speed up the alpha changing fps
        // ref: http://stackoverflow.com/questions/37601314/setting-view-alpha-in-runtime-is-slow-how-to-speed-it-up
        ViewCompat.setLayerType(imageScreenBase, ViewCompat.LAYER_TYPE_HARDWARE, null);
        if(NEED_TO_MAKE_BLUR_BACKGROUND) {
            ViewCompat.setLayerType(imageScreenBaseBlurred, ViewCompat.LAYER_TYPE_HARDWARE, null);
        }
        ViewCompat.setLayerType(imageClockIconBlob, ViewCompat.LAYER_TYPE_HARDWARE, null);
        ViewCompat.setLayerType(layout,  ViewCompat.LAYER_TYPE_HARDWARE, null);

        //adding view to layout
        //layout.addView(blurableBackgroundView);
        layout.addView(imageScreenBase);
        if(NEED_TO_MAKE_BLUR_BACKGROUND) {
            layout.addView(imageScreenBaseBlurred);
        }
        layout.addView(imageClockIconBlob);
        layout.addView(imageClockIcon);
        layout.addView(imageClockAppTimer);
        layout.addView(imageOption);
        layout.addView(txtDebugStatus);
        layout.addView(layoutHardPressThres);


        //make visible to program
        setContentView(layout);


        imageOption.setTranslationX(110);
        imageOption.setTranslationY(650);


        updateClockIconLocation(800,1300);



        vibe = (Vibrator) getSystemService(getApplicationContext().VIBRATOR_SERVICE);


        // init acosutic sensing controller
        asc=new AcousticSensingController(this,this);
        jc = new JNICallback();
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

    @Override
    protected void onPause (){
        // TODO: stop sensing
        /*
        if(uc!=null) {
            uc.stopEverything();
        }
        */
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
    public void onRequestPermissionsResult(int requestCode,
                                           String permissions[], int[] grantResults) {

        // This method is called when the user responds to the permissions dialog
    }

    // NOTE: dispatchTouchEvent can get event even the touch is intercepted by other elements
    @Override
    public boolean dispatchTouchEvent(MotionEvent event){
        super.dispatchTouchEvent(event);
        int x = (int)event.getX();
        int y = (int)event.getY();
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN: {


                /*
                Log.d(C.LOG_TAG, "dispatchTouchEvent: ACTION_DOWN: (x,y) = (" + x + "," + y + ")");
                if(uc!=null && ultraphoneHasStarted) {
                    uc.startCheckPressure(new Point(x, y));
                    userHasPressed = true;
                }
                */
                break;
            }
            case MotionEvent.ACTION_UP: {
                Log.d(LOG_TAG, "dispatchTouchEvent: ACTION_UP: (x,y) = (" + x + "," + y + ")");
                if(!dontMoveAppIcon && !isOptionShown && !isAppShown && !needToShowOptionWhenPressureIsHighEnough) {
                    int hBottomToAvoid = screenHeight - 100; // used to avoid the icon changes when user is selecting spinners

                    Rect r = new Rect((int) imageClockIcon.getTranslationX(), (int) imageClockIcon.getTranslationY(), imageClockIcon.getWidth(), imageClockIcon.getHeight());
                    if (!r.contains(x, y) && y < hBottomToAvoid) {
                        updateClockIconLocation(x - imageClockIcon.getWidth() / 2, y - imageClockIcon.getHeight() / 2);
                    }
                }
                break;
            }
        }
        return true;
    }

    void updateClockIconLocation(int x,int y){
        imageClockIcon.setTranslationX(x);
        imageClockIcon.setTranslationY(y);
        imageClockIconBlob.setTranslationX(x);
        imageClockIconBlob.setTranslationY(y);
        if(NEED_TO_MAKE_BLUR_BACKGROUND) {
            imageScreenBaseBlurred.setImageAlpha(0);
        }
    }

    void makeBlur(double pressure){
        double startBlurThres = D.appPressureButtonThres*BLUR_START_THRES_RATIO;

        if(pressure<startBlurThres){
            // no need to blur
            if(NEED_TO_MAKE_BLUR_BACKGROUND) {
                imageScreenBaseBlurred.setImageAlpha(0);
            }

            //imageClockIconBlob.setScaleX(1.0f);
            //imageClockIconBlob.setScaleY(1.0f);

        } else { // need to blur
            //double changeScale =  D.appPressureButtonThres*(1-BLUR_START_THRES_RATIO);
            //float blurExtent = pressure >= D.appPressureButtonThres? 1.0f: (float)((pressure-startBlurThres)/changeScale);

            float blurExtent = pressure >= D.appPressureButtonThres? 1.0f: (float)((pressure)/D.appPressureButtonThres);

            if(blurExtent>=0.0f&&blurExtent<=1.0f) {
                int alphaInt =  (int) Math.floor(blurExtent*255);

                if(NEED_TO_MAKE_BLUR_BACKGROUND) {
                    imageScreenBaseBlurred.setImageAlpha(alphaInt);
                }

                //blurableBackgroundView.setBlurScale(blurExtent);

                float scale = 1.0f+(float)(blurExtent*(CLOCK_ICON_SIZE_BLOB_MAX_SCALE-1.0));
                //imageClockIconBlob.setScaleX(scale);
                //imageClockIconBlob.setScaleY(scale);

                //int size = (int)((float)(CLOCK_ICON_SIZE)*scale);
                //android.view.ViewGroup.LayoutParams layoutParams = new LayoutParams(size,size);
                //imageClockIconBlob.setLayoutParams(layoutParams);

                //imageClockIconBlob.invalidate();
                //layout.invalidate();

            } else {
                Log.e(LOG_TAG,"[ERROR]: blurExtent is out of range = "+blurExtent+" when pressure = "+pressure);
            }
        }
    }

    void showImageWithAnimation() {
        Log.d(LOG_TAG, "showImageWithAnimation");

        Animation a = new AlphaAnimation(0.00f, 1.00f);
        a.setDuration(500);
        a.setAnimationListener(new Animation.AnimationListener() {
            public void onAnimationStart(Animation animation) {
                // TODO Auto-generated method stub
            }

            public void onAnimationRepeat(Animation animation) {
                // TODO Auto-generated method stub
            }

            public void onAnimationEnd(Animation animation) {
                imageClockAppTimer.setVisibility(View.VISIBLE);
            }
        });
        imageClockAppTimer.startAnimation(a);
        //imageClockAppTimer.setAlpha(1.0f);
    }


    @Override
    public void onBackPressed()
    {
        Log.d(LOG_TAG, "onBackPressed");
        // code here to show dialog
        if(isAppShown) {
            makeAppDisappear();
        } else if(isOptionShown){
            makeOptionDisappear();
        } else {
            super.onBackPressed();  // optional depending on your needs
        }
    }

    // this function makes the app disappear
    void makeAppDisappear(){
        imageClockAppTimer.setImageAlpha(0);
        imageClockAppTimer.setClickable(false);
        isAppShown = false;
        if(NEED_TO_MAKE_BLUR_BACKGROUND) {
            imageScreenBaseBlurred.setImageAlpha(0);
        }
    }

    void makeOptionDisappear(){
        isOptionShown = false;
        imageOption.setImageAlpha(0);
        imageOption.setClickable(false);
        if(NEED_TO_MAKE_BLUR_BACKGROUND) {
            imageScreenBaseBlurred.setImageAlpha(0);
        }
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
    public void updateResult(int argInt, float argFloat) {

    }

    @Override
    public void dataJNICallback(long retAddr) {

    }

    /*
    @Override
    public void reactionCallback(int reaction, int argInt, float argFloat) {

    }
    */
//===================================================================================
// Ultraphone callbacks
//===================================================================================
    /*
    @Override
    public void pressureUpdate(final double pressureNotCalibed) {
        double pressure = pressureNotCalibed;

        // update pressure by calibartion if needed
        if(calibrationController!=null && calibrationController.calibrationIsReady) {
            pressure = calibrationController.getLockedCalibResult(pressureNotCalibed);
            calibDebugStringToAttach = String.format("(calib = %.2f)", pressure);
        }

        if (needToShowOptionWhenPressureIsHighEnough && !isOptionShown && !isAppShown ) {

            boolean hardPressDetected = false;
            if(C.FORCE_TO_USE_TOP_SPEAKER && pressure > 1.5){
                hardPressDetected = true;
            } else if(pressure > D.appPressureButtonThres) { // bottom speaker setting
                hardPressDetected = true;
            }

            if(NEED_TO_MAKE_BLUR_BACKGROUND) {
                final double pressureToMakeBlur = pressure;
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        makeBlur(pressureToMakeBlur); // make blur animation
                    }
                });
            }


            if(hardPressDetected) {
                // set those label as soon as possible -> don't show two views at the same time
                isOptionShown = true;
                needToShowOptionWhenPressureIsHighEnough = false;

                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        //Toast.makeText(getApplicationContext(),"Option is shown",Toast.LENGTH_LONG).show();
                        imageOption.setImageAlpha(255);
                        imageOption.setClickable(true);

                        vibe.vibrate(500);
                    }
                });
            }
        }
    }

    @Override
    public void squeezeUpdate(int check) {
        // never use this callback here
    }

    // This callback is consistent for all caller
    String calibDebugStringToAttach = "";
    @Override
    public void updateDebugStatus(final String stringToShow) {
        runOnUiThread(new Runnable() {
            public void run() {
                txtDebugStatus.setText(stringToShow+" "+calibDebugStringToAttach);
            }
        });
    }

    // This callback is consistent for all caller
    @Override
    public void showToast(final String stringToShow){
        runOnUiThread(new Runnable() {
            public void run() {
                Toast.makeText(getApplicationContext(), stringToShow, Toast.LENGTH_LONG).show();
            }
        });
    }

    @Override
    public void unexpectedEnd(int code, String reason){
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                uc.stopEverything();
                finish();
            }
        });
    }
    */
}
