package umich.cse.yctung.libacousticsensing.Setting;

import java.io.FileWriter;
import java.io.IOException;

import com.google.gson.JsonObject;


public class SharedPreferences {
	// it is just a wrapper of json objects
	JsonObject obj;
	private static SharedPreferences ref;
	private static String JSON_FILE_NAME = "pref.json";
	public static SharedPreferences loadSharedPreferences(){
		if (ref == null) {
			ref = new SharedPreferences();
		}
		return ref;
	}
	
	public SharedPreferences() {
		// TODO: load from a json file
		obj = new JsonObject();
		obj.addProperty("aa", "123");
	}
	
	
	public String getString(String key, String defaultValue) {
		// TODO: implemnet the real logic
		return defaultValue;
	}
	
	public SharedPreferences putString(String key, String value) {
		// TODO: update json object
		
		return this;
	}
	
	// dummy edit
	public SharedPreferences edit() {
		return this;
	}
	
	public SharedPreferences clear() {
		// TODO: null the json object
		return this;
	}
	
	public void commit() {
		// TODO: save to the json file
		updateToFile();
	}
	
	// internal control functions
	// overwrite json file
    public void updateToFile(){
        String json = obj.toString();
        try {
        	FileWriter writer = new FileWriter(JSON_FILE_NAME);
            writer.write(json);
            writer.close();
        } catch (IOException e) {
            e.printStackTrace();
        }    
        
    }

    // load jason file back to object
    private void LoadOldAppSetting() {
        // clear original AppSetting
    	/*
        appSetting = null;

        BufferedReader br;
        try {
        	obj = new JsonObject()
            br = new BufferedReader(new FileReader(C.appFolderPath+C.SETTING_JSON_FILE_NAME));
            //convert the json string back to object
            Gson gson = new Gson();
            appSetting = gson.fromJson(br, AppSetting.class);

            Log.d(C.LOG_TAG, "LoadOldAppSetting");

        } catch (FileNotFoundException e) {
            Log.e(C.LOG_TAG, "Fail to open old json files");
            e.printStackTrace();
        }
        */
    }
	
}
