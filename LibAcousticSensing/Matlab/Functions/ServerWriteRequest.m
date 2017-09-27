function [] = ServerWriteRequest(t, r)
% 2017/11/21: This helps to write user study request to the server
% 2017/11/21: I also send the audio file with this function to make the operation unified (ensure the request is also coupled with the audio in the android side)    
% 2017/11/30: Add function to write request answer as string
    REACTION_SET_REQUEST = 2; % need to meet android setting
    CHECK = -1;
    
    
    % b. write reaction identifier
    fwrite(t, int8(REACTION_SET_REQUEST), 'int8');
    
    % b. write request information (need to meet the android code)
    fwrite(t, int32(r.type), 'int32');
    fwrite(t, int32(r.rIdx), 'int32');
    fwrite(t, int32(r.rCnt), 'int32');
    
    % c. write audio information -> write it as a byte array now
    %answerInt32 = str2num(r.answer);
    %fwrite(t, int32(answerInt32), 'int32'); % NOTE: I assume the answer is smaller than int32 max value
    answerSize = length(r.answer);

    
    assert(answerSize<100, '[ERROR]: answerSize is too large, might cause packet lose (need to separate?)\n');
    fwrite(t, int32(answerSize), 'int32');
    answerByteArray = int8(r.answer);
    fwrite(t, answerByteArray, 'int8');
    
    
    
    fwrite(t, single(r.vol), 'float');
    
    fwrite(t, int32(r.needToUpdateAudio), 'int32');
    fwrite(t, int32(r.needToAutoPlay), 'int32');
    fwrite(t, int32(r.needToCalibEnd), 'int32');
    
    
    fwrite(t, int8(CHECK), 'int8');
end

