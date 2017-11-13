function BufferCallback_PeakFeedback ()
    global FillUpBuffer FillUpPointers AlreadyProcessed;
    global masterFig;
    global peakAlgorithm chirpDir channel smoothSliderVal;
    global fullCorr zoomCorr highlightedRect;
    global zoomXlim zoomAx fullAx;
    global PS peakLocScatter;
    
    DidMicModeCheck = 0;
    
    if any(FillUpPointers <= AlreadyProcessed)
        return;
    end
    
    if isempty(masterFig)
        createUI();
        drawExp();
    else
        AlreadyProcessed = AlreadyProcessed + 1;
        
        %peakAlgorithmToggle chirpDirectionToggle channelToggle
        %get(peakAlgorithmToggle, 'value');
        %chirpDir = get(chirpDirectionToggle, 'value');
        %channel = get(channelToggle, 'value');
        %fprintf('Visualizing corr for %s and channel %d smoothed by %f \n', chirpDir, channel, smoothSliderVal);
        onechannel = FillUpBuffer(:, AlreadyProcessed, channel);
        if strcmp(chirpDir, 'Up')
            corr = abs(convn(onechannel, PS.upchirp_data, 'same'));
        else
            corr = abs(convn(onechannel, PS.downchirp_data, 'same'));
        end
        
        if round(smoothSliderVal) > 0
            smoothInt = round(smoothSliderVal);
            zoomcorr = smooth(corr, smoothInt);
        else
            zoomcorr = corr;
        end
        
        if strcmp(peakAlgorithm, 'Stateless')
            corrSubset = zoomcorr(zoomXlim(1):zoomXlim(2));
            peakLoc = getPeaksForCorr(corrSubset);
            peakMag = corrSubset(peakLoc);
            peakLoc = zoomXlim(1) + peakLoc - 1;
            set(peakLocScatter, 'xdata', peakLoc);
            set(peakLocScatter, 'ydata', peakMag);
        elseif strcmp(peakAlgorithm, 'Track')
        end
        
        set(fullCorr, 'ydata', corr);
        set(zoomCorr, 'ydata', zoomcorr);
        set(fullAx, 'ylim', [1 Inf]);
        set(zoomAx, 'ylim', [1 Inf]);
        set(highlightedRect, 'xdata', zoomXlim);
        set(highlightedRect, 'ydata', [max(zoomcorr), max(zoomcorr)]);
        title(sprintf('%d', AlreadyProcessed));
   end
end

function chirpDirChange (hobject, eventData, handles)
    global chirpDir;
    chirpDir = eventData.NewValue.String;
end

function channelChange (~, eventData, ~)
    global channel;
    channel = str2num(eventData.NewValue.String);
end

function peakAlgChange (~, eventData, ~)
    global peakAlgorithm;
    peakAlgorithm = eventData.NewValue.String;
end

function smoothSliderChange (~, eventData)
    global smoothSliderVal;
    smoothSliderVal = eventData.Source.Value;
end

function adjustZoom (~, ~)
    global zoomXlim fullAx zoomAx;
%     axes(fullAx);
    zoomXlim = xlim;
    xlim(zoomAx, zoomXlim);
    xlim([1 Inf]);
end

function createUI()
    global fullCorr zoomCorr masterFig;
    global peakAlgorithmToggle chirpDirectionToggle channelToggle;
    global peakAlgorithm chirpDir channel;
    global smoothSlider zoomAx zoomXlim fullAx highlightedRect;
    global PS smoothSliderVal;
    global peakLocScatter;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    masterFig = figure;
    
    
    zoomAx = subplot(2,2,1);
    hold on;
    zoomCorr = plot(1:PS.PERIOD, zeros(1, PS.PERIOD));
    peakLocScatter = scatter(0, 0, 50, 'r', 'filled');
    zoomXlim = [1 PS.PERIOD];
    hold off;
    zoom xon;
    
    fullAx = subplot(2,2,[3 4]);
    hold on;
    fullCorr = plot(1:PS.PERIOD, zeros(1, PS.PERIOD));
    highlightedRect = area([0 1], [1 1], 'FaceColor', 'red');
    alpha(highlightedRect, 0.2);
    zoom xon;
    h = zoom;
    h.ActionPostCallback = @adjustZoom;
    hold off;
        
    
    h_panel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0.5 0.5 0.5 0.5]);
    
    NROWS = 4;
    
    % Chirp direction toggle
    chirpDirectionToggle = uibuttongroup(h_panel, ...
                    'Visible','off',...
                    'units', 'normal', ...
                    'Position',[0 (NROWS-1)/NROWS 1 1/NROWS],...
                    'SelectionChangedFcn',@chirpDirChange);
    
    uicontrol(chirpDirectionToggle, ...
            'style', 'togglebutton', ...
            'string', 'Up', ...
            'units', 'normal', ...
            'position', [0 0 0.5 1]);
            
    uicontrol(chirpDirectionToggle, ...
            'style', 'togglebutton', ...
            'string', 'Down', ...
            'units', 'normal', ...
            'position', [0.5 0 0.5 1]);
        
    chirpDir = 'Up';
    chirpDirectionToggle.Visible = 'on';
    
    % Channel toggle
    channelToggle = uibuttongroup(h_panel, ...
                    'Visible','off',...
                    'units', 'normal', ...
                    'Position',[0 (NROWS-2)/NROWS 1 1/NROWS],...
                    'SelectionChangedFcn',@channelChange);
    
    uicontrol(channelToggle, ...
            'style', 'togglebutton', ...
            'string', '1', ...
            'units', 'normal', ...
            'position', [0 0 0.25 1]);
            
    uicontrol(channelToggle, ...
            'style', 'togglebutton', ...
            'string', '2', ...
            'units', 'normal', ...
            'position', [0.25 0 0.25 1]);
        
    uicontrol(channelToggle, ...
        'style', 'togglebutton', ...
        'string', '3', ...
        'units', 'normal', ...
        'position', [0.5 0 0.25 1]);

    uicontrol(channelToggle, ...
        'style', 'togglebutton', ...
        'string', '4', ...
        'units', 'normal', ...
        'position', [0.75 0 0.25 1]);

    channelToggle.Visible = 'on';
    channel = str2num('1');
    
    % Peak algorithm toggle
    peakAlgorithmToggle = uibuttongroup(h_panel, ...
                    'Visible','off',...
                    'units', 'normal', ...
                    'Position',[0 (NROWS-3)/NROWS 1 1/NROWS],...
                    'SelectionChangedFcn',@peakAlgChange);
    
    uicontrol(peakAlgorithmToggle, ...
            'style', 'togglebutton', ...
            'string', 'None', ...
            'units', 'normal', ...
            'position', [0 0 0.33 1]);
            
    uicontrol(peakAlgorithmToggle, ...
            'style', 'togglebutton', ...
            'string', 'Stateless', ...
            'units', 'normal', ...
            'position', [0.33 0 0.33 1]);
        
    uicontrol(peakAlgorithmToggle, ...
        'style', 'togglebutton', ...
        'string', 'Track', ...
        'units', 'normal', ...
        'position', [0.66 0 0.33 1]);
    
    peakAlgorithmToggle.Visible = 'on';
    peakAlgorithm = 'None';
    
    % Smooth slider
    smoothSlider = uicontrol(h_panel, ...
        'Style', 'slider',...
        'Min',0,'Max',50,'Value',0,...
        'units', 'normal',...
        'Position', [0 (NROWS-4)/NROWS 1 1/NROWS],...
        'Callback', @smoothSliderChange); 
    smoothSliderVal = 0;
end



function drawExp 
    expFig = figure(123);
    ax = subplot(1,1,1);
    hold on;
    expSteps = zeros(1, 22);
    expSteps(1) = plot([0 1], [1 1]);
    expSteps(2) = plot([1 1], [1 0]);
    expSteps(3) = plot([0 1], [0 0]);
    expSteps(4) = plot([0 0], [0 1]);
    expSteps(5) = plot([0 1], [0.5 0.5]);
    expSteps(6) = plot([0.5 0.5], [0 1]);
    
    expSteps(7) = scatter(1/5, 4/5);
    expSteps(8) = scatter(2/5, 4/5);
    expSteps(9) = scatter(3/5, 4/5);
    expSteps(10) = scatter(4/5, 4/5);
    
    expSteps(11) = scatter(1/5, 3/5);
    expSteps(12) = scatter(2/5, 3/5);
    expSteps(13) = scatter(3/5, 3/5);
    expSteps(14) = scatter(4/5, 3/5);
    
    expSteps(15) = scatter(1/5, 2/5);
    expSteps(16) = scatter(2/5, 2/5);
    expSteps(17) = scatter(3/5, 2/5);
    expSteps(18) = scatter(4/5, 2/5);
    
    expSteps(19) = scatter(1/5, 1/5);
    expSteps(20) = scatter(2/5, 1/5);
    expSteps(21) = scatter(3/5, 1/5);
    expSteps(22) = scatter(4/5, 1/5);
    
    xlim([-0.1 1.1]);
    ylim([-0.1 1.1]);
    hold off;
    
end
