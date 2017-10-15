function [ signalOut ] = ApplyFadingInStartAndEndOfSignal( signalIn, FADING_RATIO )
% 2017/10/15: Fade-in/out of the signal to make it inaudible
%           : this is usually necessary to make the sound "inaudible"
    CHIRP_LEN = length(signalIn);
    FADDING_WIN_SIZE = floor(CHIRP_LEN * FADING_RATIO);
    
    win = hamming(FADDING_WIN_SIZE); % fading by a hamming window
    win = win-min(win);
    win = win./max(win);
    [~,maxIdx] = max(win);
    winStart = win(1:maxIdx);
    winEnd = win(maxIdx+1:end);

    w = ones(CHIRP_LEN, 1);
    w(1:length(winStart)) = winStart;
    w(end-length(winEnd)+1:end) = winEnd;
    
    %signalWithoutHamming = signal; % keep the original sync signals
    signalOut = signalIn(1:CHIRP_LEN).*w; % apply fadding to the sync signal
end

