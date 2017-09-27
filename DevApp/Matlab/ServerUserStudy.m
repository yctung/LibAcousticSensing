%==========================================================================
% 2016/10/24: This is the server contact Android phone for controlling the
%             application installed in it (e.g., play or record audio)
% ref: https://www.mathworks.com/help/instrument/communicate-using-tcpip-server-sockets.html;jsessionid=811b31a6a891d64a4ffc80d75e15
% 2016/11/20: Update this server for user study specific
% 2016/12/04: Update the way to turn it into final function
%==========================================================================
REQUEST_TYPE_RECORD = 0;
REQUEST_TYPE_PLAY = 1;
REQUEST_TYPE_QA = 2; % NOTE: this should meet the android app

if ~exist('IS_FINAL','var'),
    IS_FINAL = 0; % default is 0!!
end

TRACE_PATH_MIN_SUFFIX = 0;
TRACE_PATH_MAX_SUFFIX = 100000;

SERVER_MAX_LOOP = 100000;
dfid = 2; % debug fid

if ~exist('requests','var'),
    fprintf(dfid, '[WARN]: no predefined requests (forget to execute the request generator?), use defualt request setting now\n');
    MakeRequestUserStudyFinal;
    %MakeRequestSelfDiffVol;
end

RESTART_SERVER_WHEN_CRASH_OR_END = 0;
if IS_FINAL == 1,
    RESTART_SERVER_WHEN_CRASH_OR_END = 1;
end

requestIdx = 0; % init to 0 because it is increased by 1 in the begin of request start
request = requests(1);
requestCnt = length(requests);

% show request
T = struct2table(requests)

%--------------------------------------------------------------------------
% 1: very sticky server -> never die, 0: server die after one round
%--------------------------------------------------------------------------


% actions for server to parse incoming data
ACTION_CONNECT          = 1;    % ACTION_CONNECT format: | ACTION_CONNECT |  
ACTION_DATA             = 2;    % ACTION_DATA format: | ACTION_SEND | data
ACTION_CLOSE            = -1;   % ACTION_CLOSE format: | ACTION_CLOSE |
ACTION_SET              = 3;    % ACTION_SET format: | ACTION_SET | type(int) | name(string) | var(byte[])
ACTION_INIT             = 4;    % ACTION_INIT format: | ACTION_INIT | 
ACTION_USER_STUDY_REQUEST_START    = 5;    
ACTION_USER_STUDY_REQUEST_END      = 6;  
ACTION_USER_STUDY_SAVE_RESULT      = 7;
ACTION_USER_STUDY_PLAY_START       = 8; % this indicates the user click the play button



%==========================================================================
% 1. open socket server at the assigned port
%==========================================================================
userMail = 'Unknown';
userDevice = 'Unknown';

% show network interface
[ipStatus,ipResult]=system('ifconfig en0 inet')
%try
    if ~exist('serverPort','var')
        serverPort = 50070;
        fprintf(dfid, '[WARN]: no serverPort existed, use the default one = %d\n', serverPort);
    end
    
    
    t = tcpip('0.0.0.0', serverPort, 'NetworkRole', 'server', 'Timeout', 60*60*24);
    if exist('playOtherBootstrapFolders', 'var'),
        UpdateServerStatus(serverPort*10,strrep(playOtherBootstrapFolders{1},'/','_'));
    end
    UpdateServerStatus(serverPort, 'wait');
    fprintf(dfid, '=== start wait connection to port = %d ===\n', serverPort);
    fopen(t);
    fprintf(dfid, '=== succeesfully get a connection to port = %d ===\n', serverPort);
    UpdateServerStatus(serverPort, 'busy');

    for i = 1:SERVER_MAX_LOOP,
        action = fread(t, 1, 'int8');

        %******************************************************************
        % ACTION_CONNECT: just connect the socket -> doing nothing
        %******************************************************************
        if action == ACTION_CONNECT,
            fprintf('Socket is connected and system setting is read from app\n');
            % WARN: this case is not being called -> must has some bug ->
            % don't use it now

        %******************************************************************
        % ACTION_INIT: initialize necessary commponent
        %  ***NOTE***: This action is triggered only when necessary
        %            : variables are setted by ACTION_SET
        %******************************************************************
        elseif action == ACTION_INIT, % one time initialization
            fprintf(dfid, '--- ACTION_INIT: %s / %s ---\n',userMail, userDevice);
            % assume here we should get the user mail and device
            traceBasePathPrefix = sprintf('%s%s/%s/%s_',requestInfo.basePath,userMail,userDevice, requestInfo.baesPrefix);
            traceBasePath = FindValidPath(traceBasePathPrefix, TRACE_PATH_MIN_SUFFIX, TRACE_PATH_MAX_SUFFIX, '/');
            
            userStudyIsFinished = 0;
            userPlayAnswer = '';
            clear qas;
            
            
            
            % load old calib setting if exist
            [calibVol, calibChIdx] = LoadBestCalibFromPaths(FindAllCalibFilePaths(requestInfo.calibSearchPaths, userDevice, '*'));
            fprintf(dfid,'   :calibVol=%f, calibIdx=%d\n',calibVol, calibChIdx);
            
            % init audio buf to receive
            audioDataHasBeenUpdated = 0;
            AUDIO_BUFF_MAX_SIZE = 500000; % maximize size of audio buffering (will be flush when data is processed)
            audioBuf = zeros(AUDIO_BUFF_MAX_SIZE, traceChannelCnt);
            audioBufEnd = 0;
            motion = [];

        %******************************************************************
        % ACTION_REQUEST_START: Asking providing next request to them
        %******************************************************************
        elseif action == ACTION_USER_STUDY_REQUEST_START,
            % update trace in the begin to keep requestIdx consistently
            requestIdx = requestIdx+1;
            userPlayAnswer = '';
            
            if requestIdx > requestCnt,
                % do somehting to terminate the survey
                % end of survey!!!
                fprintf(dfid, '--- ACTION_USER_STUDY_REQUEST_START: reach the end of survey!, no more task! ---\n');
                userStudyIsFinished = 1; % // TOOD: add some other logic to svae note the survey is completed! -> ex: change the folder name
                
                REACTION_USER_STUDY_END = 4;
                CHECK = -1;
                fwrite(t, int8(REACTION_USER_STUDY_END), 'int8');
                fwrite(t, int8(CHECK), 'int8');
                
                %break;  %optional -> app is going to stop it anyway
            else
                request = requests(requestIdx);
                fprintf(dfid, '--- ACTION_USER_STUDY_REQUEST_START: requestIdx = %d ---\n',requestIdx);
                
                if request.serverEnableAudioPlay == 1,
                    % load audio played by server
                    [serverPlayAudio, serverPlayAudioFS] = audioread(request.serverAudioSourcePath);
                    serverPlayAudio = [zeros(request.serverAudioDelay, size(serverPlayAudio, 2)); serverPlayAudio.*request.serverAudioVol];
                end
                
                % update calib vol if needed and if calib available
                if request.useCalib == 1,
                    request.vol = calibVol;
                end
                
                % send audio file if need
                if request.needToUpdateAudio == 1,
                    if request.type == REQUEST_TYPE_PLAY, % need to load audio in a special way
                        audioPlayParsingResult = RemoveAudioNoise(request.audioPath);
                        audio = getfield(audioPlayParsingResult, request.audioPlaySetting);
                        
                        if request.useCalib == 1, % use calib setting
                            % NOTE: should load the played device's calibChIdx, not the userDevice!!!
                            % DONT overwirte the calibVol because it is only used for this testing user device!!!
                            [parentPath,~,~] = fileparts(request.audioPath);
                            [traceParentPath,~,~] = fileparts(parentPath);
                            [~, playedAudioDevice, ~] = fileparts(traceParentPath);
                            [~, calibChIdx] = LoadBestCalibFromPaths(FindAllCalibFilePaths(requestInfo.calibSearchPaths, playedAudioDevice, '*'));
                            fprintf(dfid, '   :playedAudioDevice = %s, calibChIdx = %d\n', playedAudioDevice, calibChIdx);
                            audio = audio(:, calibChIdx); % only use the first channel
                        else
                            audio = audio(:, 1); % only use the first channel
                        end
                        audio = RecoveredAudioFinalizer(audio);
                    else
                        load(request.audioPath);
                    end
                    
                    ServerWriteAudioData(t, audio, FS);
                        fprintf(dfid, '   :audio is sent: %s\n', request.audioPath);
                end
                
                % send the assigned request
                ServerWriteRequest(t, request);
                
                
                % send media source file
                %{
                load(request.audioPath);
                ServerWriteAudioData(t, audio, FS);
                fprintf(' - audio is sent succesffully');
                %}
                
                
            end
        %******************************************************************
        % ACTION_REQUEST_END: Asking providing next request to them
        %******************************************************************
        elseif action == ACTION_USER_STUDY_REQUEST_END,
            fprintf(dfid, '--- ACTION_USER_STUDY_REQUEST_END: requestIdx = %d ---\n',requestIdx);
            % TODO: precess the audio in the real time and 
            REACTION_SET_RESULT = 3;
            fwrite(t, int8(REACTION_SET_RESULT), 'int8');
            
            if request.type == REQUEST_TYPE_RECORD && ~audioDataHasBeenUpdated,
                fprintf(dfid, '[ERROR]: no audio data is received, no way to save (forget to enable the sending audio function in Android)');
            else
                % save recorded result to a temp folder
                latestSavedTracePath = sprintf('%sq%02d_temp.mat', traceBasePath, requestIdx);
                audioBuf = audioBuf(1:audioBufEnd,:); % TODO: need to also save the server parse result!!
                
                if request.type == REQUEST_TYPE_QA && exist('qas','var')
                    userQAAnswers = qas;
                else
                    userQAAnswers = [];
                end
                
                if request.type == REQUEST_TYPE_PLAY,
                    fprintf(dfid, '   : [%s] answer=%s, userPlayAnswer=%s\n',request.audioPlaySetting,request.answer,userPlayAnswer);
                end
                
                save(latestSavedTracePath, 'request', 'requests', 'requestInfo', 'requestIdx', 'audioBuf','motion','userPlayAnswer','userQAAnswers');
                
                if request.type == REQUEST_TYPE_RECORD || request.type == requestInfo.TYPE_CALIB, 
                    if IS_FINAL == 1,
                        fprintf(2,'[WARN]: ignore the normal parsing to save time -> just try to find pilot!!!\n');
                        parsingResult = RemoveAudioNoiseDummyJustSearchPilot(latestSavedTracePath);
                    else
                        parsingResult = RemoveAudioNoise(latestSavedTracePath);
                    end
                    
                    if ~isempty(parsingResult.error),
                        fprintf(2, '[WARN] Noise removal error = %s\n', parsingResult.error);
                        parsingResultInt = -1;
                    else
                        if IS_FINAL ~= 1,
                            ratioDtoO = CalRatioToD(parsingResult, 'os');
                            fprintf(dfid, '   :ratioDtoO = %s\n', num2str(ratioDtoO));
                        end
                        parsingResultInt = 1; % tag to remember the parse passed
                    end
                    
                else % no need to parse except the recording request
                    parsingResultInt = 1;
                end
                
                if request.needToCalibEnd && parsingResultInt == 1, % means the calib ends!!!
                    calibNow = UpdateCalib(traceBasePath, 1:requestIdx);
                    % overwrite the exisitng calib setting by the new calib
                    % just finished now
                    calibVol = calibNow.bestVol;
                    calibChIdx = calibNow.bestChIdx;
                end
                
                
                % init a new audioBuf for future usage
                audioDataHasBeenUpdated = 0;
                AUDIO_BUFF_MAX_SIZE = 500000; % maximize size of audio buffering (will be flush when data is processed)
                audioBuf = zeros(AUDIO_BUFF_MAX_SIZE, traceChannelCnt);
                audioBufEnd = 0;
                motion = [];
            end
            
            fwrite(t, int32(parsingResultInt), 'int32');
            CHECK = -1;
            fwrite(t, int8(CHECK), 'int8');
            
        %******************************************************************
        % ACTION_USER_STUDY_SAVE_RESULT: Reutn user input & save the result
        %******************************************************************
        elseif action == ACTION_USER_STUDY_SAVE_RESULT,
            fprintf(dfid, '--- ACTION_USER_STUDY_SAVE_RESULT: requestIdx = %d ---\n',requestIdx);
            
            % note user might update answer after the request end received
            save(latestSavedTracePath,'userPlayAnswer','-append');
            
            submitted = fread(t, 1, 'int32'); % flag to know if user choose to submit their answer
            traceSuffix = '_succ.mat';
            if submitted == 0, % user select to ceancel this request
                traceSuffix = '_fail.mat';
            end
            
            pathPrefix = sprintf('%sq%02d_', traceBasePath, requestIdx);
            validTracePath = FindValidPath(pathPrefix, TRACE_PATH_MIN_SUFFIX, TRACE_PATH_MAX_SUFFIX, traceSuffix);
            
            % move the latest saved file to this new name
            assert(logical(exist(latestSavedTracePath, 'file')), strcat('[ERROR]: latestSavedTracePath not existed:  ', latestSavedTracePath));
            
            movefile(latestSavedTracePath, validTracePath);
            fprintf(dfid, '   :audio trace is saved to: %s\n', validTracePath);
            
            % remember also move the cache and calib files if need
            CACAHE_SUFFIX = '_cached.mat';
            latestCachePath = strrep(latestSavedTracePath, '.mat', CACAHE_SUFFIX);
            validCachePath = strrep(validTracePath, '.mat', CACAHE_SUFFIX);
            if exist(latestCachePath,'file'),
                movefile(latestCachePath, validCachePath);
            end
            
            CALIB_SUFFIX = '_calib.mat';
            latestCalibPath = strrep(latestSavedTracePath, '.mat', CALIB_SUFFIX);
            validCalibPath = strrep(validTracePath, '.mat', CALIB_SUFFIX);
            if exist(latestCalibPath,'file'),
                movefile(latestCalibPath, validCalibPath);
            end
            
        %******************************************************************
        % ACTION_USER_STUDY_PLAY_START: Called when user click play button
        %******************************************************************
        elseif action == ACTION_USER_STUDY_PLAY_START,
            fprintf(dfid, '--- ACTION_USER_STUDY_PLAY_START: enableServerAudioPlay = %d ---\n',requestInfo.enableServerAudioPlay);
             if request.serverEnableAudioPlay,
                 sound(serverPlayAudio, serverPlayAudioFS);
             end
             
             
        %******************************************************************
        % ACTION_DATA: received audio data 
        %******************************************************************
        elseif action == ACTION_DATA,
            audioDataHasBeenUpdated = 1; % a flag to know audio data is coming
            dataBytes = ServerReadFullData(t);

            % a. parse the recieved payload as audio
            dataTemp = double(typecast(dataBytes,'int16'));
            if traceChannelCnt == 1, % single-chanell ->ex: iphone
                audioNow = dataTemp;
            else % stereo-recroding
                audioNow = [dataTemp(1:2:end), dataTemp(2:2:end)];
            end

            % b. update auido to global buffer
            audioBuf(audioBufEnd+1:audioBufEnd+size(audioNow,1),:) = audioNow;
            audioBufEnd = audioBufEnd + size(audioNow,1);

        %**********************************************************************
        % ACTION_SET: set matlab variable based on code
        %**********************************************************************
        elseif action == ACTION_SET,
            [name, value, evalString] = ServerReadSetAction(t);
            fprintf(dfid, '--- ACTION_SET: %s ---\n',name);
            
            if strcmp(evalString,''),
                fprintf(dfid, '   :get a byte array (%s) not able to be eval -> use assignin instead\n', name);
                assignin('base', name, value);
            else
                eval(evalString);
            end

        %**********************************************************************
        % ACTION_CLOSE: read the end of sockets -> close loop
        %**********************************************************************
        elseif action == ACTION_CLOSE,
            fprintf(dfid, '--- ACTION_CLOSE: socket is closed remotely ---\n');
            break;
        else
            fprintf(2, '[ERROR]: undefined action=%d\n',action);
            break;
        end
    end
%catch exception % handle exception by myself!!
%    fprintf(2, '\n[ERROR]: get exception! -> something about the connection is wrong!\n');
%    exception
%end

if exist('userStudyIsFinished','var') && userStudyIsFinished == 1,
    traceBasePathFinal = strcat(traceBasePath(1:end-1), '_succ/');
    fprintf(dfid, '   :study is finished, final trace path: %s\n', traceBasePathFinal);
    movefile(traceBasePath, traceBasePathFinal);
end

fprintf(dfid, '=== end of server on port = %d ===\n', serverPort);
UpdateServerStatus(serverPort, 'dead');

if RESTART_SERVER_WHEN_CRASH_OR_END == 1,
    fprintf(dfid, '[WARN]: RESTART_SERVER_WHEN_CRASH_OR_END = 1, restart the next server');
    MakeRequestUserStudyFinal; % remember to make the request again -> so get a new set of requests
    ServerUserStudy;
end

