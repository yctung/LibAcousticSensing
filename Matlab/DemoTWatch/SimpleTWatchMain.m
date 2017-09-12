%==========================================================================
% 2017/08/17: Just plays and records one sound. No fancy callback or
% anything.
%==========================================================================
Setup
signal = CreateSignal;
save('chirp', 'signal');
upas = SetupAudioSource;
StartSensingServer(upas);

function upas = SetupAudioSource
    %% Allocate audio sources and sensing servers
    import edu.umich.cse.yctung.*;
    global PS
    upas = AudioSource(); % default audio source
    upas.signal = PS.signal;
    upas.repeatCnt = 20*60*4;
    upas.signalGain = 0.8;
end

function StartSensingServer (upas)
    %% Create sensing servers with signals
    import edu.umich.cse.yctung.*;
    SERVER_PORT = 50005; % remember to diable firewall for this port

    close all;
    JavaSensingServer.closeAll(); % close all previous open socket
    pause(1.0);

    % NOTE: DummyCallback is used so no signal received at tx will be parsed
    pss = SensingServer(SERVER_PORT, @SimpleCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, upas);
    pss.startSensingAfterConnectionInit = 0; % avoid auto sensing
    pause(1.0); % wait some time before building the next server
end

function [signal] = CreateSignal 
    %% Create signals
    
    import edu.umich.cse.yctung.*;
    
    FS = 48000;
    PERIOD = 4800; %2400;
    CHIRP_LEN = 1200;
    CHIRP_FREQ_START = 18000;
    CHIRP_FREQ_END = 24000;
    FADING_RATIO = 0.5;
    
    global PS; PS = struct(); % parse setting, easy for the callback to get
    PS.FS = FS;
    PS.detectRangeStart = 580;
    PS.detectRangeEnd = 600;
    PS.detectEnabled = 0;
    PS.detectRef = 0;
    time = (0:CHIRP_LEN-1)./FS; 
    
    upsignal = zeros(PERIOD, 1);
    upsignal(1:CHIRP_LEN) = chirp(  time, ...
                                    CHIRP_FREQ_START, ...
                                    time(end), ...
                                    CHIRP_FREQ_END);
    
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

    upsignal(1:CHIRP_LEN) = upsignal(1:CHIRP_LEN).*w;
    upsignal = upsignal./max(abs(upsignal));
    upsignal = upsignal(:);
    
    % reverse the chirp is the optimal matched filter to detect chirp singals
    PS.upsignalToCorrelate = upsignal(CHIRP_LEN:-1:1);
    PS.signal = upsignal;
    signal = PS.upsignalToCorrelate;
end