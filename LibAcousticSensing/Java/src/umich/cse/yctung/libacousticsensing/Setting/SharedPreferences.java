package umich.cse.yctung.libacousticsensing.Setting;

public class SharedPreferences {
	// it is just a wrapper of json objects
	private static SharedPreferences ref;
	public static SharedPreferences loadSharedPreferences(){
		if (ref == null) {
			ref = new SharedPreferences();
		}
		return ref;
	}
	
	public SharedPreferences() {
		// TODO: load from a json file
	}
	
	
	public String getString(String key, String defaultValue) {
		return "haha";
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
	}
}
