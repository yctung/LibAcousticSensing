function [ audioVec, audioSound ] = LibLoadPCM( path, chCnt )
% 2015/09/29: make a general version loading auido inside matlab
% 2015/10/18: update determine TRACE_TRACK_SIZE based on file size

%TODO: read channel based on channel parameters
PCM_FORMAT_BYTE_PER_SAMPLE = 2; % i.e., 16 bit 

if ~exist('chCnt','var'),
    chCnt = 1; % default channel cnt
    fprintf('[WARN]: set default chCnt = %d\n', chCnt);
end
    
    
fileID = fopen(path);
audioVec = fread(fileID, inf, 'int16');
%audioVec = fread(fileID, inf, 'uint8');
fclose(fileID);

if chCnt == 2, % stereo channel recording (ex: Samsung S5)
    traceMatR = audioVec(:, 1:2:end);
    traceMatL = audioVec(:, 2:2:end);

    traceVecR = reshape(traceMatR', length(audioVec)/2, 1);
    traceVecL = reshape(traceMatL', length(audioVec)/2, 1);

    audioVec = [traceVecR, traceVecL];
end
        
audioSound = audioVec./max(abs(audioVec)); % for matlab to play the sound
      

end

