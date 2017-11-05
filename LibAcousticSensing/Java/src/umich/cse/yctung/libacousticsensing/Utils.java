package umich.cse.yctung.libacousticsensing;

public class Utils {
	public static void createLibFoldersIfNeed() {
		// TODO: add data folder
	}
	
	public static String getDeviceName() {
		String osName = System.getProperty("os.name");
		return osName;
	}
}
