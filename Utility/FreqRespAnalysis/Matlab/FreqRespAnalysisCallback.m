function [ret] = FreqRespAnalysisCallback( obj, type, data )
    global dataCellBuf; % save this data buffer for the future reference
    global dataCellBufEnd;
    global PS;
    
    ret = [];
    if type == obj.CALLBACK_TYPE_INIT,
        dataCellBuf = {};
        dataCellBufEnd = 0;
        createUI(obj);
    elseif type == obj.CALLBACK_TYPE_DATA,
        dataSize = size(data);
        for traceIdx = 1:size(data,2)
            dataCellBuf{ dataCellBufEnd + 1 } = squeeze(data(:,traceIdx,:));
            dataCellBufEnd = dataCellBufEnd + 1;

            dataFreq = abs(fft(dataCellBuf{dataCellBufEnd}));
            dataFreq = dataFreq(1:floor(size(dataFreq, 1) / 2),:);
            for chIdx = 1:size(data, 3)    
                resp = log10(smooth(dataFreq(:, chIdx), 30));
                freqs = (1:length(resp)) ./length(resp) .* (PS.FS/2);
                line = findobj('Tag', sprintf('line%02d_%02d', chIdx, dataCellBufEnd));
                set(line, 'yData', resp); % only show the 1st ch
                set(line, 'xData', freqs);
            end
        end
    end
    
end

function createUI(obj)

    PLOT_AXE_IN_WIDTH = 250;
    PLOT_AXE_OUT_WIDTH = 310;
    PLOT_AXE_CNT = 2;
    
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    obj.userfig = figure('Name','Callback','NumberTitle','off', 'Position',[50,50, PLOT_AXE_OUT_WIDTH * PLOT_AXE_CNT + 100, 350]);
    
    
    lineCnt = 5;
    for i = 1:PLOT_AXE_CNT,
        obj.axe = axes('Parent',obj.userfig,'Units','pixels','Position', [PLOT_AXE_OUT_WIDTH * (i-1) + 100, 60, PLOT_AXE_IN_WIDTH, 250]);
        
        hold on;
        for j = 1:lineCnt,
            plot([0,0],'Tag',sprintf('line%02d_%02d',i,j),'linewidth',2); % only show the 1st ch
            ylabel('Response (dB)');
            xlabel('Frequency (Hz)');
        end
        title(sprintf('ch %d', i));
        hold off;
    end

end
