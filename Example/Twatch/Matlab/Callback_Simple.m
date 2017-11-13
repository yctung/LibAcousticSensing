function [] =  Callback_Simple ( obj, type, data )
    SAVE_FOLDER = 'saved';
    global PS; % user parse setting
    FIGTAG = "TAG";

    if type == obj.CALLBACK_TYPE_ERROR
        fprintf(2, '[ERROR]: get the error callback data = %s', data);
        return;
    end

    % parse audio data
    if type == obj.CALLBACK_TYPE_DATA
        if obj.userfig == -1 % need to create a new UI window
            createUI(obj, data);
        else
            % Plot a simplified version of the data
            data(:,1,2) = data(:,1,1);
            C1 = data(:,1,1);
            C2 = data(:,1,2);
            %all(C1 == C2);

            downsampled = downsample(data, 10);
            dataToPlot = downsampled;
            
            set(findobj('tag', 'mic1'), 'yData', dataToPlot(:,end,1));
            set(findobj('tag', 'mic2'), 'yData', dataToPlot(:,end,2));
            
            % Save it if the toggle button is pressed
            %toggleButton = findobj('Tag', 'recordtoggle');
            %if (toggleButton.Value)
            %    % Save it
            %    savename = sprintf('%s/%s', SAVE_FOLDER, datestr(now, 'MM-SS-FFF'));
            %    save(savename, 'data');
            %    %save('saved/', 'data');
            %end

        end
    elseif type == obj.CALLBACK_TYPE_USER
        % parse user data
        % must be 'pse' in this app
        if data.code == 1 % update the vertical line
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

function createUI(obj, data)
    % lineCnts is the number of lines per figure
    PADDING = 50;
    WIDTH = 250;
    PLOTHEIGHT = 100;
    BUTTON_HEIGHT = 50;
    RANGE_FONT_SIZE = 15;
    
    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    FigPos = [PADDING,PADDING,WIDTH+2*PADDING,PADDING*4+PLOTHEIGHT*2+BUTTON_HEIGHT];
    obj.userfig = figure('Position', FigPos,'Toolbar','none','MenuBar','none');
    set(obj.userfig,'UserData',obj); % attached the obj to fig property for future reference 
    
    % Mic 1
    PlotPos = [PADDING, PADDING + BUTTON_HEIGHT + PADDING, WIDTH, PLOTHEIGHT];
    ax1 = axes('Units','pixels','Position',PlotPos);
    title(ax1, 'Mic channel 2');
    plot(ax1, data(:,1), ...
        'Tag', 'mic2',...
        'linewidth',2); % only show the 1st ch
    set(ax1,'xtick',[],'ytick',[]);
    
    % Mic 2
    PlotPos = [PADDING, PADDING + BUTTON_HEIGHT + PADDING + PLOTHEIGHT + PADDING, WIDTH, PLOTHEIGHT];
    ax2 = axes('Units','pixels','Position',PlotPos);
    title(ax2, 'Mic channel 1');
    plot(ax2, data(:,1), ...
        'Tag', 'mic1',...
        'linewidth',2); % only show the 1st ch
    set(ax2,'xtick',[],'ytick',[]);
    
    % Button
    ButPos = [PADDING, PADDING, WIDTH, BUTTON_HEIGHT];
    uicontrol(...
                'Tag', 'recordtoggle', ...
                'style', 'togglebutton', ...
                'position', ButPos, ...
                'String', 'Record', ...
                'FontSize', RANGE_FONT_SIZE...
    );

    %legend(arrayfun(@(x) sprintf('%d',x), 1:lineCnts(i),'uni',false).');
end