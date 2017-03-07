classdef AudioSource < handle
    %AUDIOSOURCE Summary of this class goes here
    %   Detailed explanation goes here
    
    properties
        pilotSource;
        pilotGain;
        payload;
        FS;
        repeatCnt;
        chCnt;
        signal;
        signalGain;
    end
    
    methods
        % deafult constructor -> use default pilot
        function obj=AudioSource()
            obj.pilotSource=PilotSource();
            obj.repeatCnt=1;
            obj.payload=[];
            obj.FS=obj.pilotSource.FS;
            obj.chCnt=2;        
            obj.pilotGain=0.9;
            obj.signalGain=0.9;
        end
            
    end
    
end

