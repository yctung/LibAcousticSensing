function [] = ServerWriteAudioData(t, audioSource)
% 2016/10/27: This writes the full data to socket
    if ~exist('t','var') & ~exist('audio','var'),
        fprintf('[WARN]: no socket and audio objects -> load the latest one for just debugging\n');
        load('LatestAudioSetting');
    end


    %time = 0:1/48000:2;
    %signal = floor(sin(time*100*pi).*400);
    %signal = floor(chirp(time, 0, time(end), 1000).*400);
    
    % convert to short array audio (note audio signal should between -1 and 1)
    if any(abs(audioSource.signal*audioSource.signalGain)>1.0)
        fprintf('[WARN]: signal amplitude is cropped to ensure it is in the right range (need to tune audio gain in AudioNoiseMake.m?)\n');
    end
    
    SHORT_MAX_RANGE = 2^15-1;
    
    REACTION_SET_MEDIA = 1;
    
    % a. write reaction identifier
    fwrite(t, int8(REACTION_SET_MEDIA), 'int8');

    % b. write sample rate and other information
    fwrite(t, int32(audioSource.FS), 'int32');
    fwrite(t, int32(audioSource.chCnt), 'int32');
    fwrite(t, int32(audioSource.repeatCnt), 'int32');
    
    % c. write preamble
    preambleShortRange = floor(audioSource.preambleSource.preambleToAdd*audioSource.preambleGain*SHORT_MAX_RANGE);
    fwrite(t, int32(length(preambleShortRange)), 'int32');
    preambleShort = int16(preambleShortRange);
    preabmleBytes = typecast(preambleShort, 'int8');
    
    byteToWriteEachTime = 200;
    currentWriteStart = 1;
    while currentWriteStart < length(preabmleBytes),
        fwrite(t, preabmleBytes(currentWriteStart: min(currentWriteStart+byteToWriteEachTime-1, length(preabmleBytes))), 'int8');
        currentWriteStart = currentWriteStart+byteToWriteEachTime;
    end
    
    % d. write signal
    signalShortRange = floor(audioSource.signal*audioSource.signalGain*SHORT_MAX_RANGE);
    fwrite(t, int32(length(signalShortRange)), 'int32');
    signalShort = int16(signalShortRange);
    signalBytes = typecast(signalShort, 'int8');
    
    byteToWriteEachTime = 200;
    currentWriteStart = 1;
    while currentWriteStart < length(signalBytes),
        fwrite(t, signalBytes(currentWriteStart: min(currentWriteStart+byteToWriteEachTime-1, length(signalBytes))), 'int8');
        currentWriteStart = currentWriteStart+byteToWriteEachTime;
    end
    
    % e. write check
    CHECK = -1;
    fwrite(t, int8(CHECK), 'int8');
end

