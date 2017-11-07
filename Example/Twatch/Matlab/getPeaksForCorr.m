function peakLocation = getPeaksForCorr (xcorr)
    [pks, locs] = findpeaks(xcorr);
    %[topPks, topPksIdx] = sort(pks, 'descend');
    [~, maxPkIdx] = max(pks);
    peakLocation = locs(maxPkIdx);
end
