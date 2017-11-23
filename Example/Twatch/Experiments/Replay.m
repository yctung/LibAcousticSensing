function Replay 
    createControlUI;
    %doExperiment;
end

function createControlUI
    figure;
    
    hpanel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  0 1 1]);
    
    NROWS = 5;
    
    uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 (NROWS-1)/NROWS 0.3 1/NROWS],...
        'String','Correlation Smoothing');
    
    uicontrol(hpanel, ...
        'style','slider',...
        'min', 1, 'max', 10, 'value', 1, ...
        'units','normal',...
        'tag', 'corrSmoothing', ...
        'position', [0.3 (NROWS-1)/NROWS 0.5 1/NROWS]);
    

     
    uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 (NROWS-2)/NROWS 0.3 1/NROWS],...
        'String','Distance Smoothing');
    
    uicontrol(hpanel, ...
        'style','slider',...
        'min', 1, 'max', 10, 'value', 1, ...
        'units','normal',...
        'tag', 'distSmoothing', ...
        'position', [0.3 (NROWS-2)/NROWS 0.5 1/NROWS]);
    
    
     uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 (NROWS-3)/NROWS 0.3 1/NROWS],...
        'String','Confidence Threshold');
    
    uicontrol(hpanel, ...
        'style','slider',...
        'min', 1, 'max', 2.5, 'value', 2, ...
        'units','normal',...
        'tag', 'confidenceThresh', ...
        'position', [0.3 (NROWS-3)/NROWS 0.5 1/NROWS]);
    
    
    bg = uibuttongroup(hpanel, ...
        'units','normal', ...
        'position',[0 (NROWS-4)/NROWS 1 1/NROWS], ...
        'tag', 'algorithmToggle');
   
    
    uicontrol(bg,'Style',...
                  'radiobutton',...
                  'String','stateless',...
                  'units', 'normal', ...
                  'Position',[0 0 0.5 1]);
              
    uicontrol(bg,'Style','radiobutton',...
                  'String','conftrack',...
                  'units', 'normal', ...
                  'Position',[0.5 0 0.5 1]);

    
    
    uicontrol(hpanel, ...
        'style','pushbutton', ...
        'units','normal', ...
        'position',[0 (NROWS-5)/NROWS 1 1/NROWS], ...
        'String', 'Replay', ...
        'Callback', @doExperiment);

end



function doExperiment (~, ~, ~)
    clear global;
    
    global ReplayMode;
    global PS;
    global FillUpBuffer;
    global FillUpPointers;
    global AlreadyProcessed;
    global SpacePresses;
    global EgoFromWindow;
    global AcceptTaps TapReceived;
    
    global CORRSMOOTHING;
    global CONFTHRESH;
    global DISTSMOOTHING;
    global ALGORITHM;
    
    CORRSMOOTHING = round(get(findobj('tag', 'corrSmoothing'), 'value'));
    DISTSMOOTHING = round(get(findobj('tag', 'distSmoothing'), 'value'));
    CONFTHRESH = get(findobj('tag', 'confidenceThresh'), 'value');
    
    algoToggle = findobj('tag', 'algorithmToggle');
    ALGORITHM = get(algoToggle.SelectedObject, 'string');
    
    fprintf('Re-running with Corrsmooth=%f, Distsmooth=%f, confthresh=%f', CORRSMOOTHING, DISTSMOOTHING, CONFTHRESH);
    
    f = findobj('tag', 'stateFigure');
    if ~isempty(f), close(f); end
    
    %FillUpBuffer = zeros(PS.PERIOD, 2000, NUMSOURCES*2);
    FillUpPointers = zeros(1, 4);
    AcceptTaps = 0;
    TapReceived = 0;
    
    ReplayMode = 1;
    varargin = {'experiments/bs6'};
    if isempty(varargin)
        filename = 'experiments/lastExperiment.mat';
    else
        filename = varargin{1};
    end
    data = load(filename);
    
    PS = data.PS;
    FillUpBuffer = data.rawData;
    EgoFromWindow = data.EgoFromWindow;
    SpacePresses = data.SpacePresses;
    % The labels don't matter. We will re-find them based on spaces anyway
    
    AlreadyProcessed = EgoFromWindow-2;
    TotalWindows = data.AlreadyProcessed;
    for win=EgoFromWindow:TotalWindows
        FillUpPointers = zeros(1, 4) + win;
        BufferCallback_TWatchExperiment;
        pause(0.001);
        %pause (PS.PERIOD / PS.FS);
    end
end