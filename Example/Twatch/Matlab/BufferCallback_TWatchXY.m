function BufferCallback_TWatchXY ()

    global PS CallbackCounter StartTime;    
    global FillUpBuffer FillUpPointers AlreadyProcessed;
    global detailsHandles aggregateDetails;
    global savedData doRecord savedRawData;
    
    
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
        
        PeakUp = zeros(1,NUMCHANNELS);
        PeakDown = zeros(1,NUMCHANNELS);
        PeakDiff = zeros(1,NUMCHANNELS);
        
        for chNum=1:NUMCHANNELS
            [PeakUp(chNum), PeakDown(chNum), PeakDiff(chNum)] = getPeaks(FillUpBuffer(:,AlreadyProcessed,chNum));
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
        
        % Indices 1 and 2 are from channels 1 and 2 of the Galaxy S5. 
        % This means, the those are the important channels. We can pick
        % either one of the other device.
        [xm1, ym1] = calculateXY(AllInterMicDistances(1), AllInterMicDistances(3));
        [xm2, ym2] = calculateXY(AllInterMicDistances(2), AllInterMicDistances(4));
        plotXY([xm1 xm2], [ym1 ym2]);
        
        set(aggregateDetails, 'string', sprintf('#%d. Avg = %fcm.', AlreadyProcessed, mean(AllInterMicDistances)*100));
        
        % Draw the distances
        dplot = findobj('tag',  'distancePlot');
        
        
        set(dplot, 'xData', AllInterMicDistances);
        set(dplot, 'yData', zeros(size(AllInterMicDistances)));
        
        
        % If we are saving data, we will save these
        %toggleButton = findobj('tag', 'recordtoggle');
        if (doRecord)
            nextIdx = length(savedData)+1;
            savedData(nextIdx).peakUp = PeakUp;
            savedData(nextIdx).peakDown = PeakDown;
            savedData(nextIdx).peakDiff = PeakDiff;
            savedData(nextIdx).interMicDistances = AllInterMicDistances;
            savedData(nextIdx).xm1 = xm1;
            savedData(nextIdx).ym1 = ym1;
            savedData(nextIdx).xm2 = xm2;
            savedData(nextIdx).ym2 = ym2;
            
            savedRawData(:, nextIdx, :) = FillUpBuffer(:, AlreadyProcessed, :);
        end
        
   end
end


function plotXY (x, y)
    global xyplt;
    set(xyplt, 'xData', x);
    set(xyplt, 'yData', y);
end



function [x, y] = calculateXY(r1, r2)
    D = 0.142; % Mic to speaker distance -- fixed
    x = (D^2 - r2^2 + r1^2) / (2*D);
    if r1^2 - x^2 < 0
        y = -1;
    else
        y = sqrt(r1^2 - x^2);
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



function peakLocation = getPeaksForCorr (xcorr)
    [pks, locs] = findpeaks(xcorr);
    %[topPks, topPksIdx] = sort(pks, 'descend');
    [~, maxPkIdx] = max(pks);
    peakLocation = locs(maxPkIdx);
end

function [peakUp, peakDown, peakDiff] = getPeaks (onechannel)
    global PS; % user parse setting    
    
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
    
    
   
    
    peakUp = getPeaksForCorr(upcorr);
    peakDown = getPeaksForCorr(downcorr);
    peakDiff = peakDown - peakUp;
end





function recordToggleCallback (hObject, ~, ~)
    global savedData doRecord savedRawData FillUpBuffer;
    
    button_state = get(hObject,'Value');
    expLabel = findobj('tag', 'explabel');
    buttonName = get(hObject, 'string');
    if button_state == get(hObject, 'Max')
        % Reset data
        savedData = [];
        [PeriodSize, ~, NumChannels] = size(FillUpBuffer);
        savedRawData = zeros(PeriodSize, 0, NumChannels);
        doRecord = 1;
    else 
        % Download the data
        prefix = get(expLabel, 'String');
        saveName = sprintf('experiments/%s-%s', prefix, buttonName);
        save(saveName, 'savedData', 'savedRawData');
        doRecord = 0;
        savedData = [];
        %savedRawData = zeros(PeriodSize, 0, NumChannels);
    end
end
    

function createUI()
    % lineCnts is the number of lines per figure
    global FillUpPointers;
    global xyplt;
    global detailsHandles aggregateDetails;
    
    
    NUMCHANNELS = length(FillUpPointers);
    NROWS = 5;
    
    
    FONTSIZE = 15;
    
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
            'string', sprintf('c%d', i), ...
            'fontsize', FONTSIZE,  ...
            'Callback', @recordToggleCallback);
    end
    
    
    
    %% Draw X/Y plot
    subplot(NROWS, 1, 2:NROWS);
    hold on;
    xyplt = scatter(0, 0, 50, 'r');
    xlim([-2,2]);
    ylim([-2,2]);
    grid on;
    hold off;
end
