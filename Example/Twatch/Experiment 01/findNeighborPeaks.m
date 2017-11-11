function neighbor_peaks = findNeighborPeaks (xcorr, thispeak)
    [~, locs] = findpeaks(xcorr);
    MAXLEN = length(locs);
    distance = abs(locs - thispeak);
    [~, I] = min(distance);
    nearestPeak = locs(I);
    
    neighbor_peaks = zeros(1,5);
    neighbor_peaks(5) = locs(max(1, min(MAXLEN, I+2)));
    neighbor_peaks(4) = locs(max(1, min(MAXLEN, I+1)));
    neighbor_peaks(3) = nearestPeak;
    neighbor_peaks(2) = locs(max(1, min(MAXLEN, I-1)));
    neighbor_peaks(1) = locs(max(1, min(MAXLEN, I-2)));
end