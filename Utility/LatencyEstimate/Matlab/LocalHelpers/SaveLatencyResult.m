
nameToSave = 'latency';
pathToSave = strcat('traces/', nameToSave)


% in the format of one row of sample cnts + 2nd row of latency (ms)
latency = ss.appCallbackLatencyResult;

save(pathToSave, 'latency');