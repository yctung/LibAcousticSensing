%==========================================================================
% 2017/03/29: 
%==========================================================================
SERVER_PORT = 50005; % remember to diable firewall for this port
close all;
import edu.umich.cse.yctung.*

JavaSensingServer.closeAll(); % close all previous open socket

% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source
time = 0:1/48000:0.1; 
signal = floor(chirp(time, 0, time(end), 1000).*400);
signal = signal./max(abs(signal));
signal = signal'; % row-based signal
as.signal = signal;
as.repeatCnt = 500;
as.signalGain = 0.1;

ss = SensingServer(SERVER_PORT, @ServerAppFeatureTrainCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
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
