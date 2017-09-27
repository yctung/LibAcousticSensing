function [ resp ] = AppCheckAGCHelperGetResp( data )
    % just a helper function to get response from data
    traceCnt = size(data,2);
    
    resp = data; % use the same data format
    for traceIdx = 1:traceCnt,
        resp(:,traceIdx) = smooth(abs(data(:,traceIdx)),100);
    end
end

