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
        
        % a helper function to dum audio Source to wave format
        function outputAudioSourceToWav(obj, fileName)
            
            SHORT_MAX_RANGE = 2^15-1;
            
            %{
            preambleShortRange = floor(obj.preambleSource.preambleToAdd*obj.preambleGain*SHORT_MAX_RANGE);
            signalShortRange = floor(obj.signal*obj.signalGain*SHORT_MAX_RANGE);
            audioAll = [preambleShortRange; signalShortRange];
            %}
            audioAll = [obj.preambleSource.preambleToAdd*obj.preambleGain; repmat(obj.signal*obj.signalGain, [obj.repeatCnt, 1])];
            
            audiowrite(fileName, audioAll, obj.FS)
        end
    end
    
end

