package umich.cse.yctung.devapp;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import umich.cse.yctung.libacousticsensing.MyLog;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        MyLog temp = new MyLog();
        temp.showLog("hehe");
    }
}
