close all;

traceIdx = 3;
chIdx = 1;

load('resultCheckAGC_nexus6p_mic_onhand.mat');
resp_6p_mic_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_nexus6p_recog_onhand.mat');
resp_6p_recog_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_nexus6p_cam_onhand.mat');
resp_6p_cam_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_s5_mic_onhand.mat');
resp_s5_mic_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_s5_recog_onhand.mat');
resp_s5_recog_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_s5_cam_onhand.mat');
resp_s5_cam_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_s4_cam_onhand.mat');
resp_s4_cam_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_zenwatch3_mic_onhand.mat');
resp_zw3_mic_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_zenwatch3_recog_onhand.mat');
resp_zw3_recog_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

load('resultCheckAGC_iphone6s_up_onhand.mat');
resp_iphone6s_up_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});
load('resultCheckAGC_iphone6s_down_onhand.mat');
resp_iphone6s_down_onhand = AppCheckAGCHelperGetResp(dataCellBuf{traceIdx});

tags = {};
tagEnd = 0;

figure;
hold on;

%plot(resp_6p_mic_onhand(:,1)); tags{tagEnd+1} = '6p mic onhand ch1'; tagEnd = tagEnd+1;
%plot(resp_6p_mic_onhand(:,2)); tags{tagEnd+1} = '6p mic onhand ch2'; tagEnd = tagEnd+1;
%plot(resp_6p_cam_onhand(:,1)); tags{tagEnd+1} = '6p cam onhand ch1'; tagEnd = tagEnd+1;
%plot(resp_6p_cam_onhand(:,2)); tags{tagEnd+1} = '6p cam onhand ch2'; tagEnd = tagEnd+1;
%plot(resp_6p_recog_onhand(:,1)); tags{tagEnd+1} = '6p recog onhand ch1'; tagEnd = tagEnd+1;

%{
plot(resp_zw3_mic_onhand(:,1)); tags{tagEnd+1} = 'zw3 mic onhand ch1'; tagEnd = tagEnd+1;
plot(resp_zw3_recog_onhand(:,1)); tags{tagEnd+1} = 'zw3 recog onhand ch1'; tagEnd = tagEnd+1;
plot(resp_s5_mic_onhand(:,1)); tags{tagEnd+1} = 's5 mic onhand ch1'; tagEnd = tagEnd+1;
plot(resp_s5_recog_onhand(:,1)); tags{tagEnd+1} = 's5 recog onhand ch1'; tagEnd = tagEnd+1;
plot(resp_s5_cam_onhand(:,1)); tags{tagEnd+1} = 's5 cam onhand ch1'; tagEnd = tagEnd+1;
%}

plot(resp_s4_cam_onhand(:,1)); tags{tagEnd+1} = 's4 cam onhand ch1'; tagEnd = tagEnd+1;
plot(resp_s4_cam_onhand(:,2)); tags{tagEnd+1} = 's4 cam onhand ch2'; tagEnd = tagEnd+1;

%plot(resp_iphone6s_up_onhand(:,1)); tags{tagEnd+1} = 'iPhone 6s up onhand'; tagEnd = tagEnd+1;
%plot(resp_iphone6s_down_onhand(:,1)); tags{tagEnd+1} = 'iPhone 6s down onhand'; tagEnd = tagEnd+1;

hold off;
legend(tags);

% Nexus 6p
h_f = figure;
plotConfig;
hold on;
PLOT_DOWN_SAMPLE_FACTOR = 1500;
timeRange = 1000:144000-1000;
len = length(downsample(MyNormalize(resp_6p_mic_onhand(timeRange,1)) , PLOT_DOWN_SAMPLE_FACTOR));
x = ((1:len)./len)*100;
plot(x, downsample(MyNormalize(resp_6p_mic_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-', 'linewidth', LINE_WIDTH);
plot(x, downsample(MyNormalize(resp_6p_cam_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '--', 'linewidth', LINE_WIDTH);
plot(x, downsample(MyNormalize(resp_6p_recog_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-.', 'linewidth', LINE_WIDTH);
ylabel('Normalized amplitude');
xlabel('Signal volume (%)');
xlim([0,1.02].*100);
h_l = legend('Nexus 6p (MIC)', 'Nexus 6p (CAMCORDER)', 'Nexus 6p (VOICE\_RECOGNITION)', 'location', 'southeast');
set(h_l, 'box', 'off');
saveas(h_f,'TempResultForPaper/result_agc_off','epsc');
LibFixDottedline('TempResultForPaper/result_agc_off.eps');

h_f = figure;
plotConfig;
hold on;
plot(x, downsample(MyNormalize(resp_s4_cam_onhand(timeRange,2)), PLOT_DOWN_SAMPLE_FACTOR), '-', 'linewidth', LINE_WIDTH);
plot(x, downsample(MyNormalize(resp_s5_mic_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '--', 'linewidth', LINE_WIDTH);
plot(x, downsample(MyNormalize(resp_zw3_mic_onhand(timeRange,1)), PLOT_DOWN_SAMPLE_FACTOR), '-.', 'linewidth', LINE_WIDTH);
ylabel('Normalized amplitude');
xlabel('Signal volume (%)');
xlim([0,1.02].*100);
h_l = legend('Galaxy S4 (CAMCORDER)', 'Galaxy S5 (MIC)', 'Zenwatch 3 (MIC)', 'location', 'southeast');
set(h_l, 'box', 'off');
saveas(h_f,'TempResultForPaper/result_agc_on','epsc');
LibFixDottedline('TempResultForPaper/result_agc_on.eps');