function Helper_DistanceCalc ()
    global PS CallbackCounter StartTime;    
    global FillUpBuffer FillUpPointers AlreadyProcessed;
    global detailsHandles aggregateDetails;
    
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
        
        PeakUp = zeros(1,4);
        PeakDown = zeros(1,4);
        PeakDiff = zeros(1,4);
        
        for chNum=1:4
            [PeakUp(chNum), PeakDown(chNum), PeakDiff(chNum)] = drawChannel(chNum, FillUpBuffer(:,AlreadyProcessed,chNum));
            set(detailsHandles(chNum), 'string', sprintf('Channel %d: Up:%d, Down:%d, Diff:%d', chNum, PeakUp(chNum), PeakDown(chNum), PeakDiff(chNum)));  
        end
        
        
        
        
      
        % Distance between c1 and c3.
        d13 = calcDistance(PeakDown, PeakUp, 1, 3);
        d14 = calcDistance(PeakDown, PeakUp, 1, 4);
        d23 = calcDistance(PeakDown, PeakUp, 2, 3);
        d24 = calcDistance(PeakDown, PeakUp, 2, 4);
        set(aggregateDetails, 'string', sprintf('Avg = %fcm (%f, %f, %f, %f)', mean([d13 d14 d23 d24])*100, d13*100, d14*100, d23*100, d24*100));
        
        % Draw the distances
        dplot = findobj('tag',  'distancePlot');
        set(dplot, 'xData', [d13 d14 d23 d24]);
        set(dplot, 'yData', [0 0 0 0]);
    end
    
end


function [d] = calcDistance (PeakDown, PeakUp, ch1Num, ch2Num)
    c1PeakDown = PeakDown(ch1Num);
    c1PeakUp = PeakUp(ch1Num);
    c2PeakDown = PeakDown(ch2Num);
    c2PeakUp = PeakUp(ch2Num);
    
    % Fine-tune these numbers to get the actual distance
    MIC_DISTANCE_CONSTANT = 0;
    C = 345.63334; % Actually it's 343 m/sec or something
    FS = 48000.0; %Actually it's 48000.
    d = (c1PeakDown - c1PeakUp) - (c2PeakDown - c2PeakUp);
    d = C*d/(2*FS) + MIC_DISTANCE_CONSTANT;
end

function [peakUp, peakDown, peakDiff] = drawChannel (channelIdx, onechannel)
    global PS; % user parse setting
    global plotHandles;
    
    
    % First band pass the data
    

    upcorr = abs(convn(onechannel, PS.upchirp_data, 'same'));
    downcorr = abs(convn(onechannel, PS.downchirp_data, 'same'));
    
    
    %FilterCutoffs = [PS.upPass(1) - 200 PS.upPass(2) + 200];
    %[b, a] = butter(2, FilterCutoffs/(PS.FS/2), 'bandpass');
    %upcorr = abs(convn(filter(b, a, onechannel), PS.upchirp_data, 'same'));
    
    %FilterCutoffs = [PS.downPass(1) - 200 PS.downPass(2) + 200];
    %[d, c] = butter(2, FilterCutoffs/(PS.FS/2), 'bandpass');
    %downcorr = abs(convn(filter(d, c, onechannel), PS.downchirp_data, 'same'));
    
    
    line = findobj('tag', sprintf('%d-upcorr-line', channelIdx));
    sctplt = findobj('tag',  sprintf('%d-upcorr-scatter', channelIdx));
    maxpk = findobj('tag', sprintf('%d-upcorr-maxpeak', channelIdx));

    
    DOWNFACTOR = 10;
    MAXONLYTOP = 10;
    
    
    newx = downsample(1:size(upcorr(:,end,1)), DOWNFACTOR);
    set(line, 'xData', newx);
    set(line, 'yData', downsample(upcorr(:,end,1), DOWNFACTOR));
    [upPks, locs] = findpeaks(upcorr);
    [topPks, topPksIdx] = sort(upPks, 'descend');
    ONLYTOP = min(length(topPks), MAXONLYTOP);
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    [maxPk, peakUp] = max(upPks);
    set(maxpk, 'xData', locs(peakUp));
    set(maxpk, 'yData', maxPk);

    line = findobj('tag', sprintf('%d-downcorr-line', channelIdx));
    sctplt = findobj('tag',  sprintf('%d-downcorr-scatter', channelIdx));
    maxpk = findobj('tag', sprintf('%d-downcorr-maxpeak', channelIdx));

    set(line, 'xData', newx);
    set(line, 'yData', downsample(downcorr(:,end,1), DOWNFACTOR));
    [downPks, locs] = findpeaks(downcorr);
    [topPks, topPksIdx] = sort(downPks, 'descend');
    ONLYTOP = min(length(topPks), MAXONLYTOP);
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    [maxPk, peakDown] = max(downPks);
    set(maxpk, 'xData', locs(peakDown));
    set(maxpk, 'yData', maxPk);
    
    peakDiff = peakDown - peakUp;
    
    setYBound(plotHandles(channelIdx), [upPks; downPks]);
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
    global plotHandles distPlot;
    global detailsHandles aggregateDetails;
    
    PADDING = 50;
    WIDTH = 250;
    NROWS = 6;
    
    FONTSIZE = 20;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    FigPos = [50,50,3*WIDTH+2*PADDING,PADDING*4+WIDTH*3];
    figure('Position', FigPos,'Toolbar','none','MenuBar','none','Tag','PeakFig');
    
    hold on;
    
    
    %% Draw the details texts
    h_panel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  (NROWS - 1)/NROWS 1 1/NROWS]);  %top row
    
    for chNum=1:4
        detailsHandles(chNum) = uicontrol(h_panel, ...
                'Style','text',...
                'units', 'normalized', ...
                'Position',[0, (4-chNum)/5, 1, 1/5],...
                'FontSize',FONTSIZE ,...
                'String',sprintf('Ch %d details', chNum));
            
    end
            
   aggregateDetails = uicontrol(h_panel, ...
    'Style','text',...
    'units', 'normalized', ...
    'Position',[0, 4/5, 1, 1/5],...
    'FontSize',FONTSIZE ,...
    'String','Aggregate details');
    
    %% Draw peak charts
    
    for chNum=1:4
        plotHandles(chNum) = subplot(NROWS, 1, chNum + 1);
        hold on;
        plot(1, 'r', 'Tag', sprintf('%d-upcorr-line', chNum));
        scatter(0, 0, 50, 'r', 'tag', sprintf('%d-upcorr-scatter', chNum));
        scatter(0, 0, 250, 'r', 'filled', 'tag', sprintf('%d-upcorr-maxpeak', chNum));

        plot(1, 'g', 'Tag', sprintf('%d-downcorr-line', chNum));
        scatter(0, 0, 50, 'g', 'tag', sprintf('%d-downcorr-scatter', chNum));
        scatter(0, 0, 250, 'g', 'filled', 'tag', sprintf('%d-downcorr-maxpeak', chNum));
        
        title(sprintf('Channel %d', chNum));
        hold off;
    end
    
    
    %% Draw distance graph
    distPlot = subplot(NROWS, 1, NROWS);
    hold on;
    scatter(0, 0, 250, 'r', 'filled', 'tag', 'distancePlot');
    xlim([-0.2, 0.2]);
    ylim([-1, 1]);
    xlabel('Meters');
    title('Distance');
    hold off;
    
end