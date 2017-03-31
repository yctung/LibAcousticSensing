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
import java.util.concurrent.ConcurrentHashMap;

/**
 * @author yctung
 * A bridge for Matlab to open a separate thread to blocking socket operations
 * the concept of this code comes from the matSock library and undocumented Matlab
 */
public class JavaSensingServer extends Thread {
	private static final int MAX_SERVER_CNT = 5; // number of threads being supported
	private static final String CLASS_NAME 	= JavaSensingServer.class.getSimpleName();
	private static final boolean SHOW_DEBUG_MESSAGE = true;
	
	// set this flag to volatile because it will be read/write on different thread (ref: http://stackoverflow.com/questions/106591/do-you-ever-use-the-volatile-keyword-in-java)
	private volatile boolean shutdown; // flag to shutdown the socket reading loop
	private int port;
	private static ConcurrentHashMap<Integer, JavaSensingServer> servers = new ConcurrentHashMap<Integer, JavaSensingServer>(MAX_SERVER_CNT, 0.75f, MAX_SERVER_CNT);
	
	// Socket related variables
	private ServerSocket serverSocket = null;
	private Socket clientSocket = null;
	private DataOutputStream dataOut = null;
	private DataInputStream dataIn = null;
	
	private final static int DATA_SENDING_THREAD_LOOP_DELAY = 5; //ms, NOTE: should set this value as small as possible
	
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
	
	// Private constructor
	private JavaSensingServer(int port) {
		this.port = port;
		shutdown = false;
	}

//===============================================================
//  Public interface (called by Matlab) 	
//===============================================================
	public static void closeAll(){
		for (JavaSensingServer server : servers.values()) {
			server.close();
		}
	}
	
	public void close() {
		shutdown = true; // TODO: set time out for socket read, so the shutdown will work 
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
		public SocketChannel channel 	= null;
		public byte[] data	= null;
		public double time 	= -1;		//(sec)
		
		public SocketEvent(Object source, SocketChannel channel, byte[] data) {
			super(source);
			this.channel	= channel;
			this.data 		= data;
			this.time 		= ((double)System.currentTimeMillis())/1000;
		}
	}
	
	private void fireDataEvent(SocketChannel channel, byte[] data) {
		for( SocketListener listener : eventListeners ) {
			if( listener != null ) {
				SocketEvent event 	= new SocketEvent(this, channel, data);
				listener.opData(event);
			}
		}
	}
	
	private void fireAcceptEvent(SocketChannel channel) {
		for( SocketListener listener : eventListeners ) {
			if( listener != null ) {
				SocketEvent event 	= new SocketEvent(this, channel, null);
				listener.opAccept(event);
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
			fireAcceptEvent(null);
			
			// 2. infinite loop to read any available message
			while(true) {
				if (shutdown) {
					threadMessage("shutdown");
					break;
				}
				
				byte action = dataIn.readByte();
				threadMessage("receive a action data = "+action+" in port = "+port);
				fireDataEvent(null, null);
				
				try {
					Thread.sleep(DATA_SENDING_THREAD_LOOP_DELAY);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}
			
		} catch (IOException e) {
			threadErrMessage("[ERROR]: unable to start server on port = "+port);
		}
		
		
		
	}
	
	
	

//===============================================================
//	Main function (used for debug only)	
//===============================================================
	public static void main(String[] args) {
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
	
}
