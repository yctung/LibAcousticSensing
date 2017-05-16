close all;

% gain = 50% and 20% in this example
% distance = 1m~7m
% exp is made on the floor, don't use the resultTunePreambleGain XXX
ResultsNote4To6p = [
    0.92, 0.96, 0.92, 0.80, 0.80, 0.72, 0.48
    0.96, 0.92, 0.92, 0.84, 0.76, 0.56, 0.24
    ];


h_f = figure;
plotConfig;
hold on;
plot(ResultsNote4To6p(1,:), '-', 'linewidth', LINE_WIDTH);
plot(ResultsNote4To6p(2,:), '--', 'linewidth', LINE_WIDTH);
hold off;

ylabel('Detect probability');
xlabel('Distance (m)');
xlim([0.5,7.5]);
ylim([0,1]);
box off;

h_l = legend('Note4-Nexus6p (50% volume)', 'Note4-Nexus6p (20% volume)', 'location', 'southwest');
set(h_l, 'box', 'off');

saveas(h_f,'TempResultForPaper/result_preamble_distance','epsc');
LibFixDottedline('TempResultForPaper/result_preamble_distance.eps');