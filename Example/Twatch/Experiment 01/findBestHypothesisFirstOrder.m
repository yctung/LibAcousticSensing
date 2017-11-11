function [curr_peaks, probabilities, hyp_peaks] = findBestHypothesisFirstOrder(previousxcorr, xcorr, previous_peaks, hypotheses)
    [~, locs] = findpeaks(xcorr);
    MAXLEN = length(locs);
    currpeak = previous_peaks(3);
    curr_magnitudes = previousxcorr(previous_peaks);
    idx = find(locs == currpeak);
    if isempty(idx)
        distance = abs(locs - currpeak);
        [~, idx] = min(distance);
    end
    
    
    errors = zeros(size(hypotheses));
    hyp_peaks = zeros(length(hypotheses), 5);
    for hidx=1:length(hypotheses)
        hyp = hypotheses(hidx);
        
        % If we're too close to the edge, we won't be able to find all the
        % peaks. If we are out of bounds, we'll just use the first peak
        
        hyp_peaks(hidx, 1) = locs(max(1, min(MAXLEN, idx+hyp-2)));
        hyp_peaks(hidx, 2) = locs(max(1, min(MAXLEN, idx+hyp-1)));
        hyp_peaks(hidx, 3) = locs(max(1, min(MAXLEN, idx+hyp)));
        hyp_peaks(hidx, 4) = locs(max(1, min(MAXLEN, idx+hyp+1)));
        hyp_peaks(hidx, 5) = locs(max(1, min(MAXLEN, idx+hyp+2)));
        
        hyp_magnitudes = xcorr(hyp_peaks(hidx,:));
        adjusted_curr_mags = curr_magnitudes(:);
        
        abserrors = abs(adjusted_curr_mags-hyp_magnitudes);
        errors(hidx) = mean(abserrors);
    end
    
    probabilities = 1 ./ errors;
    probabilities = probabilities / sum(probabilities);
    [~, max_idx] = max(probabilities);
    curr_peaks = hyp_peaks(max_idx, :);
end