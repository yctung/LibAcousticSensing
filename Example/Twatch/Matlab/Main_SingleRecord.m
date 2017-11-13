%==========================================================================
% 2017/08/17: Just plays and records one sound. No fancy callback or
% anything.
%==========================================================================
Setup
[upChirp, upSignal] = CreateSignal('up');
save('chirp', 'upChirp');
upas = SetupAudioSource(upSignal);
StartSensingServer(upas);


function upas = SetupAudioSource (signal)
    %% Allocate audio sources and sensing servers
    import edu.umich.cse.yctung.*;
    upas = AudioSource(); % default audio source
    upas.signal = signal;
    upas.repeatCnt = 20*60*4;
    upas.signalGain = 0.8;
end

function StartSensingServer (upas)
    global pss;
    %% Create sensing servers with signals
    import edu.umich.cse.yctung.*;
    SERVER_1 = 50006; % remember to diable firewall for this port
    
    close all;
    JavaSensingServer.closeAll(); % close all previous open socket
    pause(1.0);

    % NOTE: DummyCallback is used so no signal received at tx will be parsed
    phoneCallback = @Callback_Simple;
    %phoneCallback = @Callback_Tapman;
    pss = SensingServer(SERVER_1, phoneCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, upas);
    pss.startSensingAfterConnectionInit = 0; % avoid auto sensing
    pause(1.0); % wait some time before building the next server
end

function [chirpSignal, playSignal] = CreateSignal (direction)
    %% Create signals
    global PS
    
    import edu.umich.cse.yctung.*;
    
    FS = 48000;
    PERIOD = 12000; %2400;
    CHIRP_LEN = 300;%1200;
    CHIRP_FREQ_START = 1400;%18000;
    CHIRP_FREQ_END = 1800; %24000;
    FADING_RATIO = 0.5;
    
    PS = struct(); % parse setting, easy for the callback to get
    PS.FS = FS;
    PS.detectRangeStart = 580;
    PS.detectRangeEnd = 600;
    PS.detectEnabled = 0;
    PS.detectRef = 0;
    
    time = (0:CHIRP_LEN-1)./FS; 
    
    playSignal = zeros(PERIOD, 1);
    if strcmp(direction, 'up')
        playSignal(1:CHIRP_LEN) = chirp(  time, ...
                                        CHIRP_FREQ_START, ...
                                        time(end), ...
                                        CHIRP_FREQ_END);
    else
        playSignal(1:CHIRP_LEN) = chirp(  time, ...
                                CHIRP_FREQ_END, ...
                                time(end), ...
                                CHIRP_FREQ_START);

    end
    
    % add hamming window
    FADDING_WIN_SIZE = floor(CHIRP_LEN*FADING_RATIO);
    win = hamming(FADDING_WIN_SIZE); % fading by a hamming window
    win = win-min(win);
    win = win./max(win);
    [~,maxIdx] = max(win);
    winStart = win(1:maxIdx);
    winEnd = win(maxIdx+1:end);
    w = ones(CHIRP_LEN, 1);
    w(1:length(winStart)) = winStart;
    w(end-length(winEnd)+1:end) = winEnd;
    % apply fadding to the sync signal
    
    playSignal(1:CHIRP_LEN) = playSignal(1:CHIRP_LEN).*w;
    playSignal = playSignal./max(abs(playSignal));
    playSignal = playSignal(:);
    
    % reverse the chirp is the optimal matched filter to detect chirp singals
    % XXX Is this why we're doing the convolution instead of correlation?
    chirpSignal = playSignal(CHIRP_LEN:-1:1);
end