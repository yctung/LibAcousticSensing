package umich.cse.yctung.libacousticsensing.Setting;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import umich.cse.yctung.libacousticsensing.Log;
import umich.cse.yctung.libacousticsensing.Utils;


public class SharedPreferences {
	// it is just a wrapper of json objects
	// we use jason-simple: https://code.google.com/archive/p/json-simple/wikis
	// example: https://howtodoinjava.com/json-simple/json-simple-read-write-json-examples/
	
	private final static String TAG = "SharedPreferences";  
	
	JSONObject obj;
	
	private static SharedPreferences ref;
	private static String JSON_FILE_NAME = "pref.json";
	public static SharedPreferences loadSharedPreferences(){
		if (ref == null) {
			ref = new SharedPreferences();
		}
		return ref;
	}
	
	public SharedPreferences() {
		loadOldAppSettingIfExist();
	}
	
	
	public String getString(String key, String defaultValue) {
		String value = (String)obj.get(key);
		if (value != null) return value;
		else return defaultValue;
	}
	
	public SharedPreferences putString(String key, String value) {
		obj.put(key, value);
		return this;
	}
	
	// dummy edit
	public SharedPreferences edit() {
		return this;
	}
	
	public SharedPreferences clear() {
		obj.clear();
		return this;
	}
	
	public void commit() {
		updateToFile();
	}
	
	// internal control functions
	// overwrite json file
    public void updateToFile(){
        try {
        	FileWriter writer = new FileWriter(JSON_FILE_NAME);
            writer.write(obj.toString());
            writer.close();
        } catch (IOException e) {
            e.printStackTrace();
        }    
    }

    // load jason file back to object
    private void loadOldAppSettingIfExist() {
    	boolean loadSuccess = false;
    	
    	try {
    		FileReader reader = new FileReader(JSON_FILE_NAME);
    		JSONParser jsonParser = new JSONParser();
    		obj = (JSONObject) jsonParser.parse(reader);
    		
    		loadSuccess = true;
    	} catch (FileNotFoundException e) {
    		// yctung: avoid dumping these errors to make users panic at the first time of using LibAS
    		//e.printStackTrace();
    	} catch (IOException e) {
			//e.printStackTrace();
		} catch (ParseException e) {
			//e.printStackTrace();
		}
    	
    	// create a new json file if need
    	if (!loadSuccess || obj == null) {
    		Log.w(TAG, "No json file existed: " + JSON_FILE_NAME + ", try to create a new one");
    		obj = new JSONObject();
    		obj.put("deviceName", Utils.getDeviceName());
    		obj.put("updateTime", Utils.getTime());
    		
    		updateToFile();
    	}
    }
	
}
