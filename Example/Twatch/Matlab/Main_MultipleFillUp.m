%==========================================================================
% 2017/08/17: Just plays and records one sound. No fancy callback or
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

PS.upPass = [2000 6000];
PS.downPass = [8000 12000];
%PS.upPass = [1000 1200];
%PS.upPass = [19000 22000]; % 2k - 6k is the paper
%PS.downPass = [19000 22000]; % 2k - 6k
%PS.upPass = [2000 6000];
%PS.downPass = [2000 6000];
%PS.downPass = [8000 12000];

[upChirp, upSignal] = Helper_CreateSignal('up');
[downChirp, downSignal] = Helper_CreateSignal('down');
%[upChirp, upSignal] = Helper_CreatePN('up');
%[downChirp, downSignal] = Helper_CreatePN('down');
%[upChirp, upSignal] = Helper_CreateBandedPN('up');
%[downChirp, downSignal] = Helper_CreateBandedPN('down');

NUMSOURCES = 3;
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
audioSources(1).preambleGain =1;
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
    analysisFunction = @BufferCallback_DistanceExperiments;
    
    clear sensingServers;
    for asIdx=1:length(audioSources)
        sensingServers(asIdx) = SensingServer(...
                50005+asIdx-1, ...
                CallbackFactory_FillUpIndices(2*asIdx-1,2*asIdx,analysisFunction), ...
                SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, ...
                audioSources(asIdx));
        sensingServers(asIdx).startSensingAfterConnectionInit = 0;
        pause(1.0);
    end
    
    master = sensingServers(1);
    for asIdx=2:length(audioSources)
        master.addSlaveServer(sensingServers(asIdx));
    end
end