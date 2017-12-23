

latency = ss.appCallbackLatencyResult(2, :);
figure; plot(latency, '-o');
median(latency)
std(latency)