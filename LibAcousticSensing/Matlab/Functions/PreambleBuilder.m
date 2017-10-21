function [ ps ] = PreambleBuilder( type, freqs, lens, FS, repeatCnt, startOffset, endOffset, fadingRatio )
% 2017/03/28: This is a helper class to build preamble
%           : I keep the definition of type, freqs, lens open for future
%           : possible preamble typle to use
% format: |________________ preambleToAdd ___________________|
% format: |  startOffset | sync1, sync2 ... syncN | endOffset|

    if ~exist('type','var'),
        type = 'CHIRP';
        freqs = [22000, 15000]; % audioble pilot
        %freqs = [23000, 19000]; % inaudible pilot
        lens = [500, 1000]; % length of signal in pilot and also the single repeat size
        FS = 48000;
    end

    if ~exist('repeatCnt','var'),
        repeatCnt = 10;
    end
    
    if ~exist('endOffset','var'), 
        endOffset = 4800;
    end

    if ~exist('startOffset','var'), 
        startOffset = 4800;
    end

    if ~exist('fadingRatio','var'),
        fadingRatio = -1;
        %fadingRatio = 0.2;
    end
    
    if fadingRatio <= 0,
        APPLY_FADING_TO_SYNC = 0;
    else
        APPLY_FADING_TO_SYNC = 1;
    end
    
    % build a single chirp signal
    if strcmp(type, 'CHIRP'),
        assert(length(freqs)==2, 'ERROR: need 2 elements in freqs for CHIRP preamble\n');
        assert(length(lens)==2, 'ERROR: need 2 elements in lens for CHIRP preamble\n');
        SYNC_SIGNAL_LEN = lens(1);
        SYNC_REPEAT_LEN = lens(2);
        
        t = 0:1/FS:(SYNC_SIGNAL_LEN-1)/FS;
        sync = chirp(t,freqs(1),(SYNC_SIGNAL_LEN-1)/FS,freqs(2))';
        syncToDetect = sync;
    else
        assert(0, 'ERROR: currently only support CHIRP type\n');
    end

    % build hamming window if need
    if APPLY_FADING_TO_SYNC == 1,
        FADDING_WIN_SIZE = floor(SYNC_SIGNAL_LEN*fadingRatio);
        win = hamming(FADDING_WIN_SIZE); % fading by a hamming window
        win = win-min(win);
        win = win./max(win);
        [~,maxIdx] = max(win);
        winStart = win(1:maxIdx);
        winEnd = win(maxIdx+1:end);

        w = ones(SYNC_SIGNAL_LEN, 1);
        w(1:length(winStart)) = winStart;
        w(end-length(winEnd)+1:end) = winEnd;
        syncWithoutHamming = sync; % keep the original sync signals
        sync = sync.*w; % apply fadding to the sync signal
    end
    
    % repeat pilot and add offsets
    syncSingleRepeat = zeros(SYNC_REPEAT_LEN, 1);
    syncSingleRepeat(1:length(sync)) = sync;
    preamble = repmat(syncSingleRepeat, [repeatCnt,1]);
    preambleToAdd = [zeros(startOffset,1); preamble; zeros(endOffset,1)];
    
    LATEST_SETTING_NAME = 'latestPreambleSetting';
    save(LATEST_SETTING_NAME);
    
    % build 
    ps = PreambleSource(LATEST_SETTING_NAME);
end

