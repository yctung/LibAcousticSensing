function [ meanRatio, meanRatioDb ] = CalDiffAmp( targetTracePath, refTracePath, rangeMeters, chIdxs)
% Function to estiamte amp difference between two traces
    if ~exist('targetTracePath', 'var')
        targetTracePath = 'Traces/6p_mic_3m_2.mat'
        refTracePath = 'Traces/6p_mic_base_1.mat'
        rangeMeters = [2.8, 3.2] % 3 ~ 4 meters
    end

    % peakAmps is in the format of [traceCnt, chCnt]
    traceSelectMode = 1; % only consider user data
    targetPeakAmps = CalPeakAmp(targetTracePath, rangeMeters, traceSelectMode);
    refPeakAmps = CalPeakAmp(refTracePath, rangeMeters, traceSelectMode);
    
    
    meanRatio = mean(targetPeakAmps)./mean(refPeakAmps);
    meanRatioDb = 20*log10(meanRatio);
    
    if exist('chIdxs', 'var')
        meanRatio = meanRatio(chIdxs);
        meanRatioDb = meanRatioDb(chIdxs);
    end
end

