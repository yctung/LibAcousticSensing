%==========================================================================
% 2017/03/29: First version used in the paper submission
% 2017/10/21: Clean the code in the new style
%==========================================================================

% 1. clean JavaSensingServer
SERVER_PORT = 50005; % remember to diable firewall for this port
close all;
import edu.umich.cse.yctung.*
JavaSensingServer.closeAll(); % close all previous open socket

%--------------------------------------------------------------------------
% 1. signal settings
%--------------------------------------------------------------------------
FS = 48000;
PERIOD = 2400;
CHIRP_LEN = 1200;
CHIRP_FREQ_START = 5000;
CHIRP_FREQ_END = 10000;
APPLY_FADING_TO_SIGNAL = 1;
FADING_RATIO = 0.1; % smaller means less fading window
REPEAT_CNT = 10;
SIGNAL_GAIN = 0.8;

%--------------------------------------------------------------------------
% 2. build customized preambles
%--------------------------------------------------------------------------
PREAMBLE_TYPE = 'CHIRP';            % only support chirp preambles now
PREAMBLE_FREQS = [22000, 15000];    % [start freq, end freq] in Hz
PREAMBLE_LENS = [500, 1000];        % [length of real signals, length of single repeatition]
PREAMBLE_FS = 48000;                % sample rate (should be consistent to the sensing signals)
PREAMBLE_REPEAT_CNT = 10;           % number of sync to be played
PREAMBLE_START_OFFSET = 4800;       % number of silent samples before the preamble is played
PREAMBLE_END_OFFSET = 4800;         % number of silent samples after the preamble is played
PREAMBLE_FADING_RATIO = -1;         % -1 menas no fading
preamble = PreambleBuilder(PREAMBLE_TYPE, PREAMBLE_FREQS, PREAMBLE_LENS, PREAMBLE_FS, PREAMBLE_REPEAT_CNT, PREAMBLE_START_OFFSET, PREAMBLE_END_OFFSET, PREAMBLE_FADING_RATIO);

%--------------------------------------------------------------------------
% 3. build sensing signal and AudioSource object
%    NOTE: here the sensing signal is just a audible dummy signal to know
%          the sound is played by the device correctly
%--------------------------------------------------------------------------
signal = zeros(PERIOD, 1);
time = (0:CHIRP_LEN-1)./FS; 
signal(1:CHIRP_LEN) = chirp(time, CHIRP_FREQ_START, time(end), CHIRP_FREQ_END);
as = AudioSource('dummySound', signal, FS, REPEAT_CNT, SIGNAL_GAIN, preamble);

%--------------------------------------------------------------------------
% 4. create server
%--------------------------------------------------------------------------
% NOTE: no parsing since we only care about the preabmel

global ss; % TODO: find a better way instead of using a global variable
ss = SensingServer(SERVER_PORT, @DummyCallback, SensingServer.DEVICE_AUDIO_MODE_PLAY_AND_RECORD, as);
ss.startSensingAfterConnectionInit = 0; % avoid auto sensing

%--------------------------------------------------------------------------
% 5. loop for experiemnts on testing preamble detection
%--------------------------------------------------------------------------

PREAMBLE_GAINS = [0.05:0.01:0.1];
%PREAMBLE_GAINS = [0:0.001:0.01];
PREAMBLE_GAIN_CNT = length(PREAMBLE_GAINS);
REPEAT_CNT = 25;
%REPEAT_CNT = 10;

fprintf(2,'<<<<<< wiats for device connected >>>>>>\n');
%waitfor(0,'UserData','ACTION_INIT');
ss.waitfor('ACTION_INIT');

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
