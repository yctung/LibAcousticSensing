classdef AudioSource < handle
    %AUDIOSOURCE Summary of this class goes here
    %   Detailed explanation goes here
    
    properties
        preambleSource;
        preambleGain;
        
        FS;
        repeatCnt;
        chCnt;
        signal;
        signalGain;
    end
    
    methods
        % deafult constructor -> use default pilot
        function obj=AudioSource()
            obj.preambleSource = PreambleSource();
            obj.preambleGain=0.9;
            
            obj.repeatCnt=1;
            obj.FS=obj.preambleSource.FS;
            obj.chCnt=2;        
            obj.signalGain=0.9;
        end
            
    end
    
end

