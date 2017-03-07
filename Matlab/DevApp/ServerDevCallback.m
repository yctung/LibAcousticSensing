function [] = ServerDevCallback( obj, type, data )
%SERVERDEVCALLBACK Summary of this function goes here
    SHOW_FIG_CON = 1;
    FIG_CON_TAG = 'FIG_CON_TAG';
    
    if type == obj.CALLBACK_TYPE_ERROR,
        fprintf(2, '[ERROR]: get the error callback data = %s', data);
        return;
    end

    hFig = findobj('Tag',FIG_CON_TAG);
    if isempty(hFig), % need to create a new UI window
        createUI(obj, FIG_CON_TAG, data);
    else
        % update figure
        line = findobj('Tag','line1');
        set(line, 'yData', data(:,1)); % only show the 1st ch
    end
end

function createUI(obj, figTag, data)
%MY_SLIDER is an example of Matlab GUI
% ref: https://www.mathworks.com/help/matlab/creating_guis/share-data-among-callbacks.html#bt9p4qp
    hfig = figure('Tag',figTag);
    set(hfig,'UserData',obj);
    recordButton = uicontrol('Parent', hfig,'Style','pushbutton',...
             'Tag','recordButton',...
             'Units','normalized',...
             'Position',[0.4 0.3 0.2 0.1],...
             'String','Record',...
             'Callback',@recordButtonCallback);
    line = plot(data(:,1),'r','Tag','line1','linewidth',2); % only show the 1st ch
end

function recordButtonCallback(obj, event)
    recordButton = findobj('Tag','recordButton');
    if strcmp(recordButton.String,'Record'), 
        recordButton.String = 'Stop';
        hFig = findobj('Tag', 'FIG_CON_TAG');
        ss = hFig.UserData;
        ss.startRecord();
    elseif strcmp(recordButton.String,'Stop'),
        recordButton.String = 'Record';
        prompt = {'Enter the trace tag','Enter the path to save'};
        dlg_title = 'Input';
        num_lines = 1;
        defaultans = {'none','Records/'};
        answer = inputdlg(prompt,dlg_title,num_lines,defaultans);
        ss.stopRecord(answer(1), answer(2));
    else
        fprintf(2,'[ERROR]: undefined recordButton status\n');
    end
end
