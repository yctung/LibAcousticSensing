%==========================================================================
% 2017/05/06: modified to show doppler shift caused by object moving
%           : NOTE: both rx/rx record and play at the same time, but the
%           played signal at rx is 0 while the received signal at tx is not
%           saved/parsed
%==========================================================================
import edu.umich.cse.yctung.*;


%% Create signals
FS = 48000;
PERIOD = 2400;
CHIRP_LEN = 1200;
CHIRP_FREQ_START = 18000;
%CHIRP_FREQ_START = 10000;
CHIRP_FREQ_END = 24000;
APPLY_FADING_TO_SIGNAL = 1;
FADING_RATIO = 0.5;

global PS; PS = struct(); % parse setting, easy for the callback to get
PS.FS = FS;
PS.detectRangeStart = 580;
PS.detectRangeEnd = 600;
PS.detectEnabled = 0;
PS.detectRef = 0;

upsignal = zeros(PERIOD, 1);
downsignal = zeros(PERIOD, 1);

time = (0:CHIRP_LEN-1)./FS; 
upsignal(1:CHIRP_LEN) = chirp(time, CHIRP_FREQ_START, time(end), CHIRP_FREQ_END);
downsignal(1:CHIRP_LEN) = chirp(time, CHIRP_FREQ_END, time(end), CHIRP_FREQ_START);

%downsignal = upsignal;


% add hamming window
if APPLY_FADING_TO_SIGNAL == 1,
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
    downsignal(1:CHIRP_LEN) = downsignal(1:CHIRP_LEN).*w;
end

upsignal = upsignal./max(abs(upsignal));
upsignal = upsignal(:);
downsignal = downsignal./max(abs(downsignal));
downsignal = downsignal(:);

% reverse the chirp is the optimal matched filter to detect chirp singals
PS.upsignalToCorrelate = upsignal(CHIRP_LEN:-1:1);
PS.downsignalToCorrelate = downsignal(CHIRP_LEN:-1:1);

%% Allocate audio sources and sensing servers
upas = AudioSource(); % default audio source
downas = AudioSource(); % default audio source

upas.signal = upsignal;
upas.repeatCnt = 20*60*4;
upas.signalGain = 0.8;

downas.signal = downsignal;
downas.repeatCnt = 20*60*4;
downas.signalGain = 0.8;
downas.preambleGain = 0; % slave device should not play preamble to avoid confusion of the algorithm

%% Create sensing servers with signals
PHONE_SERVER_PORT = 50005; % remember to diable firewall for this port
WATCH_SERVER_PORT = 50006; % remember to diable firewall for this port

close all;
JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);

% NOTE: DummyCallback is used so no signal received at tx will be parsed
phoneCallback = TWatchCallbackFactory('USER_FIG_PHONE_TAG');
%pss = SensingServer(PHONE_SERVER_PORT, @AppTWatchPhoneCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, upas);
pss = SensingServer(PHONE_SERVER_PORT, phoneCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, upas);
pss.startSensingAfterConnectionInit = 0; % avoid auto sensing
pause(1.0); % wait some time before building the next server

% NOTE: dummyas is used for simplifying the implementaion (so rx knows how to parse the signal)
watchCallback = TWatchCallbackFactory('USER_WATCH_FIG_TAG');
%wss = SensingServer(WATCH_SERVER_PORT, @AppTWatchWatchCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, downas);
wss = SensingServer(WATCH_SERVER_PORT, watchCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, downas);
wss.startSensingAfterConnectionInit = 0;

% pss.addSlaveServer(wss); % means when phone start sensing, watch will also start sensing
wss.addSlaveServer(pss); % means when phone start sensing, watch will also start sensing