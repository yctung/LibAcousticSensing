classdef AudioSource < handle
    %AUDIOSOURCE Summary of this class goes here
    %   Detailed explanation goes here
    
    properties
        name;             % a name/label for AudioSource
        signal;           % signal, in the form of [# of samples, # of channels]
        FS;               % sample rate
        repeatCnt;        % how many times to play the signal
        chCnt;            % number of channel of the signal
        signalGain;       % the signal to be played = signal * signalGain
        
        preambleSource;   % preamble to know the start of signal
        preambleGain;     % gain to play the preamble
    end
    
    methods
%         % deafult constructor -> use default pilot
%         function obj=AudioSource()
%             obj.name = 'defaultAudioSource';
%             obj.preambleSource = PreambleSource();
%             obj.preambleGain=0.9;
%             
%             obj.repeatCnt=1;
%             obj.FS=obj.preambleSource.FS;
%             obj.chCnt=2;        
%             obj.signalGain=0.9;
%         end
        
        function obj = AudioSource(name, signal, FS, repeatCnt, signalGain, preambleSource)
            if exist('name', 'var')
                obj.name = name;
            else
                obj.name = 'defaultAudioSource';
            end
            
            if exist('signal', 'var')
                obj.signal = signal;
                obj.chCnt = size(signal, 2);
            else
                obj.chCnt = 1;
            end
            
            if exist('FS', 'var')
                obj.FS = FS;
            else
                obj.FS = 48000; % Hz
            end
            
            if exist('repeatCnt', 'var')
                obj.repeatCnt = repeatCnt;
            else
                obj.repeatCnt = 1;
            end
            
            
            if exist('signalGain', 'var')
                obj.signalGain = signalGain;
            else
                obj.signalGain=0.9;
            end

            if exist('preambleSource', 'var')
                obj.preambleSource = preambleSource();
                obj.preambleGain = 0.9; % TODO: include thin the preamble itself?
            else
                obj.preambleSource = PreambleSource();
                obj.preambleGain = 0.9;
            end
            
            assert(obj.FS == obj.preambleSource.FS, '[ERROR]: source sampel rate should equal the preamble sameple rate');
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

