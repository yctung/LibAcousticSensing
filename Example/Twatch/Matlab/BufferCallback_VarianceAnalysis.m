function BufferCallback_VarianceAnalysis ()

    global PS CallbackCounter StartTime;    
    global FillUpBuffer FillUpPointers AlreadyProcessed;
    global detailsHandles aggregateDetails;
    global savedData doRecord;
    global PeakUp PeakDown PeakDiff;
    global PeakUpDelta PeakDownDelta;
    
    
    
    
    NUMCHANNELS = length(FillUpPointers);
    if any(FillUpPointers <= AlreadyProcessed)
        return;
    end
    
    %AverageChange = zeros(
    
   
    
    % Else, we're have some and will process it.
    
    SecondsPerChirp = seconds(duration(0, 0, PS.PERIOD / PS.FS));
    
    fig = findobj('Tag', 'PeakFig');
    if isempty(fig)
        PeakUp = zeros(1000,NUMCHANNELS);
        PeakDown = zeros(1000,NUMCHANNELS);
        PeakDiff = zeros(1000,NUMCHANNELS);
        PeakUpDelta = zeros(1000, NUMCHANNELS);
        PeakDownDelta = zeros(1000, NUMCHANNELS);
    
        createUI();
        
    else
        AlreadyProcessed = AlreadyProcessed + 1;
        
        %PeakUp = zeros(1,NUMCHANNELS);
        %PeakDown = zeros(1,NUMCHANNELS);
        %sPeakDiff = zeros(1,NUMCHANNELS);
        
        for chNum=1:NUMCHANNELS
            [   PeakUp(AlreadyProcessed,chNum), ...
                PeakDown(AlreadyProcessed,chNum), ...
                PeakDiff(AlreadyProcessed,chNum)] = ...
            drawChannel(chNum, FillUpBuffer(:,AlreadyProcessed,chNum));
            
        
            if AlreadyProcessed > 2
                PeakUpDelta(AlreadyProcessed, chNum) = PeakUp(AlreadyProcessed,chNum) - PeakUp(AlreadyProcessed-1,chNum);
                PeakDownDelta(AlreadyProcessed, chNum) = PeakDown(AlreadyProcessed,chNum) - PeakDown(AlreadyProcessed-1,chNum);
            end
            
            %PeakUp(AlreadyProcessed,chNum) - PeakUp(AlreadyProcessed-1,chNum)
            %PeakDown(AlreadyProcessed,chNum) - PeakDown(AlreadyProcessed-1,chNum)
            
            PeakUpVariance = 0; PeakDownVariance = 0;
            if AlreadyProcessed > 6
                PeakUpVariance = std(PeakUpDelta(AlreadyProcessed-5:AlreadyProcessed,chNum));
                PeakDownVariance = std(PeakDownDelta(AlreadyProcessed-5:AlreadyProcessed,chNum));
            end
            set(detailsHandles(chNum), 'string', ...
                sprintf('Channel %d: Up:%d (std=%f), Down:%d (std=%f), Diff:%d', ...
                    chNum, ...
                    PeakUp(AlreadyProcessed,chNum),...
                    PeakUpVariance, ...
                    PeakDown(AlreadyProcessed,chNum),...
                    PeakDownVariance, ...
                    PeakDiff(AlreadyProcessed,chNum)));
        end
   end
end


function peakLocation = plotPeaks (channelIdx, xcorr)
    DOWNFACTOR = 10;
    MAXONLYTOP = 10;
    
    line = findobj('tag', sprintf('%d-upcorr-line', channelIdx));
    sctplt = findobj('tag',  sprintf('%d-upcorr-scatter', channelIdx));
    maxpk = findobj('tag', sprintf('%d-upcorr-maxpeak', channelIdx));
    
    newx = downsample(1:size(xcorr(:,end,1)), DOWNFACTOR);
    set(line, 'xData', newx);
    set(line, 'yData', downsample(xcorr(:,end,1), DOWNFACTOR));
    
    [pks, locs] = findpeaks(xcorr);
    [topPks, topPksIdx] = sort(pks, 'descend');
    ONLYTOP = min(length(topPks), MAXONLYTOP);
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    
    [maxPk, maxPkIdx] = max(pks);
    set(maxpk, 'xData', locs(maxPkIdx));
    set(maxpk, 'yData', maxPk);
    
    % Need to index back into the input array
    peakLocation = locs(maxPkIdx);
end



function [peakUp, peakDown, peakDiff] = drawChannel (channelIdx, onechannel)
    global PS; % user parse setting
    global plotHandles;
    
    
    % First band pass the data
    if PS.bandpassFilter
        FilterCutoffs = [PS.upPass(1) - 200 PS.upPass(2) + 200];
        [b, a] = butter(2, FilterCutoffs/(PS.FS/2), 'bandpass');
        upcorr = abs(convn(filter(b, a, onechannel), PS.upchirp_data, 'same'));

        FilterCutoffs = [PS.downPass(1) - 200 PS.downPass(2) + 200];
        [d, c] = butter(2, FilterCutoffs/(PS.FS/2), 'bandpass');
        downcorr = abs(convn(filter(d, c, onechannel), PS.downchirp_data, 'same'));
    else
        upcorr = abs(convn(onechannel, PS.upchirp_data, 'same'));
        downcorr = abs(convn(onechannel, PS.downchirp_data, 'same'));
    end
    
    
   
    
    peakUp = plotPeaks(channelIdx, upcorr);
    peakDown = plotPeaks(channelIdx, downcorr);
    peakDiff = peakDown - peakUp;
        
    %[ channelIdx size(plotHandles) ]
    setYBound(plotHandles(channelIdx), max(upcorr(peakUp), downcorr(peakDown)));
    %xlim(plotHandles(channelIdx), [upLocs(peakUp)-100, upLocs(peakUp)+100]);
    %xlim(plotHandles(channelIdx), [downLocs(peakDown)-20, downLocs(peakDown)+20]);
end


function setYBound (chnlAx, maxY)
    maxY = max(maxY, 1);
    %sprintf('Max Y is %f, size of Pks is %d and size of max Y is %d\n', maxY, size(pks), size(maxY));
    ylim(chnlAx, [0, maxY]);
end


    

function createUI()
    % lineCnts is the number of lines per figure
    global FillUpPointers;
    global plotHandles distPlot;
    global detailsHandles aggregateDetails;
    
    PADDING = 50;
    WIDTH = 250;
    
    NUMCHANNELS = length(FillUpPointers);
    NUMDEVICES = NUMCHANNELS/2;
    NROWS = 1 + NUMCHANNELS;
    
    
    FONTSIZE = 10;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    %FigPos = [50,50,1000,1000];
    %figure('Position', FigPos,'Toolbar','none','MenuBar','none','Tag','PeakFig');
    figure('Toolbar','none','MenuBar','none','Tag','PeakFig');
    
    hold on;
    
    
    %% Draw the details texts
    h_panel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  (NROWS - 1)/NROWS 1 1/NROWS]);  %top row
    for chNum=1:NUMCHANNELS
        detailsHandles(chNum) = uicontrol(h_panel, ...
                'Style','text',...
                'units', 'normalized', ...
                'Position',[0, (NUMCHANNELS-chNum)/(NUMCHANNELS+1), 1, 1/(NUMCHANNELS+1)],...
                'FontSize',FONTSIZE ,...
                'String',sprintf('Ch %d details', chNum));
            
    end
            
    
    %% Draw peak charts
    
    for chNum=1:NUMCHANNELS
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
end
