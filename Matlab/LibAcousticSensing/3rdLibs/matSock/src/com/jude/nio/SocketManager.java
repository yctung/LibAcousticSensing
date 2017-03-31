package com.jude.nio;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;
import java.nio.channels.CancelledKeyException;
import java.nio.channels.ClosedChannelException;
import java.nio.channels.ClosedSelectorException;
import java.nio.channels.SelectionKey;
import java.nio.channels.Selector;
import java.nio.channels.ServerSocketChannel;
import java.nio.channels.SocketChannel;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;


//TODO:
//Create methods to:
// 1. get all open channels
// 2. 
// 
//TODO:
// 1. OpWrite and OpConnect
// 2. Create a SocketOpts class with all of the 
//	Socket, ServerSocket, SocketChannel, and ServerSocket Channel options.
// 3. Create a public register method that accepts a SocketOptions argument.
//
// and 1 million other things...


public class SocketManager extends Thread
{
	//Class Members
	private static final String className 	= SocketManager.class.getSimpleName();
	
	//Collection of SocketManager statically available so that
	// all sockets can be retrieved.
	private static ConcurrentHashMap<String, SocketManager> managers	
					= new ConcurrentHashMap<String, SocketManager>(4,0.75f,4);
	
	//Object Members
	private final String name;
	private Selector selector				= null;
	private HashMap<SocketChannel,ByteBuffer> buffers	= new HashMap<SocketChannel,ByteBuffer>(8);
	private HashMap<Object,SocketOptions> options 		= new HashMap<Object,SocketOptions>(8);
	private List<RegisterRequest> registerRequests 		= new LinkedList<RegisterRequest>();
	
	private boolean DEBUG			= false;
	
	private boolean shutdown 		= false;
	
	//default socket options
	private int soRcvBuffSize 		= 1024*1024*2;	//2 Byte
	
	//======================================
	// Constructor
	//======================================
	
	public static SocketManager init() throws IOException {
		String name 	= "SocketManager" + UniqueInt.get();
		
		SocketManager sMan	= new SocketManager(name);
		sMan.start();
		
		//register the SocketManager statically with the class
		// so that we will not lose the reference
		managers.put(name, sMan);
		
		return sMan;
	}
	
	
	private SocketManager(String name) throws IOException {
		super(name);
		this.name 	= name;
		
		//open channel multiplexor
		selector = Selector.open();
	}
	
	
	
	private void closeChannel(SocketChannel channel) {
		try {
			channel.close();
		} catch (IOException e) {
			//do nothing
		}
		buffers.remove(channel);
		options.remove(channel);
	}
	
	
	@SuppressWarnings("rawtypes")
	@Override
	public void run() {
		
		threadMessage("run");
		
		try {

			//loop forever waiting for something interesting to happen
			while(true) {
				
				//NOTE: select() is a blocking call.  If other threads
				// want to modify me somehow then I must create a helper
				// method that will call selector.wakeup().  Like the
				// register() methods.
				selector.select();
				
				if( shutdown == true ) {
					break;
				}
				
				
				try{
					// Get set of ready objects, those objects that
					// are ready to have occur one of the operations that
					// we flagged (OP_READ, OP_ACCEPT, etc...)
					Set readyKeys 		= selector.selectedKeys();
					Iterator readyItor 	= readyKeys.iterator();
	
					// Walk through set
					while(readyItor.hasNext()) {
	
						// Get key from set and remove the current entry
						SelectionKey key = (SelectionKey)readyItor.next();
						readyItor.remove();
						
						if( ! key.isValid() ) continue;
	
						//==============================
						// OP_READ
						//==============================
						if( key.isReadable() ) {
							
							// Get the channel and read in the data
							SocketChannel keyChannel = (SocketChannel)key.channel();
							ByteBuffer bb		= buffers.get(keyChannel);
							SocketOptions opts 	= options.get(keyChannel);
							
							int capacity 	= bb.capacity();
							int len			= 0;
							
							try{
								len 	= keyChannel.read(bb);
							} catch ( IOException ioe) {
								//channel was forcibly closed so do something about it...
								if( DEBUG ) threadMessage("run:badClose");
								key.cancel();
								closeChannel(keyChannel);
							}
	
							if( len > 0 ) {
								if( DEBUG ) threadMessage("run:goodRead(" + len + ")");
								
								bb.flip();
								
								// If we have not flagged the socket manager to wait
								// to collect an entire message then pass it on as
								// we receive it.
								if( ! opts.waitForWholeMessage ) {
									
									if( bb.remaining() > 0 ) {
										byte[] data 	= new byte[bb.remaining()];
										bb.get(data);
										
										fireReadEvent(keyChannel, data);
									}

								//Else wait for an entire message to be received as specified
								// by the int value that you read from message size position
								} else {
									
									//must have at least msgSizeBytePosition+3 bytes remaining to check size
									while( bb.remaining() > opts.msgSizePosition+3) {
										
										//bb.mark();	//not needed because fail point occurs before we increment the position marker					
										int numBytes 	= bb.getInt(opts.msgSizePosition);	//does not increment buffer position marker
										
										
										// We have unsynced and something is wrong
										if(numBytes <= 0 || numBytes > capacity) {
											threadErrMessage("run:readSizeError(" + numBytes + ")", "you should probably close this channel");
											byte[] data 	= new byte[bb.remaining()];
											bb.get(data);	//increments the buffer position marker by data.length
											
											fireReadEvent(keyChannel, data);
											continue;
										}
										
										
										if( bb.remaining() < numBytes ) {
											//bb.reset();	//not needed because we have not incremented the position marker
											break;
										}
										
										byte[] data 	= new byte[numBytes];
										bb.get(data);	//increments the buffer position marker
										
										fireReadEvent(keyChannel, data);
										
									}
								}
								
								// prepare buffer to receive more data
								bb.compact();
								
	
							
							// If the number of bytes read is less then 0 then the socket
							// has been gracefully shutdown.  Respond accordingly.
							} else if( len < 0 ) {
								
								threadMessage("run:goodClose");
								key.cancel();
								closeChannel(keyChannel);
							}
		
						
						//==============================
						// OP_ACCEPT
						//==============================
						} else if(key.isAcceptable()) {
							// Get channel
							ServerSocketChannel keyChannel = (ServerSocketChannel)key.channel();

							// Get server socket
							ServerSocket serverSocket 	= keyChannel.socket();
							SocketOptions serverOpts	= options.get(keyChannel);

							// Accept request
							//if( serverOpts.autoAccept ){
								Socket socket = serverSocket.accept();
								socket.setReceiveBufferSize(soRcvBuffSize);
								
								threadMessage("run:accept");
								
								// Cache the client socket
								if( serverOpts.autoRegister ) {
									SocketChannel sockChannel 	= socket.getChannel();
									sockChannel.configureBlocking(false);
									sockChannel.register(selector, SelectionKey.OP_READ);
									
									register(sockChannel, serverOpts.clone(), selector, SelectionKey.OP_READ);
									
									fireAcceptEvent(sockChannel);
									
								} else {
									//Let Matlab register the channel or do whatever it will...
									SocketChannel sockChannel 	= socket.getChannel();
									//sockChannel.configureBlocking(false);
									
									fireAcceptEvent(sockChannel);
								}
							//} else {
							//	//Let Matlab accept or do whatever it will...
							//	fireAcceptEvent(keyChannel);
							//}
								
						} else {
							
						}
						
	
					}	//end while() 
					
					
					//==========================================
					// now perform any actions waiting in the 
					// selector queues
					//==========================================
					
					synchronized( registerRequests ) {
						
						while( ! registerRequests.isEmpty() ) {
							RegisterRequest request 	= registerRequests.remove(0);
							register(request);
						}
					}
					
					
					
					//Why was this in there? should not be necessary.
					//try {
					//	Thread.sleep(1);
					//} catch (InterruptedException e) {
					//	//do nothing
					//}
					
					
					
				// If the key is canceled or the socket channel is closed
				// after we have already acquired a reference to it then
				// when we try to use it an error will be thrown.  Just
				// catch and discard so as not to kill the selector.
				} catch ( CancelledKeyException cke ) {
					//do nothing
					//threadMessage(" OK! caught CancelledKeyException");
					if( DEBUG )	 {
						threadMessage("run:goodCatch", "CancelledKeyException");
					}
				} catch ( ClosedChannelException cce ) {
					//do nothing
					//threadMessage(" OK! caught ClosedChannelException");
					if( DEBUG )	 {
						threadMessage("run:goodCatch", "ClosedChannelException");
					}
				}

				
			}	//end while(true)
			// Never ends
			
			
		//If the selector is closed then we should die.
		} catch ( ClosedSelectorException cse ) {
			if( DEBUG )	 {
				threadMessage("run:ClosedSelectorException");
				threadMessage(cse.getMessage());
			}		
		
		} catch (IOException e) {
			if( DEBUG )	 {
				threadMessage("run:IOException");
			}
			e.printStackTrace();
			
			
		} finally {
			threadMessage("run:close");
			shutdown();
		}
		
	}
	
	
	
	//==========================================================
	// register()
	// Private methods only to be called by the selector thread.
	//==========================================================
	private void register(RegisterRequest request) {
		
		SocketOptions opts	= new SocketOptions(request);
		if( request.channel instanceof SocketChannel ) {
			
			SocketChannel channel	= (SocketChannel) request.channel;
			register(channel, opts, selector, SelectionKey.OP_READ );

		}else if( request.channel instanceof ServerSocketChannel ) {
			ServerSocketChannel channel 	= (ServerSocketChannel) request.channel;
			register(channel, opts, selector, SelectionKey.OP_ACCEPT);
		}
		
	}
	
	private void register(ServerSocketChannel channel, SocketOptions opts, Selector selector, int selectionKeys ) {
		if(DEBUG) threadMessage("register:Server");
		
		try {
			channel.register(selector, selectionKeys);
			options.put(channel, opts);
			
		} catch (ClosedChannelException e) {
			e.printStackTrace();
		}
	}
	
	
	//NOTE: you can NOT register a blocking socket with a selector.  If you try 
	// to do it an IllegalBlockingModeException will be thrown.
	private void register(SocketChannel channel, SocketOptions opts, Selector selector, int selectionKeys) {
		if(DEBUG) threadMessage("register:Client");
		
		try {
			channel.configureBlocking(false);
			channel.register(selector, selectionKeys);
			buffers.put(channel, ByteBuffer.allocate(soRcvBuffSize));
			options.put(channel, opts);
				
		} catch (ClosedChannelException e) {
			e.printStackTrace();
		} catch (IOException e) {
			try {
				channel.close();
			} catch (IOException e1) {
				//do nothing
			}
			e.printStackTrace();
		}
	}
	
	
	//==========================================================
	// register()
	// Public methods available to Matlab.  These will queue the
	// registration request and notify the selector thread that
	// they are there.
	//==========================================================
	public void register(SocketChannel channel) {
		RegisterRequest request 	= new RegisterRequest(channel);
		
		synchronized( registerRequests ) {
			registerRequests.add(request);
		}
		
		//notify the selector
		selector.wakeup();
	}
	
	
	public void register(SocketChannel channel, int msgSizePosition ) {
		RegisterRequest request 	= new RegisterRequest(channel, msgSizePosition);
		
		synchronized( registerRequests ) {
			registerRequests.add(request);
		}
		
		//notify the selector
		selector.wakeup();
	}
	
	
	public void register(ServerSocketChannel channel) {
		RegisterRequest request 	= new RegisterRequest(channel, true);
		
		synchronized( registerRequests ) {
			registerRequests.add(request);
		}
		
		selector.wakeup();
	}
	
	public void register(ServerSocketChannel channel, boolean autoRegister) {
		RegisterRequest request 	= new RegisterRequest(channel, autoRegister);
		
		synchronized( registerRequests ) {
			registerRequests.add(request);
		}
		
		selector.wakeup();
	}
	
//	public void register(ServerSocketChannel channel, boolean autoAccept, boolean autoRegister) {
//		RegisterRequest request 	= new RegisterRequest(channel, autoRegister);
//		
//		synchronized( registerRequests ) {
//			registerRequests.add(request);
//		}
//		
//		selector.wakeup();
//	}
	
	public void register(ServerSocketChannel channel, boolean autoRegister, int msgSizePosition) {
		RegisterRequest request 	= new RegisterRequest(channel, autoRegister, msgSizePosition);
		
		synchronized( registerRequests ) {
			registerRequests.add(request);
		}
		
		selector.wakeup();
	}
	
	
	
	//====================================================
	// class RegisterRequest
	// Internal class to aid in grouping registration
	// requests and the associated options.
	//====================================================
	public class RegisterRequest{
		public Object channel;
		
		//socket options
		public Integer msgSizePosition	= null;
		
		//server options
		public boolean autoAccept 		= true;
		public boolean autoRegister 	= true;
		
		public RegisterRequest(SocketChannel channel) {
			this.channel 			= channel;
			this.msgSizePosition	= null;
		}
		
		public RegisterRequest(SocketChannel channel, int msgSizePosition) {
			this.channel			= channel;
			this.msgSizePosition	= msgSizePosition;
		}
		
		
		public RegisterRequest( ServerSocketChannel channel) {
			
		}
		
		public RegisterRequest(ServerSocketChannel channel, boolean autoRegister) {
			this.channel 		= channel;
			this.autoAccept		= true;
			this.autoRegister	= autoRegister;
			this.msgSizePosition	= null;
		}
		
		public RegisterRequest(ServerSocketChannel channel, int msgSizePosition) {
			this.channel 		= channel;
			this.autoAccept		= true;
			this.autoRegister	= true;
			this.msgSizePosition	= msgSizePosition;
		}
		
		public RegisterRequest(ServerSocketChannel channel, boolean autoRegister, int msgSizePosition) {
			this.channel 		= channel;
			this.autoAccept		= true;
			this.autoRegister	= autoRegister;
			this.msgSizePosition	= msgSizePosition;
		}
	}
	
	
	//===================================================
	// class SocketOptions
	// Keeps track of the processing options associated
	// with each socket.
	//===================================================
	public class SocketOptions {
		//SocketChannel
		public boolean waitForWholeMessage	= false;
		public int msgSizePosition 		= 0;
		
		//ServerSocketChannel
		public boolean autoAccept		= true;
		public boolean autoRegister 	= true;
		
		public SocketOptions(RegisterRequest request) {
			this.autoAccept 	= request.autoAccept;
			this.autoRegister	= request.autoRegister;
			
			if( request.msgSizePosition != null ) {
				this.msgSizePosition 		= request.msgSizePosition;
				this.waitForWholeMessage	= true;
			}
		}
		
		private SocketOptions() {
			
		}
		
		public SocketOptions clone() {
			SocketOptions opts 	= new SocketOptions();
			opts.waitForWholeMessage	= this.waitForWholeMessage;
			opts.msgSizePosition		= this.msgSizePosition;
			opts.autoAccept				= this.autoAccept;
			opts.autoRegister			= this.autoRegister;
			return opts;
		}
		
	}
	
	
	public static class SocketOpts {
		//Network Stuff - Socket/SocketChannel
		public String host;
		public int port;
		public boolean oobInline 	= false;
		public boolean so_reuseAddr	= true;
		public int so_sndbuf	= 1024*1024;	//buffer size used by the platform for output on this socket
		public int so_rcvbuf 	= 1024*1024;	//buffer size used by teh platform for receiving on this socket
		public boolean tcp_noDelay	= true;
		public int so_linger 	= -1; 	//(sec) -1 implies disabled
		public int so_timeout 	= 0;	//(msec) 0 implies disabled, infinite wait
		
		//PerformancePreferences
		//see the following for an explanation
		//1. http://docs.oracle.com/javase/6/docs/api/java/net/Socket.html
		//2. http://docs.oracle.com/javase/6/docs/api/java/net/ServerSocket.html
		private boolean usePerformancePreferences	= false;
		private int connectionTime;
		private int latency;
		private int bandWidth;
		
		public void setPerformancePreferences(int connectionTime, int latency, int bandwidth) {
			this.connectionTime	= connectionTime;
			this.latency 	= latency;
			this.bandWidth	= bandwidth;
			this.usePerformancePreferences	= true;
		}
		
		
		
		//My Stuff - Socket/SocketChannel
		public boolean waitForWholeMessage	= false;
		public int msgSizePosition 		= 0;
		public ByteOrder endian 	= ByteOrder.BIG_ENDIAN;	//network byte order is big-endian
		
		//My Stuff - ServerSocket/ServerSocketChannel
		public boolean autoAccept		= true;
		public boolean autoRegister 	= true;
		
		
		
		
	}
	
	
	//====================================================================
	// Matlab Event callback
	//====================================================================
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
		//void opWrite(SocketEvent event);
		void opAccept(SocketEvent event);
		//void opConnect(SocketEvent event);
	}
	
	
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
	

	private void fireReadEvent(SocketChannel channel, byte[] data) {

		for( SocketListener listener : eventListeners ) {
			if( listener != null ) {
				SocketEvent event 	= new SocketEvent(this, channel, data);
				listener.opRead(event);
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

	
	
	public static class UniqueInt {
		private static int id	= 0;
		public static int get() {
			id = (id == Integer.MAX_VALUE) ? 1 : id+1;
			return id;
		}
	}
	
	
	
	
	
	//====================================================
	// Methods
	//====================================================
	
	public void close() {
		shutdown	= true;
		selector.wakeup();
	}
	
	
	private void shutdown() {
		threadMessage("shutdown");
		
		try {
			selector.close();
		} catch (IOException e) {
			//do nothing
			//e.printStackTrace();
		}
		
		managers.remove(this);
	}
	
	
	
	
	
	public void setDebug(boolean state) {
		DEBUG 	= state;
	}
	
	public boolean isDebug() {
		return DEBUG;
	}
	
	
	
	
	//=============================================
	// thread messaging
	//=============================================
	public static void threadMessage(String id) {
		threadMessage(id,null);
	}
	
	public static void threadMessage(String id, String msg) {
		String threadName 	= Thread.currentThread().getName();
		if( msg == null ) {
			System.out.println("thread(" + threadName + "): '" + className + ":" + id + "'");
		} else {
			System.out.println("thread(" + threadName + "): '" + className + ":" + id + "' -> " + msg);
		}
	}
	
	public static void threadErrMessage(String id) {
		threadErrMessage(id,null);
	}
	
	public static void threadErrMessage(String id, String msg) {
		String threadName 	= Thread.currentThread().getName();
		if( msg == null ) {
			System.err.println("thread(" + threadName + "): '" + className + ":" + id + "'");
		} else {
			System.err.println("thread(" + threadName + "): '" + className + ":" + id + "' -> " + msg);
		}
	}
}
	

