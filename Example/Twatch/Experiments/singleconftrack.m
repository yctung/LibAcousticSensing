function [confident, newpeak]= singleconftrack (prevcorr, thiscorr, fromPeak, varargin)
    previous_peaks = findNeighborPeaks(prevcorr, fromPeak);
    
    hypotheses = -3:3;
    [this_peaks, probabilities, hyp_peaks] = findBestHypothesisFirstOrder(...
            prevcorr,  ...
            thiscorr, ...
            previous_peaks, ...
            hypotheses);
    
    [sorted, ~] = sort(probabilities, 'descend');
    largest = sorted(1);
    secondLargest = sorted(2);
    confident = 1;
    
    if length(varargin) == 0
        ConfThresh = 2.0;
    else
        ConfThresh = varargin{1};
    end
    
    if largest < ConfThresh*secondLargest
        confident = 0;
        nearNeighborWindow = 2:6;
        [~, maxHypIdx] = max(thiscorr(hyp_peaks(nearNeighborWindow,3)));
        this_peaks = hyp_peaks(maxHypIdx+nearNeighborWindow(1)-1, :);
    end
    
    newpeak = this_peaks(3);
end