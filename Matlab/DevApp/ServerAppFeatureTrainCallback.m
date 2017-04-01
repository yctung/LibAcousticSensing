function [] = ServerDevCallback( obj, type, data )
%SERVERDEVCALLBACK Summary of this function goes here
    global USER_FIG_TAG;
    USER_FIG_TAG = 'USER_FIG_TAG';
    
    if type == obj.CALLBACK_TYPE_ERROR,
        fprintf(2, '[ERROR]: get the error callback data = %s', data);
        return;
    end

    
    %hFig = findobj('Tag',FIG_CON_TAG);
    if obj.userfig == -1, % need to create a new UI window
        createUI(obj, USER_FIG_TAG, data);
    else
        % update figure
        line = findobj('Tag','line1');
        set(line, 'yData', data(:,1)); % only show the 1st ch
    end
end

function createUI(obj, figTag, data)
    obj.userfig = figure('Position',[50,50,550,330],'Toolbar','none','MenuBar','none','Tag',figTag);
    set(obj.userfig,'UserData',obj); % attached the obj to fig property for future reference 
    
    h_panel2 = uipanel(obj.userfig,'Units','pixels','Position',[15,15,520,300]);
    h_text2 = uicontrol(h_panel2,'Style','text',...
                'Position',[10,255,180,30],'String',...
                '2. Click a button to try and interrupt the waitbar.');
    buttonStartSensing = uicontrol(h_panel2,'Style','pushbutton',...
                'Position',[30,200,110,30],...
                'String','Start Sensing',...
                'BusyAction','queue',...
                'TooltipString','BusyAction = queue',...
                'Callback',@callbackStartSensing);
            %{
    hmesh_cancel = uicontrol(h_panel2,'Style','pushbutton',...
                'Position',[30,130,110,30],...
                'String','Mesh Plot (cancel)',...
                'BusyAction','cancel',...
                'TooltipString','BusyAction = cancel',...
                'Callback',@(~,~)obj.callbackTemp);
                %}
    obj.axe = axes('Parent',h_panel2,'Units','pixels','Position',[220,30,270,250]);
    line = plot(obj.axe, data(:,1),'r','Tag','line1','linewidth',2); % only show the 1st ch

%MY_SLIDER is an example of Matlab GUI
% ref: https://www.mathworks.com/help/matlab/creating_guis/share-data-among-callbacks.html#bt9p4qp
%{
    hfig = figure('Tag',figTag);
    set(hfig,'UserData',obj);
    recordButton = uicontrol('Parent', hfig,'Style','pushbutton',...
             'Tag','recordButton',...
             'Units','normalized',...
             'Position',[0.4 0.3 0.2 0.1],...
             'String','Record',...
             'Callback',@recordButtonCallback);
    line = plot(data(:,1),'r','Tag','line1','linewidth',2); % only show the 1st ch
%}
end

function callbackStartSensing(obj, event)
    fprintf('    callbackStartSensing is called\n');
    global USER_FIG_TAG;
    userfig = findobj('Tag', USER_FIG_TAG);
    ss = userfig.UserData;
    while ss.latestReceivedAction ~= ss.ACTION_INIT,
        fprintf('    wait socket is connected\n');
        pause(1.0);
    end
    ss.startSensing();
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
