% NOTE: this result is based on the new experiments of 50 repetitions on
%       each setting made in 2017/12/08


% experiment of 50 repetitions
% maed in 2017/12/07
% settings: 0.1%,   1%,     10%,    100% 
s6      = [ 1.0,     1,    1,    0.98];     
gear3   = [ 0,       0.94,   0.98,   0.96];
iphone6 = [ 0.02,    0.28,   0.92,   0.98];

rateAll = [iphone6;gear3;s6]';

co = get(gca,'ColorOrder'); % Initial
colormap([co(1,:); co(2,:); co(3,:)])

labelAll = {'0.1', '1', '10', '100'};
         
figure; hold on;
plotConfig;

dataToPlot = rateAll;

co = get(gca,'ColorOrder'); % Initial
colormap([co(1,:); co(2,:); co(3,:)])
h_f = bar(dataToPlot, 'hist');

box off;
ylabel('Detection probability');
xlabel('Preamble volume (%)');

ylim([0, 1]);
xlim([0.5, length(labelAll)+0.5]);

set(gca,'xtick', 1:length(labelAll));
set(gca,'xticklabel', labelAll);

h_l = legend('iPhone 6s','Tizen Gear S3','Nexus 6P','location','southeast');
%set(h_l,'box','off')

hold off;

set(gcf, 'renderer', 'painters');
print(gcf, '-depsc2', './result_preamble_gain.eps');