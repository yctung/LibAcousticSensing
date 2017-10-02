function Helper_DoAggregatePeaks ()
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

        %[ CallbackCounter numChirps ]

        [c1PeakUp, c1PeakDown, c1PeakDiff] = drawChannel(1, FillUpBuffer(:,AlreadyProcessed,1));
        [c2PeakUp, c2PeakDown, c2PeakDiff] = drawChannel(2, FillUpBuffer(:,AlreadyProcessed,2));
        [c3PeakUp, c3PeakDown, c3PeakDiff] = drawChannel(3, FillUpBuffer(:,AlreadyProcessed,3));
        %drawChannel(4, FillUpBuffer(:,AlreadyProcessed,4));
        
        sprintf('Channel 1: Up:%d, Down:%d, Diff:%d', c1PeakUp, c1PeakDown, c1PeakDiff)
        sprintf('Channel 2: Up:%d, Down:%d, Diff:%d', c2PeakUp, c2PeakDown, c2PeakDiff)
        sprintf('Channel 3: Up:%d, Down:%d, Diff:%d', c3PeakUp, c3PeakDown, c3PeakDiff)
    end
    
end


function [peakUp, peakDown, peakDiff] = drawChannel (channelIdx, onechannel)
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
    ONLYTOP = min(length(topPks), MAXONLYTOP);
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    [maxPk, peakUp] = max(pks);
    set(maxpk, 'xData', locs(peakUp));
    set(maxpk, 'yData', maxPk);

    line = findobj('tag', sprintf('%d-downcorr-line', channelIdx));
    sctplt = findobj('tag',  sprintf('%d-downcorr-scatter', channelIdx));
    maxpk = findobj('tag', sprintf('%d-downcorr-maxpeak', channelIdx));

    set(line, 'xData', newx);
    set(line, 'yData', downsample(downcorr(:,end,1), DOWNFACTOR));
    [pks, locs] = findpeaks(downcorr);
    [topPks, topPksIdx] = sort(pks, 'descend');
    ONLYTOP = min(length(topPks), MAXONLYTOP);
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    [maxPk, peakDown] = max(pks);
    set(maxpk, 'xData', locs(peakDown));
    set(maxpk, 'yData', maxPk);
    
    peakDiff = peakDown - peakUp;
    
    if channelIdx == 1, setYBound(channel1Ax, pks);
    elseif channelIdx == 2, setYBound(channel2Ax, pks);
    else, setYBound(channel3Ax, pks);
    end
end


function setYBound (chnlAx, pks)
    maxY = max(pks)+max(pks)*0.1;
    %'--------------'
    %[size(pks); size(maxY)]
    maxY = max(maxY, 1);
    %sprintf('Max Y is %f, size of Pks is %d and size of max Y is %d\n', maxY, size(pks), size(maxY));
    ylim(chnlAx, [0, maxY]);
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
    hold on;
    plot(1, 'r', 'Tag', '3-upcorr-line');
    scatter(0, 0, 50, 'r', 'tag', '3-upcorr-scatter');
    scatter(0, 0, 250, 'r', 'filled', 'tag', '3-upcorr-maxpeak');
    
    plot(1, 'g', 'Tag', '3-downcorr-line');
    scatter(0, 0, 50, 'g', 'tag', '3-downcorr-scatter');
    scatter(0, 0, 250, 'g', 'filled', 'tag', '3-downcorr-maxpeak');
    hold off;
end