function [  ] = ServerWriteFullData(t)
% 2016/10/27: This writes the full data to socket

    time = 0:1/48000:2;
    %signal = floor(sin(time*100*pi).*400);
    signal = floor(chirp(time, 0, time(end), 1000).*400);
    
    % convert signal to media
    REACTION_SET_MEDIA = 1;
    fwrite(t, int8(REACTION_SET_MEDIA), 'int8');

    
    fwrite(t, int32(length(signal)), 'int32');
    signalShort = int16(signal);
    signalBytes = typecast(signalShort, 'int8');
    
    %set(t, 'OutputBufferSize', length(signalBytes)+5);
    BUFFER_SIZE = get(t, 'OutputBufferSize');
    
    byteToWriteEachTime = 200;
    currentWriteStart = 1;
    while currentWriteStart < length(signalBytes),
        fwrite(t, signalBytes(currentWriteStart: min(currentWriteStart+byteToWriteEachTime-1, length(signalBytes))), 'int8');
        currentWriteStart = currentWriteStart+byteToWriteEachTime;
    end
    
    CHECK = -1;
    fwrite(t, int8(CHECK), 'int8');
end

