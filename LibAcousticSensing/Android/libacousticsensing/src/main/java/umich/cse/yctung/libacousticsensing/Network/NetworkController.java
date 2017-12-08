package umich.cse.yctung.libacousticsensing.Network;

import android.util.Log;

import java.io.BufferedOutputStream;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.UnknownHostException;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;
import java.util.LinkedList;
import java.util.Queue;

import umich.cse.yctung.libacousticsensing.Audio.AudioSource;
import umich.cse.yctung.libacousticsensing.Constant;
/**
 * Created by Yu-Chih Tung on 10/15/15.
 * NetworkController provides interface to talk to the matlab server
 * 2015/10/15: update to a common controller for all EchoTag/BumpFree/MicroButton projects
 * */

public class NetworkController {
//==================================================================================================
//	Constants
//==================================================================================================
	private static String LOG_TAG= Constant.LOG_TAG+"_NetworkController";
	// Types of actions (for packets sent from the server)
	private final static int ACTION_CONNECT = 1; 	// ACTION_CONNECT format: | ACTION_CONNECT | xxx parater setting
	private final static int ACTION_DATA 	= 2; 	// ACTION_DATA format: | ACTION_DATA | # of bytes to send | byte[] | -1
	private final static int ACTION_CLOSE 	= -1;	// ACTION_CLOSE format: | ACTION_CLOSE |
	private final static int ACTION_SET 	= 3;
	private final static int ACTION_INIT 	= 4;
	private final static int ACTION_SENSING_END = 5;
	private final static int ACTION_USER	= 6; 	// used for sending application's user-defined variables

	// Types of set actions (for packets sent to the server)
	public final static int SET_TYPE_BYTE_ARRAY 	= 1;
	public final static int SET_TYPE_STRING 		= 2;
	public final static int SET_TYPE_DOUBLE 		= 3;
	public final static int SET_TYPE_INT 			= 4;
	public final static int SET_TYPE_VALUE_STRING 	= 5; // sent value by string

	// Types of receving packets from server
	private final static int REACTION_SET_MEDIA 	= 1;
	private final static int REACTION_ASK_SENSING   = 2;
	private final static int REACTION_SET_RESULT 	= 3;
	private final static int REACTION_STOP_SENSING  = 4;
	private final static int REACTION_SERVER_CLOSED  = 5;
	private final static int REACTION_DELAY_SOUND 	= 6;

	// Server statuses
	private final static int SERVER_STATUS_DISABLED = -1; // default status of server
	private final static int SERVER_STATUS_ENABLED 	= 1;
	private final static int SERVER_STATUS_CONNECTED = 2;

	// Other control flags
	private final static boolean SAVE_LATEST_LOADED_AUDIO_TO_FILE = false;
	private final static int SOCKET_CONNECTION_CREATE_TIMEOUT = 500; // ms
	private final static int SOCKET_DATA_TRANSMIT_TIMEOUT = 0; // 0 means never timeout
	private final static int DATA_SENDING_THREAD_LOOP_DELAY = 5; //ms

//==================================================================================================
//	Internal status
//==================================================================================================
	int status;
	private Socket sc = null;
	private DataOutputStream dataOut = null;
	private DataInputStream dataIn = null;
	Queue<NetworkRequest> requestQueue;
	NetworkControllerListener listener;

//==================================================================================================
//	Public interface to open socket and send packets
//==================================================================================================
	public NetworkController(NetworkControllerListener listener) {
		this.listener=listener;
		status=SERVER_STATUS_DISABLED;
		requestQueue = new LinkedList();
	}

	// start connect to servers
	public void connectToServer(final String serverIp, final int serverPort){
		new Thread(){ // NOTE: networking processing can't be in the UI thread
			public void run() {
				try {
					InetAddress serverAddr = InetAddress.getByName(serverIp);
					Log.d(LOG_TAG,String.format("Trying to connect server at %s:%d", serverIp, serverPort));
					sc = new Socket(); // use a dummy socket initialization because the new timeout need to be set before connection
					sc.setSoTimeout(SOCKET_CONNECTION_CREATE_TIMEOUT);
					sc.connect(new InetSocketAddress(serverAddr, serverPort), SOCKET_CONNECTION_CREATE_TIMEOUT);
					sc.setSoTimeout(SOCKET_DATA_TRANSMIT_TIMEOUT); // update timeout back to normal timeout, e.g., no timeout

					dataOut = new DataOutputStream(sc.getOutputStream());
					dataIn = new DataInputStream(sc.getInputStream());

					Thread.sleep(1000); // intentionally wait to avoid packet lost (matlab bug)

					dataOut.write(ACTION_CONNECT);
					dataOut.flush();

					createThreadToReceiveAndBlockArrivePacket();

					status = SERVER_STATUS_CONNECTED;
					listener.isConnected(true, "Connected to server successfully");
				} catch (UnknownHostException e) {
					Log.e(LOG_TAG, "Can't connect socket : " + e.getMessage());
					e.printStackTrace();
					listener.isConnected(false, "UnknownHostException" + e.getMessage());
				} catch (IOException e) {
					Log.e(LOG_TAG, "Can't connect socket : " + e.getMessage());
					e.printStackTrace();
					listener.isConnected(false, "IOException" + e.getMessage());
				} catch (InterruptedException e) {
					e.printStackTrace();
					listener.isConnected(false, "InterruptedException" + e.getMessage());
				}
			}
		}.start();
	}

	public void sendInitAction() {
		NetworkRequest r = new NetworkRequest(ACTION_INIT, null, null, -1);
		requestQueue.add(r);
		sendPacketByAnotherThread();
	}

	// Note: the request here means the user study request
	boolean audioHasBeenUpdatedAfterRequestStartIsAsked = false;

	public void sendDataRequest(byte[] data) {
		NetworkRequest r = new NetworkRequest(ACTION_DATA, null, data, -1);
		requestQueue.add(r);
		sendPacketByAnotherThread();
	}

	public void sendSetAction(int setType, String name, byte[] data) {

		NetworkRequest r = new NetworkRequest(ACTION_SET, name, data, setType);
		requestQueue.add(r);
		sendPacketByAnotherThread();
	}

	public void sendUserAction(int stamp, String tag, int code, float arg0, float arg1, byte[] data) {
		// follow the previous ForcePhone's log setting format
		int TEMP_TYPE = 1; // TODO: support real types like float or int
		NetworkRequest r = new NetworkRequest(ACTION_USER, stamp, tag, code, arg0, arg1, data, TEMP_TYPE);
		requestQueue.add(r);
		sendPacketByAnotherThread();
	}

	public void sendSensingEndAction() {
		NetworkRequest r = new NetworkRequest(ACTION_SENSING_END, null, null, -1);
		requestQueue.add(r);
		sendPacketByAnotherThread();
	}
//==================================================================================================
//	Internal functions to handle the recevied packets
//==================================================================================================
	// Create a separate thread to pool packets
	private boolean keepRecvThreadRunning = false; // flag to mark it the receving thread is running or not
	private void createThreadToReceiveAndBlockArrivePacket (){
		if(!keepRecvThreadRunning){ // thread is already running, no need to run another thread
			keepRecvThreadRunning = true;
			class DataRecvingRunnable implements Runnable {
				public void run() {
					keepPacketRecving();
				}
			}
			new Thread(new DataRecvingRunnable(), "Data Recving Thread").start();
		}
	}

	//private short[] audioReceived = null;
	private void keepPacketRecving(){
		while(keepRecvThreadRunning) {
			try {
				byte reaction;
				reaction = dataIn.readByte();

				if(reaction == REACTION_ASK_SENSING) {
					listener.serverAskStartSensing();
					/*
					int type = dataIn.readInt();
					int rIdx = dataIn.readInt();
					int rCnt = dataIn.readInt();
					int answerSize = dataIn.readInt();
					byte[] answerBytes = new byte[answerSize];
					dataIn.readFully(answerBytes);
					String answerString = new String(answerBytes);


					float vol = dataIn.readFloat();
					boolean needToUpdateAudio = (dataIn.readInt()==1);
					boolean needToAutoPlay = (dataIn.readInt()==1);
					boolean needToCalibEnd = (dataIn.readInt()==1);

					if(needToUpdateAudio&&!audioHasBeenUpdatedAfterRequestStartIsAsked){
						Log.e(C.LOG_TAG, "[ERROR]: audio need to update but is not updated before the request is received");
						caller.error("[ERROR]: audio need to update but is not updated before the request is received");
					}

					latestReceviedUserStudyRequest = new UserStudyRequest(type, rIdx, rCnt, answerString, vol, needToUpdateAudio, needToAutoPlay, needToCalibEnd);

					byte check = dataIn.readByte();
					if(check != -1){
						Log.e(C.LOG_TAG, "[ERROR]: check is not -1 -> some packet might be dropped or there is a bug in matlab server");
						caller.error("Receive corrupted information from server (unstable network connection?) at reaction = "+reaction);
					}

					caller.requestReceivedFromServer(latestReceviedUserStudyRequest);
					*/
				} else if (reaction == REACTION_SERVER_CLOSED) {
					listener.serverClosed();
				} else if(reaction == REACTION_STOP_SENSING) {
					listener.serverAskStopSensing();
				} else if(reaction == REACTION_SET_MEDIA){ // This reaction sets audio based on the received payload
					int FS = dataIn.readInt(); // sample rate
					int chCnt = dataIn.readInt();
					int repeatCnt = dataIn.readInt(); // number of audio repetation played

					// read pilot
					int shortToRead = dataIn.readInt();
					int BYTE_OF_SHORT = 2;
					byte[] b = new byte[shortToRead*BYTE_OF_SHORT];
					int totalByteRead = 0;
					while(totalByteRead<shortToRead*BYTE_OF_SHORT) {
						//Log.d(Constant.LOG_TAG, "totalByteRead = "+totalByteRead+",validByteToRead = "+validByteToRead);
						int byteIsRead = dataIn.read(b, totalByteRead, shortToRead * BYTE_OF_SHORT - totalByteRead);
						totalByteRead += byteIsRead;
					}
					short[] pilot = new short[shortToRead];
					ByteBuffer.wrap(b).order(ByteOrder.LITTLE_ENDIAN).asShortBuffer().get(pilot);

					// read signal
					shortToRead = dataIn.readInt();
					b = new byte[shortToRead*BYTE_OF_SHORT];
					totalByteRead = 0;
					while(totalByteRead<shortToRead*BYTE_OF_SHORT) {
						//Log.d(Constant.LOG_TAG, "totalByteRead = "+totalByteRead+",validByteToRead = "+validByteToRead);
						int byteIsRead = dataIn.read(b, totalByteRead, shortToRead * BYTE_OF_SHORT - totalByteRead);
						totalByteRead += byteIsRead;
					}
					short[] signal = new short[shortToRead];
					ByteBuffer.wrap(b).order(ByteOrder.LITTLE_ENDIAN).asShortBuffer().get(signal);
					byte check = dataIn.readByte();
					if(check != -1){
						Log.e(LOG_TAG, "Check is not -1 -> some packet might be dropped or there is a bug in matlab server");
						listener.updateDebugStatus(false, "signal loaded fails");
					}

					AudioSource audioSource = new AudioSource(pilot, signal, FS, chCnt, repeatCnt);

					Log.d(LOG_TAG, "Load audio from server with length="+shortToRead);
					listener.audioReceivedFromServer(audioSource);

					audioHasBeenUpdatedAfterRequestStartIsAsked = true;
					if(SAVE_LATEST_LOADED_AUDIO_TO_FILE){
						BufferedOutputStream bos = new BufferedOutputStream(new FileOutputStream(Constant.libFolderPath + "audioFromServer.dat"));
						bos.write(b);
						bos.flush();
						bos.close();
					}
				} else if (reaction == REACTION_SET_RESULT) {
					// TODO: update result to user-app callbacks
					int audioSampleCnt = dataIn.readInt();
					int argInt = dataIn.readInt();
					// TODO: add write float
					byte check = dataIn.readByte();

					Log.d(LOG_TAG, "received result = "+argInt+", check = "+check);
					if(check != -1){
						Log.e(LOG_TAG, "Check is not -1 -> some packet might be dropped or there is a bug in matlab server");
						listener.updateDebugStatus(false, "result loaded fails (check != -1)");
					} else {
						listener.resultReceviedFromServer(audioSampleCnt, argInt);
					}
				} else if (reaction == REACTION_DELAY_SOUND) {
					int argInt = dataIn.readInt();
					int delayBySamples = argInt;

					byte check = dataIn.readByte();
					Log.d(LOG_TAG, "received result = "+argInt+", check = "+check);
					if(check != -1){
						Log.e(LOG_TAG, "Check is not -1 -> some packet might be dropped or there is a bug in matlab server");
						listener.updateDebugStatus(false, "result loaded fails (check != -1)");
					} else {
						Log.e(LOG_TAG, "Received delay samples in NC: " + delayBySamples);
						listener.audioDelayFromServer(delayBySamples);
					}
				}
			} catch (IOException e) {
				Log.w(LOG_TAG, "Read socket data timeout (need more data? or wait a while?)");
			}
		}
	}


	private boolean keepSendThreadRunning = false; // control outside the thread to make it work or not
	private boolean sendThreadIsStopped = true; // control inside the thread to make sure it run before the previous one has been stopped
	private void sendPacketByAnotherThread(){
		if(!keepSendThreadRunning){ // thread is not running anymore(or yet) -> need to run a new thread
			keepSendThreadRunning = true;
			class DataSendingRunnable implements Runnable {
				public void run() {
					// *** comment this line just for debugging ***
					keepPacketSending();
				}
			}
			new Thread(new DataSendingRunnable(), "Data Sending Thread").start();
		}
	}

	private void keepPacketSending(){
		boolean threadNeedInit = true;
		while(keepSendThreadRunning){
			if(threadNeedInit) {
				if (!sendThreadIsStopped) {
					Log.d(LOG_TAG, "Previous thread is not stopped yet when a new sending thread is created");
				} else {
					// indicate this thread is working
					sendThreadIsStopped = false;
					threadNeedInit = false;
				}
			} else {
				// send message to remote server
				try{
					while(!requestQueue.isEmpty()){
						NetworkRequest r = requestQueue.peek();
						Log.d(LOG_TAG, "Sending message type: " + r.action);
						switch (r.action){
							case ACTION_INIT:
								dataOut.write(ACTION_INIT);
								break;
							case ACTION_DATA:
								dataOut.write(ACTION_DATA);
								dataOut.writeInt(r.data.length);
								dataOut.write(r.data);
								dataOut.write(-1); // use as the sanity check of send message
								break;
							case ACTION_SET:
								dataOut.write(ACTION_SET);
								dataOut.writeInt(r.type);
								byte[] nameBytes = r.name.getBytes();
								dataOut.writeInt(nameBytes.length);
								dataOut.write(nameBytes);
								dataOut.write(-1); // use as the sanity check of send message
								dataOut.writeInt(r.data.length);
								dataOut.write(r.data);
								dataOut.write(-1); // use as the sanity check of send message
								break;
							case ACTION_USER:
								dataOut.write(ACTION_USER);
								dataOut.writeInt(r.stamp);

								byte[] tagBytes = r.name.getBytes();
								dataOut.writeInt(tagBytes.length);
								dataOut.write(tagBytes);
								dataOut.write(-1); // use as the sanity check of send message

								dataOut.writeInt(r.code);
								dataOut.writeFloat(r.arg0);
								dataOut.writeFloat(r.arg1);

								//dataOut.write(-1); // use as the sanity check of send message
							case ACTION_SENSING_END:
								dataOut.write(ACTION_SENSING_END);
								break;
							default:
								Log.e(LOG_TAG, "[ERROR]: undefined action = "+r.action);
						}
						requestQueue.poll();
						Log.d(LOG_TAG, "Finished sending packet.");
					}
					dataOut.flush();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
			try {
				Thread.sleep(DATA_SENDING_THREAD_LOOP_DELAY);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		// end of sending thread (could be terminated by close socket)
		sendThreadIsStopped = true;
	}

	// this function open a new thread to close server if need
	public void closeServerIfServerIsAlive(){
		new Thread() {
			public void run() {
				// end the packet sending thread
				keepSendThreadRunning = false;
				keepRecvThreadRunning = false;
				// close server directly since the check alive function doesn't work
				closeServer();
			}
		}.start();
	}

	private void closeServer(){
		if(status != SERVER_STATUS_DISABLED){
			try {
				if(status == SERVER_STATUS_CONNECTED) {
					Log.d(LOG_TAG, "send disconnection messgae to socket for closing socket");
					dataOut.write(ACTION_CLOSE);
					dataOut.flush();
				}
				
				sc.close();
			} catch (IOException e) {
				Log.e(LOG_TAG, "ERROR: can't being closed : " + e.getMessage());
				e.printStackTrace();
			}
			status = SERVER_STATUS_DISABLED;
		} else {
			Log.w(LOG_TAG, "ERROR: server is not connected -> no need to close it");
		}
	}

	public boolean isConnected(){
		return status == SERVER_STATUS_CONNECTED;
	}

	
	
}
