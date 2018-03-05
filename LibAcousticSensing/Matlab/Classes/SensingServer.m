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
        REACTION_SERVER_CLOSED  = 5;
        REACTION_DELAY_SOUND    = 6;
        
        % Supported type for ACTION_SET
        SET_TYPE_BYTE_ARRAY = 1;
        SET_TYPE_STRING = 2;
        SET_TYPE_DOUBLE = 3;
        SET_TYPE_INT = 4;
        SET_TYPE_VALUE_STRING = 5;
        
        % Types of user-defined callback messages 
        CALLBACK_TYPE_ERROR     = -1;
        CALLBACK_TYPE_INIT      = 0;
        CALLBACK_TYPE_DATA      = 1;
        CALLBACK_TYPE_USER      = 2;
        
        SOCKET_TIME_OUT         = 60*60*24;
        
        DEVICE_AUDIO_MODE_RECORD_ONLY       = 1;
        DEVICE_AUDIO_MODE_PLAY_ONLY         = 2;
        DEVICE_AUDIO_MODE_PLAY_AND_RECORD   = 3;
        
        % Save/Load configuration
        AUDIO_ALL_BUFFER_SIZE = 48000*60; % 60 seconds
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
        buttonLoad;
        buttonSave;
        buttonReplayOrStop;
        buttonAutotune;
        textServerInfo;
        textServerStatus;
        isUIBusy;
        
        userfig;
        axe;
        
        % internal server status
        latestReceivedAction;
        isConnected;
        isSensing;
        isPreambleDetectedCorrectly;
        slaveServers; % number of slave servers to activate when start sensing
        masterServer; % can only has one master server
        
        % audio variables
        audioSource;
        deviceAudioMode;
        traceParser;
        
        audioToProcessAll;
        audioToProcessAllEnd;
        
        % variable to be saved/loaded
        needToUpdateAudioAllForSave;
        audioAll;
        audioAllEnd;
        
        startSensingAfterConnectionInit; % set this variable to 0 if users want to manually trigger the senisng after the connection is established
        
        keepReading;
        
        % recevied trace variables
        userDevice;
        traceChannelCnt; 
        
        % latency analysis
        appCallbackLatencyResult; % format [marker1, marker2, maerk ..., delay1, delay2, ...etc], this is set from device
        
        needToAnalyzeAppCallbackLatency; % app callback is the callback assigned by app
        needToAnalyzeSocketCallbackLatency; % socket callback is called by the internal JavaSensingServer
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
            obj.isPreambleDetectedCorrectly = -2; % init status meaning wait for result
            obj.isUIBusy = 0;
            % build a UI sample
            obj.buildUI();
            
            % add some dummy data to init the userfig
            obj.userfig = -1; % init as a dummy figure handle
            feval(obj.callback, obj, obj.CALLBACK_TYPE_INIT, 1:2); 
            % NOTE: the userfig must be initialized in the user-defined
            
            obj.audioAll = [];
            obj.audioAllEnd = 0;
            obj.needToUpdateAudioAllForSave = 1;
            
            
            % create java sensing server
            obj.jss = edu.umich.cse.yctung.JavaSensingServer.create(port);
            obj.jss.SHOW_DEBUG_MESSAGE = false; % yctung: temporarly remove it since access java class variable might not be allowed in High Sierra
            set(obj.jss,'OpAcceptCallback',@(~,~)obj.onAcceptCallback);
            set(obj.jss,'OpDataCallback',@(h,e)obj.onDataCallback(h,e));
            %set(obj.jss,'OpDataCallback',@JavaServerOnDataCallback);
            
            obj.needToAnalyzeSocketCallbackLatency = 0;
            
            obj.setWaitFlag('NONE');
        end
        
        % add slave server to acitavet when this server start sense
        function addSlaveServer(obj, serverToAdd)
            if ~isempty(serverToAdd.masterServer),
                fprintf(2, '[ERROR]: unable to add a slave server whcih has master server allocated (add slave server twice?)\n');
            elseif ~isempty(obj.masterServer), 
                fprintf(2, '[ERROR]: unable to add a slave server to a server that is also slave (add the wrong server as master?)\n');
            else
                obj.slaveServers = [obj.slaveServers serverToAdd];
                serverToAdd.masterServer = obj;
                serverToAdd.updateUI(); % update UI to adapt to the slave mode
            end
        end
        
        % start ask device to record or play audio
        function startSensingSelf(obj) % only sense device connected to this server
            %DEBUG_CH_CNT = 2; % TODO: load from audio sensing setting
            obj.audioToProcessAll = zeros(length(obj.audioSource.signal), obj.audioSource.repeatCnt, obj.traceChannelCnt);
            obj.audioToProcessAllEnd = 0;
            obj.traceParser = TraceParser(obj.audioSource, obj.traceChannelCnt,obj);
            obj.isPreambleDetectedCorrectly = -2;
            obj.jss.writeByte(int8(obj.REACTION_ASK_SENSING));
            obj.isSensing = 1;
            obj.buttonStartOrStopSensing.String = 'Stop Sensing';
            obj.updateUI();
        end
        
        % start ask device and other slave server's device to sense
        function startSensing(obj)
            if ~isempty(obj.slaveServers) % check if all the slave server (if existed) is connected
                for i = 1:length(obj.slaveServers)
                    if obj.slaveServers(i).isConnected == 0 % one of the slave server is not connected
                        fprintf(2, '[ERROR]: start sensing fails since one of the slave server (at port = %d) is not connected\n', obj.slaveServers(i).port);
                        return;
                    end
                end
            end
                
            obj.startSensingSelf();
            % start all slave server if existed
            fprintf('Wait before playing the slave server\n');
            pause(0.100);
            for i = 1:length(obj.slaveServers)
                obj.slaveServers(i).startSensingSelf(); % TODO: add some delay before triggering the slave server
            end
        end
        
        function stopSensing(obj)
            obj.jss.writeByte(int8(obj.REACTION_STOP_SENSING));
            obj.isSensing = 0;
            obj.buttonStartOrStopSensing.String = 'Start Sensing';
            obj.updateUI();
            fprintf('audioAll is going to be updated by the new sensing data\n');
            obj.needToUpdateAudioAllForSave = 1;
            
            % Tell all slave servers to shut down too
            for i=1:length(obj.slaveServers)
                obj.slaveServers(i).stopSensing();
            end
            
            obj.setWaitFlag('ACTION_SENSING_END');
        end
        
        function ret = getResponse(obj)
            ret = obj.audioToProcessAll(:, 1:obj.audioToProcessAllEnd, :);
        end
        
        % stop server waiting
        function close(obj)
            obj.isConnected = 0;
            if ishandle(obj.fig), close(obj.fig); end % close the UI control in case the users will trigger the button when the server stops
            obj.jss.close();
            
            % Close all slaves too
            for i=1:length(obj.slaveServers)
                obj.slaveServers(i).isConnected = 0;
                if ishandle(obj.slaveServers(i).fig), close(obj.slaveServers(i).fig); end
                obj.slaveServers(i).jss.close();
                %clear(obj.slaveServers(i).object);
            end
            
            clear obj.object;
        end
        
        % update preambleDetectResult by parser
        function preambleDetectResult(obj, result)
            obj.isPreambleDetectedCorrectly = result;
            if result == 1, % preamble is detected correctly
                % do nothing now
            else % preamble is not detected
                fprintf(2, '[ERROR]: going to stop sensing because preamble is not detected\n');
                obj.stopSensing();
            end
        end
        
        % utility function to set 'UserData' for wait for master server
        function setWaitFlag(obj, flag)
            % only set flag when it is a master server
            %if isempty(obj.masterServer), % mean it is the master server
            %    set(0,'UserData', flag);
            %end
            set(obj.fig, 'UserData', flag);
        end
        
        function waitfor(obj, flag)
            waitfor(obj.fig, 'UserData', flag);
        end
        
        function enableSocketCallbackAnalysis(obj)
            obj.jss.needToAnalyzeLatency = true; % enable latency analysis in the java sensing server
            obj.needToAnalyzeSocketCallbackLatency = 1;
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
            %fprintf('    onDataCallback is called\n');
            action = event.action;
            obj.latestReceivedAction = action;
            
            time = event.time;
            %fprintf('    action = %d\n', action);
            
            %**********************************************************
            % ACTION_CONNECT: just connect the socket -> doing nothing
            %**********************************************************
            if action == obj.ACTION_CONNECT,
                fprintf(obj.dfid, '--- ACTION_CONNECT ---\n');
                obj.setWaitFlag('ACTION_CONNECT');
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
                obj.setWaitFlag('ACTION_INIT');
            %**********************************************************
            % ACTION_DATA: received audio data 
            %**********************************************************
            elseif action == obj.ACTION_DATA
                % a. parse the recieved payload as audio
                if obj.needToAnalyzeSocketCallbackLatency == 1 % need to analyze the latency of java socket callback
                    obj.jss.la.addResultStamp(obj.audioAllEnd * obj.traceChannelCnt * 2);
                end
                
                dataTemp = double(typecast(event.dataBytes,'int16'));
                if obj.traceChannelCnt == 1 % single-chanell ->ex: iphone
                    audioNow = dataTemp;
                else % stereo-recroding
                    audioNow = [dataTemp(1:2:end), dataTemp(2:2:end)];
                end
                
                % b. buff this audio for future replay if need
                if obj.needToUpdateAudioAllForSave
                    if isempty(obj.audioAll) || obj.audioAllEnd == 0 % need to init
                        obj.audioAll = zeros(obj.AUDIO_ALL_BUFFER_SIZE, obj.traceChannelCnt);
                        obj.audioAllEnd = 0;
                    end

                    obj.audioAll(obj.audioAllEnd+1:obj.audioAllEnd+size(audioNow,1), :) = audioNow;
                    obj.audioAllEnd = obj.audioAllEnd + size(audioNow,1);
                end
                
                %fprintf('    get a audio data with size = %d\n', size(audioNow,1));
                
                audioToProcess = obj.traceParser.parse(audioNow);
                
                
                if ~isempty(audioToProcess)
                    processCnt = size(audioToProcess,2); % number of trace to be processed
                    % size(audioToProcess)
                    % size(obj.audioToProcessAll(:,obj.audioToProcessAllEnd+1:obj.audioToProcessAllEnd+processCnt,:))
                    obj.audioToProcessAll(:,obj.audioToProcessAllEnd+1:obj.audioToProcessAllEnd+processCnt,:) = audioToProcess;
                    obj.audioToProcessAllEnd = obj.audioToProcessAllEnd+1;
                    
                    % only parse the last audio data
                    % fprintf('callback is called for parsing audio data\n');
                    
                    if nargout(obj.callback) == 0 % no output
                        feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, audioToProcess);
                    else
                        ret = feval(obj.callback, obj, obj.CALLBACK_TYPE_DATA, audioToProcess);
                        if ~isempty(ret)
                            fprintf(2, 'send result back to phone\n');
                            % we now use the audio stamp as a refernece
                            obj.sendResult(-1, -1);
                        end
                    end
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
                obj.isSensing = 0;
                obj.updateUI();
                
                obj.setWaitFlag('ACTION_SENSING_END');
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
            preambleShortRange = floor(obj.audioSource.preambleSource.preambleToAdd.*obj.audioSource.preambleGain.*SHORT_MAX_RANGE);
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
        
        function sendResult(obj, argInt, argFloat)
            obj.jss.writeByte(int8(obj.REACTION_SET_RESULT));
            obj.jss.writeInt(int32(obj.audioAllEnd)); % time stamp for the result
            obj.jss.writeInt(int32(argInt));
            CHECK = -1;
            obj.jss.writeByte(int8(CHECK));
        end
%==========================================================================
%  Internal UI functions
%==========================================================================

        function destroyFnc (obj, ~, ~)
            [h, figure] = gcbo;
            fprintf('    Destroying figure. Should tell client to disconnect\n');
            
            if (obj.isConnected)
                try
                    obj.jss.writeByte(int8(obj.REACTION_SERVER_CLOSED));
                catch err
                    fprintf('    Error destroying figure. Probably socket closed.\n');
                end
            end
            
            for i = 1:length(obj.slaveServers)
                delete(obj.slaveServers(i).fig);
            end
                
            closereq;
        end

        
        function buildUI(obj)
            TEXT_FONT_SIZE = 15;
            obj.fig = figure(...
                'Name','Server',...
                'NumberTitle','off',...
                'Position',[50,450,230,230],...
                'Toolbar','none',...
                'MenuBar','none',...
                'DeleteFcn', @obj.destroyFnc);
            obj.panel = uipanel(obj.fig,'Units','pixels','Position',[15,15,200,210]);
            
            IPaddress = GetAddress();

            obj.textServerInfo = uicontrol(obj.panel,'Style','text',...
                        'Position',[20,170,170,40],...
                        'FontSize',TEXT_FONT_SIZE,...
                        'String',sprintf('Server at %s:%d',IPaddress,obj.port));
                    
            obj.textServerStatus = uicontrol(obj.panel,'Style','text',...
                        'Position',[30,130,150,30],...
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
                        'Position',[30,90,140,30],...
                        'String','Start Sensing',...
                        'TooltipString','Sensing',...
                        'FontSize',TEXT_FONT_SIZE,...
                        'Interruptible','on',...
                        'Callback',@(~,~)obj.buttonStartOrStopSensingCallback);
                    
            obj.buttonLoad = uicontrol(obj.panel,'Style','pushbutton',...
                        'Position',[5,60,90,30],...
                        'String','Load',...
                        'TooltipString','Sensing',...
                        'FontSize',TEXT_FONT_SIZE,...
                        'Interruptible','on',...
                        'Callback',@(~,~)obj.buttonLoadCallback);
            obj.buttonSave = uicontrol(obj.panel,'Style','pushbutton',...
                        'Position',[5+100,60,90,30],...
                        'String','Save',...
                        'TooltipString','Sensing',...
                        'FontSize',TEXT_FONT_SIZE,...
                        'Interruptible','on',...
                        'Callback',@(~,~)obj.buttonSaveCallback);
                    
            obj.buttonReplayOrStop = uicontrol(obj.panel,'Style','pushbutton',...
                        'Position',[5,30,90,30],...
                        'String','Replay',...
                        'TooltipString','Sensing',...
                        'FontSize',TEXT_FONT_SIZE,...
                        'Interruptible','on',...
                        'Callback',@(~,~)obj.buttonReplayOrStopCallback);
                    
              
            obj.buttonAutotune = uicontrol(obj.panel,'Style','pushbutton',...
                'Position',[5+100,30,90,30],...
                'String','Autotune',...
                'TooltipString','Autoshift Sounds',...
                'FontSize',TEXT_FONT_SIZE,...
                'Interruptible','on',...
                'Callback',@(~,~)obj.buttonAutotuneCallback);



            obj.updateUI();
        end
        
        
        function dummyCloseReq (~, ~, ~, ~)
            
        end
        

        % update UI based on server status
        function updateUI(obj)
            % determine the sensing status string
            if obj.isConnected == 0,
                obj.buttonStartOrStopSensing.Enable = 'off';
                textConnectionStatus = 'wait connection';
            else
                obj.buttonStartOrStopSensing.Enable = 'on';
                textConnectionStatus = 'ready to sense';
                if obj.isSensing,
                    textConnectionStatus = 'sensing...';
                end
            end
            
            if obj.isSensing
                obj.buttonAutotune.Enable = 'on';
            else
                obj.buttonAutotune.Enable = 'off';
            end
            
            if ~isempty(obj.masterServer)
                obj.buttonStartOrStopSensing.Enable = 'off';
                % Only the master server can do autotuning
                obj.buttonAutotune.Enable = 'off';
                obj.buttonStartOrStopSensing.String = 'Slave Mode';
                
                % Disable closing the slave window
                % We can only close from the master window
                set(obj.fig, 'CloseRequestFcn', @obj.dummyCloseReq);
            end
            
            obj.textServerStatus.String=textConnectionStatus;
            
            obj.buttonLoad.Enable = 'on';
            obj.buttonSave.Enable = 'on';
            
            % diable all UI if it is busy
            if obj.isUIBusy
                obj.buttonStartOrStopSensing.Enable = 'off';
                obj.buttonAutotune.Enable = 'off';
                obj.buttonLoad.Enable = 'off';
                obj.buttonSave.Enable = 'off';
            end
            
        end
        
        % callback for the start or stop sensing button
        function buttonStartOrStopSensingCallback(obj)
            if obj.isSensing == 0, % need to start sensing 
                obj.startSensing();
            else % need to stop sensing
                obj.stopSensing(); % TODO: implement this part
            end
        end
        
        function buttonSaveCallback(obj)
            obj.isUIBusy = 1;
            obj.updateUI();
            
            [fileName,fileFolder] = uiputfile(sprintf('%s/Traces/*.mat', pwd()), 'Save to (*.mat)', sprintf('%s/Traces/trace_', pwd()));
            wantToSave = 1;
            if fileName == 0
                wantToSave = 0; % canceled
            end
            
            filePathToSave = strcat(fileFolder, fileName);
            if exist(filePathToSave, 'file')
                result = questdlg('Trace file existed (want to overwite it?)','File existed','Yes','No','Yes')
                if ~strcmp(result, 'Yes')
                    wantToSave = 0;
                end
            end
            
            if wantToSave
                audioAll = obj.audioAll(1:obj.audioAllEnd, :); % save space
                audioSource = obj.audioSource;
                save(filePathToSave, 'audioAll', 'audioSource');
            end
                
            obj.isUIBusy = 0;
            obj.updateUI();
        end
        
        function buttonLoadCallback(obj)
            obj.isUIBusy = 1;
            obj.updateUI();
            
            [fileName,fileFolder] = uigetfile('./Traces', 'Please select path to load')
            wantToLoad = 1;
            if fileName == 0
                wantToLoad = 0; % canceled
            end
            
            if wantToLoad
                filePathToLoad = strcat(fileFolder, fileName)
                load(filePathToLoad);
                obj.audioAll = audioAll;
                obj.audioAllEnd = size(audioAll,1);
                obj.traceChannelCnt = size(audioAll,2);
                obj.audioSource = audioSource;

                obj.needToUpdateAudioAllForSave = 0; % avoid the loaded being replaced by replaying the data
            end
            
            obj.isUIBusy = 0;
            obj.updateUI();
        end
        
        function buttonReplayOrStopCallback(obj)
            if isempty(obj.audioAll)
                fprintf(2, '[ERROR] nothing to be replayed\n');
                return;
            end
            
            % reset processing buffers
            obj.audioToProcessAll = zeros(length(obj.audioSource.signal), obj.audioSource.repeatCnt, obj.traceChannelCnt);
            obj.audioToProcessAllEnd = 0;
            
            % reset a new trace parser
            obj.traceParser = TraceParser(obj.audioSource, obj.traceChannelCnt,obj);
            
            % simulate the loaded data being replayed
            audioAllShort = int16(obj.audioAll);
            if obj.traceChannelCnt > 1
                audioAllTemp = audioAllShort;
                audioAllShort = zeros(size(obj.audioAll,1)*obj.traceChannelCnt,1);
                audioAllShort(1:2:end) = audioAllTemp(:,1);
                audioAllShort(2:2:end) = audioAllTemp(:,2); % separate the chaneel to simulate how the audio is recorded
                audioAllShort = int16(audioAllShort);
            end
            audioAllBytes = typecast(audioAllShort, 'int8');
            fakeEvent.action = obj.ACTION_DATA;
            fakeEvent.time = -1;
            fakeEvent.dataBytes = audioAllBytes;
            fakeJavaHanlder = -1;
            obj.onDataCallback(fakeJavaHanlder, fakeEvent);
        end
        
        
        
        function buttonAutotuneCallback (obj)
            %{
            Records audio from this device (assuming this is master server)
            If we hear both chirps (based on PS?), calculate the peak of
            both chirps. If the peaks are equally spread apart (based on
            PS.period) then we're done. Otherwise, we will send 
            REACTION_DELAY_SOUND to this device.
            %}
            
            
            % For now it simply delays by a fixed value.
            obj.jss.writeByte(int8(obj.REACTION_DELAY_SOUND));
            obj.jss.writeInt(int32(300));
            CHECK = -1;
            obj.jss.writeByte(int8(CHECK));
        end
    end
    
end

