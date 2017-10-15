%==========================================================================
% 2017/03/29: An example to detect nearby objects by sounds
%           : it can estiamte the distance to the object as well
%==========================================================================
close all;
import edu.umich.cse.yctung.*
JavaSensingServer.closeAll(); % close all previous open socket
SERVER_PORT = 50005; % remember to diable firewall for this port

%--------------------------------------------------------------------------
% 1. signal settings
%--------------------------------------------------------------------------
FS = 48000;                 % sample rate (Hz)
PERIOD = 2400;              % period of one repetition of sensing
CHIRP_LEN = 1200;           % signal length (shorter than period) 
CHIRP_FREQ_START = 18000;   % signal min freq (Hz)
CHIRP_FREQ_END = 24000;     % signal max freq (Hz)
APPLY_FADING_TO_SIGNAL = 1; % fade in/out of the singal for being inaudible
FADING_RATIO = 0.2;         % ratio of singals being "faded"
REPEAT_CNT = 20*60*4;       % total repetition of signal to play
SIGNAL_GAIN = 0.8;          % gain to scale signal

%--------------------------------------------------------------------------
% 2. build sensing signal and AudioSource object
%--------------------------------------------------------------------------
signal = zeros(PERIOD, 1);
time = (0:CHIRP_LEN-1)./FS;
signal(1:CHIRP_LEN) = chirp(time, CHIRP_FREQ_START, time(end), CHIRP_FREQ_END);
if APPLY_FADING_TO_SIGNAL == 1, % add fadding if necessary (make it inaudible but lose some SNR)
    signal(1:CHIRP_LEN) = ApplyFadingInStartAndEndOfSignal(signal(1:CHIRP_LEN), FADING_RATIO);
end
as = AudioSource('objectDetectSound', signal, FS, REPEAT_CNT, SIGNAL_GAIN);

%--------------------------------------------------------------------------
% 3. parse settings (later used in ObjectDetectorCallback)
%--------------------------------------------------------------------------
global PS; PS = struct(); % parse setting, easy for the callback to get
PS.FS = FS;
PS.detectRangeStart = CHIRP_LEN/2; % for remove unnecessary singals in convolution
PS.detectRangeEnd = 1800; % should be larger than CHIRP_LEN/2
PS.detectEnabled = 0;
PS.detectRef = 0;
PS.signalToCorrelate = signal(CHIRP_LEN:-1:1); % reverse the chirp is the optimal matched filter to detect chirp singals

%--------------------------------------------------------------------------
% 4. build sensing server
%--------------------------------------------------------------------------
global ss; % TODO: find a better way instead of using a global variable
ss = SensingServer(SERVER_PORT, @ObjectDetectorCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing
