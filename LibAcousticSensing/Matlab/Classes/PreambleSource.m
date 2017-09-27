classdef PreambleSource < handle
    %PILOTSOURCE is a container to save pilot attributes
    %   pilotToAdd is the final signal to add before payload
    
    properties
        preambleToAdd;
        syncToDetect;
        syncRepeatCnt;
        
        FS;
        name;
        preambleEndOffset;
    end
    
    methods
        % Default constructor, load default pilot
        function obj=PreambleSource(settingPath)
            if ~exist('settingPath','var'), % use the default setting
                settingPath = 'latestPreambleSetting.mat';
                if ~exist(settingPath,'file'),
                    PreambleBuilder(); % creat the latestPreambleSetting.mat by default setting
                end
            end
            
            obj.name=settingPath;
            
            load(settingPath)
            
            obj.syncToDetect=syncToDetect;
            obj.preambleToAdd=preambleToAdd;
            obj.preambleEndOffset=endOffset;
            obj.syncRepeatCnt=repeatCnt;
            
            obj.FS=FS;
        end
        
        % Function to write binary file being used by audio tracks
        function writePreambleToFileAsBinary(obj, filePath)
            fid = fopen(filePath,'wt');
            AMP_FROM_FLOAT_TO_SHORT = (2^15)-1; % do some adjustment in java later on
            pilotToWrite = floor(obj.preambleToAdd.*AMP_FROM_FLOAT_TO_SHORT);
            fwrite(fid, pilotToWrite, 'int16');
            fclose(fid);
        end
        
        function writeSyncToFileAsStringArray(obj, filePath, varName)
            stringToSave = sprintf('AUDIO_PILOT_END_OFFSET = %d;\n', obj.preambleEndOffset);
            values = ConvertVectorToStringArray(obj.syncToDetect);
            stringToSave = sprintf('%s%s = %s', stringToSave, varName, values);
            fid = fopen(filePath,'wt');
            fprintf(fid, stringToSave);
            fclose(fid);
        end
    end
    
end

