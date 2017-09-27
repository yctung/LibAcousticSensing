function callback_interrupt
% CALLBACK_INTERRUPT illustrates callback interruption management.  
% This example enables you to see the interplay of 'Interruptible' and 
% 'BusyAction' properties for managing callback execution.  It creates two
% GUIs: The first one has two Wait buttons.  The seconds one has two Plot
% buttons and an axes to display the plots.
% 1. Click a Wait push button in the first GUI to generate and update a 
%    waitbar. For one Wait button, Interruptible = on; for the other, 
%    Interruptible = off. 
%    For the interruptible button, each time the waitbar is updated by the 
%    utility function CREATE_UPDATE_WAITBAR, the waitbar issues a DRAWNOW 
%    and all events on the event queue are processed. 
%    For the uninterruptible button, events on the queue must wait to be 
%    processed until the waitbar terminates or is destroyed.
% 2. Click a Plot push button in the second GUI. For the Surf Plot button, 
%    BusyAction = queue; for the Mesh Plot button, BusyAction = cancel. 
%    If you first clicked the uninterruptible Wait button, the Surf Plot 
%    event is queued and the plot displays when the waitbar completes or 
%    when you close the window; the Mesh Plot event is canceled and the 
%    plot does not display. 
%    If you first clicked the interruptible Wait button, both the Surf Plot
%    and the Mesh Plot events are queued and the plots display when the 
%    waitbar issues the next DRAWNOW.     

% Create the first figure and its components.
h_fig1 = figure('Position',[50,420,230,230],'Toolbar','none',...
                'MenuBar','none');
h_panel1 = uipanel(h_fig1,'Units','pixels','Position',[15,15,200,210]);
h_text1 = uicontrol(h_panel1,'Style','text',...
                        'Position',[10,155,180,30],'String',...
                        '1. Click a button to generate a waitbar.');
h_interrupt = uicontrol(h_panel1,'Style','pushbutton',...
                        'Position',[30,110,120,30],...
                        'String','Wait (interruptible)',...
                        'TooltipString','Interruptible = on',...
                        'Interruptible','on',...
                        'Callback',@wait_interruptible);
h_nointerrupt = uicontrol(h_panel1,'Style','pushbutton',...
                        'Position',[30,40,120,30],...
                        'String','Wait (uninterruptible)',...
                        'TooltipString','Interruptible = off',...
                        'Interruptible','off',...
                        'Callback',@wait_uninterruptible);
                    
% Create the second figure and its components
h_fig2 = figure('Position',[50,50,550,330],'Toolbar','none',...
                'MenuBar','none');
h_panel2 = uipanel(h_fig2,'Units','pixels','Position',[15,15,520,300]);
h_text2 = uicontrol(h_panel2,'Style','text',...
                        'Position',[10,255,180,30],'String',...
                        '2. Click a button to try and interrupt the waitbar.');
hsurf_queue = uicontrol(h_panel2,'Style','pushbutton',...
                        'Position',[30,200,110,30],...
                        'String','Surf Plot (queue)',...
                        'BusyAction','queue',...
                        'TooltipString','BusyAction = queue',...
                        'Callback',@surf_queue);
hmesh_cancel = uicontrol(h_panel2,'Style','pushbutton',...
                        'Position',[30,130,110,30],...
                        'String','Mesh Plot (cancel)',...
                        'BusyAction','cancel',...
                        'TooltipString','BusyAction = cancel',...
                        'Callback',@mesh_cancel);
h_axes2 = axes('Parent',h_panel2,'Units','pixels','Position',[220,30,270,250]);
% -----------------------------------------------------------------------
% Executes when you click the Wait (interruptible) push button.
    function wait_interruptible(hObject,eventdata)
        % Disable the other key.
        h_nointerrupt.Enable = 'off';
        cla(h_axes2,'reset')
        % Create and update the waitbar.
        create_update_waitbar()
        % Enable the other key
        h_nointerrupt.Enable = 'on';
    end
% -----------------------------------------------------------------------
% Executes when you click the Wait (uninterruptible) push button.
    function wait_uninterruptible(hObject,eventdata)
        % Disable the other key.
        h_interrupt.Enable = 'off';
        cla(h_axes2,'reset')
        % Create and update the waitbar.
        create_update_waitbar()        
        % Enable the other key
        h_interrupt.Enable = 'on';
    end
% -----------------------------------------------------------------------
% Executes when you click the Surf Plot (queue) push button
    function surf_queue(hObject,eventdata)
        h_plot = surf(h_axes2,peaks(35));
    end
% -----------------------------------------------------------------------
% Executes when you click the Mesh Plot (cancel) push button.
    function mesh_cancel(hObject,eventdata)
        h_plot = mesh(h_axes2,peaks(35));
    end
% -----------------------------------------------------------------------
% Create and update a waitbar.
    function create_update_waitbar
    h_wait = waitbar(0,'Please wait...',...
            'Position',[250,320,270,50],...
            'CloseRequestFcn',@close_waitbar);
        
        port = 50005;
        
        %{
        socket=tcpip('0.0.0.0', port, 'NetworkRole', 'server', 'Timeout', 60*60*24);    
        fprintf(2, '=== start wait connection to port = %d ===\n', port);
        fopen(socket);
        fprintf(2, '=== succeesfully get a connection to port = %d ===\n', port);
        %}
        
        sockcon=pnet('tcpsocket',port)
        fprintf(2, '=== start wait connection to port = %d ===\n', port);
        con=pnet(sockcon,'tcplisten');
        fprintf(2, '=== succeesfully get a connection to port = %d ===\n', port);
        
        for i=1:10000,
            if ishandle(h_wait)
            
            %action=fread(socket, 1, 'int8')
            sizeAcc = pnet(con,'read',1, 'int32')
                
            waitbar(i/10000,h_wait)
            tic
            fprintf('\nwait: %.1f: ', (i/10000)*100);
            toc
            else               
                break
            end
        end
        % When waitbar reaches max, close it.
        if ishandle(h_wait)        
           close(h_wait)
        end
    end
% -----------------------------------------------------------------------
% Close the waitbar. Executes in response to BREAK and CLOSE commands.
    function close_waitbar(hObject,eventdata)
        delete(gcbf)
    end
end