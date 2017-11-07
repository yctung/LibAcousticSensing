function BufferCallback_TWatchExperiment ()
    global FillUpBuffer savedLabels FillUpPointers AlreadyProcessed;
    global currentExpStep ongoingExperiment;
    global aggregateDetails;
    
    if any(FillUpPointers <= AlreadyProcessed)
        return;
    end
    
    fig = findobj('Tag', 'PeakFig');
    if isempty(fig)
        createUI();
        savedLabels = [];
    else
        AlreadyProcessed = AlreadyProcessed + 1;
        set(aggregateDetails, 'string', sprintf('#%d', AlreadyProcessed));
        %savedLabels{AlreadyProcessed} = groundLabel;
        if ongoingExperiment
            savedLabels(AlreadyProcessed) = currentExpStep;
        else
            savedLabels(AlreadyProcessed) = -1;
        end
   end
end

function recordToggleCallback (hObject, ~, ~)
    global groundLabel;
    button_state = get(hObject,'Value');
    buttonName = get(hObject, 'string');
    if button_state == get(hObject, 'Max')
        %doRecord = 1;
        groundLabel = buttonName;
    else 
        % Download the data
        %doRecord = 0;
        groundLabel = '';
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
                disp('All done!');
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



function createUI()
    % lineCnts is the number of lines per figure
    global aggregateDetails;
    global expSteps currentExpStep expFig ongoingExperiment;
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
    
    
    % Draw experiment window
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
    
    set(expFig, 'KeyPressFcn', @Key_Down);
end
