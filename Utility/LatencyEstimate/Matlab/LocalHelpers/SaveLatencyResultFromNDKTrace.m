nameToSave = 'latency';
pathToSave = strcat('traces/', nameToSave)

latencyResult; % this trace file is saved by NDK program

latency = appCallbackLatencyResult;

save(pathToSave, 'latency');

