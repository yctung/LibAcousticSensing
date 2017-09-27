function [ meanRatio, meanRatioDb ] = CalDiffAmp( targetTracePath, refTracePath, rangeMeters, chIdx)
% Function to estiamte amp difference between two traces
    TRACE_SELECT_MODE_ALL = 0;
    TRACE_SELECT_MODE_USER_DATA_ONLY = 1;
    if ~exist('targetTracePath', 'var')
        targetTracePath = 'Traces/6p_mic_2m_1.mat'
        refTracePath = 'Traces/6p_mic_base_1.mat'
        %rangeMeters = [2.8, 3.2] % for 3m
        rangeMeters = [1.8, 2.2] % for 2m
        chIdx = 2 % only support 1 ch for plot
        traceSelectMode = TRACE_SELECT_MODE_USER_DATA_ONLY;
    end

    
    tracePaths = {refTracePath, targetTracePath};
    traceCnt = length(tracePaths);
    refAll = cell(traceCnt, 1);
    for traceIdx = 1:traceCnt
        tracePath = tracePaths{traceIdx};
        
        load(tracePath);
        r = result;

        rangeMask = find(r.dsXMeters>=rangeMeters(1) & r.dsXMeters<=rangeMeters(2));

        if traceSelectMode == TRACE_SELECT_MODE_ALL
            refs = r.dsDetectsAll(:, :, chIdx);
        elseif traceSelectMode == TRACE_SELECT_MODE_USER_DATA_ONLY
            assert(r.userStartsEnd > 0 && r.userEndsEnd > 0 && r.userStartsEnd == r.userEndsEnd, sprintf('[ERROR]: user data mismatch: userStartsEnd = %d, userEndsEnd = %d', r.userStartsEnd, r.userEndsEnd));
            traceIdxs = [];
            for startIdx = 1:r.userStartsEnd,
                traceIdxs = [traceIdxs, r.userStarts(startIdx):r.userEnds(startIdx)];
            end
            refs = r.dsDetectsAll(:, traceIdxs, chIdx);
        else
            fprintf(2,'[ERROR]: undefined traceSelectMode = %d\n', traceSelectMode);
        end
        refAll{traceIdx} = refs;
    end
    
    % plot figure
    h_f = figure; hold on;
    for traceIdx = 1:traceCnt
        data = 10*log10(refAll{traceIdx});
        plot(mean(data, 2));
    end
    ynow = ylim;
    ymin = ynow(1); ymax = ynow(2);
    plot([rangeMask(1), rangeMask(1)], [ymin, ymax], 'g--', 'linewidth', 2);
    plot([rangeMask(end), rangeMask(end)], [ymin, ymax], 'g--', 'linewidth', 2);
    
    [~, diff] = CalDiffAmp(targetTracePath, refTracePath, rangeMeters, chIdx)
end

