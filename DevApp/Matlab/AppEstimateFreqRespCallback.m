function [] = AppEstimateFreqRespCallback( obj, type, data )
    % just a dummy callback
    global dataCellBuf;
    global dataCellBufEnd;
    
    if type == obj.CALLBACK_TYPE_DATA,
        if obj.userfig == -1, % need to create a new UI window
            dataCellBuf = {};
            dataCellBufEnd = 0;
            createUI(obj);
        else
            dataSize = size(data)
            for traceIdx = 1:size(data,2)
                dataCellBuf{ dataCellBufEnd + 1 } = squeeze(data(:,traceIdx,:));
                dataCellBufEnd = dataCellBufEnd + 1;
                
                dataFreq = abs(fft(dataCellBuf{dataCellBufEnd}));
                dataFreq = dataFreq(1:floor(size(dataFreq,1)/2),:);
                resp = log10(smooth(dataFreq,30));
                lineTag = sprintf('line01_%02d',dataCellBufEnd)
                line = findobj('Tag',sprintf('line01_%02d',dataCellBufEnd))
                set(line, 'yData', resp); % only show the 1st ch
            end
        end
    end
    
end

function createUI(obj)
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    obj.userfig = figure('Position',[50,50,350,350]);
    
    figCnt = 1;
    lineCnt = 5;
    for i = 1:figCnt,
        hold on;
        for j = 1:lineCnt,
            plot([0,0],'Tag',sprintf('line%02d_%02d',i,j),'linewidth',2); % only show the 1st ch
        end
        hold off;
    end

end