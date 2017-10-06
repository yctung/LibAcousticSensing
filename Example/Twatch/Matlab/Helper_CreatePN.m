function [ chirpSignal, playSignal ] = Helper_CreatePN( direction )
%HEPLPER_CREATEPN Summary of this function goes here
%   Detailed explanation goes here

    %% Create signals
    global PS
    
    import edu.umich.cse.yctung.*;
    
    FS = 48000;
    PERIOD = 24000; %2400;
    CHIRP_LEN = 1200;%1200;
    FADING_RATIO = 0.5;
    
    PS.FS = FS;
    PS.PERIOD = PERIOD;
    
    time = (0:CHIRP_LEN-1)./FS; 
    
    playSignal = zeros(PERIOD, 1);
    if strcmp(direction, 'up'), rng(1);
    else, rng(2);
    end
        
    playSignal(1:CHIRP_LEN) = rand(length(time), 1); 
    
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

