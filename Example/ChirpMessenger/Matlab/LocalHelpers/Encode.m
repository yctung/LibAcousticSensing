function [signal] = Encode(codes, codeIdxs)
% 2017/12/18: encode data accordingly based on the codes
%           : note codeIdxs must start from 1 (Matlab style)
    CODE_CNT = length(codes);
    CODE_MAX_LEN = max(cellfun(@length, codes));
    DATA_LEN = length(codeIdxs);
    
    assert(max(codeIdxs) > 0, 'enocde data must start from 1\n');
    assert(max(codeIdxs) <= CODE_CNT, 'encode fails becuase max(codeIdxs) > the code to ecode (send a wrong data?)\n');
    
    signal = zeros(CODE_MAX_LEN * DATA_LEN, 1); % assume sigle channel
    signalEnd = 0;
    for i = 1:DATA_LEN
        code = codes{codeIdxs(i)};
        signal(signalEnd + 1:signalEnd + length(code)) = code;
        signalEnd = signalEnd + length(code);
    end
    signal = signal(1:signalEnd);
    
    
    UNIT_TEST = 1;
    if UNIT_TEST
        tests = reshape(signal, [CODE_MAX_LEN, signalEnd/CODE_MAX_LEN]); % assume codes have the same length
        checks = Decode(codes, tests);
        
        if any(checks ~= codeIdxs)
            figure; hold on;
            plot(codeIdxs, 'o');
            plot(checks, 'x');
            hold off;
            legend('sent', 'received');
        end
        assert(all(checks == codeIdxs), 'encode/decode unit test fails\n');
    end
end

