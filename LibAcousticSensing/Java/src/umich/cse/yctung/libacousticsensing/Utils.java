package umich.cse.yctung.libacousticsensing;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

public class Utils {
	public static void createLibFoldersIfNeed() {
		// TODO: add data folder
	}
	
	public static String getDeviceName() {
		String osName = System.getProperty("os.name");
		return osName;
	}
	
	static SimpleDateFormat dateFormat;
    public static String getTime(){
        if (dateFormat == null) dateFormat = new SimpleDateFormat("yyyy-MM-dd_HH-mm-ss");
        Calendar c = Calendar.getInstance();
        int mseconds = c.get(Calendar.MILLISECOND);
        String currentDateandTime = dateFormat.format(new Date()) + String.format("-%04d", mseconds);
        return currentDateandTime;
    }
}
