function [] =  PeakCallback ( obj, type, recorded_data )
    global PS; % user parse setting
    FIGTAG = "TAG";
    
    if type == obj.CALLBACK_TYPE_ERROR
        fprintf(2, '[ERROR]: get the error callback data = %s', recorded_data);
        return;
    end
    
    % parse audio data
    if type == obj.CALLBACK_TYPE_DATA
        if obj.userfig == -1 % need to create a new UI window
            createUI(obj, FIGTAG);
        else
            drawChannel(1, recorded_data(:,end,1), FIGTAG);
            drawChannel(2, recorded_data(:,end,2), FIGTAG);
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
    upcorr = abs(convn(onechannel, PS.upchirp_data, 'same'));
    downcorr = abs(convn(onechannel, PS.downchirp_data, 'same'));

    line = findobj('tag', sprintf('%d-%s-upcorr-line', channelIdx, FIGTAG));
    sctplt = findobj('tag',  sprintf('%d-%s-upcorr-scatter', channelIdx, FIGTAG));
    maxpk = findobj('tag', sprintf('%d-%s-upcorr-maxpeak', channelIdx, FIGTAG));

    set(line, 'yData', upcorr(:,end,1));
    [pks, locs] = findpeaks(upcorr);
    set(sctplt, 'xData', locs);
    set(sctplt, 'yData', pks);
    [maxPk, maxInd] = max(pks);
    set(maxpk, 'xData', locs(maxInd));
    set(maxpk, 'yData', maxPk);

    line = findobj('tag', sprintf('%d-%s-downcorr-line', channelIdx, FIGTAG));
    sctplt = findobj('tag',  sprintf('%d-%s-downcorr-scatter', channelIdx, FIGTAG));
    maxpk = findobj('tag', sprintf('%d-%s-downcorr-maxpeak', channelIdx, FIGTAG));

    set(line, 'yData', downcorr(:,end,1));
    [pks, locs] = findpeaks(downcorr);
    set(sctplt, 'xData', locs);
    set(sctplt, 'yData', pks);
    [maxPk, maxInd] = max(pks);
    set(maxpk, 'xData', locs(maxInd));
    set(maxpk, 'yData', maxPk);

    ylim([0 max(pks) + max(pks)*0.1]);
end

function createUI(obj, figTag)
    % lineCnts is the number of lines per figure
    global channel1Ax;
    global channel2Ax;
    
    PADDING = 50;
    WIDTH = 250;
    BUTTON_HEIGHT = 50;
    
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