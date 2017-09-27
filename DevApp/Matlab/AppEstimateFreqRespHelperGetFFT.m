function [ dataFreq ] = AppEstimateFreqRespHelperGetFFT( data )
%APPESTIMATEFREQRESPHELPERGETFFT Summary of this function goes here
%   Detailed explanation goes here
    dataFreq = abs(fft(data));
    dataFreq = dataFreq(1:floor(size(dataFreq,1)/2),:);
    %dataFreq = smooth(dataFreq, 100);
    
    traceCnt = size(data,2);
    
    for traceIdx = 1:traceCnt,
        dataFreq(:,traceIdx) = smooth(abs(dataFreq(:,traceIdx)),100);
    end
end

