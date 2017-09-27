function [  ] = my_slider(  )
%MY_SLIDER is an example of Matlab GUI
% ref: https://www.mathworks.com/help/matlab/creating_guis/share-data-among-callbacks.html#bt9p4qp
    hfig = figure('Tag','fig');
    slider = uicontrol('Parent', hfig,'Style','slider',...
             'Units','normalized',...
             'Position',[0.3 0.5 0.4 0.1],...
             'Tag','slider1',...
             'UserData',struct('val',0,'diffMax',1),...
             'Callback',@slider_callback);

    button = uicontrol('Parent', hfig,'Style','pushbutton',...
             'Units','normalized',...
             'Position',[0.4 0.3 0.2 0.1],...
             'String','Display Difference',...
             'Callback',@button_callback);
         
    line = plot([1:10],'Tag','line1');
end

function slider_callback(hObject,eventdata)
	sval = hObject.Value;
	diffMax = hObject.Max - sval;
	data = struct('val',sval,'diffMax',diffMax);
	hObject.UserData = data;
	% For R2014a and earlier: 
	% sval = get(hObject,'Value');  
	% maxval = get(hObject,'Max');  
	% diffMax = maxval - sval;      
	% data = struct('val',sval,'diffMax',diffMax);   
	% set(hObject,'UserData',data);   

end

function button_callback(hObject,eventdata)
	h = findobj('Tag','slider1');
	data = h.UserData;
	% For R2014a and earlier: 
	% data = get(h,'UserData'); 
	display([data.val data.diffMax]);
    
    
    h = findobj('Tag','line1');
    ydata = get(h, 'yData');
    set(h, 'yData', ydata+1);
    drawnow;
    
    prompt = {'Enter matrix size:','Enter colormap name:'};
    dlg_title = 'Input';
    num_lines = 1;
    defaultans = {'20','hsv'};
    answer = inputdlg(prompt,dlg_title,num_lines,defaultans);
end

