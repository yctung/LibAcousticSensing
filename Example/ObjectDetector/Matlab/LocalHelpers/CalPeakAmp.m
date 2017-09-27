function [ peakAmps ] = CalPeakAmp( tracePath, rangeMeters, traceSelectMode, DEBUG_SHOW)
% function to estimate peak energy in the trace
    TRACE_SELECT_MODE_ALL = 0;
    TRACE_SELECT_MODE_USER_DATA_ONLY = 1;
    if ~exist('tracePath', 'var') % debug mode
        tracePath = 'Traces/test.mat'
        rangeMeters = [3, 4]; % 3 to 4 meters
        traceSelectMode = TRACE_SELECT_MODE_USER_DATA_ONLY;
        DEBUG_SHOW = 1;
    end

    load(tracePath);
    r = result;
    
    rangeMask = r.dsXMeters>=rangeMeters(1) & r.dsXMeters<=rangeMeters(2);
    
    if traceSelectMode == TRACE_SELECT_MODE_ALL
        refs = r.dsDetectsAll(rangeMask==1, :, :);
    elseif traceSelectMode == TRACE_SELECT_MODE_USER_DATA_ONLY
        assert(r.userStartsEnd > 0 && r.userEndsEnd > 0 && r.userStartsEnd == r.userEndsEnd, sprintf('[ERROR]: user data mismatch: userStartsEnd = %d, userEndsEnd = %d', r.userStartsEnd, r.userEndsEnd));
        traceIdxs = [];
        for startIdx = 1:r.userStartsEnd,
            traceIdxs = [traceIdxs, r.userStarts(startIdx):r.userEnds(startIdx)];
        end
        refs = r.dsDetectsAll(rangeMask==1, traceIdxs, :);
    else
        fprintf(2,'[ERROR]: undefined traceSelectMode = %d\n', traceSelectMode);
    end
    
    [maxVals, maxIdxs] = max(refs);
    peakAmps = squeeze(maxVals);
end

