function AnalysisReplay 
    createControlUI;
    %doExperiment;
end

function createControlUI
    figure;
    
    hpanel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0  0 1 1]);
    
    NROWS = 6;
    
    uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 (NROWS-1)/NROWS 0.3 1/NROWS],...
        'String','Correlation Smoothing');
    
    uicontrol(hpanel, ...
        'style','slider',...
        'min', 1, 'max', 10, 'value', 5, ...
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
        'min', 1, 'max', 10, 'value', 5, ...
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
              
    u2 = uicontrol(bg,'Style','radiobutton',...
                  'String','conftrack',...
                  'units', 'normal', ...
                  'Position',[0.5 0 0.5 1]);

    
    set(bg,'SelectedObject',u2);  % Set the object.

    
    uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 (NROWS-5)/NROWS 0.3 1/NROWS],...
        'String','Apply Bandpass?');
    
    uicontrol(hpanel, ...
        'style','checkbox',...
        'string', 'Yes lol', ... 
        'value', 0,...
        'units','normal',...
        'tag', 'bandpass', ...
        'position', [0.3 (NROWS-5)/NROWS 0.5 1/NROWS]);
    
    
    % Alwaus last item
    uicontrol(hpanel, ...
        'style','pushbutton', ...
        'units','normal', ...
        'position',[0 0 1 1/NROWS], ...
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
    
    % These are parameters we might take back ro from GeneralCallback
    global XYBuffer savedLabels PeakUpBuffer PeakDownBuffer ExperimentResultBuffer;
    
    
    global OVERRIDEBN BN_A BN_B BN_P;
    global OVERRIDEBORDER;
    global recordedBorder;
    global minX maxX minY maxY;
    global left top right bottom middlehoriz middlevert;
    
    global CORRSMOOTHING;
    global CONFTHRESH;
    global DISTSMOOTHING;
    global ALGORITHM;
    global FLIP_X FLIP_Y;
    global BANDPASS;
    global WINDOWLEFT;
    global WINDOWRIGHT;

    global MICDISTANCE MIC1D MIC2D WMD;
    
    
    CORRSMOOTHING = round(get(findobj('tag', 'corrSmoothing'), 'value'));
    DISTSMOOTHING = round(get(findobj('tag', 'distSmoothing'), 'value'));
    CONFTHRESH = get(findobj('tag', 'confidenceThresh'), 'value');
    BANDPASS = get(findobj('tag', 'bandpass'), 'value');
    
    algoToggle = findobj('tag', 'algorithmToggle');
    ALGORITHM = get(algoToggle.SelectedObject, 'string');
    
    fprintf('Re-running with Corrsmooth=%f, Distsmooth=%f, confthresh=%f\n', CORRSMOOTHING, DISTSMOOTHING, CONFTHRESH);
    
    f = findobj('tag', 'stateFigure');
    if ~isempty(f), close(f); end
    
    %FillUpBuffer = zeros(PS.PERIOD, 2000, NUMSOURCES*2);
    FillUpPointers = zeros(1, 4);
    AcceptTaps = 0;
    TapReceived = 0;
    
    ReplayMode = 1;

    
    
    %global LoadBorderNow;
    %global BorderFilename;
    
    %filename = 'experiments/desktopbestgold.mat';
    % This only holds for desktop experiments.
     
    %OVERRIDEBN = 1;
     %BN_A = 4.292396; 
     %BN_B = 13.556328;
     %BN_P = 0.000000;
     
     
%     OVERRIDEBORDER = 1;
%     tvgold = load('tvgold.mat');
%     recordedBorder = tvgold.recordedBorder;
%     minX = tvgold.minX;
%     maxX = tvgold.maxX;
%     minY = tvgold.minY;
%     maxY = tvgold.maxY;
%     left = tvgold.left;
%     right = tvgold.right;
%     top = tvgold.top;
%     bottom = tvgold.bottom;
%     middlehoriz = tvgold.middlehoriz;
%     middlevert = tvgold.middlevert;
%     
%     OVERRIDEBN = 1;
%     BN_A = tvgold.BN_A;
%     BN_B = tvgold.BN_B;
%     BN_P = tvgold.BN_P;
    
     %BN_A = 4.292396; 
     %BN_B = 13.556328;
     %BN_P = 0.000000;
    
     
    %filename = 'experiments/desktopbestgold.mat';
    %filename = 'experiments/deskborders02.mat';
    %filename = 'experiments/desktake2-uptopoint14.mat';
    %filename = 'experiments/hamedexperiment1.mat';
    %filename = 'experiments/tvgoldnew.mat';
    
    
    %LoadBorderNow = 1;
    %BorderFilename = 'FullExperimentalData/borders/ycborderdesktop.mat';
    %filename = 'FullExperimentalData/data/ycdeskunguided.mat';
    %filename = 'FullExperimentalData/data/ycdeskgoodinteractive.mat';
    %filename = 'FullExperimentalData/data/yctvall';
    
    
    WINDOWLEFT = 100;
    %filename = 'FullExperimentalData/data/yctvall';
    %filename = 'FullExperimentalData/data/takbigscreenfull';
    %filename = 'FullExperimentalData/data/takbigscreenfull';
    %filename = 'FullExperimentalData/data/mert-full-bigscreen';
    %filename = 'FullExperimentalData/data/arunbigscreenfull';
    %filename = 'FullExperimentalData/data/danielintractivebigsreen';
    %WINDOWRIGHT = 300;
    
    
    %filename = 'FullExperimentalData/data/takdesktopfull';
    %filename = 'FullExperimentalData/data/mert-desktop-until7';
    filename = 'FullExperimentalData/data/arun-desktop-upto-14';
    WINDOWRIGHT = 200;

    data = load(filename);
    
    PS = data.PS;
    FillUpBuffer = data.rawData;
    EgoFromWindow = data.EgoFromWindow;
    SpacePresses = data.SpacePresses;
    MICDISTANCE = data.MICDISTANCE;
    MIC1D = data.MIC1D;
    MIC2D = data.MIC2D;
    
    % Really weird value that gives us good results for desktop.
    WMD = data.WMD; %0.335; %data.WMD; %0.335; %
    FLIP_X = data.FLIP_X;
    FLIP_Y = data.FLIP_Y;
    
    
    % The labels don't matter. We will re-find them based on spaces anyway
    AlreadyProcessed = EgoFromWindow-2;
    TotalWindows = data.AlreadyProcessed;
    for win=EgoFromWindow:TotalWindows
        [win TotalWindows]
        FillUpPointers = zeros(1, 4) + win;
        ReplayCallback;
        pause(0.001);
    end
    
    % expected x/y, mapped x/y, expected number, mapped number
    nonzero = find(ExperimentResultBuffer(:, 5));
    correct = sum(ExperimentResultBuffer(nonzero, 5) == ExperimentResultBuffer(nonzero, 6));
    total = length(nonzero);
    [normedmu,normedV,normederrors] = calc2derror(ExperimentResultBuffer(nonzero, 1:2), ExperimentResultBuffer(nonzero, 3:4));
    [pxlmu,pxlV,pxlerrors] = calc2derror(norm2pxl(ExperimentResultBuffer(nonzero, 1:2)), norm2pxl(ExperimentResultBuffer(nonzero, 3:4)));
    fprintf('Got %d/%d right = %f %%\n', correct, total, correct/total*100);
    fprintf('Normalized error = %f (std %f)\n', normedmu, sqrt(normedV));
    fprintf('Pixel error = %f (std %f)\n', pxlmu, sqrt(pxlV));
    
    
    %save('lastRelayErrors', 'normederrors', 'pxlerrors');
    %save('results_yctvallgoldresults', 'ExperimentResultBuffer');
    %save('results_taktvallgoldresults', 'ExperimentResultBuffer');
    %save('results_merttvallgoldresults', 'ExperimentResultBuffer');
    %save('results_aruntvallgoldresults', 'ExperimentResultBuffer');
    %save('results_aruntvallNOTGOLDresults', 'ExperimentResultBuffer');
    %save('results_danieltvallgoldresults', 'ExperimentResultBuffer');
    %save('results_mertDesk', 'ExperimentResultBuffer');
    %save('results_arunDesk', 'ExperimentResultBuffer');
    
    %save('taktvgoldresults', 'ExperimentResultBuffer');
   
    
    %normederrors;
    %pxlerrors;
    % Now, we can save XYBuffer PeakUpBuffer PeakDownBuffer for offset
    % testing and Beier Neely deformation mapping.
    
%     save('lastReplayOutput', 'XYBuffer', 'PeakUpBuffer', ...
%         'TotalWindows', 'PeakDownBuffer', 'savedLabels', ...
%         'recordedBorder', 'minX', 'maxX', 'minY', 'maxY', ...
%         'left', 'top', 'right', 'bottom', 'middlehoriz', 'middlevert');
end