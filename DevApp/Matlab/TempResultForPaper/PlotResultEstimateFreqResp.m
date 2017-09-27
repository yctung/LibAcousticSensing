close all;

traceIdx = 3;
load('resultEstimateFreqResp_iphone5c_up_onhand.mat');
freq_5c_up = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_iphone5c_down_onhand.mat');
freq_5c_down = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_iphone6s_down_onhand.mat');
freq_6s_down = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_iphone6s_up_onhand.mat');
freq_6s_up = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_s5_recog_onhand.mat');
freq_s5_recog_onhand = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_s5_mic_onhand.mat');
freq_s5_mic_onhand = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_s4_recog_onhand.mat');
freq_s4_recog_onhand = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_s4_mic_onhand.mat');
freq_s4_mic_onhand = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_s4_cam_onhand.mat');
freq_s4_cam_onhand = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

load('resultEstimateFreqResp_nexus6p_mic_onhand.mat');
freq_6p_mic_onhand = AppEstimateFreqRespHelperGetFFT(dataCellBuf{traceIdx});

tags = {};
tagEnd = 0;

figure;
hold on;

%{
plot(log10(freq_5c_up)); tags{tagEnd+1} = '5c up'; tagEnd = tagEnd+1;
plot(log10(freq_5c_down)); tags{tagEnd+1} = '5c down'; tagEnd = tagEnd+1;
plot(log10(freq_6s_down)); tags{tagEnd+1} = '6s down'; tagEnd = tagEnd+1;
plot(log10(freq_6s_up)); tags{tagEnd+1} = '6s up'; tagEnd = tagEnd+1;
%}


plot(log10(freq_s4_mic_onhand(:,1))); tags{tagEnd+1} = 's4 mic onhand ch1'; tagEnd = tagEnd+1;
plot(log10(freq_s4_mic_onhand(:,2))); tags{tagEnd+1} = 's4 mic onhand ch2'; tagEnd = tagEnd+1;
plot(log10(freq_s5_mic_onhand(:,1))); tags{tagEnd+1} = 's5 mic onhand ch1'; tagEnd = tagEnd+1;
plot(log10(freq_s5_mic_onhand(:,2))); tags{tagEnd+1} = 's5 mic onhand ch2'; tagEnd = tagEnd+1;


plot(log10(freq_6p_mic_onhand(:,1))); tags{tagEnd+1} = '6p mic onhand ch1'; tagEnd = tagEnd+1;
plot(log10(freq_6p_mic_onhand(:,2))); tags{tagEnd+1} = '6p mic onhand ch2'; tagEnd = tagEnd+1;


hold off;
legend(tags);

% Nexus 6p
h_f = figure;
plotConfig;
hold on;
PLOT_DOWN_SAMPLE_FACTOR = 1500;
timeRange = 500:96000-500;
len = size(downsample(10*log10(freq_s4_mic_onhand(timeRange,1)) , PLOT_DOWN_SAMPLE_FACTOR),1);
x = ((1:len)/len)*24000;
plot(x, downsample(10*log10(freq_s4_mic_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-', 'linewidth', LINE_WIDTH);
plot(x, downsample(10*log10(freq_s4_mic_onhand(timeRange,2)), PLOT_DOWN_SAMPLE_FACTOR), '--', 'linewidth', LINE_WIDTH);
%plot(x, downsample(10*log10(freq_s5_mic_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-.', 'linewidth', LINE_WIDTH);
%plot(x, downsample(10*log10(freq_s5_mic_onhand(timeRange,2)), PLOT_DOWN_SAMPLE_FACTOR), ':', 'linewidth', LINE_WIDTH);
plot(x, downsample(10*log10(freq_6p_mic_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-.', 'linewidth', LINE_WIDTH);
plot(x, downsample(10*log10(freq_6p_mic_onhand(timeRange,2)), PLOT_DOWN_SAMPLE_FACTOR), ':', 'linewidth', LINE_WIDTH);
ylabel('Amplitude (dB)');
xlabel('Frequency (Hz)');
ylim([0,75]);
%xlim([0,1.02]);
%h_l = legend('Galaxy S4 (ch1)', 'Galaxy S4 (ch2)', 'Galaxy S5 (ch1)', 'Galaxy S5 (ch2)', 'location', 'southwest');
h_l = legend('Galaxy S4 (mic ch1)', 'Galaxy S4 (mic ch2)', 'Nexus 6p (mic ch1)', 'Nexus 6p (mic ch2)', 'location', 'southwest');

set(h_l, 'box', 'off');
saveas(h_f,'TempResultForPaper/result_resp_diff_mic','epsc');
LibFixDottedline('TempResultForPaper/result_resp_diff_mic.eps');

h_f = figure;
plotConfig;
hold on;
plot(x, downsample(10*log10(freq_5c_up(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-', 'linewidth', LINE_WIDTH);
plot(x, downsample(10*log10(freq_5c_down(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '--', 'linewidth', LINE_WIDTH);
plot(x, downsample(10*log10(freq_6s_up(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-.', 'linewidth', LINE_WIDTH);
plot(x, downsample(10*log10(freq_6s_down(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), ':', 'linewidth', LINE_WIDTH);
ylabel('Amplitude (dB)');
xlabel('Frequency (Hz)');
ylim([0,50]);
h_l = legend('iPhone5c (top speaker)', 'iPhone5c (bottom speaker)', 'iPhone6s (top speaker)', 'iPhone6s (bottom speaker)', 'location', 'southwest');
set(h_l, 'box', 'off');
saveas(h_f,'TempResultForPaper/result_resp_diff_speaker','epsc');
LibFixDottedline('TempResultForPaper/result_resp_diff_speaker.eps');

