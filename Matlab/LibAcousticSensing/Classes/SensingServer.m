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
        ACTION_USER             = 6;
        
        % Types of sending packets to deivce
        REACTION_SET_MEDIA      = 1;
        REACTION_ASK_SENSING    = 2;
        REACTION_SET_RESULT 	= 3;
        REACTION_STOP_SENSING   = 4;
        
        % Supported type for ACTION_SET
        SET_TYPE_BYTE_ARRAY = 1;
        SET_TYPE_STRING = 2;
        SET_TYPE_DOUBLE = 3;
        SET_TYPE_INT = 4;
        SET_TYPE_VALUE_STRING = 5;
        
        % Types of user-defined callback messages 
        CALLBACK_TYPE_ERROR     = -1;
        CALLBACK_TYPE_DATA      = 1;
        CALLBACK_TYPE_USER      = 2;
        
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
        buttonStartOrStopSensing;
        textServerInfo;
        textServerStatus;
        
        userfig;
        axe;
        
        % internal server status
        latestReceivedAction;
        isConnected;
        isSensing;
        slaveServers; % number of slave servers to activate when start sensing
        masterServer; % can only has one master server
        
        % audio variables
        audioSource;
        deviceAudioMode;
        traceParser;
        
        audioToProcessAll;
        audioToProcessAllEnd;
        
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
            
            obj.isConnected = 0;
            obj.isSensing = 0;
            obj.latestReceivedAction = obj.ACTION_CLOSE;
            
            % build a UI sample
            obj.buildUI();
            
            % add some dummy data to init the userfig
            obj.userfig = -1; % init as a dummy figure handle
            feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, 1:2); 
            % NOTE: the userfig must be initialized in the user-defined
            
            % create java sensing server
            obj.jss = edu.umich.cse.yctung.JavaSensingServer.create(port);
            set(obj.jss,'OpAcceptCallback',@(~,~)obj.onAcceptCallback);
            set(obj.jss,'OpDataCallback',@(h,e)obj.onDataCallback(h,e));
            %set(obj.jss,'OpDataCallback',@JavaServerOnDataCallback);
        end
        
        % add slave server to acitavet when this server start sense
        function addSlaveServer(obj, serverToAdd)
            if ~isempty(serverToAdd.masterServer),
                fprintf(2, '[ERROR]: unable to add a slave server whcih has master server allocated (add slave server twice?)\n');
            elseif ~isempty(obj.masterServer), 
                fprintf(2, '[ERROR]: unable to add a slave server to a server that is also slave (add the wrong server as master?)\n');
            else
                obj.slaveServers = serverToAdd;
                serverToAdd.masterServer = obj;
                serverToAdd.updateUI(); % update UI to adapt to the slave mode
            end
        end
        
        % start ask device to record or play audio
        function startSensing(obj)
            %DEBUG_CH_CNT = 2; % TODO: load from audio sensing setting
            obj.audioToProcessAll = zeros(length(obj.audioSource.signal), obj.audioSource.repeatCnt, obj.traceChannelCnt);
            obj.audioToProcessAllEnd = 0;
            obj.traceParser = TraceParser(obj.audioSource, obj.traceChannelCnt);
            obj.jss.writeByte(int8(obj.REACTION_ASK_SENSING));
            obj.isSensing = 1;
            obj.buttonStartOrStopSensing.String = 'Stop Sensing';
            obj.updateUI();
        end
        
        function stopSensing(obj)
            obj.jss.writeByte(int8(obj.REACTION_STOP_SENSING));
            obj.isSensing = 0;
            obj.buttonStartOrStopSensing.String = 'Start Sensing';
            obj.updateUI();
        end
        
        % stop server waiting
        function close(obj)
            obj.isConnected = 0;
            close(obj.fig); % close the UI control in case the users will trigger the button when the server stops
            obj.jss.close();
            clear obj.object;
        end
        
%==========================================================================
%  Internal UI/networking functions for parsing recevied packets
%  NOTE: callbacks are triggered from a seperate java thread 
%  evendata format is defined in JavaSensingServer.java
%==========================================================================
        function onAcceptCallback(obj, event)
            fprintf('    onAcceptCallback is called\n');
            % do nothing
            obj.isConnected = 1;
            obj.updateUI();
        end
        
        function onDataCallback(obj, javahandle, event)
            fprintf('    onDataCallback is called\n');
            action = event.action;
            obj.latestReceivedAction = action;
            
            time = event.time;
            fprintf('    action = %d\n', action);
            
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
                obj.sendMediaData();
                
                if obj.startSensingAfterConnectionInit == 1,
                    obj.startSensing();
                end
                set(0,'UserData','ACTION_INIT'); % for trigger the 

            %**********************************************************
            % ACTION_DATA: received audio data 
            %**********************************************************
            elseif action == obj.ACTION_DATA,
                % a. parse the recieved payload as audio
                dataTemp = double(typecast(event.dataBytes,'int16'));
                if obj.traceChannelCnt == 1, % single-chanell ->ex: iphone
                    audioNow = dataTemp;
                else % stereo-recroding
                    audioNow = [dataTemp(1:2:end), dataTemp(2:2:end)];
                end
                
                audioToProcess = obj.traceParser.parse(audioNow);
                
                
                if ~isempty(audioToProcess),
                    processCnt = size(audioToProcess,2); % number of trace to be processed
                    size(audioToProcess)
                    size(obj.audioToProcessAll(:,obj.audioToProcessAllEnd+1:obj.audioToProcessAllEnd+processCnt,:))
                    obj.audioToProcessAll(:,obj.audioToProcessAllEnd+1:obj.audioToProcessAllEnd+processCnt,:) = audioToProcess;
                    obj.audioToProcessAllEnd = obj.audioToProcessAllEnd+1;
                    
                    % only parse the last audio data
                    fprintf('callback is called for parsing audio data\n');
                    feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, audioToProcess);
                end
            %**********************************************************
            % ACTION_SET: set matlab variable based on code
            %**********************************************************
            elseif action == obj.ACTION_SET,
                [name, value, evalString] = parseSetActionData(obj, event);
                fprintf(obj.dfid, '--- ACTION_SET: %s ---\n', name);

                if ~isprop(obj,name),
                    fprintf(2,'[ERROR]: obj has no property named %s, (typo or forget to set this property in the class?)\n', name);
                end

                if strcmp(evalString,''),
                    fprintf(obj.dfid, '   :get a byte array (%s) not able to be eval -> use assignin instead\n', name);
                    assignin('base', strcat('obj.',name), value);
                else
                    eval(strcat('obj.',evalString));
                end
            %**********************************************************
            % ACTION_USER: application's user-defined data
            %**********************************************************
            elseif action == obj.ACTION_USER,
                fprintf(obj.dfid, '--- ACTION_USER ---\n');
                data = struct();
                data.stamp = event.stamp;
                data.name = native2unicode(event.nameBytes);
                data.name = data.name(:)'; % ensure name is the row-based string
                data.code = event.code;
                data.arg0 = event.arg0;
                data.arg1 = event.arg1;
            
                fprintf('callback is called for parsing user data\n');
                feval(obj.callback, obj, obj.CALLBACK_TYPE_USER, data);
            
            %**********************************************************
            % ACTION_SENSING_END: just break the loop
            %**********************************************************
            elseif action == obj.ACTION_SENSING_END,
                fprintf(obj.dfid, '--- ACTION_SENSING_END: this round of sensing ends ---\n');
                set(0,'UserData','ACTION_SENSING_END');
                obj.isSensing = 0;
                obj.updateUI();
            %**********************************************************
            % ACTION_CLOSE: read the end of sockets -> close loop
            %**********************************************************
            elseif action == obj.ACTION_CLOSE,
                fprintf(obj.dfid, '--- ACTION_CLOSE: socket is closed remotely ---\n');
                obj.close();
            else
                fprintf(2, '[ERROR]: undefined action=%d\n',action);
            end
        end

        
        function callbackStartSensingInterruptible(obj, eventdata)
            fprintf('    callbackStartSensingInterruptible is called\n');
        end
        
        
        function [ name, value, evalString ] = parseSetActionData(obj, event)
            valueBytes = event.dataBytes; % reuse the same field to store the bytes of value
            name = native2unicode(event.nameBytes);
            name = name(:)'; % ensure name is the row-based string
    
            switch event.setType,
                case obj.SET_TYPE_STRING,
                    value = native2unicode(valueBytes);
                    evalString = sprintf('%s = ''%s'';', name, value);
                case obj.SET_TYPE_INT, %int 32
                    value = valueBytes(end:-1:1);
                    value = typecast(value, 'INT32');
                    evalString = sprintf('%s = %d;', name, value);
                case obj.SET_TYPE_VALUE_STRING,
                    value = str2double(native2unicode(valueBytes));
                    evalString = sprintf('%s = %s;', name, native2unicode(valueBytes));
                case obj.SET_TYPE_BYTE_ARRAY,
                    value = valueBytes;
                    evalString = '';
                otherwise
                    fprintf(2, '[ERROR]: undefined setType = %s', setType);
            end
        end
        
        function sendMediaData(obj) 
            if any(abs(obj.audioSource.signal*obj.audioSource.signalGain)>1.0)
                fprintf(2, '[WARN]: signal amplitude is cropped to ensure it is in the right range (need to tune audio gain in AudioNoiseMake.m?)\n');
            end
    
            SHORT_MAX_RANGE = 2^15-1;
            
            % a. write reaction identifier
            obj.jss.writeByte(int8(obj.REACTION_SET_MEDIA));

            % b. write sample rate and other information
            obj.jss.writeInt(int32(obj.audioSource.FS));
            obj.jss.writeInt(int32(obj.audioSource.chCnt));
            obj.jss.writeInt(int32(obj.audioSource.repeatCnt));
    
            % c. write preamble
            preambleShortRange = floor(obj.audioSource.preambleSource.preambleToAdd*obj.audioSource.preambleGain*SHORT_MAX_RANGE);
            obj.jss.writeInt(int32(length(preambleShortRange)));
            preambleShort = int16(preambleShortRange);
            % *** just for debug ***
            preambleShort(1:3) = [5566, 1234, -1234];
            
            preabmleBytes = typecast(preambleShort, 'int8');
            temp = obj.jss.write(preabmleBytes)
    
    
            % d. write signal
            signalShortRange = floor(obj.audioSource.signal*obj.audioSource.signalGain*SHORT_MAX_RANGE);
            obj.jss.writeInt(int32(length(signalShortRange)));
            signalShort = int16(signalShortRange);
            signalBytes = typecast(signalShort, 'int8');
            temp = obj.jss.write(signalBytes)
    
    
            % e. write check
            CHECK = -1;
            obj.jss.writeByte(int8(CHECK));
        end
%==========================================================================
%  Internal UI functions
%==========================================================================
        function buildUI(obj)
            TEXT_FONT_SIZE = 15;
            obj.fig = figure('Position',[50,420,230,230],'Toolbar','none','MenuBar','none');
            obj.panel = uipanel(obj.fig,'Units','pixels','Position',[15,15,200,210]);
            
            % ref: https://www.mathworks.com/matlabcentral/newsreader/view_thread/292100
            address = java.net.InetAddress.getLocalHost ;
            IPaddress = char(address.getHostAddress);

            obj.textServerInfo = uicontrol(obj.panel,'Style','text',...
                        'Position',[20,160,170,40],...
                        'FontSize',TEXT_FONT_SIZE,...
                        'String',sprintf('Server at %s:%d',IPaddress,obj.port));
                    
            obj.textServerStatus = uicontrol(obj.panel,'Style','text',...
                        'Position',[30,110,120,30],...
                        'FontSize',TEXT_FONT_SIZE,...
                        'String','Server Status');
            
            %{
            obj.buttonStartServer = uicontrol(obj.panel,'Style','pushbutton',...
                        'Position',[30,110,120,30],...
                        'String','Start Server',...
                        'TooltipString','Started',...
                        'Interruptible','on',...
                        'Callback',@(~,~)obj.callbackStartServerInterruptible);
            %}
            
            obj.buttonStartOrStopSensing = uicontrol(obj.panel,'Style','pushbutton',...
                        'Position',[30,40,120,30],...
                        'String','Start Sensing',...
                        'TooltipString','Sensing',...
                        'Interruptible','on',...
                        'Callback',@(~,~)obj.buttonStartOrStopSensingCallback);
                    
            obj.updateUI();
        end
        
        % update UI based on server status
        function updateUI(obj)
            % determine the sensing status string
            if ~isempty(obj.masterServer),
                obj.buttonStartOrStopSensing.Enable = 'off';
                obj.buttonStartOrStopSensing.String = 'Slave Mode';
            elseif obj.isConnected == 0,
                obj.buttonStartOrStopSensing.Enable = 'off';
                textConnectionStatus = 'wait connection';
            else
                obj.buttonStartOrStopSensing.Enable = 'on';
                textConnectionStatus = 'ready to sense';
                if obj.isSensing,
                    textConnectionStatus = 'sensing...';
                end
            end
            obj.textServerStatus.String=textConnectionStatus;
        end
        
        function buttonStartOrStopSensingCallback(obj)
            if obj.isSensing == 0, % need to start sensing 
                obj.startSensing();
            else % need to stop sensing
                obj.stopSensing(); % TODO: implement this part
            end
        end
    end
    
end

