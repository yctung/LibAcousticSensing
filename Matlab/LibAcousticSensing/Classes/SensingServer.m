classdef SensingServer < handle
    % 2017/01/27: class handles all the remote communication to mobile
    % device
    
    % init constants in matlab
    %ref: http://stackoverflow.com/questions/1773850/constants-in-matlab
    properties (Constant = true)
        % types of receving packets from devies
        ACTION_CLOSE            = -1;   % ACTION_CLOSE format: | ACTION_CLOSE |
        ACTION_CONNECT          = 1;    % ACTION_CONNECT format: | ACTION_CONNECT |  
        ACTION_DATA             = 2;    % ACTION_DATA format: | ACTION_SEND | data
        ACTION_SET              = 3;    % ACTION_SET format: | ACTION_SET | type(int) | name(string) | var(byte[])
        ACTION_INIT             = 4;    % ACTION_INIT format: | ACTION_INIT | 
        ACTION_SENSING_END      = 5;
        
        % Types of sending packets to deivce
        REACTION_SET_MEDIA      = 1;
        REACTION_ASK_SENSING    = 2;
        REACTION_SET_RESULT 	= 3;
        
        % Types of user-defined callback messages 
        CALLBACK_TYPE_ERROR     = -1;
        CALLBACK_TYPE_DATA      = 1;
        
        SOCKET_TIME_OUT         = 60*60*24;
        
        DEVICE_AUDIO_MODE_RECORD_ONLY       = 1;
        DEVICE_AUDIO_MODE_PLAY_ONLY         = 2;
        DEVICE_AUDIO_MODE_PLAY_AND_RECORD   = 3;
        
        
    end
    
    properties
        dfid=2; % debug fid
        % socket variables
        port;
        callback;
        socket;
        
        % audio variables
        audioSource;
        deviceAudioMode;
        traceParser;
        
        startSensingAfterConnectionInit; % set this variable to 0 if users want to manually trigger the senisng after the connection is established
        
        keepReading;
        
        % recevied trace variables
        userDevice;
        traceChannelCnt; 
    end
    
    methods
        % constructor 
        function obj = SensingServer(port, callback)
            obj.port=port;
            obj.callback=callback;
            
            feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, [1:10]); % add some dummy data to init the callback figures
        end
        
        % start server waiting for the incoming connections
        function startServer(obj, audioSource, deviceAudioMode)
            obj.audioSource=audioSource;
            obj.deviceAudioMode=deviceAudioMode;
            obj.startSensingAfterConnectionInit=1; % the server start asking device to sense after the connection initialized as default
            
            obj.socket=tcpip('0.0.0.0', obj.port, 'NetworkRole', 'server', 'Timeout', obj.SOCKET_TIME_OUT);
            obj.socket.ReadAsyncMode='continuous';
            obj.socket.BytesAvailableFcnMode='byte';
            obj.socket.BytesAvailableFcnCount=1; % trigger the event every byte available
            obj.socket.BytesAvailableFcn=@(~,~)obj.socketReadCallback; % correct format of passing callback, ref: https://www.mathworks.com/matlabcentral/answers/176729-matlab-arduino-communication-using-bytesavailablefcn-too-many-input-arguments
            obj.socket.InputBufferSize = 4800;
            
            obj.keepReading = 0;
            
            % wait on connections from remote devices
            fprintf(obj.dfid, '=== start wait connection to port = %d ===\n', obj.port);
            fopen(obj.socket);
            fprintf(obj.dfid, '=== succeesfully get a connection to port = %d ===\n', obj.port);
            
            % intentionally wait one second to avoid first few packets lost
            % (matlab bug, ref: http://stackoverflow.com/questions/31435942/matlab-tcp-ip-socket-only-sometimes-works)
            pause(1);
        end
        
        % start ask device to record or play audio
        function startSensing(obj)
            obj.traceParser = TraceParser(obj.audioSource, obj.traceChannelCnt);
            fwrite(obj.socket, int8(obj.REACTION_ASK_SENSING), 'int8');
            % TODO: send the whole audio record setting to device
        end
        
        % stop server waiting
        function stopServer(obj)
            fclose(obj.socket);
            delete(obj.socket);
            clear obj.object;
        end
        
%==========================================================================
%  Internal networking functions for parsing recevied packets
%==========================================================================
        % socket read callback
        function socketReadCallback(obj)
            fprintf('    get a read callback, byte available = %d\n',obj.socket.BytesAvailable);
            
            obj.socket.BytesAvailableFcn=''; % *** just for debug ***
            %while obj.socket.BytesAvailable>0,
            obj.keepReading = 1;
            while obj.keepReading,
                action=fread(obj.socket, 1, 'int8');
                %**********************************************************
                % ACTION_CONNECT: just connect the socket -> doing nothing
                %**********************************************************
                if action == obj.ACTION_CONNECT,
                    fprintf(obj.dfid, '--- ACTION_CONNECT ---\n');
                %**********************************************************
                % ACTION_INIT: initialize necessary commponent
                %  ***NOTE***: This action is triggered only when necessary
                %            : variables are setted by ACTION_SET
                %**********************************************************
                elseif action == obj.ACTION_INIT, % one time initialization
                    fprintf(obj.dfid, '--- ACTION_INIT: %s ---\n', obj.userDevice);
                    
                    % send audio to device
                    ServerWriteAudioData(obj.socket, obj.audioSource);
                    if obj.startSensingAfterConnectionInit,
                        obj.startSensing();
                    end
                %**********************************************************
                % ACTION_DATA: received audio data 
                %**********************************************************
                elseif action == obj.ACTION_DATA,
                    tic;
                    fprintf(obj.dfid, '.');
                    toc;
                    dataBytes = ServerReadFullData(obj.socket);
                    toc;
                    % a. parse the recieved payload as audio
                    dataTemp = double(typecast(dataBytes,'int16'));
                    if obj.traceChannelCnt == 1, % single-chanell ->ex: iphone
                        audioNow = dataTemp;
                    else % stereo-recroding
                        audioNow = [dataTemp(1:2:end), dataTemp(2:2:end)];
                    end
                    toc;
                    audioToProcess = obj.traceParser.parse(audioNow);
                    if ~isempty(audioToProcess),
                        % only parse the last audio data
                        fprintf('callback is called\n');
                        tic;
                        feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, squeeze(audioToProcess(:,end,:)));
                        toc;
                    end
                    %fprintf(obj.dfid, '--- ACTION_DATA: end ---\n');
                %**********************************************************
                % ACTION_SET: set matlab variable based on code
                %**********************************************************
                elseif action == obj.ACTION_SET,
                    [name, value, evalString] = ServerReadSetAction(obj.socket);
                    fprintf(obj.dfid, '--- ACTION_SET: %s ---\n', name);

                    if ~isprop(obj,name),
                        fprintf(2,'[ERROR]: obj has no property named %s, (typo or forget to set this property in the class?)\n', name);
                        break;
                    end
                    
                    if strcmp(evalString,''),
                        fprintf(obj.dfid, '   :get a byte array (%s) not able to be eval -> use assignin instead\n', name);
                        assignin('base', strcat('obj.',name), value);
                    else
                        eval(strcat('obj.',evalString));
                    end
                %**********************************************************
                % ACTION_SENSING_END: just break the loop
                %**********************************************************
                elseif action == obj.ACTION_SENSING_END,
                    fprintf(obj.dfid, '--- ACTION_SENSING_END: this round of sensing ends ---\n');
                    break;
                %**********************************************************
                % ACTION_CLOSE: read the end of sockets -> close loop
                %**********************************************************
                elseif action == obj.ACTION_CLOSE,
                    fprintf(obj.dfid, '--- ACTION_CLOSE: socket is closed remotely ---\n');
                    break;
                else
                    fprintf(2, '[ERROR]: undefined action=%d\n',action);
                    break;
                end
                
                
                pause(0.001); % real-time mode
            end
            
            
            % remember to set callback function back is we remove it before
            obj.socket.BytesAvailableFcn=@(~,~)obj.socketReadCallback;
        end
        
%==========================================================================
%  Internal networking functions for sending packets
%==========================================================================
        
    end
    
end

