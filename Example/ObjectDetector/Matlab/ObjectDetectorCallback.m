function [] = ObjectDetectorCallback( server, type, data )
%SERVERDEVCALLBACK Summary of this function goes here
    global USER_FIG_TAG; USER_FIG_TAG = 'USER_FIG_TAG';
    global PS; % user parse setting
    
    global dsDetectsAll;
    global dsDetectsAllEnd;
    global tvgSetting;
    global needToUpdateXLine2;
    global DOWNSAMPLE_FACTOR;
    global dsXMeters;
    global dsSize;
    global userStarts;
    global userEnds;
    global userStartsEnd;
    global userEndsEnd;
    
    if type == server.CALLBACK_TYPE_ERROR,
        fprintf(2, '[ERROR]: get the error callback data = %s', data);
        return;
    end

    if type == server.CALLBACK_TYPE_INIT,
%--------------------------------------------------------------------------
% 1. init GUI
%--------------------------------------------------------------------------
        DOWNSAMPLE_FACTOR = 4;
        tvgSetting.SOUND_SPEED = 340;
        tvgSetting.TVG_ALPHA = 0.65 % for note 4
        tvgSetting.TVG_BETA = 0;
        tvgSetting.FS = PS.FS/DOWNSAMPLE_FACTOR;

        oriSize = PS.detectRangeEnd - PS.detectRangeStart + 1;
        dsSize = floor(oriSize/DOWNSAMPLE_FACTOR);

        dsXMeters = LibSamplesToMeters(1:dsSize, 340, PS.FS/DOWNSAMPLE_FACTOR);

        dsDetectsAll = zeros(dsSize, 20*60*10, 2);
        dsDetectsAllEnd = 0;
        userStarts = zeros(500, 1);
        userEnds = zeros(500, 1);
        userStartsEnd = 0;
        userEndsEnd = 0;


        needToUpdateXLine2 = 1;
        LINE_CNTS = [2,2]; % size of it is the number of figure axes, and the number in it is the number of lines per axe
        createUI(server, USER_FIG_TAG, data, LINE_CNTS);
    elseif type == server.CALLBACK_TYPE_DATA,            
%--------------------------------------------------------------------------
% 2. data processing and update figures
%--------------------------------------------------------------------------
        % find detected objects by matched filter
        % where the PS.signalToCorrelate is the reverse of sensing signal
        % and PS.detectRangeStart:PS.detectRangeEnd are determined by the GUI
        cons = convn(data, PS.signalToCorrelate, 'same');
        detects = abs(cons(PS.detectRangeStart:PS.detectRangeEnd, :, :));
        traceCnt = size(detects, 2);
        chCnt = size(detects, 3);
        dsDetects = zeros(dsSize, traceCnt, chCnt);
        for chIdx = 1:chCnt
            dsDetects(:,:,chIdx) = imresize(detects(:,:,chIdx), [dsSize, traceCnt], 'Bilinear'); % subsampled results
        end
        dsDetectsAll(:, dsDetectsAllEnd+1:dsDetectsAllEnd+traceCnt, 1:chCnt) = dsDetects;
        dsDetectsAllEnd = dsDetectsAllEnd + traceCnt;

        % update line1: data 
        check1 = findobj('Tag','check01');
        if check1.Value == 1,
            for chIdx = 1:1,
                line = findobj('Tag',sprintf('line01_%02d',chIdx));
                dataToPlot = data(:,end,chIdx);
                set(line, 'yData', dataToPlot); % only show the 1st ch
            end
        end

        % update line2: detected peaks
        check2 = findobj('Tag','check02');
        if check2.Value == 1,
            for chIdx = 1:1, % TODO: based on channel
                line = findobj('Tag',sprintf('line02_%02d',chIdx));
                dataToPlot = LibTimeVaryingGainCorrect(dsDetects(:,end, chIdx), tvgSetting);
                set(line, 'yData', dataToPlot); % only show the 1st ch
                if needToUpdateXLine2
                    set(line, 'xData', dsXMeters);
                    if chIdx == 2
                        needToUpdateXLine2 = 0;
                    end
                end
            end
        end
%--------------------------------------------------------------------------
% 3. handle user data sent from device
%    in this example, click the user button in device will set a tag to
%    remember the location
%--------------------------------------------------------------------------
    elseif type == server.CALLBACK_TYPE_USER,
        data.code
        % parse user data
        % must be 'pse' in this app
        if data.code == 1, % update the vertical line
            userStarts(userStartsEnd+1) = dsDetectsAllEnd-1;
            userStartsEnd = userStartsEnd+1;
        else
            userEnds(userEndsEnd+1) = dsDetectsAllEnd-1;
            userEndsEnd = userEndsEnd+1;
        end
    end
end

%==========================================================================
% Followings are just some UI help functions
%==========================================================================
function createUI(server, figTag, data, lineCnts)
    % lineCnts is the number of lines per figure
    global PS;
    
    PLOT_AXE_IN_WIDTH = 270;
    PLOT_AXE_OUT_WIDTH = 290;
    PLOT_AXE_CNT = length(lineCnts);
    
    server.userfig = figure(...
                    'Name', 'Callback', ...
                    'Position',[50,50,550+PLOT_AXE_OUT_WIDTH*(PLOT_AXE_CNT-1),330], ...
                    'Toolbar','none', ...
                    'MenuBar','none', ...
                    'Tag', figTag);
    set(server.userfig, 'UserData', server); % attached the server object to fig property for future reference 
    
    h_panel2 = uipanel(server.userfig,'Units','pixels','Position',[15,15,520+PLOT_AXE_OUT_WIDTH*(PLOT_AXE_CNT-1),300]);
    textIntro = uicontrol(h_panel2,'Style','text','Position',[10,255,180,30],'String','Control the sensing response');
    
    RANGE_Y = 200;
    RANGE_FONT_SIZE = 15;
    textRange = uicontrol(h_panel2,'Style','text','Position',[25,RANGE_Y-5,50,30],'String','Range:','FontSize',RANGE_FONT_SIZE);
    uicontrol(h_panel2, 'Tag','editRangeStart', 'style','edit','units','pixels','position',[80,RANGE_Y,50,30],'String',num2str(PS.detectRangeStart),'FontSize',RANGE_FONT_SIZE);
    uicontrol(h_panel2, 'Tag','editRangeEnd', 'style','edit','units','pixels','position',[130,RANGE_Y,50,30],'String',num2str(PS.detectRangeEnd),'FontSize',RANGE_FONT_SIZE);
    
    uicontrol(h_panel2,'Style','pushbutton','Position',[30,130,110,30],'String','Apply','Callback',@buttonApplyCallback);
    
    UPDATE_LABELS = {'show recorded signals', 'show detected objects'};
    X_LABELS = {'sample', 'meter'};
    for i = 1:PLOT_AXE_CNT,
        uicontrol(h_panel2, 'Style','checkbox','String',UPDATE_LABELS{i},'Value',0,'Position',[220+PLOT_AXE_OUT_WIDTH*(i-1),280,200,20], 'Tag',sprintf('check%02d',i));
        
        server.axe = axes('Parent',h_panel2,'Units','pixels','Position',[220+PLOT_AXE_OUT_WIDTH*(i-1),30,270,250]);
        hold on;
        for j = 1:lineCnts(i),
            plot(server.axe, data(:,1),'Tag',sprintf('line%02d_%02d',i,j),'linewidth',2); % only show the 1st ch
        end
        hold off;
        xlabel(X_LABELS{i})
        legend(arrayfun(@(x) sprintf('%d',x), 1:lineCnts(i),'uni',false).');
    end
end

% apply ui control to parse value
function buttonApplyCallback(obj, event)
    global PS;
    editRangeStart = findobj('Tag','editRangeStart');
    editRangeEnd = findobj('Tag','editRangeEnd');
    
    rangeStart = str2num(editRangeStart.String);
    rangeEnd = str2num(editRangeEnd.String);
    
    if isempty(rangeStart) || isempty(rangeEnd),
        warndlg('Range input must be numerical');
    else
        PS.detectRangeStart = rangeStart;
        PS.detectRangeEnd = rangeEnd;
    end
end