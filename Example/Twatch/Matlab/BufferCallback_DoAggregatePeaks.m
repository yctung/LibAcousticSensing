function Helper_DoAggregatePeaks ()
    global PS CallbackCounter StartTime;    
    global FillUpBuffer FillUpPointers AlreadyProcessed;
    global ch1Details ch2Details ch3Details aggregateDetails;
    
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
        
        set(ch1Details, 'string', sprintf('Channel 1: Up:%d, Down:%d, Diff:%d', c1PeakUp, c1PeakDown, c1PeakDiff));
        set(ch2Details, 'string', sprintf('Channel 2: Up:%d, Down:%d, Diff:%d', c2PeakUp, c2PeakDown, c2PeakDiff));
        set(ch3Details, 'string', sprintf('Channel 3: Up:%d, Down:%d, Diff:%d', c3PeakUp, c3PeakDown, c3PeakDiff));
        
        % Fine-tune these numbers to get the actual distance
        MIC_DISTANCE_CONSTANT = 0;
        C = 345.63334; % Actually it's 343 m/sec or something
        FS = 48000.0; %Actually it's 48000.
        
        % Distance between c1 and c3.
        distance_c1_c3 = (c1PeakDown - c1PeakUp) - (c3PeakDown - c3PeakUp);
        distance_c1_c3 = C*distance_c1_c3/(2*FS) + MIC_DISTANCE_CONSTANT;
        
        % Distance between c2 and c3.
        distance_c2_c3 = (c2PeakDown - c2PeakUp) - (c3PeakDown - c3PeakUp);
        distance_c2_c3 = C*distance_c2_c3/(2*FS) + MIC_DISTANCE_CONSTANT;
        
        set(aggregateDetails, 'string', sprintf('C_1 to C_3 = %f cm. C_2 to C_3 = %f cm', distance_c1_c3*100, distance_c2_c3*100)); 
    end
    
end


function [peakUp, peakDown, peakDiff] = drawChannel (channelIdx, onechannel)
    global PS; % user parse setting
    global channel1Ax channel2Ax channel3Ax;
    
    
    % First band pass the data
    

    %upcorr = abs(convn(onechannel, PS.upchirp_data, 'same'));
    %downcorr = abs(convn(onechannel, PS.downchirp_data, 'same'));
    
    
    FilterCutoffs = [PS.upPass(1) - 200 PS.upPass(2) + 200];
    [b, a] = butter(2, FilterCutoffs/(PS.FS/2), 'bandpass');
    upcorr = abs(convn(filter(b, a, onechannel), PS.upchirp_data, 'same'));
    
    FilterCutoffs = [PS.downPass(1) - 200 PS.downPass(2) + 200];
    [d, c] = butter(2, FilterCutoffs/(PS.FS/2), 'bandpass');
    downcorr = abs(convn(filter(d, c, onechannel), PS.downchirp_data, 'same'));
    
    
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
    
    if channelIdx == 1, setYBound(channel1Ax, [upPks; downPks]);
    elseif channelIdx == 2, setYBound(channel2Ax, [upPks; downPks]);
    else, setYBound(channel3Ax, [upPks; downPks]);
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
    global channel1Ax channel2Ax channel3Ax;
    global ch1Details ch2Details ch3Details aggregateDetails;
    
    PADDING = 50;
    WIDTH = 250;
    NROWS = 4;
    
    FONTSIZE = 15;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    FigPos = [50,50,3*WIDTH+2*PADDING,PADDING*4+WIDTH*3];
    fig = figure('Position', FigPos,'Toolbar','none','MenuBar','none','Tag','PeakFig');
    
    hold on;
    
    h_panel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  3/NROWS 1 1/NROWS]);  %top fourth
    ch1Details = uicontrol(h_panel, ...
                'Style','text',...
                'units', 'normalized', ...
                'Position',[0, 2/4, 1, 1/4],...
                'FontSize',FONTSIZE ,...
                'String','Ch 1 details');
            
     ch2Details = uicontrol(h_panel, ...
                'Style','text',...
                'units', 'normalized', ...
                'Position',[0, 1/4, 1, 1/4],...
                'FontSize',FONTSIZE ,...
                'String','Ch 2 details');
            
     ch3Details = uicontrol(h_panel, ...
                'Style','text',...
                'units', 'normalized', ...
                'Position',[0, 0, 1, 1/4],...
                'FontSize',FONTSIZE ,...
                'String','Ch 3 details');
    
            
   aggregateDetails = uicontrol(h_panel, ...
    'Style','text',...
    'units', 'normalized', ...
    'Position',[0, 3/4, 1, 1/4],...
    'FontSize',FONTSIZE ,...
    'String','Aggregate details');


    
    channel1Ax = subplot(NROWS,1,2);
    hold on;
    plot(1, 'r', 'Tag', '1-upcorr-line');
    scatter(0, 0, 50, 'r', 'tag', '1-upcorr-scatter');
    scatter(0, 0, 250, 'r', 'filled', 'tag', '1-upcorr-maxpeak');
    
    plot(1, 'g', 'Tag', '1-downcorr-line');
    scatter(0, 0, 50, 'g', 'tag', '1-downcorr-scatter');
    scatter(0, 0, 250, 'g', 'filled', 'tag', '1-downcorr-maxpeak');
    hold off;
    
    
    channel2Ax = subplot(NROWS,1,3);
    hold on;
    plot(1, 'r', 'Tag', '2-upcorr-line');
    scatter(0, 0, 50, 'r', 'tag', '2-upcorr-scatter');
    scatter(0, 0, 250, 'r', 'filled', 'tag', '2-upcorr-maxpeak');
    
    plot(1, 'g', 'Tag', '2-downcorr-line');
    scatter(0, 0, 50, 'g', 'tag', '2-downcorr-scatter');
    scatter(0, 0, 250, 'g', 'filled', 'tag', '2-downcorr-maxpeak');
    hold off;
    
    
    
    channel3Ax = subplot(NROWS,1,4);
    hold on;
    plot(1, 'r', 'Tag', '3-upcorr-line');
    scatter(0, 0, 50, 'r', 'tag', '3-upcorr-scatter');
    scatter(0, 0, 250, 'r', 'filled', 'tag', '3-upcorr-maxpeak');
    
    plot(1, 'g', 'Tag', '3-downcorr-line');
    scatter(0, 0, 50, 'g', 'tag', '3-downcorr-scatter');
    scatter(0, 0, 250, 'g', 'filled', 'tag', '3-downcorr-maxpeak');
    hold off;
end