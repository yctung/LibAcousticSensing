
%load('resultOk.mat')

plotRange = [160:270];

peakBufToPlot = peakBuf(plotRange);

peakRef = peakBufToPlot(1);
diffBinIdxs = peakBufToPlot-peakRef;

diffFreqs = DF*diffBinIdxs/PS.downsampleFactor;
diffVels = diffFreqs*(34000)/PS.SIGNAL_FREQ;
accDists = cumsum(diffVels*(PS.PERIOD/PS.FS));

h_f = figure;
hold on;
plot(diffVels,'linewidth',2);
plot(accDists,'--','linewidth',2);
hold off;
axis off;
box off;
h_l = legend('v','d');
set(h_l,'box','off');

saveas(h_f, 'app_doppler_result_all','epsc');