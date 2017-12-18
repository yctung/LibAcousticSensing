function [confident, newpeak]= singleconftrack (prevcorr, thiscorr, fromPeak, ConfThresh, NearWindow)
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
    
    if largest < ConfThresh*secondLargest
        confident = 0;
        nearNeighborWindow = (4-NearWindow):(4+NearWindow);
        %nearNeighborWindow = 2:6;
        [~, maxHypIdx] = max(thiscorr(hyp_peaks(nearNeighborWindow,3)));
        this_peaks = hyp_peaks(maxHypIdx+nearNeighborWindow(1)-1, :);
    end
    
    newpeak = this_peaks(3);
end