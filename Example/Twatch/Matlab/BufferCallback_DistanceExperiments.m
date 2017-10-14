function BufferCallback_DistanceExperiments ()

    global PS CallbackCounter StartTime;    
    global FillUpBuffer FillUpPointers AlreadyProcessed;
    global detailsHandles aggregateDetails;
    global savedData doRecord;
    
    
    NUMCHANNELS = length(FillUpPointers);
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
        doRecord = 0;
    else
        AlreadyProcessed = AlreadyProcessed + 1;
        
        %if CallbackCounter == -1
        %    CallbackCounter = 0;
        %    StartTime = datetime;
        %else
        %    CallbackCounter = CallbackCounter + 1;
        %end
        %
        %NowTime = datetime;
        %elapsedInSeconds = seconds(NowTime - StartTime);
        %numChirps = floor(elapsedInSeconds / SecondsPerChirp);

        %[ CallbackCounter numChirps ]
        
        PeakUp = zeros(1,NUMCHANNELS);
        PeakDown = zeros(1,NUMCHANNELS);
        PeakDiff = zeros(1,NUMCHANNELS);
        
        for chNum=1:NUMCHANNELS
            [PeakUp(chNum), PeakDown(chNum), PeakDiff(chNum)] = drawChannel(chNum, FillUpBuffer(:,AlreadyProcessed,chNum));
            set(detailsHandles(chNum), 'string', sprintf('Channel %d: Up:%d, Down:%d, Diff:%d', chNum, PeakUp(chNum), PeakDown(chNum), PeakDiff(chNum)));
        end
        
        
        % Distance between c1 and c3.
        % For X distances, we will calculate distance between all
        % combinations of things
        NumDevices = NUMCHANNELS/2;
        AllInterMicDistances = zeros(1, nchoosek(NumDevices, 2)*2);
        LocationIndex = 1;
        for Dev1=1:NumDevices
            for Dev2=Dev1+1:NumDevices
                d13 = calcDistance(PeakDown, PeakUp, Dev1*2-1, Dev2*2-1);
                d14 = calcDistance(PeakDown, PeakUp, Dev1*2-1, Dev2*2);
                d23 = calcDistance(PeakDown, PeakUp, Dev1*2, Dev2*2-1);
                d24 = calcDistance(PeakDown, PeakUp, Dev1*2, Dev2*2);
                
                AllInterMicDistances(LocationIndex:LocationIndex+3) = [d13 d14 d23 d24];
                LocationIndex  = LocationIndex + 4;
            end
        end
        
        set(aggregateDetails, 'string', sprintf('#%d. Avg = %fcm.', AlreadyProcessed, mean(AllInterMicDistances)*100));
        
        % Draw the distances
        dplot = findobj('tag',  'distancePlot');
        set(dplot, 'xData', AllInterMicDistances);
        set(dplot, 'yData', zeros(size(AllInterMicDistances)));
        
        
        % If we are saving data, we will save these
        %toggleButton = findobj('tag', 'recordtoggle');
        if (doRecord)
            savedData = [savedData; PeakUp PeakDown PeakDiff AllInterMicDistances];
            size(savedData)
        end
        
   end
end

function recordToggleCallback (hObject, ~, ~)
    global savedData doRecord; 
    button_state = get(hObject,'Value');
    expLabel = findobj('tag', 'explabel');
    buttonName = get(hObject, 'string');
    if button_state == get(hObject, 'Max')
        % Reset data
        savedData = [];
        doRecord = 1;
    %elseif button_state == get(hObject, 'Min')
    else
        % Download the data
        prefix = get(expLabel, 'String');
        saveName = sprintf('experiments/%s-%s', prefix, buttonName);
        save(saveName, 'savedData');
        doRecord = 0;
        savedData = [];
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
end


function setYBound (chnlAx, maxY)
    %maxY = max(pks)+max(pks)*0.1;
    %'--------------'
    %[size(pks); size(maxY)]
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
    NROWS = 2 + NUMCHANNELS;
    
    
    FONTSIZE = 20;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    %FigPos = [50,50,1000,1000];
    %figure('Position', FigPos,'Toolbar','none','MenuBar','none','Tag','PeakFig');
    figure('Toolbar','none','MenuBar','none','Tag','PeakFig');
    
    hold on;
    
    
    %% Draw the details texts
    h_panel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  (NROWS - 1)/NROWS 0.5 1/NROWS]);  %top row
    for chNum=1:NUMCHANNELS
        detailsHandles(chNum) = uicontrol(h_panel, ...
                'Style','text',...
                'units', 'normalized', ...
                'Position',[0, (NUMCHANNELS-chNum)/(NUMCHANNELS+1), 1, 1/(NUMCHANNELS+1)],...
                'FontSize',FONTSIZE ,...
                'String',sprintf('Ch %d details', chNum));
            
    end
            
   aggregateDetails = uicontrol(h_panel, ...
    'Style','text',...
    'units', 'normalized', ...
    'Position',[0, (NUMCHANNELS)/(NUMCHANNELS+1), 1, 1/(NUMCHANNELS+1)],...
    'FontSize',FONTSIZE ,...
    'String','Aggregate details');
    

    %% Experiment recording panel
    h_panel2 = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0.5  (NROWS - 1)/NROWS 0.5 1/NROWS]); 
    uicontrol(h_panel2, 'tag', 'explabel', 'style','edit','units','normal','position',[0.1 0.1 0.3 0.8], 'String', 'default' ,'FontSize', FONTSIZE);
    
    % Create 10 cases. 2x5
    for i=1:10
        if i < 6
            xcoord = 0.3 + i*0.1;
            ycoord = 0.5;
        else
            xcoord = 0.3 + (i-5)*0.1;
            ycoord = 0.1;
        end
        uicontrol(h_panel2, ...
            'tag', 'recordtoggle', ...
            'style', 'togglebutton', ...
            'units', 'normal', ...
            'position', [xcoord ycoord 0.1 0.4], ...
            'string', sprintf('%dcm', i*10), ...
            'fontsize', FONTSIZE,  ...
            'Callback', @recordToggleCallback);
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
    
    
    %'Created UI!!!!!!'
    %size(plotHandles)
    
    
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
