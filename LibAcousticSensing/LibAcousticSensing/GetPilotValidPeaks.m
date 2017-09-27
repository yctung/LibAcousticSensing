function [ validPeakIdxs ] = GetPilotValidPeaks( con, thres, window , DEBUG_SHOW)
% 15/10/04: this function returns peaks in windows
    CHECK_RATIO = 2;

    
    assert(size(con,2)==1, '[ERROR]: LibGetValidPeaks only supports vector input right now');
    
    peaks = con > thres;
    peakIdxs = find(peaks>0);
    
    validPeakIdxs = [];
    validPeakCnt = 0;
    idxsIdx = 1;
    %for i = 1:length(peakIdxs),
    while idxsIdx <= length(peakIdxs),
        idxNow = peakIdxs(idxsIdx); 
        idxRangeInWindow = find(peakIdxs - idxNow >= 0 & peakIdxs - idxNow < window );
        
        % use the maxium value as the real peak
        [~,maxPeakIdx] = max(con(peakIdxs(idxRangeInWindow)));
        
        validPeakCnt = validPeakCnt+1;
        validPeakIdxs(validPeakCnt) = peakIdxs(idxRangeInWindow(maxPeakIdx));
        
        % this is only used for sanilty check
        idxRangeCheck = find(peakIdxs - idxNow >= 0 & peakIdxs - idxNow < CHECK_RATIO*window );
        if length(idxRangeCheck) > length(idxRangeInWindow),
            fprintf('[WARN]: find additioanl peaks outside the window at %d (need a large window?)\n', maxPeakIdx)
        end
        
        % update idxsIdx
        idxsIdx = idxsIdx + length(idxRangeInWindow);
    end

    if exist('DEBUG_SHOW','var') && DEBUG_SHOW > 0,
        figure; hold on;
        plot(con, 'b');
        plot([0,length(con)], [thres, thres], 'k', 'linewidth', 2);
        plot(validPeakIdxs, con(validPeakIdxs), 'ro', 'linewidth', 2);
        
        figure;
        %cdfplot(validPeakIdxs(2:end) - validPeakIdxs(1:end-1));
        plot(validPeakIdxs(2:end) - validPeakIdxs(1:end-1), 'o');
    end
end

