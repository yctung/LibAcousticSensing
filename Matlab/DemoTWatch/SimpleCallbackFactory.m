function [callback] = SimpleCallbackFactory (FIGTAG)
    callback = @SimpleCallback;
    
    function f = SimpleCallback ( obj, type, data )
        SAVE_FOLDER = 'saved';
        global PS; % user parse setting

        if type == obj.CALLBACK_TYPE_ERROR
            fprintf(2, '[ERROR]: get the error callback data = %s', data);
            return;
        end

        % parse audio data
        if type == obj.CALLBACK_TYPE_DATA
            if obj.userfig == -1 % need to create a new UI window
                createUI(obj, FIGTAG, data);
            else
                % Plot a simplified version of the data
                line = findobj('Tag', sprintf('%sline',FIGTAG));
                %upcons = abs(convn(data, PS.upsignalToCorrelate,'same'));
                %set(convPlot, 'yData', upcons(:, end, 1));
                downsampled = downsample(data, 50);
                dataToPlot = downsampled;
                set(line, 'yData', dataToPlot (:, end, 1));

                % Save it if the toggle button is pressed
                toggleButton = findobj('Tag', sprintf('%srecordToggleButton', FIGTAG));
                if (toggleButton.Value)
                    % Save it
                    savename = sprintf('%s/%s', SAVE_FOLDER, datestr(now, 'MM-SS-FFF'));
                    save(savename, 'data');
                    %save('saved/', 'data');
                end

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
end

function createUI(obj, figTag, data)
    % lineCnts is the number of lines per figure
    PADDING = 50;
    WIDTH = 250;
    BUTTON_HEIGHT = 50;
    RANGE_FONT_SIZE = 15;

    set(0,'DefaultAxesFontSize',14,'DefaultTextFontSize',16);
    FigPos = [50,50,WIDTH+2*PADDING,PADDING*3+WIDTH+BUTTON_HEIGHT];
    obj.userfig = figure('Position', FigPos,'Toolbar','none','MenuBar','none','Tag',figTag);
    set(obj.userfig,'UserData',obj); % attached the obj to fig property for future reference 
    
    PlotPos = [PADDING, PADDING*2 + BUTTON_HEIGHT, WIDTH, WIDTH];
    obj.axe = axes('Units','pixels','Position',PlotPos);
    plot(obj.axe, data(:,1), ...
        'Tag', sprintf('%sline',figTag),...
        'linewidth',2); % only show the 1st ch
    %set(findobj(gcf, 'type','axes'), 'Visible','off')
    set(gca,'xtick',[],'ytick',[]);

    ButPos = [PADDING, PADDING, WIDTH, BUTTON_HEIGHT];
    uicontrol(...
                'Tag', sprintf('%srecordToggleButton', figTag), ...
                'style', 'togglebutton', ...
                'position', ButPos, ...
                'String', 'Record', ...
                'FontSize', RANGE_FONT_SIZE...
    );

    %legend(arrayfun(@(x) sprintf('%d',x), 1:lineCnts(i),'uni',false).');
end



