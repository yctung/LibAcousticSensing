%==========================================================================
% 2017/06/22: Script to parse different device detect reslts for TMC paper
%           : NOTE: all reg traces collectd with VOICE_RECOGNITION flag
%           :       while mic traces collected with MIC flag
%==========================================================================
close all;

% DONT set it too large, otherwise might include the reflections from the
% floor
RANGES_3M = [2.8, 3.2];
RANGES_2M = [1.8, 2.2];

allTags = {};
all2ms = [];
all3ms = [];

% S4 -> baseline, not working
[~, d_s4_3m] = CalDiffAmp('Traces/s4_reg_3m_1', 'Traces/s4_reg_base_1', RANGES_3M, 1)
[~, d_s4_2m] = CalDiffAmp('Traces/s4_reg_2m_1', 'Traces/s4_reg_base_1', RANGES_2M, 1)
allTags = [allTags, 'S4']; all2ms = [all2ms, d_s4_2m]; all3ms = [all3ms, d_s4_3m];

% s5 -> might be ok
[~, d_s5_3m] = CalDiffAmp('Traces/s5_reg_3m_1', 'Traces/s5_reg_base_1', RANGES_3M, 1)
[~, d_s5_2m] = CalDiffAmp('Traces/s5_reg_2m_1', 'Traces/s5_reg_base_1', RANGES_2M, 1)
allTags = [allTags, 'S5']; all2ms = [all2ms, d_s5_2m]; all3ms = [all3ms, d_s5_3m];

% s7 -> not working
[~, d_s7_3m] = CalDiffAmp('Traces/s7_mic_3m_1', 'Traces/s7_mic_base_1', RANGES_3M, 1)
[~, d_s7_2m] = CalDiffAmp('Traces/s7_mic_2m_1', 'Traces/s7_mic_base_1', RANGES_2M, 1)
allTags = [allTags, 'S7']; all2ms = [all2ms d_s7_2m]; all3ms = [all3ms, d_s7_3m];



% s8 -> working
[~, d_s8_3m] = CalDiffAmp('Traces/s8_mic_3m_2', 'Traces/s8_mic_base_2', RANGES_3M, 1)
[~, d_s8_2m] = CalDiffAmp('Traces/s8_mic_2m_1', 'Traces/s8_mic_base_2', RANGES_2M, 1)
allTags = [allTags, 'S8']; all2ms = [all2ms, d_s8_2m]; all3ms = [all3ms, d_s8_3m];


% Note 4s -> best
[~, d_note4_3m] = CalDiffAmp('Traces/note4_reg_3m_1', 'Traces/note4_reg_base_1', RANGES_3M, 1)
[~, d_note4_2m] = CalDiffAmp('Traces/note4_reg_2m_1', 'Traces/note4_reg_base_1', RANGES_2M, 1)
allTags = [allTags, 'Note4']; all2ms = [all2ms, d_note4_2m]; all3ms = [all3ms, d_note4_3m];

% 6p -> best
[~, d_6p_3m] = CalDiffAmp('Traces/6p_mic_3m_2', 'Traces/6p_mic_base_1', RANGES_3M, 2)
[~, d_6p_2m] = CalDiffAmp('Traces/6p_mic_2m_1', 'Traces/6p_mic_base_1', RANGES_2M, 2)
allTags = [allTags, 'Nexus6P']; all2ms = [all2ms, d_6p_2m]; all3ms = [all3ms, d_6p_3m];

h_f = figure;
PlotConfig;

oldB = [70,0,255]/255;
oldY = [252,215,51]/255;

%co = get(gca,'ColorOrder'); % Initial

%co(1,:) = oldB;
%co(2,:) = oldB;
%set(gca, 'ColorOrder', co);

%{
colormap([oldB; oldY]);
h_b = bar([all2ms; all3ms]');

%}

gw = 0.5 ; % almost touching, 1 is touching
x = 1:length(all2ms);
fig(1) = bar(x-gw/4,all2ms,gw/2,'b') ;
hold on ;
fig(2) = bar(x+gw/4,all3ms,gw/2,'r') ;
hold off ;

set(fig(1),'FaceColor',oldB) ;
set(fig(2),'FaceColor',oldY) ;

set(gca,'XTick', x);
set(gca,'XTickLabel',allTags);
ylabel('Detect energy ratio (dB)');
xlabel('Devices');
h_l = legend('2m','3m','location','northwest');
set(h_l, 'box', 'off');
box off;

saveas(h_f,'Figures/result_cross_device','epsc');
%set(gcf, 'renderer', 'painters');
%print(gcf, '-depsc2', 'Figures/result_cross_device.eps');


