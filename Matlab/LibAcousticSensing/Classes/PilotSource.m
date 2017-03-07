classdef PilotSource
    %PILOTSOURCE is a container to save pilot attributes
    %   pilotToAdd is the final signal to add before payload
    
    properties
        pilot;
        pilotToAdd;
        FS;
        name;
        PILOT_END_OFFSET;
    end
    
    methods
        % Default constructor, load default pilot
        function obj=PilotSource()
            obj.name='pilot_default';
            load('pilot_default.mat');
            obj.pilot=pilot;
            obj.pilotToAdd=pilotToAdd;
            obj.FS=FS;
            obj.PILOT_END_OFFSET=PILOT_END_OFFSET;
        end
    end
    
end

