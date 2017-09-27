%==========================================================================
% 2017/03/28: This is tuning for the pilot synchronization
%==========================================================================
%close all;
SERVER_PORT = 50005; % remember to diable firewall for this port
close all;
JavaSensingServer.closeAll(); % close all previous open socket
pause(1.0);

% build dummy "audible" audios for knowing the sound is played correctly on device
as = AudioSource(); % default audio source
time = 0:1/48000:0.1; 
signal = floor(chirp(time, 0, time(end), 1000).*400);
signal = signal./max(abs(signal));
signal = signal'; % row-based signal
as.signal = signal;
as.repeatCnt = 5;
as.signalGain = 0.1;


ss = SensingServer(SERVER_PORT, @AppTuningPreambleDummyCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing
%ss.startSensing();

% wait for 
fprintf(2,'<<<<<< wiats for device connected >>>>>>\n');
%waitfor(0,'UserData','ACTION_INIT');
ss.waitfor('ACTION_INIT');

%PREAMBLE_GAINS = [0.05:0.01:0.1];
PREAMBLE_GAINS = [0:0.001:0.01];
PREAMBLE_GAIN_CNT = length(PREAMBLE_GAINS);
REPEAT_CNT = 25;
%REPEAT_CNT = 10;
preambleDetectResults = zeros(PREAMBLE_GAIN_CNT, REPEAT_CNT);
for gainIdx = PREAMBLE_GAIN_CNT:-1:2,
    ss.audioSource.preambleGain = PREAMBLE_GAINS(gainIdx) 
    ss.sendMediaData();
    
    for repeatIdx = 1:REPEAT_CNT,
        pause(3.0);

        fprintf(2,'<<<<<< sensing (%d,%d) starts >>>>>>\n',gainIdx,repeatIdx);
        ss.startSensing();

        fprintf(2,'       wiats ACTION_SENSING_END\n');
        ss.waitfor('ACTION_SENSING_END');
        preambleDetectResults(gainIdx, repeatIdx) = ss.isPreambleDetectedCorrectly;
        
        ss.setWaitFlag('NONE'); % reset the flag for the next wait

        % TODO: check senisng result
        fprintf(2,'<<<<<< sensing (%d,%d) ends >>>>>>\n',gainIdx,repeatIdx);
    end
end
mean(preambleDetectResults,2)

save('TempResultForPaper/resultTunePreambleGain_temp', 'preambleDetectResults', 'PREAMBLE_GAINS');