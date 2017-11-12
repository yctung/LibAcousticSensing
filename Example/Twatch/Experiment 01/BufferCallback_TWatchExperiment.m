function BufferCallback_TWatchExperiment ()
    global FillUpBuffer savedLabels FillUpPointers AlreadyProcessed;
    global CorrBuffer XYBuffer;
    global currentExpStep ongoingExperiment;
    global AcceptTaps TapReceived;
    global aggregateDetails;
    global BN_A BN_B BN_P;
    global c1ego c2ego c3ego;
    global c1window c2window c3window;
    global c1DownPeak c2DownPeak c3UpPeak;
    global initialized doneTraining;
    
    global recordedBorder referenceBorder; 
    global minX maxX minY maxY;
    
    global NROWS NCOLS;
    global handles;
    
    
    global confPlot currentPoint;
    global PS;
    
    global CORRSIZE;

    
    
    if any(FillUpPointers <= AlreadyProcessed)
        return;
    end
    
    fig = findobj('Tag', 'PeakFig');
    FLIPX = 1;
    if isempty(fig)
        CORRSIZE = 501;
        initialized = 0;
        doneTraining = 0;
        CorrBuffer = zeros(CORRSIZE, 2000, 4);
        NROWS = 4;
        NCOLS = 4;
        XYBuffer = zeros(2000, 2);
        createUI();
        savedLabels = [];
        c1DownPeak = -1;
        c2DownPeak = -1;
        c3UpPeak = -1;
    else
        AlreadyProcessed = AlreadyProcessed + 1;
        set(aggregateDetails, 'string', sprintf('#%d', AlreadyProcessed));
        %savedLabels{AlreadyProcessed} = groundLabel;
        
        
        if initialized
            lastWindow = FillUpBuffer(:,AlreadyProcessed,:);
            
            c1downcorr = abs(convn(lastWindow(:,1), PS.downchirp_data, 'same'));
            c2downcorr = abs(convn(lastWindow(:,2), PS.downchirp_data, 'same'));
            c3upcorr = abs(convn(lastWindow(:,3), PS.upchirp_data, 'same'));
            
            %c1downcorr = smooth(c1downcorr, 'moving', 10);
            %c2downcorr = smooth(c2downcorr, 'moving', 10);
            %c3upcorr = smooth(c3upcorr, 'moving', 10);
            
            
            c1downcorr = c1downcorr(c1window(1):c1window(2));
            c2downcorr = c2downcorr(c2window(1):c2window(2));
            c3upcorr = c3upcorr(c3window(1):c3window(2));
            
            CorrBuffer(:, AlreadyProcessed, 1) = c1downcorr;
            CorrBuffer(:, AlreadyProcessed, 2) = c2downcorr;
            CorrBuffer(:, AlreadyProcessed, 3) = c3upcorr;
            
            c1uppeak = c1ego;
            c2uppeak = c2ego;
            c3downpeak = c3ego;
            
            if c1DownPeak == -1 % This means we haven't initialized peaks yet
                c1DownPeak = getPeaksForCorr(CorrBuffer(:, AlreadyProcessed, 1));
                c2DownPeak = getPeaksForCorr(CorrBuffer(:, AlreadyProcessed, 2));
                c3UpPeak = getPeaksForCorr(CorrBuffer(:, AlreadyProcessed, 3));
            else % We did initialize and found a peak before this. We're ready to go!
                c1DownPeak = singleconftrack(CorrBuffer(:, AlreadyProcessed-1, 1), CorrBuffer(:, AlreadyProcessed, 1), c1DownPeak - c1window(1) + 1);
                c2DownPeak = singleconftrack(CorrBuffer(:, AlreadyProcessed-1, 2), CorrBuffer(:, AlreadyProcessed, 2), c2DownPeak - c2window(1) + 1);
                c3UpPeak = singleconftrack(CorrBuffer(:, AlreadyProcessed-1, 3), CorrBuffer(:, AlreadyProcessed, 3), c3UpPeak - c3window(1) + 1);
            end
            
            if abs(c1DownPeak - c2DownPeak) > 25
                earlier = min(c1DownPeak, c2DownPeak);
                newWindow = [earlier-c1window(1)+1-15, earlier-c1window(1)+1+15];
                [~, c1DownPeak] = max(CorrBuffer(newWindow(1):newWindow(2), AlreadyProcessed, 1));
                [~, c2DownPeak] = max(CorrBuffer(newWindow(1):newWindow(2), AlreadyProcessed, 2));
            end
            
            %c1PeakBuffer(AlreadyProcessed) = c1DownPeak;
            %c2PeakBuffer(AlreadyProcessed) = c2DownPeak;
            %c3PeakBuffer(AlreadyProcessed) = c3UpPeak;
            
            c1DownPeak =  c1DownPeak + c1window(1) - 1;
            c2DownPeak = c2DownPeak + c2window(1) - 1;
            c3UpPeak = c3UpPeak + c3window(1) - 1;
            
            PeakDown = [c1DownPeak c2DownPeak c3downpeak];
            PeakUp = [c1uppeak c2uppeak c3UpPeak];
            d13 = calcDistance(PeakDown, PeakUp, 1, 3, 0.14, 0.01);
            d23 = calcDistance(PeakDown, PeakUp, 2, 3, 0.06, 0.01);
            
            AllInterMicDistances = [d13 d23];
            [xm1, ym1] = calculateXY(AllInterMicDistances(1), AllInterMicDistances(2), 0.142);
            %if FLIPX
            %    xm1 = -xm1;
            %end
            
            XYBuffer(AlreadyProcessed, :) = [xm1 ym1];
         
            LASTN = 100;   
            set(confPlot, 'xdata', smooth(XYBuffer(max(1, AlreadyProcessed-LASTN):AlreadyProcessed, 1), 4));
            set(confPlot, 'ydata', smooth(XYBuffer(max(1, AlreadyProcessed-LASTN):AlreadyProcessed, 2), 4));
            
            set(handles.c1CorrPlot, 'ydata', c1downcorr);
            set(handles.c2CorrPlot, 'ydata', c2downcorr);
            set(handles.c3CorrPlot, 'ydata', c3upcorr);
            set(handles.c1CorrPeak, 'xdata', c1DownPeak-c1window(1)+1);
            set(handles.c1CorrPeak, 'ydata', c1downcorr(c1DownPeak-c1window(1)+1));
            set(handles.c2CorrPeak, 'xdata', c2DownPeak-c2window(1)+1);
            set(handles.c2CorrPeak, 'ydata', c2downcorr(c2DownPeak-c2window(1)+1));
            set(handles.c3CorrPeak, 'xdata', c3UpPeak-c3window(1)+1);
            set(handles.c3CorrPeak, 'ydata', c3upcorr(c3UpPeak-c3window(1)+1));
            
            
            if doneTraining
                x = xm1;
                y = ym1;
                
                if FLIPX    
                    x = -x;
                end
                
                width = maxX - minX;
                height = maxY - minY;
                x = (x - minX) / width;
                y = (y - minY) / height;
                
                % Go through beier neely!
                mappedPoint = bnTransform(recordedBorder, referenceBorder, [x y; x y], BN_A, BN_B, BN_P);
                set(currentPoint, 'xdata', mappedPoint(1, 1));
                set(currentPoint, 'ydata', mappedPoint(1, 2));
                
                
                if TapReceived && AcceptTaps && doneTraining % Not strictly necessary to check the third item
                    highlightButtonAt(mappedPoint(1, 1), mappedPoint(1, 2));
                end
            end
        end
        
        if TapReceived && AcceptTaps && ~doneTraining
            event = [];
            event.Modifier = [];
            event.Key = 'space';
            Key_Down(0, event);
        end
        
        TapReceived = 0;
        
        if ongoingExperiment
            savedLabels(AlreadyProcessed) = currentExpStep;
        else
            savedLabels(AlreadyProcessed) = -1;
        end
   end
end


function saveButton (~, ~)
    global FillUpBuffer savedLabels AlreadyProcessed;
    rawData = FillUpBuffer(:,1:AlreadyProcessed,:);
    expLabel = findobj('tag', 'explabel');
    prefix = get(expLabel, 'String');
    saveName = sprintf('experiments/%s', prefix);
    save(saveName, 'rawData', 'savedLabels');
end


function Key_Down(~, event)
    global expSteps currentExpStep expFig ongoingExperiment;
    global recordedBorder referenceBorder doneTraining;
    global currentPoint;
    global minX maxX minY maxY;
    global handles;
    global BN_P BN_A BN_B;
    
    if isempty(event.Modifier) && strcmp(event.Key, 'space')
        % Space is pressed.
        % If currently doing one experiment, we will stop the label and
        % highlight the next experiment using a light highlight.
        % If we are not currently doing an experiment, start the current
        % experiment and highlight experiment with bold highlight.
        
        INACTIVE_COLOR = [0.6 0.6 0.6];
        PREP_COLOR = [0 0 0];
        CURRENT_COLOR = [1 0 0];
        
        experimentObjects = findall(expSteps, 'type', 'line');
        set(experimentObjects, 'color', INACTIVE_COLOR);
        experimentObjects = findall(expSteps, 'type', 'scatter');
        set(experimentObjects, 'markerfacecolor', INACTIVE_COLOR);
        set(experimentObjects, 'markerEdgeColor', INACTIVE_COLOR);
        
        if ongoingExperiment
            ongoingExperiment = 0;
            currentExpStep = currentExpStep + 1;
            if currentExpStep > length(expSteps) 
                if ~doneTraining
                    doneTraining = 1;
                    disp('All done!');
                    set(currentPoint, 'visible', 'on');
                    [minX, maxX, minY, maxY, recordedBorder] = getPoints;
                    referenceBorder = getReference;
                    
                    set(handles.instructionText, 'string', 'Finding deformation. Please wait.');
                    drawnow;
                    [BN_A, BN_B, BN_P, ~] = BNSearch(recordedBorder, referenceBorder);
                    
                    set(handles.instructionText, 'visible', 'off');
                    drawnow;
                    drawbuttons;
                end
                
                return;
            end
            currStep = expSteps(currentExpStep);
            if strcmp(get(currStep, 'type'), 'line')
                set(currStep, 'color', PREP_COLOR);
            else
                set(currStep, 'MarkerFaceColor', PREP_COLOR);
                set(currStep, 'MarkerEdgeColor', PREP_COLOR);
            end
        else
            ongoingExperiment = 1;
            currStep = expSteps(currentExpStep);
            if strcmp(get(currStep, 'type'), 'line')
                set(currStep, 'color', CURRENT_COLOR);
            else
                set(currStep, 'MarkerFaceColor', CURRENT_COLOR);
                set(currStep, 'MarkerEdgeColor', CURRENT_COLOR);
            end
        end
    end
end



function findWindowsAndEgoCallback(~, ~, ~)
    global initialized;
    global c1ego c2ego c3ego;
    global c1window c2window c3window;
    global FillUpBuffer AlreadyProcessed;
    global PS;
    % Take the last correlation 
    % Find the ego sounds in c1-up, c2-up, c3-down
    % Use those to set the windows for c1-down, c2-down and c3-up
    
    lastWindow = FillUpBuffer(:, AlreadyProcessed, :);
    % Ego sounds: 
    c1upcorr = abs(convn(lastWindow(:,1), PS.upchirp_data, 'same'));
    c2upcorr = abs(convn(lastWindow(:,2), PS.upchirp_data, 'same'));
    c3downcorr = abs(convn(lastWindow(:,3), PS.downchirp_data, 'same'));
    
    [~, c1ego] = max(c1upcorr);
    [~, c2ego] = max(c2upcorr);
    [~, c3ego] = max(c3downcorr);
    
    c1window = [c3ego-100 c3ego+400];
    c2window = [c3ego-100 c3ego+400];
    c3window = [c1ego-100 c1ego+400];
    initialized = 1;
    
    fprintf('c1ego=%d c2Ego=%d c3Ego=%d, c1Window=[%d, %d], c2Window=[%d, %d] c3Window=[%d, %d]\n', ...
            c1ego, c2ego, c3ego, ...
            c1window(1), c1window(2), ...
            c2window(1), c2window(2), ...
            c3window(1), c3window(2));
end

function startTapCallback (~, ~, ~)
    global AcceptTaps TapsReceived;
    AcceptTaps = 1;
    TapsReceived = 0;
end


function createUI()
    % lineCnts is the number of lines per figure
    global aggregateDetails;
    global currentPoint;
    global expSteps currentExpStep expFig ongoingExperiment;
    global confPlot statelessPlot;
    global handles;
    global CORRSIZE;
    currentExpStep = 1;
    ongoingExperiment = 0;
    
    FONTSIZE = 20;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    figure('Toolbar','none','MenuBar','none','Tag','PeakFig');
    
    h_panel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  0 1 0.5]);
    
            
   aggregateDetails = uicontrol(h_panel, ...
    'Style','text',...
    'units', 'normalized', ...
    'Position',[0 0 1 0.9],...
    'FontSize',100 ,...
    'String','Num');
    
    
    %% Experiment recording panel
    h_panel2 = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  0.5 1 0.5]); 
    
    uicontrol(h_panel2, ...
        'tag', 'explabel',...
        'style','edit',...
        'units','normal',...
        'position',[0.0 0.5 0.5 0.5], ...
        'String', 'default',...
        'FontSize', FONTSIZE);
    
    uicontrol(h_panel2, ...
        'style','pushbutton', ...
        'units','normal', ...
        'position',[0.0 0 0.5 0.5], ...
        'String', 'Done!', ...
        'FontSize', FONTSIZE, ...
        'Callback', @saveButton);
     
        
    uicontrol(h_panel2, ...
        'style','pushbutton', ...
        'units','normal', ...
        'position',[0.5 0.5 0.5 0.5], ...
        'String', 'Find Windows and Ego', ...
        'FontSize', FONTSIZE, ...
        'Callback', @findWindowsAndEgoCallback);



    uicontrol(h_panel2, ...
        'style','pushbutton', ...
        'units','normal', ...
        'position',[0.5 0.0 0.5 0.5], ...
        'String', 'Start Tapping', ...
        'FontSize', FONTSIZE, ...
        'Callback', @startTapCallback);
    
        
    % Draw experiment window
    expFig = figure(123);
    handles.expAx = subplot(1,1,1);
    hold on;
    expSteps = zeros(1, 6);
    expSteps(1) = plot([0 1], [1 1]);
    expSteps(2) = plot([1 1], [1 0]);
    expSteps(3) = plot([0 1], [0 0]);
    expSteps(4) = plot([0 0], [0 1]);
    expSteps(5) = plot([0 1], [0.5 0.5]);
    expSteps(6) = plot([0.5 0.5], [0 1]);
    
    handles.instructionText = text(0.23, 0.5, 'Please trace the border');
    
    currentPoint = scatter(0, 0, 150, 'r', 'filled');
    currentPoint.Visible = 'off';
    xlim([-0.1 1.1]);
    ylim([-0.1 1.1]);
    hold off;
    
    set(expFig, 'KeyPressFcn', @Key_Down);
    
    figure;
    subplot(3,2,[1 3 5]);
    confPlot = plot(0, 0, 'r');
    
    subplot(3,2,2);
    hold on;
    handles.c1CorrPlot = plot(zeros(1, CORRSIZE));
    handles.c1CorrPeak = scatter(0,0);
    hold off;
    
    subplot(3,2,4);
    hold on;
    handles.c2CorrPlot = plot(zeros(1, CORRSIZE));
    handles.c2CorrPeak = scatter(0,0);
    hold off;
    
    subplot(3,2,6);
    hold on;
    handles.c3CorrPlot = plot(zeros(1, CORRSIZE));
    handles.c3CorrPeak = scatter(0,0);
    hold off;
end












function drawbuttons
%DRAWBU Summary of this function goes here
%   Detailed explanation goes here
    global handles;
    global NCOLS NROWS;

    
    axes(handles.expAx);
    hold on;
    for r=1:NROWS
        for c=1:NCOLS
            x = (c/NCOLS + (c-1)/NCOLS)/2.0;
            y = ((1-r/NROWS) + (1-(r-1)/NROWS)) / 2.0;
            s = scatter(x, y);
            s.ZData = 10;
        end
    end
    
    for r=1:NROWS
        plot([0 1], [1-r/NROWS 1-r/NROWS]);
    end
    
    for c=1:NCOLS
        plot([c/NCOLS c/NCOLS], [0 1]);
    end
    
    handles.highlightedPart = fill(0, 0, 'r');
    
    hold off;
    
    %return;
    %fprintf('Ready?\n');
    %pause;
    
  
    
    %highlightButtonAt(0.23, 0.6);
end


function highlightButtonAt (x, y)
    global NCOLS NROWS;
    x = round(x*100);
    y = round((1-y)*100);
    perCol = round(1/NCOLS*100);
    perRow = round(1/NROWS*100);
    
    col = ceil(x/perCol);
    row = ceil(y/perRow);
    highlightButton(row, col);
end

function highlightButton (r, c)
    global NCOLS NROWS;
    global handles;
    x = [(c-1)/NCOLS c/NCOLS c/NCOLS (c-1)/NCOLS];
    y = [(1-r/NROWS) (1-r/NROWS) (1-(r-1)/NROWS) (1-(r-1)/NROWS)];
    set(handles.highlightedPart, 'xdata', x);
    set(handles.highlightedPart, 'ydata', y);
end
