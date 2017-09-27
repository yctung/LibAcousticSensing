function [] =  PeakCallback ( obj, type, recorded_data )
    global PS; % user parse setting
    global CallbackCounter;
    global StartTime;
    
    
    %MaxTimePerCallback = duration(0, 0, PS.PERIOD / PS.FS);
    SecondsPerChirp = seconds(duration(0, 0, PS.PERIOD / PS.FS));
    
    FIGTAG = "TAG";
    
    if type == obj.CALLBACK_TYPE_ERROR
        fprintf(2, '[ERROR]: get the error callback data = %s', recorded_data);
        return;
    end
    
    % parse audio data
    if type == obj.CALLBACK_TYPE_DATA
        if obj.userfig == -1 % need to create a new UI window
            createUI(obj, FIGTAG);
            CallbackCounter = -1;
            StartTime = -1;
        else
            % If this is the first callback, assume it is on time
            if CallbackCounter == -1
                CallbackCounter = 0;
                StartTime = datetime;
            else
                CallbackCounter = CallbackCounter + size(recorded_data, 2);
            end
            
            NowTime = datetime;
            elapsedInSeconds = seconds(NowTime - StartTime);
            numChirps = floor(elapsedInSeconds / SecondsPerChirp);
            
            %sprintf('Number of chirps we probably have played %d', numChirps)
            [ CallbackCounter numChirps ]
            %sprintf('%d/%d', CallbackCounter, numChirps)
            
            % Only process this window if we're not lagging too much
            %if numChirps - CallbackCounter < 20
            drawChannel(1, recorded_data(:,end,1), FIGTAG);
            drawChannel(2, recorded_data(:,end,2), FIGTAG);
            %end
            
        end
    elseif type == obj.CALLBACK_TYPE_USER
        % parse user data
        % must be 'pse' in this app
        if recorded_data.code == 1 % update the vertical line
            PS.detectEnabled = 1;
            refIdx = detectResultsEnd-1;
            if refIdx<0
                refIdx = 1;
            end
            PS.detectRef = detectResults(refIdx); % latest detect reuslt is the reference

            line = findobj('Tag','line03_02');
            set(line, 'yData', zeros(DETECT_RESULT_SIZE,1)+ PS.detectRef); % only show the 1st ch
        else
            PS.detectEnabled = 0;
            PS.detectRef = 1;
        end
    end
end 

function drawChannel (channelIdx, onechannel, FIGTAG)
    global PS; % user parse setting
    global channel1Ax;
    global channel2Ax;

    
    upcorr = abs(convn(onechannel, PS.upchirp_data, 'same'));
    downcorr = abs(convn(onechannel, PS.downchirp_data, 'same'));

    line = findobj('tag', sprintf('%d-%s-upcorr-line', channelIdx, FIGTAG));
    sctplt = findobj('tag',  sprintf('%d-%s-upcorr-scatter', channelIdx, FIGTAG));
    maxpk = findobj('tag', sprintf('%d-%s-upcorr-maxpeak', channelIdx, FIGTAG));

    
    DOWNFACTOR = 10;
    ONLYTOP = 10;
    
    
    newx = downsample(1:size(upcorr(:,end,1)), DOWNFACTOR);
    set(line, 'xData', newx);
    set(line, 'yData', downsample(upcorr(:,end,1), DOWNFACTOR));
    [pks, locs] = findpeaks(upcorr);
    [topPks, topPksIdx] = sort(pks, 'descend');
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    [maxPk, maxInd] = max(pks);
    set(maxpk, 'xData', locs(maxInd));
    set(maxpk, 'yData', maxPk);

    line = findobj('tag', sprintf('%d-%s-downcorr-line', channelIdx, FIGTAG));
    sctplt = findobj('tag',  sprintf('%d-%s-downcorr-scatter', channelIdx, FIGTAG));
    maxpk = findobj('tag', sprintf('%d-%s-downcorr-maxpeak', channelIdx, FIGTAG));

    set(line, 'xData', newx);
    set(line, 'yData', downsample(downcorr(:,end,1), DOWNFACTOR));
    [pks, locs] = findpeaks(downcorr);
    [topPks, topPksIdx] = sort(pks, 'descend');
    set(sctplt, 'xData', locs(topPksIdx(1:ONLYTOP)));
    set(sctplt, 'yData', topPks(1:ONLYTOP));
    %set(sctplt, 'xData', locs);
    %set(sctplt, 'yData', pks);
    [maxPk, maxInd] = max(pks);
    set(maxpk, 'xData', locs(maxInd));
    set(maxpk, 'yData', maxPk);
    
    if channelIdx == 1
        ylim(channel1Ax, [0 max(pks) + max(pks)*0.1]);
    else
        ylim(channel2Ax, [0 max(pks) + max(pks)*0.1]);
    end
end

function createUI(obj, figTag)
    % lineCnts is the number of lines per figure
    global channel1Ax;
    global channel2Ax;
    
    PADDING = 50;
    WIDTH = 250;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    FigPos = [50,50,3*WIDTH+2*PADDING,PADDING*3+WIDTH*2];
    obj.userfig = figure('Position', FigPos,'Toolbar','none','MenuBar','none','Tag',figTag);
    set(obj.userfig,'UserData',obj); % attached the obj to fig property for future reference 
    
    
    channel1Ax = subplot(2,1,1);
    hold on;
    plot(1, 'r', 'Tag', sprintf('1-%s-upcorr-line', figTag));
    scatter(0, 0, 50, 'r', 'tag', sprintf('1-%s-upcorr-scatter', figTag));
    scatter(0, 0, 250, 'r', 'filled', 'tag', sprintf('1-%s-upcorr-maxpeak', figTag));
    
    plot(1, 'g', 'Tag', sprintf('1-%s-downcorr-line', figTag));
    scatter(0, 0, 50, 'g', 'tag', sprintf('1-%s-downcorr-scatter', figTag));
    scatter(0, 0, 250, 'g', 'filled', 'tag', sprintf('1-%s-downcorr-maxpeak', figTag));
    hold off;
    
    
    channel2Ax = subplot(2,1,2);
    hold on;
    plot(1, 'r', 'Tag', sprintf('2-%s-upcorr-line', figTag));
    scatter(0, 0, 50, 'r', 'tag', sprintf('2-%s-upcorr-scatter', figTag));
    scatter(0, 0, 250, 'r', 'filled', 'tag', sprintf('2-%s-upcorr-maxpeak', figTag));
    
    plot(1, 'g', 'Tag', sprintf('2-%s-downcorr-line', figTag));
    scatter(0, 0, 50, 'g', 'tag', sprintf('2-%s-downcorr-scatter', figTag));
    scatter(0, 0, 250, 'g', 'filled', 'tag', sprintf('2-%s-downcorr-maxpeak', figTag));
    hold off;
    
    
    %legend(arrayfun(@(x) sprintf('%d',x), 1:lineCnts(i),'uni',false).');
end