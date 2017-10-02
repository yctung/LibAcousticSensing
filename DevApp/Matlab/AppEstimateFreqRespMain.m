%==========================================================================
% 2017/05/13: check if AGC is on or off
%==========================================================================
%close all;
SERVER_PORT = 50005; % remember to diable firewall for this port

import edu.umich.cse.yctung.*

close all;
JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);

% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source
time = 0:1/48000:4;
signal = chirp(time, 0, time(end), 24000);
signal = signal./max(abs(signal));
signal = signal'; % row-based signal
as.signal = signal;
as.repeatCnt = 5;
as.signalGain = 0.5;
as.preambleGain = 0.5;
as.outputAudioSourceToWav('latestAudioToEstimateFreqResp.wav');

ss = SensingServer(SERVER_PORT, @AppEstimateFreqRespCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing

%global dataCellBuf;
% save('TempResultForPaper/resultEstimateFreqResp_temp','dataCellBuf');