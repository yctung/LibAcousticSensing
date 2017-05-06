%==========================================================================
% 2017/04/26: Modified to send audio from one device to another
%==========================================================================

TX_SERVER_PORT = 50005; % remember to diable firewall for this port
RX_SERVER_PORT = 50006; % remember to diable firewall for this port

close all;
JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);

% create signal to send
% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source

FS = 48000;
PERIOD = 2400;
CHIRP_LEN = 1200;
CHIRP_FREQ_START = 18000;
CHIRP_FREQ_END = 23000;
APPLY_FADING_TO_SIGNAL = 1;
FADING_RATIO = 0.5;

global PS; PS = struct(); % parse setting, easy for the callback to get
PS.FS = FS;
PS.detectRangeStart = 2000;
PS.detectRangeEnd = 2350;
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

PS.signalToCorrelate = signal(CHIRP_LEN:-1:1);

as.signal = signal;
as.repeatCnt = 20*60*4;
as.signalGain = 0.8;

% create servers
txss = SensingServer(TX_SERVER_PORT, @AppTwoDevicesTxCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_ONLY, as);
txss.startSensingAfterConnectionInit = 0; % avoid auto sensing

% NOTE: as should be assigned to rxss as well, so it know how to parse it
rxss = SensingServer(RX_SERVER_PORT, @AppTwoDevicesRxCallback, SensingServer.DEVICE_AUDIO_MODE_RECORD_ONLY, as);
rxss.startSensingAfterConnectionInit = 0;
rxss.addSlaveServer(txss);
% TODO: set rx as the chain mode