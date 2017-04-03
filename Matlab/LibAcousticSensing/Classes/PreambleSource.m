classdef PreambleSource < handle
    %PILOTSOURCE is a container to save pilot attributes
    %   pilotToAdd is the final signal to add before payload
    
    properties
        preambleToAdd;
        syncToDetect;
        
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
            
            obj.FS=FS;
        end
    end
    
end

