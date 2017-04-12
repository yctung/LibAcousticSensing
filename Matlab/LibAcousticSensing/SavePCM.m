function [ ] = SavePCM( audio, path )
    if ~exist('path','var'),
        path = '/Users/eddyxd/Downloads/audio.pcm';
    end

    fileID = fopen(path, 'w');
    fwrite(fileID,audio,'int16');
    fclose(fileID);
end

