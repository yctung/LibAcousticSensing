%==========================================================================
% 2017/05/06: modified to show doppler shift caused by object moving
%           : NOTE: both rx/rx record and play at the same time, but the
%           played signal at rx is 0 while the received signal at tx is not
%           saved/parsed
% 2017/10/21: use this to test slave devices UI for save/reload
%==========================================================================
TX_SERVER_PORT = 50005;
RX_SERVER_PORT = 50006;
import edu.umich.cse.yctung.*
close all;
JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);

%--------------------------------------------------------------------------
% 1. signal settings
%--------------------------------------------------------------------------
FS = 48000;
PERIOD = 4800;
SIGNAL_LEN = 4800;
SIGNAL_FREQ = 20000;
REPEAT_CNT = 20*60*4;

%--------------------------------------------------------------------------
% 2. build sensing signal and AudioSource object
%    NOTE: dummyas is a sound with 0 gains, so nothing will be played
%--------------------------------------------------------------------------
signal = zeros(PERIOD, 1);
time = (0:SIGNAL_LEN-1)./FS; 
signal(1:SIGNAL_LEN) = sin(2*pi*SIGNAL_FREQ*time);
signal = signal./max(abs(signal));
signal = signal(:);
as = AudioSource('dopplerDetectorSound', signal, FS, REPEAT_CNT, 0.8); % default audio source
dummyas = AudioSource('dummySound', signal, FS, REPEAT_CNT, 0); % dummy audio source (with 0 gain) to be played at rx
dummyas.preambleGain = 0;

%--------------------------------------------------------------------------
% 3. parse settings (later used in ObjectDetectorCallback)
%--------------------------------------------------------------------------
global PS; PS = struct(); % parse setting, easy for the callback to get
PS.FS = FS;
PS.PERIOD = PERIOD;
PS.SIGNAL_FREQ = SIGNAL_FREQ;
PS.detectRangeStart = 1550;
PS.detectRangeEnd = 1650;
PS.downsampleFactor = 8; % increase the frequency resolution by subsampling
PS.combineFactor = 8; % combine multiple frame to estimate the frequency shift

%--------------------------------------------------------------------------
% 4. build sensing server
%--------------------------------------------------------------------------
% NOTE: DummyCallback is used so no signal received at tx will be parsed
txss = SensingServer(TX_SERVER_PORT, @DummyCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
txss.startSensingAfterConnectionInit = 0; % avoid auto sensing
pause(1.0); % wait some time before building the next server


% NOTE: dummyas is used for simplifying the implementaion (so rx knows how to parse the signal)
rxss = SensingServer(RX_SERVER_PORT, @DopplerDetectorCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, dummyas);
rxss.startSensingAfterConnectionInit = 0;
rxss.addSlaveServer(txss);