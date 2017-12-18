function [codeIdxs] = Decode(codes, signals)
% 2017/12/18: signal signals can be a m x n matrix where n represents the
%             number of symbol and m is the sample of each sample
    [~, SYM_CNT] = size(signals);    
    codeIdxs = zeros(SYM_CNT, 1);
    
    % TODO: optimizaiton by matrix operations
    for symIdx = 1:SYM_CNT
        sym = signals(:, symIdx);
        likelihoods = cellfun(@(code) max(abs(conv(sym, code(end:-1:1)))), codes ,'UniformOutput', true);
        [maxLikelihoods, codeIdxs(symIdx)] = max(likelihoods);
    end
end

