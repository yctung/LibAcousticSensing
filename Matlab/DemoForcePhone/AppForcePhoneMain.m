%==========================================================================
% 2017/03/29: 
%==========================================================================
SERVER_PORT = 50005; % remember to diable firewall for this port
close all;
import edu.umich.cse.yctung.*

JavaSensingServer.closeAll(); % close all previous open socket

% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source
as.name = 'ForcePhoneAudioSource';

FS = 48000;
PERIOD = 2400;
CHIRP_LEN = 1200;
%CHIRP_FREQ_START = 18000;
CHIRP_FREQ_START = 11000;
CHIRP_FREQ_END = 24000;
APPLY_FADING_TO_SIGNAL = 1;
FADING_RATIO = 0.5;

global PS; PS = struct(); % parse setting, easy for the callback to get
PS.FS = FS;
PS.detectRangeStart = 580;
PS.detectRangeEnd = 600;
PS.detectEnabled = 0;
PS.detectRef = 0;

signal = zeros(PERIOD, 1);

time = (0:CHIRP_LEN-1)./FS; 
signal(1:CHIRP_LEN) = chirp(time, CHIRP_FREQ_START, time(end), CHIRP_FREQ_END);
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
    
    signalWithoutHamming = signal; % keep the original sync signals
    signal(1:CHIRP_LEN) = signal(1:CHIRP_LEN).*w; % apply fadding to the sync signal
end

signal = signal./max(abs(signal));
signal = signal(:);

PS.signalToCorrelate = signal(CHIRP_LEN:-1:1); % reverse the chirp is the optimal matched filter to detect chirp singals

as.signal = signal;
as.repeatCnt = 20*60*4;
as.signalGain = 0.8;

% modify preamble
%{
fprintf(2, '[WARN]: using inaudible preamble\n');
ps = PreambleBuilder('CHIRP', [22000, 18000], [500, 1000], 48000, 10, 4800, 4800, 0.1);
ps.writePreambleToFileAsBinary('preamble.dat'); % dump for Android to import
ps.writeSyncToFileAsStringArray('sync.cpp', 'AUDIO_PILOT_TO_FILTER'); % dump for Android to import
as.preambleSource = ps;
%}

global ss; % TODO: find a better way instead of using a global variable
ss = SensingServer(SERVER_PORT, @AppForcePhoneCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing

%ss2 = SensingServer(SERVER_PORT+1, @ServerAppFeatureTrainCallback, ss.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
%ss2.startSensingAfterConnectionInit = 0; % avoid auto sensing

%{
pause(1.0);
for i=1:1000
    fprintf('busy...\n');
    temp = rand(1000,1000)*rand(1000,1000);
    pause(1.0);
end
%}
%ss.startServer(as,);
