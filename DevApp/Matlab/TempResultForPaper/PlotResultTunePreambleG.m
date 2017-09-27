close all;


load('resultTunePreambleGain_note4_onfloor.mat');
prob_note4 = mean(preambleDetectResults,2);
load('resultTunePreambleGain_s5_onchair_ok.mat');
prob_s5 = mean(preambleDetectResults,2);
load('resultTunePreambleGain_nexus6p_ontable_tohigh_25round.mat');
prob_6p = mean(preambleDetectResults,2);


h_f = figure;
plotConfig;
hold on;
PLOT_SCALE = 100;
plot(PREAMBLE_GAINS*PLOT_SCALE, prob_note4, '-', 'linewidth', LINE_WIDTH);
plot(PREAMBLE_GAINS*PLOT_SCALE, prob_6p, '--', 'linewidth', LINE_WIDTH);
plot(PREAMBLE_GAINS*PLOT_SCALE, prob_s5, '-.', 'linewidth', LINE_WIDTH);
hold off;

ylabel('Detect probability');
xlabel('Preamble volume (%)');
xlim([0,0.0104]*PLOT_SCALE);
ylim([0,1]);
box off;

h_l = legend('Note4', 'Nexus 6p', 'Galaxy 5s', 'location', 'southeast');
set(h_l, 'box', 'off');

saveas(h_f,'TempResultForPaper/result_preamble_gain','epsc');
LibFixDottedline('TempResultForPaper/result_preamble_gain.eps');