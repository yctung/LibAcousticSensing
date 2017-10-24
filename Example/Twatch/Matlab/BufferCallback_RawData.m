function BufferCallback_RawData ()
    global FillUpBuffer savedLabels FillUpPointers AlreadyProcessed;
    global aggregateDetails;
    global groundLabel;
    
    if any(FillUpPointers <= AlreadyProcessed)
        return;
    end
    
    fig = findobj('Tag', 'PeakFig');
    if isempty(fig)
        createUI();
    else
        AlreadyProcessed = AlreadyProcessed + 1;
        set(aggregateDetails, 'string', sprintf('#%d', AlreadyProcessed));
        savedLabels{AlreadyProcessed} = groundLabel;
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
    global FillUpBuffer savedLabels FillUpPointers AlreadyProcessed;
    rawData = FillUpBuffer(:,1:AlreadyProcessed,:);
    expLabel = findobj('tag', 'explabel');
    prefix = get(expLabel, 'String');
    saveName = sprintf('experiments/%s', prefix);
    save(saveName, 'rawData', 'savedLabels');
end


function createUI()
    % lineCnts is the number of lines per figure
    global aggregateDetails;
    
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
    
    % Create 10 cases. 2x5
    for i=1:10
        if i < 6
            xcoord = 0.5 + (i-1)*0.1;
            ycoord = 0.5;
        else
            xcoord = 0.5 + (i-6)*0.1;
            ycoord = 0;
        end
        
        uicontrol(h_panel2, ...
            'tag', 'recordtoggle', ...
            'style', 'togglebutton', ...
            'units', 'normal', ...
            'position', [xcoord ycoord 0.1 0.5], ...
            'string', sprintf('c%d', i), ...
            'fontsize', FONTSIZE,...
            'Callback', @recordToggleCallback);
    end
end
