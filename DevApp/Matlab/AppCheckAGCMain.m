%==========================================================================
% 2017/05/13: check if AGC is on or off
%==========================================================================
%close all;
SERVER_PORT = 50005; % remember to diable firewall for this port
close all;

import edu.umich.cse.yctung.*

JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);

% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source
FS = 48000;
SIGNAL_LEN = FS*3;
SIGNAL_FREQ = 2000;
GAIN_WIN = [1:SIGNAL_LEN]/SIGNAL_LEN;

signal = zeros(SIGNAL_LEN, 1);
time = (0:SIGNAL_LEN-1)./FS; 
signal(1:SIGNAL_LEN) = sin(2*pi*SIGNAL_FREQ*time).*GAIN_WIN;
signal = signal(:);

as.signal = signal;
as.repeatCnt = 5;
as.signalGain = 0.9;
as.preambleGain = 0.5;
as.outputAudioSourceToWav('latestAudioToCheckAGC.wav');

ss = SensingServer(SERVER_PORT, @AppCheckAGCCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing

%fprintf(2,'<<<<<< wiats for device connected >>>>>>\n');
%ss.waitfor('ACTION_INIT');
%ss.startSensing();


%global dataCellBuf;
% save('TempResultForPaper/resultCheckAGC_temp','dataCellBuf');