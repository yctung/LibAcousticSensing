function [ output_args ] = ServerAppFeatureTrainFunc( input_args )
%SERVERAPPFEATURETRAINFUNC Summary of this function goes here
%   Detailed explanation goes here
%==========================================================================
% 2017/03/29: 
%==========================================================================
SERVER_PORT = 50005; % remember to diable firewall for this port
close all;
pnet('closeall');

% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source
time = 0:1/48000:0.1; 
signal = floor(chirp(time, 0, time(end), 1000).*400);
signal = signal./max(abs(signal));
signal = signal'; % row-based signal
as.signal = signal;
as.repeatCnt = 5;
as.signalGain = 0.1;

ss = SensingServer(SERVER_PORT, @ServerAppFeatureTrainCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing

%ss2 = SensingServer(SERVER_PORT+1, @ServerAppFeatureTrainCallback, ss.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
%ss2.startSensingAfterConnectionInit = 0; % avoid auto sensing
%ss.startServer(as,);

end

