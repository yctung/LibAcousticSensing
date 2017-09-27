function [ ] = SaveAudioSourceAndParseSetting(audioSource, outFolder)
% 2017/09/21: utility function to export the format to json format
%           : for the standalone parsing
    FILE_NAME_SIGNAL_OUT = 'signal.dat';
    FILE_NAME_SETTING_OUT = 'audio_source.json';
    FILE_NAME_PREAMBLE_TO_ADD_OUT = 'preamble.dat';
    FILE_NAME_PREAMBLE_SYNC_OUT = 'sync.dat';
    
    if ~exist(outFolder, 'dir')
        fprintf(1, '[ERROR]: outFolder = %s not existed (warng path?)\n', outFolder);
        return;
    end
    
    if outFolder(length(outFolder)) ~= filesep
        outFolder = strcat(outFolder, filesep);
    end
    
    SHORT_SCALE = 2^15 - 1;
    % TODO: handle stereo output files?
    SavePCM(floor(audioSource.signal*SHORT_SCALE*audioSource.signalGain), strcat(outFolder, FILE_NAME_SIGNAL_OUT));
    SavePCM(floor(audioSource.preambleSource.preambleToAdd*SHORT_SCALE*audioSource.preambleGain), strcat(outFolder, FILE_NAME_PREAMBLE_TO_ADD_OUT));
    % sync is used only for detecting the preamble, so wo don't need to
    % apply the preamble gain
    SavePCM(floor(audioSource.preambleSource.syncToDetect*SHORT_SCALE), strcat(outFolder, FILE_NAME_PREAMBLE_SYNC_OUT));
    
    % TODO: we could use jsonencode, but it is now only supported in 2017b
    json = '{';
    json = sprintf('%s"id":"%s",', json, audioSource.name);
    json = sprintf('%s"sampleRate":%d,', json, audioSource.FS);
    json = sprintf('%s"chCnt":%d,', json, audioSource.chCnt);
    json = sprintf('%s"repeatCnt":%d,', json, audioSource.repeatCnt);
    json = sprintf('%s"preambleEndOffset":%d,', json, audioSource.preambleSource.preambleEndOffset);
    json = sprintf('%s"preambleSyncRepeatCnt":%d,', json, audioSource.preambleSource.syncRepeatCnt);
    json = sprintf('%s"preambleName":"%s"', json, audioSource.preambleSource.name);
    json = strcat(json, '}');
    
    % just for debug
    fprintf('json = %s\n', json);
    
    fid = fopen(strcat(outFolder, FILE_NAME_SETTING_OUT), 'wt');
    fprintf(fid, '%s', json);
    fclose(fid);
    
    fid = fopen(strcat(outFolder, 'README'), 'wt');
    fprintf(fid, 'Please copy all files in this folder to the Andriod assets (or other platform) folder');
    fclose(fid);
end

