global detectResultsAll;
global detectResultsAllEnd;

peaks = detectResultsAll(1:detectResultsAllEnd);

figure;
cdfplot(peaks);


GROUND_TRUTH = 600;
peakAccs = sum(peaks==GROUND_TRUTH)/length(peaks)
peakErrs = sum(abs(peaks-GROUND_TRUTH))/length(peaks)
