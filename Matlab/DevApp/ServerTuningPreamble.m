%==========================================================================
% 2017/03/28: This is tuning for the pilot synchronization
%==========================================================================
%close all;
SERVER_PORT = 50005; % remember to diable firewall for this port


% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source
time = 0:1/48000:0.1; 
signal = floor(chirp(time, 0, time(end), 1000).*400);
signal = signal./max(abs(signal));
signal = signal'; % row-based signal
as.signal = signal;
as.repeatCnt = 5;
as.signalGain = 0.1;

ss = SensingServer(SERVER_PORT,@ServerDevCallback);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing
ss.startServer(as,ss.DEVICE_AUDIO_MODE_PLAY_AND_RECORD);
%ss.startSensing();

REPEAT_CNT = 10;
for repeatIdx = 1:REPEAT_CNT,
    waitfor(0,'UserData','ACTION_INIT');
    fprintf(2,'<<<<<< sensing repeatIdx = %d starts >>>>>>\n',repeatIdx);
    %ss.startSensing();
    waitfor(0,'UserData','ACTION_SENSING_END');
    
    % TODO: check senisng result
    fprintf(2,'<<<<<< sensing repeatIdx = %d ends >>>>>>\n',repeatIdx);
end

%ss.stopServer();
%temp=@(~,~)ss.socketReadCallback;