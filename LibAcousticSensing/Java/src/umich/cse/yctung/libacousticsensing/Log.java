package umich.cse.yctung.libacousticsensing;

// 2017/11/04: just a helper to dump debug information

public class Log {
	public static void d(String tag, String text) {
		System.out.println("[" + tag + "]:" + text);
	}
	// dump by red text
	public static void e(String tag, String text) {
		d(tag, text);
	}
	public static void w(String tag, String text) {
		d(tag, text);
	}
}
