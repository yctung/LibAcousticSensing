function [ ] = SaveTrace( name )
    if ~exist('name', 'var') % test mode
        name = 'test.mat';
    end


    TRACE_FOLDER = 'Traces/';
    tracePath = strcat(TRACE_FOLDER, name);
    if exist(tracePath, 'file')
        fprintf(2, '[ERROR]: tracePath = %s existed\n', tracePath);
        return
    end
    
    
    
    global PS; % user parse setting
    global dsDetectsAll;
    global dsDetectsAllEnd;
    global tvgSetting;
    global DOWNSAMPLE_FACTOR;
    global dsXMeters;
    global dsSize;
    global userStarts;
    global userEnds;
    global userStartsEnd;
    global userEndsEnd;
    
    result.PS = PS;
    result.dsDetectsAll = dsDetectsAll(:, 1:dsDetectsAllEnd, :);
    result.dsDetectsAllEnd = dsDetectsAllEnd;
    result.tvgSetting = tvgSetting;
    result.DOWNSAMPLE_FACTOR = DOWNSAMPLE_FACTOR;
    result.dsXMeters = dsXMeters;
    result.dsSize = dsSize;
    result.userStarts = userStarts(1:userStartsEnd);
    result.userEnds = userEnds(1:userEndsEnd);
    result.userStartsEnd = userStartsEnd;
    result.userEndsEnd = userEndsEnd;
    
    save(tracePath, 'result');
    
    % just for test
    check = mean(CalPeakAmp(tracePath, [2.5, 3.5], 1))
end

