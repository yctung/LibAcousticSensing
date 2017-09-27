classdef TraceParser < handle
    %TRACEPARSER handles all online/offline parsing for the receved audio
    %            from devices
    % 
    properties (Constant = true)
        AUDIO_SAMPLE_TO_FIND_PREAMBLE = 35000; % TODO: this value should be set large enough to handle pilot search
        AUDIO_BUFF_MAX_SIZE=500000; % maximize size of audio buffering (will be flush when data is processed)
    end
    
    properties
        audioSource;
        traceChannelCnt;
        sensingServer;
        
        % parsing states
        needToSearchPreamble;
        needToRemovePreamble;
        pilotEndOffsets;
        pilotToRemoveLens;
        
        audioBuf;
        audioBufEnd;
    end
    
    methods
        % constructor
        function obj = TraceParser(audioSource, traceChannelCnt, sensingServer)
            obj.audioSource = audioSource;
            obj.traceChannelCnt = traceChannelCnt;
            obj.sensingServer = sensingServer;
            obj.reset();
        end
        
        function reset(obj)
            % init audio buffers
            obj.audioBuf=zeros(obj.AUDIO_BUFF_MAX_SIZE, obj.traceChannelCnt);
            obj.audioBufEnd=0;
            obj.needToSearchPreamble = 1;
            obj.needToRemovePreamble = 1;
        end
        
        % parse the inputted audio
        function audioToProcess = parse(obj, audioNow)
            % a. update auido to global buffer
            obj.audioBuf(obj.audioBufEnd+1:obj.audioBufEnd+size(audioNow,1),:) = audioNow;
            obj.audioBufEnd = obj.audioBufEnd+size(audioNow,1);
            
            audioToProcess = [];
            
            % b. search preamble in the first packet
            % NOTE: currently I always use the first traces as
            % reference to cut signals, it might be better if both
            % are used seprately
            if obj.needToSearchPreamble && obj.audioBufEnd > obj.AUDIO_SAMPLE_TO_FIND_PREAMBLE,
                [obj.pilotEndOffsets] = FindPilotAutoSearch(obj.audioBuf(1:obj.AUDIO_SAMPLE_TO_FIND_PREAMBLE,:), obj.audioSource.preambleSource, 1:size(obj.audioBuf,2), 0);
                
                if obj.pilotEndOffsets(1) < 0,
                    fprintf(2, '[ERROR]: unable to sync preamble, offsets = %d\n', obj.pilotEndOffsets(1));
                    obj.sensingServer.preambleDetectResult(0);
                else
                    obj.sensingServer.preambleDetectResult(1); % detect correctly
                end
                
                %assert(obj.pilotEndOffsets(1) > 0, '[ERROR]: unable to find pilot, (AUDIO_SAMPLE_TO_FIND_PREAMBLE is too short?)\n');
                obj.pilotToRemoveLens = obj.pilotEndOffsets(1) + obj.audioSource.preambleSource.preambleEndOffset;
                obj.needToSearchPreamble = 0;
            end
            
            % c. remove pilot if receive enough audio data
            if obj.needToSearchPreamble == 0 && obj.needToRemovePreamble && obj.audioBufEnd > obj.pilotToRemoveLens(1),
                newAudioBufEnd = obj.audioBufEnd - obj.pilotToRemoveLens(1);
                obj.audioBuf(1:newAudioBufEnd, :) = obj.audioBuf(obj.pilotToRemoveLens(1)+1:obj.audioBufEnd, :);
                obj.audioBufEnd = newAudioBufEnd;
                obj.needToRemovePreamble = 0;
            end
            
            % d. start cut the audio data for processing
            SINGLE_REPEAT_LEN = size(obj.audioSource.signal,1);
            if obj.needToSearchPreamble == 0 && obj.needToRemovePreamble == 0 && obj.audioBufEnd > SINGLE_REPEAT_LEN,
                repeatToProcess = floor(obj.audioBufEnd/SINGLE_REPEAT_LEN);
                lenToProcess = repeatToProcess*SINGLE_REPEAT_LEN;
                newAudioBufEnd = obj.audioBufEnd - lenToProcess;
                audioToProcess = obj.audioBuf(1:lenToProcess,:); % TODO: find a efficent data structure to handle this data movement
                obj.audioBuf(1:newAudioBufEnd,:) = obj.audioBuf(lenToProcess+1:obj.audioBufEnd,:);
                obj.audioBufEnd = newAudioBufEnd;
                
                % do audio process
                audioToProcess = reshape(audioToProcess, [SINGLE_REPEAT_LEN, repeatToProcess, obj.traceChannelCnt]);
                
                % TODO: add filter option if need
                %{ 
                if NEED_PRE_FILTER,
                    audioToProcess = filter(pfB, pfA, audioToProcess);
                end
                %}
            end
        end
        
    end
    
end

