function peaks = statelesspeaks (correlations, fromWindow, ~, ~)
    % Correlation: <Samples, Window>
    numwindows = size(correlations, 2);
    peaks = zeros(1, numwindows);
    for win=fromWindow:numwindows
        corr = correlations(:, win);
        peaks(win) = getPeaksForCorr(corr);
    end
end

