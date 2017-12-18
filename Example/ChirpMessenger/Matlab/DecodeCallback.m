function [ret] = DecodeCallback( context, action, data, user)
    global PS; % parse settings
    
%--------------------------------------------------------------------------
% 1. init callback if need (TODO: add realtime GUI?)
%--------------------------------------------------------------------------
    if action == context.CALLBACK_TYPE_INIT
        
%--------------------------------------------------------------------------   
% 2. process data
%-------------------------------------------------------------------------- 
    elseif action == context.CALLBACK_TYPE_DATA
        codes = PS.codes;
        dataSent = PS.dataSent;
        
        CODE_LEN = length(codes{1});
        [DATA_LEN, CH_CNT] = size(data);
        CH_IDX_USED = 1;
        assert(CH_IDX_USED < CH_CNT, 'decode fails because CH_IDX_USED is larger than the availabe channel (recorded by a single-channel device?)\n');
        SYM_CNT = DATA_LEN / CODE_LEN;
        tests = reshape(data(:, CH_IDX_USED), [CODE_LEN, SYM_CNT]); % assume codes have the same length
        dataDecoded = Decode(codes, tests);
        
        % visualization
        figure; hold on;
        plot(dataSent, 'o');
        plot(dataDecoded, 'x');
        ylim([min(dataSent) - 1, max(dataSent) + 1]);
        hold off;
        legend('sent', 'received');
        fprintf('decoded rate = %.2f (%d / %d)\n', sum(dataSent == dataDecoded) / SYM_CNT, sum(dataSent == dataDecoded), SYM_CNT);
%--------------------------------------------------------------------------
% 3. response user-defeind events (not useful in this example)
%--------------------------------------------------------------------------
    elseif action == context.CALLBACK_TYPE_USER
        
    end
    
    ret = []; % dummy response to devices
end
