%==========================================================================
% 2017/05/06: modified to show doppler shift caused by object moving
%           : NOTE: both rx/rx record and play at the same time, but the
%           played signal at rx is 0 while the received signal at tx is not
%           saved/parsed
%==========================================================================
TX_SERVER_PORT = 50005; % remember to diable firewall for this port
RX_SERVER_PORT = 50006; % remember to diable firewall for this port

close all;
JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);

% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source

FS = 48000;
PERIOD = 4800;
SIGNAL_LEN = 4800;
SIGNAL_FREQ = 20000;

signal = zeros(PERIOD, 1);
time = (0:SIGNAL_LEN-1)./FS; 
signal(1:SIGNAL_LEN) = sin(2*pi*SIGNAL_FREQ*time);

signal = signal./max(abs(signal));
signal = signal(:);

global PS; PS = struct(); % parse setting, easy for the callback to get
PS.FS = FS;
PS.PERIOD = PERIOD;
PS.SIGNAL_FREQ = SIGNAL_FREQ;
PS.detectRangeStart = 1550;
PS.detectRangeEnd = 1650;
PS.downsampleFactor = 8; % increase the frequency resolution by subsampling
PS.combineFactor = 8; % combine multiple frame to estimate the frequency shift

as.signal = signal;
as.repeatCnt = 20*60*4;
as.signalGain = 0.8;

% NOTE: DummyCallback is used so no signal received at tx will be parsed
txss = SensingServer(TX_SERVER_PORT, @DummyCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
txss.startSensingAfterConnectionInit = 0; % avoid auto sensing
pause(1.0); % wait some time before building the next server


dummyas = AudioSource(); % dummy audio source (with 0 gain) to be played at rx
dummyas.repeatCnt = as.repeatCnt;
dummyas.signal = as.signal;
dummyas.signalGain = 0;
dummyas.preambleGain = 0;

% NOTE: dummyas is used for simplifying the implementaion (so rx knows how to parse the signal)
rxss = SensingServer(RX_SERVER_PORT, @AppDopplerDetectorCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, dummyas);
rxss.startSensingAfterConnectionInit = 0;
rxss.addSlaveServer(txss);