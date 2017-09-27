function DoAggregatePeaks ()
    global PS; % user parse setting
    global CallbackCounter;
    global StartTime;
    
    global FillUpBuffer;
    global FillUpPointers;
    global AlreadyProcessed;    
    
    if any(FillUpPointers <= AlreadyProcessed)
        return;
    end
    
    % Else, we're have some and will process it.
    
    SecondsPerChirp = seconds(duration(0, 0, PS.PERIOD / PS.FS));
    
    fig = findobj('Tag', 'PeakFig');
    if isempty(fig)
        createUI();
        CallbackCounter = -1;
        StartTime = -1;
    else
        AlreadyProcessed = AlreadyProcessed + 1;
        
        if CallbackCounter == -1
            CallbackCounter = 0;
            StartTime = datetime;
        else
            CallbackCounter = CallbackCounter + 1;
        end

        NowTime = datetime;
        elapsedInSeconds = seconds(NowTime - StartTime);
        numChirps = floor(elapsedInSeconds / SecondsPerChirp);

        [ CallbackCounter numChirps ]

        drawChannel(1, FillUpBuffer(:,AlreadyProcessed,1));
        drawChannel(2, FillUpBuffer(:,AlreadyProcessed,2));
        drawChannel(3, FillUpBuffer(:,AlreadyProcessed,3));
        drawChannel(4, FillUpBuffer(:,AlreadyProcessed,4));
    end
    
end


function drawChannel (channelIdx, onechannel)
    global PS; % user parse setting
    global channel1Ax;
    global channel2Ax;
    global channel3Ax;

    
    upcorr = abs(convn(onechannel, PS.upchirp_data, 'same'));
    downcorr = abs(convn(onechannel, PS.downchirp_data, 'same'));
    
    line = findobj('tag', sprintf('%d-upcorr-line', channelIdx));
    sctplt = findobj('tag',  sprintf('%d-upcorr-scatter', channelIdx));
    maxpk = findobj('tag', sprintf('%d-upcorr-maxpeak', channelIdx));

    
    DOWNFACTOR = 10;
    MAXONLYTOP = 10;
    
    
    newx = downsample(1:size(upcorr(:,end,1)), DOWNFACTOR);
    set(line, 'xData', newx);
    set(line, 'yData', downsample(upcorr(:,end,1), DOWNFACTOR));
    [pks, locs] = findpeaks(upcorr);
    [topPks, topPksIdx] = sort(pks, 'descend');
    ONLYTOP = max(length(topPks), MAXONLYTOP);
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    [maxPk, maxInd] = max(pks);
    set(maxpk, 'xData', locs(maxInd));
    set(maxpk, 'yData', maxPk);

    line = findobj('tag', sprintf('%d-downcorr-line', channelIdx));
    sctplt = findobj('tag',  sprintf('%d-downcorr-scatter', channelIdx));
    maxpk = findobj('tag', sprintf('%d-downcorr-maxpeak', channelIdx));

    set(line, 'xData', newx);
    set(line, 'yData', downsample(downcorr(:,end,1), DOWNFACTOR));
    [pks, locs] = findpeaks(downcorr);
    [topPks, topPksIdx] = sort(pks, 'descend');
    ONLYTOP = max(length(topPks), MAXONLYTOP);
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    [maxPk, maxInd] = max(pks);
    set(maxpk, 'xData', locs(maxInd));
    set(maxpk, 'yData', maxPk);
    
    if channelIdx == 1
        ylim(channel1Ax, [0 max(pks) + max(pks)*0.1]);
    elseif channelIdx == 2
        ylim(channel2Ax, [0 max(pks) + max(pks)*0.1]);
    else 
        ylim(channel3Ax, [0 max(pks) + max(pks)*0.1]);
    end
end


function createUI()
    % lineCnts is the number of lines per figure
    global channel1Ax;
    global channel2Ax;
    global channel3Ax;
    
    PADDING = 50;
    WIDTH = 250;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    FigPos = [50,50,3*WIDTH+2*PADDING,PADDING*4+WIDTH*3];
    figure('Position', FigPos,'Toolbar','none','MenuBar','none','Tag','PeakFig');
    
    channel1Ax = subplot(3,1,1);
    hold on;
    plot(1, 'r', 'Tag', '1-upcorr-line');
    scatter(0, 0, 50, 'r', 'tag', '1-upcorr-scatter');
    scatter(0, 0, 250, 'r', 'filled', 'tag', '1-upcorr-maxpeak');
    
    plot(1, 'g', 'Tag', '1-downcorr-line');
    scatter(0, 0, 50, 'g', 'tag', '1-downcorr-scatter');
    scatter(0, 0, 250, 'g', 'filled', 'tag', '1-downcorr-maxpeak');
    hold off;
    
    
    channel2Ax = subplot(3,1,2);
    hold on;
    plot(1, 'r', 'Tag', '2-upcorr-line');
    scatter(0, 0, 50, 'r', 'tag', '2-upcorr-scatter');
    scatter(0, 0, 250, 'r', 'filled', 'tag', '2-upcorr-maxpeak');
    
    plot(1, 'g', 'Tag', '2-downcorr-line');
    scatter(0, 0, 50, 'g', 'tag', '2-downcorr-scatter');
    scatter(0, 0, 250, 'g', 'filled', 'tag', '2-downcorr-maxpeak');
    hold off;
    
    
    
    channel3Ax = subplot(3,1,3);
    hold on;0
    plot(1, 'r', 'Tag', '3-upcorr-line');
    scatter(0, 0, 50, 'r', 'tag', '3-upcorr-scatter');
    scatter(0, 0, 250, 'r', 'filled', 'tag', '3-upcorr-maxpeak');
    
    plot(1, 'g', 'Tag', '3-downcorr-line');
    scatter(0, 0, 50, 'g', 'tag', '3-downcorr-scatter');
    scatter(0, 0, 250, 'g', 'filled', 'tag', '3-downcorr-maxpeak');
    hold off;
end