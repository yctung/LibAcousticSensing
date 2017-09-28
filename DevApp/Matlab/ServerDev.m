%==========================================================================
% 2017/01/26: This is a demo for the LibAcousticSensing server module
%==========================================================================
%close all;
SERVER_PORT = 50005; % remember to diable firewall for this port
import edu.umich.cse.yctung.*

as = AudioSource(); % default audio source

% *** this signal is used only for debugging ***
time = 0:1/48000:0.1;
%time = 0:1/48000:0.5;
signal = floor(chirp(time, 0, time(end), 1000).*400);
signal = signal./max(abs(signal));
signal = signal'; % row-based signal

as.signal = signal;
as.repeatCnt = 25;
as.signalGain = 0.001;
%signal = zeros(48000,1);

ss = SensingServer(SERVER_PORT,@ServerDevCallback);
ss.startServer(as,ss.DEVICE_AUDIO_MODE_PLAY_AND_RECORD);
%ss.startSensing();

%ss.stopServer();
%temp=@(~,~)ss.socketReadCallback;
