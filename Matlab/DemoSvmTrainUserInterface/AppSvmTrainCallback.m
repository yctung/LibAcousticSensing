function [] = AppSvmTrainCallback( obj, type, data )
%SERVERDEVCALLBACK Summary of this function goes here
    global USER_FIG_TAG;
    USER_FIG_TAG = 'USER_FIG_TAG';
    global PS; % user parse setting
    global detectResults;
    global detectResultsEnd;
    global recordedData;
    global recordedDataEnd;
    global isRecording;
    global isPredicting;
    
    DETECT_RESULT_SIZE = 300; % number of result sample to show
    RECORDED_DATA_SIZE = 500; % number of data being recorded (saved to the buffer), use a big enoguh size to avoid reallocate the buffer
    
    global svm;
    
    if type == obj.CALLBACK_TYPE_ERROR,
        fprintf(2, '[ERROR]: get the error callback data = %s', data);
        return;
    end

    CH_CNT_TO_SHOW = 1; % TOOD: set it based on device settings
    
    % parse audio data
    if type == obj.CALLBACK_TYPE_DATA,
        LINE_CNTS = [2,2,3]; % size of it is the number of figure axes, and the number in it is the number of lines per axe
        %hFig = findobj('Tag',FIG_CON_TAG);
        if obj.userfig == -1, % need to create a new UI window
            detectResultsEnd = 0;
            detectResults = zeros(DETECT_RESULT_SIZE, 1);
            recordedDataEnd = 0;
            
            createUI(obj, USER_FIG_TAG, data, LINE_CNTS);
        else
            % save data to the recorded buffer if need
            if isRecording,
                % init recordedData if need
                if recordedDataEnd == 0,
                    recordedData = zeros(size(data,1), RECORDED_DATA_SIZE, size(data,2));
                end
                
                recordedData(:,recordedDataEnd+1:recordedDataEnd+size(data,2),:) = data;
                recordedDataEnd = recordedDataEnd+size(data,2);
            end
            % make prediction if need
            if isPredicting,
                [predictedIdx, predictedTag, predictedConfidence] = svm.predict(recordedData(:,recordedDataEnd,:));
                nowSize = length(predictedTag);
                textResult = findobj('Tag','textResult');
                textResult.String = sprintf('Result: %s', predictedTag);
            end
            
            % convlution of all data
            %{
            detectChIdx = 1;
            dataTime = data(:,end,detectChIdx); 
            FS = 48000;
            DF = FS/length(dataTime);
            freqs = -FS/2:DF:(FS/2-DF);
            SMOOTH_FACTOR = 5;
            dataFreq = smooth(fftshift(abs(fft(dataTime))), SMOOTH_FACTOR);
            %}
            features = svm.getFeatureFromData(data(:,end,:)); % only plot the latest data
            
            % return the result if need
            if PS.detectEnabled,
                %obj.jss.write()
            end
            
            % line1: data 
            check1 = findobj('Tag','check01');
            if check1.Value == 1,
                for chIdx = 1:CH_CNT_TO_SHOW,
                    line = findobj('Tag',sprintf('line01_%02d',chIdx));
                    dataToPlot = data(:,end,chIdx);
                    set(line, 'yData', dataToPlot); % only show the 1st ch
                end
            end

            % line2: fft 
            check2 = findobj('Tag','check02');
            if check2.Value == 1,
                line = findobj('Tag','line02_01');
                set(line, 'yData', features); % only show the 1st ch
            end

            % line3: detect result
            check3 = findobj('Tag','check03');
            if check3.Value == 1 && isPredicting == 1
                line = findobj('Tag','line03_01');
                if detectResultsEnd+nowSize > DETECT_RESULT_SIZE, % need to shift
                    toShift = detectResultsEnd+nowSize - DETECT_RESULT_SIZE;
                    detectResults(1:end-toShift) = detectResults(toShift+1:end);
                    detectResultsEnd = detectResultsEnd - nowSize;
                end

                % update result
                detectResults(detectResultsEnd+1:detectResultsEnd+nowSize) = predictedIdx;
                detectResultsEnd = detectResultsEnd+nowSize;
                set(line, 'yData', detectResults); % only show the 1st ch
            end
        end
    elseif type == obj.CALLBACK_TYPE_USER,
        % parse user data
        % must be 'pse' in this app
        if data.code == 1, % update the vertical line
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

function createUI(obj, figTag, data, lineCnts)
    % lineCnts is the number of lines per figure
    global svm;
    global isRecording;
    global isPredicting;
    isRecording = 0; % false
    isPredicting = 0; % false
    
    PLOT_AXE_IN_WIDTH = 270;
    PLOT_AXE_OUT_WIDTH = 290;
    PLOT_AXE_CNT = length(lineCnts);
    
    obj.userfig = figure('Position',[50,50,550+PLOT_AXE_OUT_WIDTH*(PLOT_AXE_CNT-1),330],'Toolbar','none','MenuBar','none','Tag',figTag);
    set(obj.userfig,'UserData',obj); % attached the obj to fig property for future reference 
    
    h_panel2 = uipanel(obj.userfig,'Units','pixels','Position',[15,15,520+PLOT_AXE_OUT_WIDTH*(PLOT_AXE_CNT-1),300]);
    textIntro = uicontrol(h_panel2,'Style','text','Position',[10,255,180,30],'String','Control the sensing response');
    
    RANGE_Y = 200;
    RANGE_FONT_SIZE = 15;
    textRange = uicontrol(h_panel2,'Style','text','Position',[25,RANGE_Y-5,50,30],'String','Range:','FontSize',RANGE_FONT_SIZE);
    uicontrol(h_panel2, 'Tag','editRangeStart', 'style','edit','units','pixels','position',[80,RANGE_Y,50,30],'String',num2str(svm.featureFreqBinStartIdx),'FontSize',RANGE_FONT_SIZE);
    uicontrol(h_panel2, 'Tag','editRangeEnd', 'style','edit','units','pixels','position',[130,RANGE_Y,50,30],'String',num2str(svm.featureFreqBinEndIdx),'FontSize',RANGE_FONT_SIZE);
    buttonApply = uicontrol(h_panel2,'Style','pushbutton','Position',[30,130,110,30],'String','Apply','Callback',@buttonApplyCallback, 'Interruptible', 'on');
    
    uicontrol(h_panel2,'Style','text','Position',[25,100-5,50,30],'String','Tag:','FontSize',RANGE_FONT_SIZE);
    uicontrol(h_panel2, 'Tag','menuTag','style','popupmenu','Position',[60,90,110,30], 'String',svm.getTags());
    uicontrol(h_panel2,'Style','pushbutton','Position',[30,60,60,30],'String','New','Callback',@buttonNewTagCallback);
    uicontrol(h_panel2,'Style','pushbutton','Position',[110,60,60,30],'String','Delete','Callback',@buttonApplyCallback);
    
    
    uicontrol(h_panel2,'Style','pushbutton','Position',[30,30,60,30],'String','Record','Tag','buttonRecordOrStop','Callback',@buttonRecordOrStopCallback);
    uicontrol(h_panel2,'Style','pushbutton','Position',[110,30,60,30],'String','Train','Callback',@buttonTrainCallback);
    
    uicontrol(h_panel2,'Style','pushbutton','Position',[30,10,60,30],'String','Predict','Tag','buttonPredictOrStop','Callback',@buttonPredictOrStopCallback);
    uicontrol(h_panel2,'Style','text','Position',[110,10,60,30],'String','result: ','Tag','textResult');
    

    %{
    buttonStartSensing = uicontrol(h_panel2,'Style','pushbutton',...
                'Position',[30,200,110,30],...
                'String','Start Sensing',...
                'BusyAction','queue',...
                'TooltipString','BusyAction = queue',...
                'Callback',@callbackStartSensing);
            %}
            
    
                
    for i = 1:PLOT_AXE_CNT,
        uicontrol(h_panel2, 'Style','checkbox','String','update','Value',0,'Position',[220+PLOT_AXE_OUT_WIDTH*(i-1),280,80,20], 'Tag',sprintf('check%02d',i));
        
        obj.axe = axes('Parent',h_panel2,'Units','pixels','Position',[220+PLOT_AXE_OUT_WIDTH*(i-1),30,270,250]);
        hold on;
        for j = 1:lineCnts(i),
            plot(obj.axe, data(:,1),'Tag',sprintf('line%02d_%02d',i,j),'linewidth',2); % only show the 1st ch
        end
        hold off;
        legend(arrayfun(@(x) sprintf('%d',x), 1:lineCnts(i),'uni',false).');
    end
        

    updateUI();
end


function updateUI(obj, event), 
    global isRecording;
    global svm;
    
    buttonRecordOrStop = findobj('Tag','buttonRecordOrStop');
    buttonPredictOrStop = findobj('Tag','buttonPredictOrStop');
    
    % hide all ui if no tag existed
    if svm.targetCnt() == 0, 
        buttonRecordOrStop.Enable = 'off';
    else
        buttonRecordOrStop.Enable = 'on';
    end
    
    if isRecording,
        buttonRecordOrStop.String = 'Stop';
    else
        buttonRecordOrStop.String = 'Record';
    end
    
    if svm.isTrained,
        buttonPredictOrStop.Enable = 'on';
    else
        buttonPredictOrStop.Enable = 'off';
    end
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

function saveButtonCallback(obj, event)
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


% apply ui control to parse value
function buttonApplyCallback(obj, event)
    global svm;
    editRangeStart = findobj('Tag','editRangeStart');
    editRangeEnd = findobj('Tag','editRangeEnd');
    
    rangeStart = str2num(editRangeStart.String);
    rangeEnd = str2num(editRangeEnd.String);
    
    if isempty(rangeStart) || isempty(rangeEnd),
        warndlg('Range input must be numerical');
    else
        svm.featureFreqBinStartIdx = rangeStart;
        svm.featureFreqBinEndIdx = rangeEnd;
    end
end

function buttonNewTagCallback(obj,event)
    global PS;
    global svm;
    % ask user input the tag name
    tagNew = inputdlg('Please input the new tag name (ex: A)');
    tagNew = tagNew{:}; % unwrap the cell
    
    
    if svm.isTagExisted(tagNew),
        warndlg(sprintf('The tag name (%s) already exists, please use another name', tagNew));
        return;
    end
    
    if isempty(tagNew),
        fprintf('no input (canceled?)\n');
        return;
    end
    
    % add new tag
    svm.addNewTag(tagNew);
    % update tags UI
    menuTag = findobj('Tag','menuTag');
    menuTag.String = svm.getTags();
    
    updateUI();
end

function buttonRecordOrStopCallback(obj, event)
    global USER_FIG_TAG;
    global svm;
    global isRecording;
    global isPredicting;
    global recordedDataEnd;
    global recordedData;
    
    if  ~isRecording,
        isRecording = 1;
        recordedDataEnd = 0; % for the data to be initialzed
        updateUI();

        %{
        % it is just a fake ui to control the record
        dummyServer.CALLBACK_TYPE_ERROR = SensingServer.CALLBACK_TYPE_ERROR;
        dummyServer.CALLBACK_TYPE_DATA = SensingServer.CALLBACK_TYPE_DATA;
        dummyServer.CALLBACK_TYPE_USER = SensingServer.CALLBACK_TYPE_USER;
        dummyServer.userfig = findobj('Tag',USER_FIG_TAG);
        for i = 1:10,
            AppSvmTrainCallback(dummyServer, SensingServer.CALLBACK_TYPE_DATA, rand(10,2));
            pause(0.1);
        end
        
        % ask to stop the record in the end of testing data ends
        if isPredicting
            buttonPredictOrStopCallback(obj, event);
        else
            buttonRecordOrStopCallback(obj, event);
        end
        %}
    else
        isRecording = 0;
        menuTag = findobj('Tag','menuTag');
        tag = menuTag.String{menuTag.Value};
        
        if ~isPredicting
            choice = questdlg('Would you like to save/train this recording', sprintf('selected tag = %s', tag),'No','Yes','Yes');
            switch choice
                case 'No'
                    fprintf('[WARN]: previous record is not saved\n');
                case 'Yes'
                    % save this recording
                    svm.addTaggedData(tag, recordedData(:,1:recordedDataEnd,:));
            end
        end
        updateUI();
    end
end

function buttonTrainCallback(obj, event)
	global svm;
    if svm.targetCnt() <= 1,
        warndlg(sprintf('Unable to train bacause of # of target = %d < 2', svm.targetCnt()));
    else
        svm.trainAll();
        updateUI();
    end
end

function buttonPredictOrStopCallback(obj, event)
    global isPredicting;
    
    if ~isPredicting
        isPredicting = 1;
        buttonRecordOrStopCallback(obj, event); % reuse the is recording function to save data 
    else
        isPredicting = 0;
        buttonRecordOrStopCallback(obj, event); % reuse the is recording function to save data 
    end
end