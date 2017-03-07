function [ data ] = ServerReadFullData(t, DEBUG_SHOW)
% 2015/10/18: This is the helper function to read my customized packet
%       NOTE: Pakcet format = | # of bytes to send (int) | byte[] | -1 
    if ~exist('DEBUG_SHOW', 'var'),
        DEBUG_SHOW = 1;
    end
    
    % check how many byte should read
    byteToRead = fread(t, 1, 'int32'); 
    data = zeros(byteToRead, 1, 'int8');
    
    if DEBUG_SHOW, 
        fprintf(2,'  - going to read %d byte of data\n', byteToRead);
    end
    
    % wait until enough pkacket is received
    %byteToReadEachTime = 400; % NOTE: this should meet the buffer size set
    MAX_BYTE_TO_READ_EACH_TIME = t.InputBufferSize; % NOTE: this should meet the buffer size set
    currentReadStart = 1;
    while currentReadStart <= byteToRead,
        byteToReadThisTime = min(MAX_BYTE_TO_READ_EACH_TIME, byteToRead-currentReadStart+1);
        data(currentReadStart: currentReadStart+byteToReadThisTime-1) = fread(t, byteToReadThisTime, 'int8');
        currentReadStart = currentReadStart+byteToReadThisTime;
    end
    
    % check if data format is correct -> end with -1
    check = fread(t, 1, 'int8');
    assert(check == -1, '[ERROR]: wrong represetation of message send (size inconsistence?)');
    
end

