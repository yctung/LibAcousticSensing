%==========================================================================
% 2017/06/10: tune squeeze
%==========================================================================

global detectResultsAll;
global detectResultsAllEnd;
global detectResultsAllSqueezeStartIdxs;
global detectResultsAllSqueezeEndIdxs;

squeezeCnt = length(detectResultsAllSqueezeStartIdxs);

figure; hold on;
plot(detectResultsAll(1:detectResultsAllEnd),'b');
lineMin = min(detectResultsAll);
lineMax = max(detectResultsAll);

for squeezeIdx = 1:squeezeCnt
    startIdx = detectResultsAllSqueezeStartIdxs(squeezeIdx);
    endIdx = detectResultsAllSqueezeEndIdxs(squeezeIdx);
    plot([startIdx, startIdx],[lineMin, lineMax],'r');
    plot([endIdx, endIdx],[lineMin, lineMax],'g');
    
    s = detectResultsAll(startIdx:endIdx);
    SqueezeDetect(smooth(s,3))
    
end
    
   