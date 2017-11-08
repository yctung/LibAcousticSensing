package umich.cse.yctung.libacousticsensing;


import org.apache.commons.cli.CommandLine;
import org.apache.commons.cli.HelpFormatter;
import org.apache.commons.cli.Option;
import org.apache.commons.cli.Options;
import org.apache.commons.cli.Option.Builder;
import org.apache.commons.cli.CommandLineParser;
import org.apache.commons.cli.DefaultParser;
import org.apache.commons.cli.ParseException;

import umich.cse.yctung.libacousticsensing.Audio.AudioController;
import umich.cse.yctung.libacousticsensing.Setting.AcousticSensingSetting;

// 2017/11/04: Only command line interface for testing LibAS

public class MainActivity implements AcousticSensingControllerListener {
	private static final String TAG = "MainActivity";
	AcousticSensingSetting ass;
	AcousticSensingController asc;
	
	// command line public interface to use this tester
	public static void main(String[] args) {
		// create activity based on the input arguments
		MainActivity activity = new MainActivity();
		
		
		// we use Apache Commons CLI to parse options
		// ref: https://commons.apache.org/proper/commons-cli/
		// example: https://stackoverflow.com/questions/7341683/parsing-arguments-to-a-java-command-line-program
		Option optMode = Option.builder("m")
				.longOpt("mode")
				.required(false)
				.desc("Sensing Mode: remote|standalone")
				.hasArg()
				.build();
		
		Option optServer = Option.builder("s")
				.longOpt("server")
				.required(false)
				.desc("Server: address:port")
				.hasArg()
				.build();
		
		Option optHelp = Option.builder("h")
				.longOpt("help")
				.required(false)
				.desc("Help")
				.build();
		
		Option optDump = Option.builder("d")
				.longOpt("dump")
				.required(false)
				.desc("Dump current setting")
				.build();
		
		Options options = new Options();
		options.addOption(optMode);
		options.addOption(optServer);
		options.addOption(optHelp);
		options.addOption(optDump);
		
		CommandLineParser parser = new DefaultParser();
		
		try {
			CommandLine cmd = parser.parse(options, args);
			
			if (cmd.hasOption("h")) {
				HelpFormatter formatter = new HelpFormatter();
				formatter.printHelp("LibAS", options);
				return;
			}
			
			if (cmd.hasOption("d")) {
				activity.ass.dump();
				return;
			}
			
			if (cmd.hasOption("s")) {
				Log.d(TAG, "option server = " + cmd.getOptionValue("s"));
				String server = cmd.getOptionValue("s");
				String[] parts = server.split(":");
				if (parts.length != 2) {
					Log.e(TAG, "server format error (should be something like 10.0.0.1:50005)");
					return;
				}
				
				activity.ass.setServerAddr(parts[0]);
				activity.ass.setServerPort(parts[1]);
			}
			
			if (cmd.hasOption("m")) {
				Log.d(TAG, "option mode = " + cmd.getOptionValue("m"));
				String mode = cmd.getOptionValue("m");
				if (!mode.equals("remote")) {
					Log.e(TAG, "we currently only support remote mode in Java");
					return;
				}
				activity.ass.setMode(AcousticSensingSetting.PARSE_MODE_REMOTE);
			}
			
		} catch (ParseException e) {
			e.printStackTrace();
			Log.e(TAG, "Fail to parse commandline argument, please check the document for input arguments");
			return;
		}
		
		activity.start();
	}
	
	public MainActivity() {
		// init acousitc sensing classes
		Log.d(TAG, "MainActivity()");
		ass = new AcousticSensingSetting();
		asc = new AcousticSensingController(this);
	}
	
	public void start() {
		boolean succ = asc.init(ass);
		if (!succ) {
			Log.e(TAG, "init/start fails");
		}
		/*
		if (succ) {
			asc.startSensingWhenPossible();
		}
		*/
	}

	@Override
	public void updateDebugStatus(boolean status, String stringToShow) {
		Log.d(TAG, stringToShow);
	}

	@Override
	public void showToast(String stringToShow) {
		Log.d(TAG, stringToShow);
	}

	@Override
	public void sensingEnd() {
		Log.d(TAG, "sensingEnd()");
	}

	@Override
	public void sensingStarted() {
		Log.d(TAG, "sensingStarted()");
	}

	@Override
	public void updateSensingProgress(int percent) {
		
	}

	@Override
	public void serverClosed() {
		Log.d(TAG, "serverClosed()");
	}

	@Override
	public void updateResult(int argInt, float argFloat) {
		
	}

	@Override
	public void dataJNICallback(long retAddr) {
		
	}

	@Override
	public void isConnected(boolean success, String resp) {
		Log.d(TAG, "isConnected() = " + success + ": " + resp);
	}
}
