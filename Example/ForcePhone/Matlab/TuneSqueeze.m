%==========================================================================
% 2017/06/10: tune squeeze
%==========================================================================

global detectResultsAll;
global detectResultsAllEnd;
global detectResultsAllSqueezeStartIdxs;
global detectResultsAllSqueezeEndIdxs;

%sAll = smooth(detectResultsAll(1:detectResultsAllEnd),5);
sAll = detectResultsAll(1:detectResultsAllEnd);
squeezeCnt = length(detectResultsAllSqueezeStartIdxs);


figure; hold on;
subplot(2,1,1); hold on;
plot(detectResultsAll(1:detectResultsAllEnd),'b');
plot(sAll, 'm');
legend('sOriginal','sAll');
lineMin = min(detectResultsAll);
lineMax = max(detectResultsAll);


for squeezeIdx = 1:squeezeCnt
    startIdx = detectResultsAllSqueezeStartIdxs(squeezeIdx);
    endIdx = detectResultsAllSqueezeEndIdxs(squeezeIdx);
    plot([startIdx, startIdx],[lineMin, lineMax],'r');
    plot([endIdx, endIdx],[lineMin, lineMax],'g');
    
    % Just for debug
    %s = detectResultsAll(startIdx:endIdx);
    %SqueezeTwiceDetect(smooth(s,3))
end


subplot(2,1,2); hold on;
SQUEEZE_LEN_TO_CHECK = 40;
resps = zeros(detectResultsAllEnd, 1);
peakCnts = zeros(detectResultsAllEnd, 1);
for idx = 1:detectResultsAllEnd-SQUEEZE_LEN_TO_CHECK
    sNow = sAll(idx:idx+SQUEEZE_LEN_TO_CHECK-1);
    
    [~, peaks, resp] = SqueezeTwiceDetect(sNow, [], 0);
    %{
    if idx == detectResultsAllSqueezeStartIdxs(2)
        [~, peaks, resp] = SqueezeTwiceDetect(sNow, [], 1);
    end
    %}
    
    resps(idx) = resp;
    peakCnts(idx) = length(peaks);
end
subplot(2,1,2); hold on;
plot(resps);
%plot(peakCnts);
hold off;
legend('resp', 'peakCnt');

debugIdx = detectResultsAllSqueezeStartIdxs(2);
SqueezeTwiceDetect(detectResultsAll(debugIdx:debugIdx+SQUEEZE_LEN_TO_CHECK-1), [], 1);