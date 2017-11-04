%==========================================================================
% 2017/08/17: Just plays and records one sound. No fancy callback orw
% anything.
%==========================================================================
Setup

global PS; PS = struct(); 
global FillUpBuffer;
global FillUpPointers;
global AlreadyProcessed;

%% Initialize global variables
% FillUpBuffer is <Audio signal, Chirp number, Buffer Index>
%PS.PERIOD = 2400;
%PS.downPass = [2000 6000];
%PS.upPass = [2000 6000];
%PS.downPass = [8000 12000];

SOUNDTYPE = 'ch3';

%PS.upPass = [1000 1200];

if strcmp(SOUNDTYPE, 'ch1')
    PS.bandpassFilter = 0;
    PS.downPass = [8000 12000]; PS.upPass = [2000 6000];
    [upChirp, upSignal] = Helper_CreateSignal('up');
    [downChirp, downSignal] = Helper_CreateSignal('down');    
elseif strcmp(SOUNDTYPE, 'ch2')
    PS.bandpassFilter = 1;
    PS.downPass = [8000 12000]; PS.upPass = [2000 6000];
    [upChirp, upSignal] = Helper_CreateSignal('up');
    [downChirp, downSignal] = Helper_CreateSignal('down');    
elseif strcmp(SOUNDTYPE, 'ch3')
    PS.bandpassFilter = 0;
    PS.downPass = [2000 6000]; PS.upPass = [2000 6000];
    %PS.downPass = [17000 20000]; PS.upPass = [17000 20000];
    [upChirp, upSignal] = Helper_CreateSignal('up');
    [downChirp, downSignal] = Helper_CreateSignal('down');    
elseif strcmp(SOUNDTYPE, 'ch4')
    PS.bandpassFilter = 0;
    PS.downPass = [16000 17000];
    PS.upPass = [18000 19000];
    [upChirp, upSignal] = Helper_CreateSignal('up');
    [downChirp, downSignal] = Helper_CreateSignal('down');
elseif strcmp(SOUNDTYPE, 'pn1')
    PS.bandpassFilter = 0;
    [upChirp, upSignal] = Helper_CreatePN('up');
    [downChirp, downSignal] = Helper_CreatePN('down');
elseif strcmp(SOUNDTYPE, 'pn2')
    PS.bandpassFilter = 1;
    PS.downPass = [8000 12000]; PS.upPass = [2000 6000];
    [upChirp, upSignal] = Helper_CreateBandedPN('up');
    [downChirp, downSignal] = Helper_CreateBandedPN('down');
end



NUMSOURCES = 2;
FillUpBuffer = zeros(PS.PERIOD, 2000, NUMSOURCES*2);
FillUpPointers = zeros(1, NUMSOURCES*2);
AlreadyProcessed = 0;

PS.upchirp_data = upChirp;
PS.downchirp_data = downChirp;
PS.detectEnabled = 0;
PS.detectRef = 0;


%% Set up sensing server
% Only one plays up chirp
% First one plays upSignal
audioSources(1) = SetupAudioSource(upSignal);
audioSources(1).preambleGain = 1;
audioSources(1).signalGain = 1;
for asIdx=2:NUMSOURCES
    audioSources(asIdx) = SetupAudioSource(downSignal);
    audioSources(asIdx).preambleGain = 0;
end

for asIdx=3:NUMSOURCES
    audioSources(asIdx).signalGain = 0;
end

StartSensingServer(audioSources);

%% Functions
function as = SetupAudioSource (signal)
    %% Allocate audio sources and sensing servers
    import edu.umich.cse.yctung.*;
    as = AudioSource(); % default audio source
    as.signal = signal;
    as.repeatCnt = 20*60*4;
    as.signalGain = 0.8;
end

function StartSensingServer (audioSources)
    %% Create sensing servers with signals
    import edu.umich.cse.yctung.*;
    close all;
    JavaSensingServer.closeAll(); 
    pause(1.0);
    
    %analysisFunction = @Helper_DoAggregatePeaks;
    %analysisFunction = @Helper_DistanceCalc;
    %analysisFunction = @BufferCallback_DistanceExperiments;
    %analysisFunction = @BufferCallback_GenericExperiments;
    %analysisFunction = @BufferCallback_VarianceAnalysis;
    %analysisFunction = @BufferCallback_TWatchXY;
    %analysisFunction = @BufferCallback_RawData;
    analysisFunction = @BufferCallback_TWatchExperiment;
    
    clear sensingServers;
    for asIdx=1:length(audioSources)
        sensingServers(asIdx) = SensingServer(...
                50005+asIdx-1, ...
                CallbackFactory_FillUpIndices(2*asIdx-1,2*asIdx,analysisFunction), ...
                SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, ...
                audioSources(asIdx));
        sensingServers(asIdx).startSensingAfterConnectionInit = 0;
        pause(0.5);
    end
    
    master = sensingServers(1);
    for asIdx=2:length(audioSources)
        master.addSlaveServer(sensingServers(asIdx));
    end
end