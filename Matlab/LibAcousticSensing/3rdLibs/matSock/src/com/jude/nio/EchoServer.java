package com.jude.nio;

import java.io.IOException;
import java.net.InetSocketAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.ByteBuffer;
import java.nio.channels.ClosedChannelException;
import java.nio.channels.ClosedSelectorException;
import java.nio.channels.SelectionKey;
import java.nio.channels.Selector;
import java.nio.channels.ServerSocketChannel;
import java.nio.channels.SocketChannel;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Set;
import java.util.Vector;



public class EchoServer extends Thread
{
	public static boolean DEBUG 	= false;
	public final static String name 		= "EchoServer";
	
	private static String hostName 		= "localhost";	//string ipaddress (ex. "192.0.0.2"), "localhost" or computer name is acceptable also
	private static Selector selector 	= null;			//channel multiplexor
	private static int soRcvBuffSize	= 1024 * 1024 * 2;
	//private static ByteBuffer bb 		= ByteBuffer.allocate(soRcvBuffSize);
	
	//private Object bufferLock				= new Object();
	private HashMap<SocketChannel,ByteBuffer> buffers	= new HashMap<SocketChannel,ByteBuffer>(16);
	
	private Vector<ServerSocketChannel> servers 	= new Vector<ServerSocketChannel>(8,1);
	private Vector<Integer> ports 		= new Vector<Integer>(8,8);
	private static int defaultPort 		= 10059;
	
	private boolean shutdown			= false;
	
	public EchoServer() throws IOException {
		this(defaultPort);
	}
	
	public EchoServer(int portNum) throws IOException {
		this(new int[]{portNum});
	}
	
	
	public EchoServer(int[] portNums) throws IOException {
		
		//name this thread
		super(name);
		
		//create channel multiplexor
		selector = Selector.open();	//throw this exception but catch the others
	
		//open a new socket channel
		//configure non-blocking
		//bind it to the host (ipaddress) and port
		ServerSocketChannel channel 	= null;
		
		for( int portNum : portNums ) {
			
			try {
				InetSocketAddress isa 	= new InetSocketAddress(hostName, portNum);
				channel = ServerSocketChannel.open();
				channel.socket().setReceiveBufferSize(soRcvBuffSize);
				channel.socket().setReuseAddress(true);
				channel.configureBlocking(false);
				channel.socket().bind(isa);
				threadMessage("'" + name + ":echoBind' -> host('" + hostName + "') on port " + portNum);
				servers.add(channel);
				ports.add(portNum);
				channel.register(selector, SelectionKey.OP_ACCEPT );
				
			} catch (ClosedChannelException cce) {
				threadMessage("'" + name + ":channelClosed' -> host('" + hostName + "') on port " + portNum);
				servers.remove(channel);
				ports.remove(portNum);

			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				threadMessage("'" + name + ":noBind' -> host('" + hostName + "') on port " + portNum);
			}
			
		}
	}
	
	
	@Override
	public void run() {
		
		threadMessage("'" + name + ":echoStart'");
		
		long baseTime		= -1;
		long currTime 		= -1;
		long elapsedTime 	= -1;
		
		// Wait for something of interest to happen
		try {
			
			while(true) {
				
				selector.select();
				
				if( shutdown ) {
					break;
				}
				
				// Get set of ready objects, those objects that
				// have had occur one of the operations that
				// we flagged (OP_READ, OP_ACCEPT)
				Set readyKeys 		= selector.selectedKeys();
				Iterator readyItor 	= readyKeys.iterator();

				// Walk through set
				while(readyItor.hasNext()) {

					// Get key from set
					SelectionKey key = (SelectionKey)readyItor.next();

					// Remove current entry
					readyItor.remove();

					if( key.isReadable() ) {

						// Get the channel and read the data
						SocketChannel keyChannel = (SocketChannel)key.channel();
						ByteBuffer bb 	= buffers.get(keyChannel);
						baseTime 		= System.currentTimeMillis();
						int l 	= 0;
						try {
							l 			= keyChannel.read(bb);
						} catch( IOException ioe ) {
							// the socket was forced close so close our side
							threadMessage("'" + name + ":channelClose'");
							key.cancel();
							keyChannel.close();
							buffers.remove(keyChannel);
							continue;
						}
						
						if( l > 0 ) {
							if(DEBUG)
								threadMessage("'" + name + ":goodRead' -> Read " + l + " bytes.");
							
							//echo back the bytes
							bb.flip();
							
							l 	= -1;
							while( bb.hasRemaining() ) {
								try{
									l 			= keyChannel.write(bb);
								} catch( IOException ioe ) {
									threadMessage("'" + name + ":channelClose'");
									key.cancel();
									keyChannel.close();
									buffers.remove(keyChannel);
									break;
								}
								
								currTime 	= System.currentTimeMillis();
								elapsedTime = currTime - baseTime;
								
								if( bb.hasRemaining() ) {
									try {
										Thread.sleep(3);
									} catch (InterruptedException e) {
										//do nothing
									}
								}
							}
							
							if(DEBUG)
								threadMessage("'" + name + ":goodWrite' -> Wrote " + l + " bytes at " + elapsedTime + " (milli-sec)");
							
							
						} else if( l < 0 ) {
							//The socket was gracefully shut down so shut down our side.
							threadMessage("'" + name + ":channelClose'");
							key.cancel();
							keyChannel.close();
							buffers.remove(keyChannel);
						}
						
						//Testing
						bb.clear();
						

						
					} else if(key.isAcceptable()) {
						// Get channel
						ServerSocketChannel keyChannel = (ServerSocketChannel)key.channel();

						// Get server socket
						ServerSocket serverSocket = keyChannel.socket();

						// Accept request
						Socket socket = serverSocket.accept();
						socket.setReceiveBufferSize(soRcvBuffSize);
						//socket.getChannel();
						
						// Cache the client socket
						SocketChannel clientChannel 	= socket.getChannel();
						clientChannel.configureBlocking(false);
						buffers.put(clientChannel, ByteBuffer.allocate(soRcvBuffSize));
						
						clientChannel.register(selector, SelectionKey.OP_READ);
						
						threadMessage("'" + name + ":clientAccept'");
						
					} 

				}	//end while(readyItor.hasNext()) 

			} // Never ends
			
			// The finally will take care of this
			//// shut it down
			//shutdown();
			
		} catch ( ClosedSelectorException cse ) {
			//do nothing
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			threadMessage("'" + name + ":echoDeath'");
			shutdown();
			
		}
		
	}
	
	
	//====================================================
	// Methods
	//====================================================
	
	private void shutdown() {
		threadMessage("'" + name + ":echoStop' -> shutting down.");
		
		for( ServerSocketChannel channel : servers) {
			try {
				if( channel != null )
					channel.close();
			} catch (IOException e) {
				//do nothing
				//e.printStackTrace();
			}
		}
		
		try {
			selector.close();
		} catch (IOException e) {
			//do nothing
			//e.printStackTrace();
		}
	}
	
	public void close() {
		shutdown 	= true;
		selector.wakeup();
	}
	
	
	//=================================================
	// Testing
	//=================================================
	
	public static void main(String[] args) {
		
		EchoServer server = null;
		
		//start the data server
		threadMessage("'" + name + ":echoStarting'");
		try {
			server 	= new EchoServer();
			server.start();
			
		} catch (IOException e) {
			threadMessage("'" + name + ":echoNoStart' -> exit.");
			System.exit(-1);
		} finally {
			threadMessage("'" + name + ":echoStarted'");
		}

	}
	
	
	public static void threadMessage(String message) {
		String threadName 	= Thread.currentThread().getName();
		System.out.println("thread(" + threadName + "): " + message);
	}
	

}


