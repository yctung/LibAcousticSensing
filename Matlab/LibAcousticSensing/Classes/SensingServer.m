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
        
        callback; % user-defined callback
        
        % socket variables (NOTE: all socket operations is delgated to the JavaSensingServer)
        port;
        jss; % instance of Java socket server
        
        % UI variables
        fig; % figure handler -> there must be a handle because I am reusing the intteruable feature of Matlab UI to build async socket read
        panel;
        buttonStartServer;
        buttonStartSensing;
        userfig;
        axe;
        
        latestReceivedAction;
        
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
        function obj = SensingServer(port, callback, deviceAudioMode, audioSource)
            obj.audioSource = audioSource;
            obj.deviceAudioMode = deviceAudioMode;
            obj.port=port;
            
            obj.callback=callback;
            obj.startSensingAfterConnectionInit=1; % the server start asking device to sense after the connection initialized as default
            
            obj.latestReceivedAction = -1;
            
            % build a UI sample
            obj.fig = figure('Position',[50,420,230,230],'Toolbar','none','MenuBar','none');
            obj.panel = uipanel(obj.fig,'Units','pixels','Position',[15,15,200,210]);
            
            obj.buttonStartServer = uicontrol(obj.panel,'Style','pushbutton',...
                        'Position',[30,110,120,30],...
                        'String','Start Server',...
                        'TooltipString','Started',...
                        'Interruptible','on',...
                        'Callback',@(~,~)obj.callbackStartServerInterruptible);
            
            obj.buttonStartSensing = uicontrol(obj.panel,'Style','pushbutton',...
                        'Position',[30,40,120,30],...
                        'String','Start Sensing',...
                        'TooltipString','Sensing',...
                        'Interruptible','on');%,...
                        %'Callback',@obj.callbackStartSensingInterruptible);
            
            % add some dummy data to init the userfig
            obj.userfig = -1; % init as a dummy figure handle
            feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, 1:2); 
            % NOTE: the userfig must be initialized in the user-defined
            
            
            % create java sensing server
            obj.jss = edu.umich.cse.yctung.JavaSensingServer.create(port);
            set(obj.jss,'OpAcceptCallback',@(~,~)obj.onAcceptCallback);
            set(obj.jss,'OpDataCallback',@(~,~)obj.onDataCallback);
        end
        
        % start server waiting for the incoming connections
        function startServer(obj, audioSource, deviceAudioMode)
            %obj.audioSource = audioSource;
            %obj.deviceAudioMode = deviceAudioMode;
            
        end
        
        % start ask device to record or play audio
        function startSensing(obj)
            obj.traceParser = TraceParser(obj.audioSource, obj.traceChannelCnt);
            % TODO: write action to sense
            %fwrite(obj.socket, int8(obj.REACTION_ASK_SENSING), 'int8');
            
            % TODO: send the whole audio record setting to device
        end
        
        % stop server waiting
        function close(obj)
            %fclose(obj.socket);
            %delete(obj.socket);
            obj.jss.close();
            clear obj.object;
        end
        
%==========================================================================
%  Internal UI/networking functions for parsing recevied packets
%  NOTE: callbacks are triggered from a seperate java thread 
%  evendata format is defined in JavaSensingServer.java
%==========================================================================
        function onAcceptCallback(obj, eventdata)
            fprintf('    onAcceptCallback is called\n');
            
        end
        
        
        function onDataCallback(obj, eventdata)
            fprintf('    onDataCallback is called\n');
            
        end

        
        function callbackStartSensingInterruptible(obj, eventdata)
            fprintf('    callbackStartSensingInterruptible is called\n');
            
        end
        
        % socket read callback
        function socketReadCallback(obj)
            fprintf('    start a interruptable callback on receive socket data\n');
            
            while obj.keepReading,
                %action = pnet(obj.con,'read',1, 'int8')
                obj.latestReceivedAction = action;
                %{
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
                    if obj.startSensingAfterConnectionInit == 1,
                        obj.startSensing();
                    end
                    set(0,'UserData','ACTION_INIT');
                    fprintf(obj.dfid, '  - UserData = %s\n', get(0,'UserData'));
                    
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
                    set(0,'UserData','ACTION_SENSING_END');
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
                %}
            end
        end
%==========================================================================
%  Internal networking functions for sending packets
%==========================================================================
        
    end
    
end

