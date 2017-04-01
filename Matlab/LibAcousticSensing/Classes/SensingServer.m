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
        
        % Supported type for ACTION_SET
        SET_TYPE_BYTE_ARRAY = 1;
        SET_TYPE_STRING = 2;
        SET_TYPE_DOUBLE = 3;
        SET_TYPE_INT = 4;
        SET_TYPE_VALUE_STRING = 5;
        
        
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
            set(obj.jss,'OpDataCallback',@(h,e)obj.onDataCallback(h,e));
            %set(obj.jss,'OpDataCallback',@JavaServerOnDataCallback);
        end
        
        % start server waiting for the incoming connections
        function startServer(obj, audioSource, deviceAudioMode)
            %obj.audioSource = audioSource;
            %obj.deviceAudioMode = deviceAudioMode;
            
        end
        
        % start ask device to record or play audio
        function startSensing(obj)
            obj.traceParser = TraceParser(obj.audioSource, obj.traceChannelCnt);
            obj.jss.writeByte(int8(obj.REACTION_ASK_SENSING));
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
        function onAcceptCallback(obj, event)
            fprintf('    onAcceptCallback is called\n');
            % do nothing
        end
        
        
        function onDataCallback(obj, javahandle, event)
            fprintf('    onDataCallback is called\n');
            action = event.action;
            setType = event.setType;
            nameBytes = event.nameBytes;
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
                    % only parse the last audio data
                    fprintf('callback is called\n');
                    feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, squeeze(audioToProcess(:,end,:)));
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
            % ACTION_SENSING_END: just break the loop
            %**********************************************************
            elseif action == obj.ACTION_SENSING_END,
                fprintf(obj.dfid, '--- ACTION_SENSING_END: this round of sensing ends ---\n');
                set(0,'UserData','ACTION_SENSING_END');
            %**********************************************************
            % ACTION_CLOSE: read the end of sockets -> close loop
            %**********************************************************
            elseif action == obj.ACTION_CLOSE,
                fprintf(obj.dfid, '--- ACTION_CLOSE: socket is closed remotely ---\n');
                obj.jss.close();
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
%  Internal networking functions for sending packets
%==========================================================================
        
    end
    
end

