/**
 * 
 */
package edu.umich.cse.yctung;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.channels.SocketChannel;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Random;
import java.util.Vector;
import java.util.concurrent.ConcurrentHashMap;


/**
 * @author yctung
 * A bridge for Matlab to open a separate thread to blocking socket operations
 * the concept of this code comes from the matSock library and undocumented Matlab
 */
public class JavaSensingServer extends Thread {
	private static final String VERSION_DESC = "1.0.2: temporaly disable latency analyzer"; 
	private static final int MAX_SERVER_CNT = 5; // number of threads being supported
	private static final String CLASS_NAME 	= JavaSensingServer.class.getSimpleName();
	public static boolean SHOW_DEBUG_MESSAGE = true;
	
	// set this flag to volatile because it will be read/write on different thread (ref: http://stackoverflow.com/questions/106591/do-you-ever-use-the-volatile-keyword-in-java)
	private volatile boolean shutdown; // flag to shutdown the socket reading loop
	private int port;
	private static ConcurrentHashMap<Integer, JavaSensingServer> servers = new ConcurrentHashMap<Integer, JavaSensingServer>(MAX_SERVER_CNT, 0.75f, MAX_SERVER_CNT);
	
	// Socket related variables
	private ServerSocket serverSocket = null;
	private Socket clientSocket = null;
	private DataOutputStream dataOut = null;
	private DataInputStream dataIn = null;
	
	private final static int DATA_SENDING_THREAD_LOOP_DELAY = 1; //ms, NOTE: should set this value as small as possible
	
	// Types of actions (for identifying packets sent to the server)
	private final static int ACTION_CONNECT = 1; 	// ACTION_CONNECT format: | ACTION_CONNECT | xxx parater setting
	private final static int ACTION_DATA 	= 2; 	// ACTION_SEND format: | ACTION_DATA | # of bytes to send | byte[] | -1
	private final static int ACTION_CLOSE 	= -1;	// ACTION_CLOSE format: | ACTION_CLOSE |
	private final static int ACTION_SET 	= 3;
	private final static int ACTION_INIT 	= 4;
	private final static int ACTION_SENSING_END = 5;
	private final static int ACTION_USER 	= 6;
	
	// Analysis related variable
	int dataByteCnt;
	public boolean needToAnalyzeLatency;
	public LatencyAnalyzer la; // NOTE: la is not initialized since a not import correclty issue
	// TODO: fix this bug, maybe try to move the LatencyAnalyzer to another public class?
	
//===============================================================
//	Constructors	
//===============================================================
	// Public constructor (called by Matlab)
	public static JavaSensingServer create(int port){
		// TODO: check if the port of server exist
		JavaSensingServer jss = new JavaSensingServer(port);
		jss.start(); // now everything is in the seperate thread
		servers.put(port, jss);
		return jss;
	}
	
	public static String version() {
		threadErrMessage("JavaSensingVersion = " +VERSION_DESC);
		return VERSION_DESC;
	}
	
	// Private constructor
	private JavaSensingServer(int port) {
		this.port = port;
		shutdown = false;
		serverSocket = null;
		clientSocket = null;
		
		dataByteCnt = 0;
		needToAnalyzeLatency = false;
		// TODO: init la after solving the import issue
		//la = new LatencyAnalyzer();
	}

//===============================================================
//  Public interface (called by Matlab) 	
//===============================================================
	public void writeByte(byte dataByte) throws IOException {
		dataOut.writeByte(dataByte);
	}
	
	public void writeInt(int dataInt) throws IOException {
		dataOut.writeInt(dataInt);
	}
	
	public int write(byte[] dataBytes) throws IOException {
		dataOut.write(dataBytes);
		return dataBytes.length; // just for debug
	}
	
	public static void closeAll(){
		for (JavaSensingServer server : servers.values()) {
			threadMessage("closeAll: going to close server at port = "+server.port);
			server.close();
		}
	}
	
	public void close() {
		shutdown = true; // TODO: set time out for socket read, so the shutdown will work 
		try {
			threadMessage("close: going to close socket at port = "+port);
			if (serverSocket != null) serverSocket.close();
			if (clientSocket != null) clientSocket.close();
		} catch (IOException e) {
			threadErrMessage("[ERROR]: unable to close socket"+e.getMessage());
		}
		servers.remove(port);
	}
	

//===============================================================
// Matlab callback setting
// reference: matSock and Undocumented Matlab
//===============================================================
	private java.util.Vector<SocketListener> eventListeners	= new java.util.Vector<SocketListener>(4,1);
	public synchronized void addListener(SocketListener lis) {
		eventListeners.addElement(lis);
	}
	public synchronized void removeListener(SocketListener lis) {
		eventListeners.removeElement(lis);
	}
	
	// Matlab automatically converts the methods of classes that extend java.util.EventListener
	// into a Matlab callback.  In this case "opRead" will automatically be
	// converted into "OpReadCallback".  The first character will always be capitalized
	// and the suffix "Callback" will be appended.  All of this happens automatically for
	// classes on Matlab's static class path.
	// Thank you Yair Altman for this insight, see his blog post:
	// http://undocumentedmatlab.com/blog/matlab-callbacks-for-java-events/
	public interface SocketListener extends java.util.EventListener {
		void opRead(SocketEvent event);
		void opData(SocketEvent event);
		void opAccept(SocketEvent event);
		//void opConnect(SocketEvent event);
	}
	
	// TODO: modify this even based on my need
	public class SocketEvent extends java.util.EventObject {
		private static final long serialVersionUID = 1L;
		public int action = -1;
		public byte[] dataBytes	= null;
		public int setType = -1;
		public byte[] nameBytes = null;
		public double time 	= -1;		//(sec)
		public int stamp = -1;
		public float arg0 = 0, arg1 = 0;
		public int code = -1;
		
		
		public SocketEvent(Object source, int action, byte[] dataBytes) {
			super(source);
			this.action		= action;
			this.dataBytes 	= dataBytes;
			this.time 		= ((double)System.currentTimeMillis())/1000;
		}
		
		// for set action
		public SocketEvent(Object source, int action, byte[] dataBytes, int setType, byte[] nameBytes) {
			super(source);
			this.action		= action;
			this.dataBytes 	= dataBytes;
			this.setType 	= setType;
			this.nameBytes  = nameBytes;
			this.time 		= ((double)System.currentTimeMillis())/1000;
		}
		
		// for user action
		public SocketEvent(Object source, int action, int stamp, byte[] nameBytes, int code, float arg0, float arg1) {
			super(source);
			this.action 	= action;
			this.stamp 		= stamp;
			this.nameBytes  = nameBytes;
			this.code 		= code;
			this.arg0 		= arg0;
			this.arg1  		= arg1;
			this.time 		= ((double)System.currentTimeMillis())/1000;
		}
	}
	
	private void fireDataEvent(SocketEvent event) {
		for( SocketListener listener : eventListeners ) {
			if( listener != null ) {
				listener.opData(event);
			}
		}
	}
	
	private void fireAcceptEvent() {
		SocketEvent dummyEvent 	= new SocketEvent(this, -1, null);
		for( SocketListener listener : eventListeners ) {
			if( listener != null ) {
				listener.opAccept(dummyEvent);
			}
		}
	}
	
//===============================================================
//	Read thread (read forever until the server is closed)	
//===============================================================
	@Override
	public void run() {
		threadMessage("run");
		try {
			// 1. wait for the socket being connected
			serverSocket = new ServerSocket(port);
			threadMessage("wait socket being connected at port :"+port);
			clientSocket = serverSocket.accept();
			threadMessage("socket has been connected at port :"+port);
		    dataOut = new DataOutputStream(clientSocket.getOutputStream());
			dataIn = new DataInputStream(clientSocket.getInputStream());
			fireAcceptEvent();
			
			// 2. infinite loop to read any available message
			while(true) {
				if (shutdown) {
					threadMessage("shutdown");
					break;
				}
				
				byte action = dataIn.readByte();
				threadMessage("receive a action = "+action+" in port = "+port);
				
				//**********************************************************
                // ACTION_CONNECT: just connect the socket -> doing nothing
                //**********************************************************
                if (action == ACTION_CONNECT) {
                    threadMessage("--- ACTION_CONNECT ---");
                    fireDataEvent(new SocketEvent(this, action, null));
                }
                //**********************************************************
                // ACTION_INIT: initialize necessary commponent
                //  ***NOTE***: This action is triggered only when necessary
                //            : variables are setted by ACTION_SET
                //**********************************************************
                else if (action == ACTION_INIT) { // % one time initialization
                	threadMessage("--- ACTION_INIT ---");
                	//writeAudioData();
                	// just for debug -> start sensing
                	//dataOut.write(REACTION_ASK_SENSING);
                	
                	fireDataEvent(new SocketEvent(this, action, null));
                }
                //**********************************************************
                // ACTION_DATA: received audio data 
                //**********************************************************
                else if (action == ACTION_DATA) { // acoustic sensing data received
                	threadMessage("--- ACTION_DATA ---");
                    byte[] dataBytes = readFullData();
                    
                    // TODO: revise the name to make this function easy to read, we should use the data byte cnt as the marker
                    if (needToAnalyzeLatency) {
                    	la.addAudioStamp(dataByteCnt);
                    }
                    
                    dataByteCnt += dataBytes.length;
                    fireDataEvent(new SocketEvent(this, action, dataBytes));
                }
                //**********************************************************
                // ACTION_SET: set matlab variable based on code
                //**********************************************************
                else if (action == ACTION_SET) {
                    threadMessage("--- ACTION_SET ---");
                    int setType = dataIn.readInt();
                    threadMessage("setType = " + setType);
            	    byte[] nameBytes = readFullData();
            	    byte[] valueBytes = readFullData();
            	    fireDataEvent(new SocketEvent(this, action, valueBytes, setType, nameBytes));
                }
                
                //**********************************************************
                // ACTION_USER: application's user-defined data
                //**********************************************************
                else if (action == ACTION_USER) {
                	threadMessage("--- ACTION_USER ---");
                	int stamp = dataIn.readInt();
                	byte[] tagBytes = readFullData();
                	int code = dataIn.readInt();
                	float arg0 = dataIn.readFloat();
                	float arg1 = dataIn.readFloat();
                	fireDataEvent(new SocketEvent(this, action, stamp, tagBytes, code, arg0, arg1));
                }
                
                //**********************************************************
                // ACTION_SENSING_END: just break the loop
                //**********************************************************
                else if (action == ACTION_SENSING_END) {
                    threadMessage("--- ACTION_SENSING_END: this round of sensing ends ---");
                    //set(0,'UserData','ACTION_SENSING_END');   
                    fireDataEvent(new SocketEvent(this, action, null));
                }
                //**********************************************************
                // ACTION_CLOSE: read the end of sockets -> close loop
                //**********************************************************
                else if (action == ACTION_CLOSE) {
                    threadMessage("--- ACTION_CLOSE: socket is closed remotely ---");
                    fireDataEvent(new SocketEvent(this, action, null));
                    break;
                }
                else { // error action 
                    threadMessage("[ERROR]: undefined action ="+action);
                    break;
                }
				
                // sleep a short period to avoid overwhelming the CPU by a single thread
				try {
					Thread.sleep(DATA_SENDING_THREAD_LOOP_DELAY);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}
			
		} catch (IOException e) {
			// NOTE: we assume the socket is closed whenever there is a read socket exception happens
			// TODO: let Matlab know if it is an internal error or just a socket close event
			fireDataEvent(new SocketEvent(this, ACTION_CLOSE, null));
			if (e.toString().equals("java.net.SocketException: Socket closed")) {
				threadMessage("[WARN]: socket is closed (either by local or remote entity)");
			} else {
				threadErrMessage("[WARN]: on port = "+port+", e="+e.toString());
			}
		}
		
		
		threadMessage("end of thread");
	}
	
//===============================================================
// Internal sensing control functions	
//===============================================================
	
	private byte[] readFullData() throws IOException {
	    int byteToRead = dataIn.readInt();
	    threadMessage("readFullData: byteToRead = "+byteToRead);
	    byte[] data = new byte[byteToRead];
	    
	    int totalByteRead = 0;
	    while(totalByteRead<byteToRead) {
	    	int byteIsRead = dataIn.read(data, totalByteRead, byteToRead - totalByteRead);
	    	totalByteRead += byteIsRead;
	    }
	    // check if data format is correct -> end with -1
	    byte check = dataIn.readByte();
	    threadMessage("readFullData: check = "+check);
	    if (check != -1){
	    	threadErrMessage("[ERROR]: wrong represetation of message send (size inconsistence?)");
	    	close();
	    }
	    return data;
	}
	
	// this method should be implemented in Matlab, but this one is just for debug purpose
	/*
	private void writeAudioData() throws IOException {
		// a. write reaction identifier
		dataOut.writeByte(REACTION_SET_MEDIA);
		// b. write sample rate and other information
		dataOut.writeInt(48000); // FS
		dataOut.writeInt(2); // chCnt
		dataOut.writeInt(5); // repeatCnt
		
		// c. write preamble
		int preambleSize = 4800; // NOTE the size is for short
		dataOut.writeInt(preambleSize);
		byte[] preamble = new byte[preambleSize*2]; 
		new Random().nextBytes(preamble);
	    dataOut.write(preamble);
		
		// d. write signal
		int signalSize = 48000; // NOTE the size is for short
		dataOut.writeInt(signalSize);
		byte[] signal = new byte[signalSize*2]; 
		new Random().nextBytes(signal);
		dataOut.write(signal);
		
		// e. write check
	    byte check = -1;
	    dataOut.writeByte(check);
	}
	*/
	

//===============================================================
//	Main function (used for debug only)	
//===============================================================
	public static void main(String[] args) {
		JavaSensingServer.closeAll();
		
		try {
			Thread.sleep(1000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		JavaSensingServer jss = JavaSensingServer.create(50005);
	}


	
//===============================================================
// Some Internal help functions
//===============================================================
	public static void threadMessage(String id) {
		threadMessage(id,null);
	}
	
	public static void threadMessage(String id, String msg) {
		// thread message is only shown when the DEBUG_SHOW_MESSAGE = true
		if (SHOW_DEBUG_MESSAGE) {
			String threadName 	= Thread.currentThread().getName();
			if( msg == null ) {
				System.out.println("thread(" + threadName + "): '" + CLASS_NAME + ":" + id + "'");
			} else {
				System.out.println("thread(" + threadName + "): '" + CLASS_NAME + ":" + id + "' -> " + msg);
			}
		}
	}
	
	public static void threadErrMessage(String id) {
		threadErrMessage(id,null);
	}
	
	public static void threadErrMessage(String id, String msg) {
		String threadName 	= Thread.currentThread().getName();
		if( msg == null ) {
			System.err.println("thread(" + threadName + "): '" + CLASS_NAME + ":" + id + "'");
		} else {
			System.err.println("thread(" + threadName + "): '" + CLASS_NAME + ":" + id + "' -> " + msg);
		}
	}
	
	 //=================================================================================================
	 // Latency analysis
	 //=================================================================================================
	     protected class LatencyAnalyzer {
	         private class LatencyStamp {
	             int sampleCnt;
	             long time; // ms
	             public LatencyStamp(int sampleCnt, long time) {
	                 this.sampleCnt = sampleCnt;
	                 this.time = time;
	             }
	         }
	         Queue<LatencyStamp> audioStamps; // time stamps when the audio buffer is read
	         Queue<LatencyStamp> resultStamps; // time stamps when the sensing results are updated

	         public LatencyAnalyzer() {
	             audioStamps = new LinkedList<LatencyStamp>();
	             resultStamps = new LinkedList<LatencyStamp>();
	         }

	         public void addAudioStamp(int sampleCnt) {
	        	 threadErrMessage("addAudioStamp() at sampleCnt = " + sampleCnt);
	             addStamp(sampleCnt, audioStamps);
	         }

	         public void addResultStamp(int sampleCnt) {
	        	 threadErrMessage("addResultStamp() at sampleCnt = " + sampleCnt);
	             addStamp(sampleCnt, resultStamps);
	         }

	         public double avgLatency = -1;

	         public Vector<Integer> resultSampleCnts, resultLatencies;
	         public double resultAvgLatency = -1;
	         public void analyze() {
	        	 threadErrMessage("analyze()");

	             LatencyStamp audioStamp;
	             LatencyStamp resultStamp;

	             int cnt = 0;
	             double sum = 0;

	             resultSampleCnts = new Vector<Integer>();
	             resultLatencies = new Vector<Integer>();

	             while(!audioStamps.isEmpty() && !resultStamps.isEmpty()) {
	                 audioStamp = audioStamps.peek();
	                 resultStamp = resultStamps.peek();

	                 if (audioStamp.sampleCnt == resultStamp.sampleCnt) { // find a match
	                     long latency = resultStamp.time - audioStamp.time;
	                     threadMessage("Find a matched latency record (" + 
	                    		 audioStamp.sampleCnt + "," + 
	                    		 audioStamp.time + "," +
	                    		 resultStamp.time + "): " + 
	                    		 latency + "(ms)");

	                     cnt ++;
	                     sum += latency;

	                     resultSampleCnts.add(audioStamp.sampleCnt);
	                     resultLatencies.add((int)latency);

	                     audioStamps.poll();
	                     resultStamps.poll();
	                 } else if (audioStamp.sampleCnt < resultStamp.sampleCnt) {
	                     audioStamps.poll();
	                 } else {
	                     resultStamps.poll();
	                 }
	             }

	             resultAvgLatency = cnt == 0 ? -1 : sum / cnt;
	         }

	         private void addStamp(int sampleCnt, Queue<LatencyStamp>target) {
	             long now = System.currentTimeMillis();
	             target.add(new LatencyStamp(sampleCnt, now));
	         }
	     }
	
}
