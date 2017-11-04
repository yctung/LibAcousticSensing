package umich.cse.yctung.libacousticsensing;

import umich.cse.yctung.libacousticsensing.Audio.AudioController;

// 2017/11/04: Only command line interface for testing LibAS

public class Main {
	public static void main(String[] args) {
		AudioController ac = new AudioController();
		ac.start();
		System.out.println("Hello World");
	}
}
