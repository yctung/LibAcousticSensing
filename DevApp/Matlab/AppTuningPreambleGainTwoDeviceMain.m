%==========================================================================
% 2017/03/28: This is tuning for the pilot synchronization
% 2017/05/13: used to tune preamble gain on another device
%==========================================================================
TX_SERVER_PORT = 50005; % remember to diable firewall for this port
RX_SERVER_PORT = 50006; % remember to diable firewall for this port
import edu.umich.cse.yctung.*

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
as.signalGain = 0.005;

dummyas = AudioSource(); % dummy audio source (with 0 gain) to be played at rx
dummyas.repeatCnt = as.repeatCnt;
dummyas.signal = as.signal;
dummyas.signalGain = 0;
dummyas.preambleGain = 0;

% NOTE: DummyCallback is used so no signal received at tx will be parsed
txss = SensingServer(TX_SERVER_PORT, @AppTuningPreambleDummyCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
txss.startSensingAfterConnectionInit = 0; % avoid auto sensing
pause(1.0); % wait some time before building the next server

% NOTE: dummyas is used for simplifying the implementaion (so rx knows how to parse the signal)
rxss = SensingServer(RX_SERVER_PORT, @AppTuningPreambleDummyCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, dummyas);
rxss.startSensingAfterConnectionInit = 0;
rxss.addSlaveServer(txss);


% wait for 
fprintf(2,'<<<<<< wiats for device connected >>>>>>\n');
%waitfor(0,'UserData','ACTION_INIT');
txss.waitfor('ACTION_INIT');
rxss.waitfor('ACTION_INIT');

%PREAMBLE_GAINS = [0.05:0.01:0.1];
%PREAMBLE_GAINS = [0.5, 1];
PREAMBLE_GAINS = [0.5, 0.2];
%PREAMBLE_GAINS = [0:0.001:0.01];
PREAMBLE_GAIN_CNT = length(PREAMBLE_GAINS);
REPEAT_CNT = 25;
txPreambleDetectResults = zeros(PREAMBLE_GAIN_CNT, REPEAT_CNT);
rxPreambleDetectResults = zeros(PREAMBLE_GAIN_CNT, REPEAT_CNT);
for gainIdx = 1:PREAMBLE_GAIN_CNT,
    %txss.audioSource.preambleGain = PREAMBLE_GAINS(gainIdx) 
    %txss.sendMediaData();
    
    for repeatIdx = 1:REPEAT_CNT,
        pause(5.0);

        fprintf(2,'<<<<<< sensing (%d,%d) starts >>>>>>\n',gainIdx,repeatIdx);
        rxss.startSensing(); % rxss is the master server

        fprintf(2,'       wiats ACTION_SENSING_END\n');
        
        %waitfor(0,'UserData','ACTION_SENSING_END');
        txss.waitfor('ACTION_SENSING_END');
        rxss.waitfor('ACTION_SENSING_END');
        
        txPreambleDetectResults(gainIdx, repeatIdx) = txss.isPreambleDetectedCorrectly;
        rxPreambleDetectResults(gainIdx, repeatIdx) = rxss.isPreambleDetectedCorrectly;
        
        %set(0,'UserData','NONE'); % reset the control variable to wait back to init value
        txss.setWaitFlag('NONE');
        rxss.setWaitFlag('NONE');
        
        % TODO: check senisng result
        fprintf(2,'<<<<<< sensing (%d,%d) ends >>>>>>\n',gainIdx,repeatIdx);
    end
end

txPreambleDetectResults
rxPreambleDetectResults

mean(rxPreambleDetectResults,2)

save('TempResultForPaper/resultTunePreambleGain_note4_to_nexus6p_temp', 'txPreambleDetectResults', 'rxPreambleDetectResults', 'PREAMBLE_GAINS');