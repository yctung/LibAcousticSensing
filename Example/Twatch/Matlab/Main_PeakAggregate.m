%==========================================================================
% 2017/08/17: Just plays and records one sound. No fancy callback or
% anything.
%==========================================================================
Setup

global PS; PS = struct(); 
global FillUpBuffer;
global FillUpPointers;
global AlreadyProcessed;
%global PS;
%% Initialize global variables
% FillUpBuffer is <Audio signal, Chirp number, Buffer Index>
%PS.PERIOD = 2400;

%PS.downPass = [1000 1200];
%PS.upPass = [1500 1700];
%PS.downPass = [1000 1200];
%PS.upPass = [1000 1200];
%PS.upPass = [19000 22000]; % 2k - 6k is the paper
%PS.downPass = [19000 22000]; % 2k - 6k

PS.upPass = [2000 6000];
%PS.downPass = [2000 6000];
PS.downPass = [8000 12000];

[upChirp, upSignal] = Helper_CreateSignal('up');
[downChirp, downSignal] = Helper_CreateSignal('down');
%[upChirp, upSignal] = Helper_CreatePN('up');
%[downChirp, downSignal] = Helper_CreatePN('down');
%[upChirp, upSignal] = Helper_CreateBandedPN('up');
%[downChirp, downSignal] = Helper_CreateBandedPN('down');


FillUpBuffer = zeros(PS.PERIOD, 2000, 4);
FillUpPointers = [0 0 0 0];
AlreadyProcessed = 0;


PS.upchirp_data = upChirp;
PS.downchirp_data = downChirp;
PS.detectEnabled = 0;
PS.detectRef = 0;


%% Set up sensing server
upas = SetupAudioSource(upSignal);
downas = SetupAudioSource(downSignal);
downas.preambleGain = 0;
StartSensingServer(upas, downas);


%% Functions
function as = SetupAudioSource (signal)
    %% Allocate audio sources and sensing servers
    import edu.umich.cse.yctung.*;
    as = AudioSource(); % default audio source
    as.signal = signal;
    as.repeatCnt = 20*60*4;
    as.signalGain = 0.8;
end

function StartSensingServer (upas, downas)
    %% Create sensing servers with signals
    import edu.umich.cse.yctung.*;
    close all;
    JavaSensingServer.closeAll(); 
    pause(1.0);
    
    %analysisFunction = @Helper_DoAggregatePeaks;
    %analysisFunction = @Helper_DistanceCalc;
    analysisFunction = @BufferCallback_DistanceExperiments;
    
    pss = SensingServer(50005, CallbackFactory_FillUpIndices(1,2,analysisFunction), SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, upas);
    pss.startSensingAfterConnectionInit = 0; 
    
    pause(1.0);
    
    wss = SensingServer(50006, CallbackFactory_FillUpIndices(3,4,analysisFunction), SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, downas);
    wss.startSensingAfterConnectionInit = 0;
    
    wss.addSlaveServer(pss);
end