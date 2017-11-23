function analyze(filename_, fieldname_)
    global filename fieldname;
    global BN_A BN_B BN_P;
    
    BN_P = 0; BN_A = 0.233; BN_B = 3.75;
    filename = filename_;
    fieldname = fieldname_;
    
    global recordedBorder recordedPoints;
    global referenceBorder referencePoints;
    global deformedBorder deformedPoints;
    
    fprintf('Getting points\n');
    [recordedBorder, recordedPoints] = getPoints;
    [referenceBorder, referencePoints] = getReference;
    
    
    doBN;
    createFig;
    updateSliders;
end


function doBN
    global recordedBorder recordedPoints;
    global referenceBorder;
    global deformedBorder deformedPoints;
    deformedPoints = bnTransform (recordedBorder, referenceBorder, recordedPoints);
    
    bPoints = [recordedBorder(:, [1 2]); recordedBorder(:, [3 4])];
    deformedBoundaryPoints = bnTransform(recordedBorder, referenceBorder, bPoints);
    deformedBorder = zeros(size(recordedBorder));
    numLines = size(recordedBorder, 1);
    deformedBorder(:, [1 2]) = deformedBoundaryPoints(1:numLines, :);
    deformedBorder(:, [3 4]) = deformedBoundaryPoints(numLines+1:end, :);
end

function updateSliders (~, ~, ~)
    global BN_A BN_B BN_P;
    global handles;
    global deformedPoints referencePoints;
    
    BN_A = get(handles.aSlider, 'value');
    BN_B = get(handles.bSlider, 'value');
    BN_P = get(handles.pSlider, 'value');
    
    set(handles.aLabel, 'string', sprintf('A: %f', BN_A));
    set(handles.bLabel, 'string', sprintf('B: %f', BN_B));
    set(handles.pLabel, 'string', sprintf('P: %f', BN_P));
    
    doBN;
    drawBN;
    
    
    error = calcError (deformedPoints, referencePoints);
    pixelDeformed = norm2pxl(deformedPoints);
    pixelReference = norm2pxl(referencePoints);
    pxlError = calcError(pixelDeformed, pixelReference);
    fprintf('Normalized error: %f\n', error);
    fprintf('Pixel error: %f\n', pxlError);
end


function autosearch (~, ~, ~)
    global BN_A BN_B BN_P;
    global handles;
    global deformedPoints referencePoints;
    global deformedBorder referenceBorder;

    A_Range = 8.8:0.1:9.1; %3.5:0.1:5.5;
    B_Range = 20:35; %9:1:50;
    P_Range = 0:0;%:0.1:3;
    
    minerror = NaN;
    minSetting = [0 0 0];
    errors = zeros(length(A_Range), length(B_Range));
    for aidx=1:length(A_Range)
        a = A_Range(aidx);
        for bidx=1:length(B_Range)
            b = B_Range(bidx);
            for p=P_Range
                BN_A = a; BN_B = b; BN_P = p; doBN; 
                error = calcError(deformedBorder, referenceBorder);
                errors(aidx, bidx) = error;
                if isnan(minerror) || error < minerror
                    minerror = error;
                    minSetting(1:3) = [a b p];
                end
                fprintf('A=%f, B=%f, P=%f; Error = %f\n', a, b, p, error);
            end
        end
    end
    
    fprintf('Best setting: [a b p] = [%f %f %f]\n', minSetting(1), minSetting(2), minSetting(3));
    
    
    figure;
    surf(A_Range, B_Range, errors');
    BN_A = minSetting(1);
    BN_B = minSetting(2);
    BN_P = minSetting(3);
    
    set(handles.aSlider, 'value', BN_A);
    set(handles.bSlider, 'value', BN_B);
    set(handles.pSlider, 'value', BN_P);
    updateSliders;
    
    doBN; drawBN;
end


function error = calcError (defPoints, refPoints)
    diff = defPoints(:, [1 2]) - refPoints(:, [1 2]);
    errors = sqrt(sum(diff.^2, 2));
    error = mean(errors);
end

function drawBN 
    global deformedBorder deformedPoints;
    global handles;
    
    axes(handles.bnplot);
    cla;
    hold on;
    for lidx=1:length(deformedBorder)
        plot(deformedBorder(lidx,[1 3]), deformedBorder(lidx, [2 4])); 
    end
    deformedBoundaryPoints = [deformedBorder(:, [1 2]); deformedBorder(:, [3 4])];
    scatter(deformedPoints(:,1), deformedPoints(:,2));
    scatter(deformedBoundaryPoints(:, 1), deformedBoundaryPoints(:, 2), 'g');
    title('Deformed data');
    hold off;
end

function createFig 
    global recordedBorder recordedPoints;
    global referenceBorder referencePoints;
    global BN_A BN_B BN_P;
    global handles;
     
    figure;
    subplot(2,2,1);
    hold on;
    %xlim([-0.2 0.2]);
    %ylim([0.15 0.4]);
    title('Recorded data');
    for lidx=1:length(recordedBorder)
        plot(recordedBorder(lidx,[1 3]), recordedBorder(lidx, [2 4])); 
    end
    bPoints = [recordedBorder(:, [1 2]); recordedBorder(:, [3 4])];
    scatter(recordedPoints(:,1), recordedPoints(:,2));
    scatter(bPoints(:, 1), bPoints(:, 2), 'g');
    hold off;
    
   
    subplot(2,2,2);
    hold on;
    title('Reference data');
    for lidx=1:length(referenceBorder)
        plot(referenceBorder(lidx,[1 3]), referenceBorder(lidx, [2 4])); 
    end
    scatter(referencePoints(:,1), referencePoints(:,2));
    hold off;
    
    
    % Bottom left - subplot(2,2,3);
    hpanel = uipanel('Parent', gcf, 'Units', 'normal', 'Position', [0 0 0.5 0.5]); 

    
    handles.aLabel = uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 0.6 0.3 0.25],...
        'String','A');
    
    handles.aSlider = uicontrol(hpanel, ...
        'style','slider',...
        'min', 0, 'max', 50, 'value', BN_A, ...
        'units','normal',...
        'position', [0.3 0.6 0.5 0.25], ...
        'callback', @updateSliders);
    
    
    handles.bLabel = uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 0.5 0.3 0.25],...
        'String','B');
    
    
    handles.bSlider = uicontrol(hpanel, ...
        'style','slider',...
        'min', 0, 'max', 50, 'value', BN_B, ...
        'units','normal',...
        'position', [0.3 0.5 0.5 0.25], ...
        'callback', @updateSliders);

    
    handles.pLabel = uicontrol(hpanel, ...
        'Style','text',...
        'units' ,'normal', ...
        'Position',[0 0.4 0.3 0.25],...
        'String','P');
    
    handles.pSlider = uicontrol(hpanel, ...
        'style','slider',...
        'min', 0, 'max', 3, 'value', BN_P, ...
        'units','normal',...
        'position', [0.3 0.4 0.5 0.25], ...
        'callback', @updateSliders);
    
    handles.bnplot = subplot(2,2,4);
    
    uicontrol(hpanel, ...
        'style', 'pushbutton', ...
        'string', 'Search', ...
        'units', 'normal',...
        'position', [0 0 1 0.3], ...
        'callback' ,@autosearch);
    
    drawBN;
end