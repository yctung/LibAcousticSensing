%==========================================================================
% 2017/12/18: add this example for Kate
%==========================================================================
TX_SERVER_PORT = 50005;
RX_SERVER_PORT = 50006;
import edu.umich.cse.yctung.*
close all;
JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);


%--------------------------------------------------------------------------
% 0. data to send/receive
%--------------------------------------------------------------------------
DATA_LEN = 100;
data = (rand(DATA_LEN, 1) > 0.5 ) + 1; % 1 or 2

%--------------------------------------------------------------------------
% 1. modulated signal setting
%--------------------------------------------------------------------------
FS = 48000;
CHIRP_LEN = 4800;
CHIRP_FREQ_MIN = 18000;
CHIRP_FREQ_MAX = 22000;
APPLY_FADING_TO_SIGNAL = 1; % fade in/out of the singal for being inaudible
FADING_RATIO = 0.2;         % ratio of singals being "faded"
SIGNAL_GAIN = 0.8;          % gain to scale signal

REPEAT_CNT = 2;             % total repetition of signal to play
% NOTE: I intentially set the data being sent twice to avoid a stupid bug in my program (insufficent recording)

%--------------------------------------------------------------------------
% 2. build sensing signal and AudioSource object
%    NOTE: dummyas is a sound with 0 gains, so nothing will be played
%--------------------------------------------------------------------------
time = (0:CHIRP_LEN-1)'./FS;
chirpUp = chirp(time, CHIRP_FREQ_MIN, time(end), CHIRP_FREQ_MAX);
chirpDown = chirp(time, CHIRP_FREQ_MAX, time(end), CHIRP_FREQ_MIN);

if APPLY_FADING_TO_SIGNAL == 1 % add fadding if necessary (make it inaudible but lose some SNR)
    chirpUp = ApplyFadingInStartAndEndOfSignal(chirpUp, FADING_RATIO);
    chirpDown = ApplyFadingInStartAndEndOfSignal(chirpDown, FADING_RATIO);
end

codes = {chirpUp, chirpDown}; % a cell array of constellation for encoder
signal = Encode(codes, data);

% NOTE: preamble freq range should be different from the modulated chirps
%     : or it should have a longer guard window (e.g., 48000 samples)
preamble = PreambleBuilder('CHIRP', [22000, 18000], [500, 1000], 48000, 10, 4800, 48000, 0.1);
as = AudioSource('encodedSound', signal, FS, REPEAT_CNT, SIGNAL_GAIN);

dummyas = AudioSource('dummySound', signal, FS, REPEAT_CNT, 0); % dummy audio source (with 0 gain) to be played at rx
dummyas.preambleGain = 0;

%--------------------------------------------------------------------------
% 3. parse settings (later used in DecodeCallback)
%--------------------------------------------------------------------------
global PS; PS = struct(); % parse setting, easy for the callback to get
PS.codes = codes;
PS.dataSent = data;

%--------------------------------------------------------------------------
% 4. build sensing server
%--------------------------------------------------------------------------
% NOTE: DummyCallback is used so no signal received at tx will be parsed
txss = SensingServer(TX_SERVER_PORT, @DummyCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
txss.startSensingAfterConnectionInit = 0; % avoid auto sensing
pause(1.0); % wait some time before building the next server

% NOTE: dummyas is used for simplifying the implementaion (so rx knows how to detect preambles)
rxss = SensingServer(RX_SERVER_PORT, @DecodeCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, dummyas);
rxss.startSensingAfterConnectionInit = 0;
rxss.addSlaveServer(txss);