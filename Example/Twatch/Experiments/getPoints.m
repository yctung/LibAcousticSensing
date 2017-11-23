function [minX, maxX, minY, maxY, lineSegments, left, top, right, bottom, middlehoriz, middlevert] = getPoints (FLIP_X, FLIP_Y)
    global XYBuffer savedLabels;    
    % First we'll interpolate 5 points within each segment
    % Mapping ground truth to data points:
    %     expSteps(1) = plot([0 1], [1 1]);
    %     expSteps(2) = plot([1 1], [1 0]);
    %     expSteps(3) = plot([0 1], [0 0]);
    %     expSteps(4) = plot([0 0], [0 1]);
    %     expSteps(5) = plot([0 1], [0.5 0.5]);
    %     expSteps(6) = plot([0.5 0.5], [0 1]);
    
    SCALE_POINTS = 1;
    
    % Extract raw XY points from recording
    fprintf('\tExtracting points\n');
    
    
    left = XYBuffer(savedLabels == 4, :);
    top = XYBuffer(savedLabels == 1, :);
    right = XYBuffer(savedLabels == 2, :);
    bottom = XYBuffer(savedLabels == 3, :);
    middlehoriz = XYBuffer(savedLabels == 5, :);
    middlevert = XYBuffer(savedLabels == 6, :);
    
    % Convert points into resampled points
    % <Line number, interpolated point number, x/y coordinates >
    
    fprintf('\tDividing up segments\n');
    lineSegments = zeros(12, 5, 2);
    T1 = 1; T2 = 2; R1 = 3; R2 = 4;
    B1 = 5; B2 = 6; L1 = 7; L2 = 8;
    MV1 = 9; MV2 = 10; MH1 = 11; MH2 = 12;
    
    lineSegments(T1,:,:) = findPoints(top, left, middlevert);
    lineSegments(T2,:,:) = findPoints(top, middlevert, right);
    lineSegments(R1,:,:) = findPoints(right, top, middlehoriz);
    lineSegments(R2,:,:) = findPoints(right, middlehoriz, bottom);
    lineSegments(B1,:,:) = findPoints(bottom, right, middlevert);
    lineSegments(B2,:,:) = findPoints(bottom, middlevert, left);
    lineSegments(L1,:,:) = findPoints(left, bottom, middlehoriz);
    lineSegments(L2,:,:) = findPoints(left, middlehoriz, top);
    lineSegments(MV1,:,:) = findPoints(middlevert, top, middlehoriz);
    lineSegments(MV2,:,:) = findPoints(middlevert, middlehoriz, bottom);
    lineSegments(MH1,:,:) = findPoints(middlehoriz, left, middlevert);
    lineSegments(MH2,:,:) = findPoints(middlehoriz, middlevert, right);
    
    
    % Then glue them together
    % Not 100% sure why this is necessary. Maybe for better accuracy of BN?
    % Glues the corners together by averaging the expected value
    
    % First glue together corners where only 2 points meet
    fprintf('\tGluing points\n');
    p = mean([lineSegments(T1,1,:); lineSegments(L2,end,:)]);
    lineSegments(T1,1,:) = p;
    lineSegments(L2,end,:) = p;
    
    p = mean([lineSegments(T2,end,:); lineSegments(R1,1,:)]);
    lineSegments(T2,end,:) = p;
    lineSegments(R1,1,:) = p;
    
    p = mean([lineSegments(R2,end,:); lineSegments(B1,1,:)]);
    lineSegments(R2,end,:) = p;
    lineSegments(B1,1,:) = p;
    
    p = mean([lineSegments(B2,end,:); lineSegments(L1,1,:)]);
    lineSegments(B2,end,:) = p;
    lineSegments(L1,1,:) = p;
    
    
    % Then glue together points where 3 points meet
    p = mean([lineSegments(T1,end,:); lineSegments(MV1,1,:); lineSegments(T2,1,:)]);
    lineSegments(T1,end,:) = p;
    lineSegments(MV1,1,:) = p;
    lineSegments(T2,1,:) = p;
    
    p = mean([lineSegments(R1,end,:); lineSegments(MH2,end,:); lineSegments(R2,1,:)]);
    lineSegments(R1,end,:) = p;
    lineSegments(MH2,end,:) = p;
    lineSegments(R2,1,:) = p;
    
    p = mean([lineSegments(B1,end,:); lineSegments(MV2,end,:); lineSegments(B2,1,:)]);
    lineSegments(B1,end,:) = p;
    lineSegments(MV1,end,:) = p;
    lineSegments(B2,1,:) = p;
    
    
    p = mean([lineSegments(L1,end,:); lineSegments(MH1,1,:); lineSegments(L2,1,:)]);
    lineSegments(L1,end,:) = p;
    lineSegments(MH1,1,:) = p;
    lineSegments(L2,1,:) = p;
    
    
    % Finally the four point intersection
    p = mean([lineSegments(MH1,end,:); lineSegments(MV1,end,:); lineSegments(MH2,1,:); lineSegments(MV2,1,:)]);
    lineSegments(MH1,end,:) = p;
    lineSegments(MV1,end,:) = p;
    lineSegments(MH2,1,:) = p;
    lineSegments(MV2,1,:) = p;
    
    lineSegments = linearize(lineSegments);
    
    
    
    % Also extract points
    %     expSteps(7) = scatter(1/5, 4/5);
    %     expSteps(8) = scatter(2/5, 4/5);
    %     expSteps(9) = scatter(3/5, 4/5);
    %     expSteps(10) = scatter(4/5, 4/5);
    %     
    %     expSteps(11) = scatter(1/5, 3/5);
    %     expSteps(12) = scatter(2/5, 3/5);
    %     expSteps(13) = scatter(3/5, 3/5);
    %     expSteps(14) = scatter(4/5, 3/5);
    %     
    %     expSteps(15) = scatter(1/5, 2/5);
    %     expSteps(16) = scatter(2/5, 2/5);
    %     expSteps(17) = scatter(3/5, 2/5);
    %     expSteps(18) = scatter(4/5, 2/5);
    %     
    %     expSteps(19) = scatter(1/5, 1/5);
    %     expSteps(20) = scatter(2/5, 1/5);
    %     expSteps(21) = scatter(3/5, 1/5);
    %     expSteps(22) = scatter(4/5, 1/5);
    
    
    if FLIP_X
        lineSegments(:, [1 3]) = -lineSegments(:, [1 3]);
    end
    
    if FLIP_Y
        lineSegments(:, [2 4]) = -lineSegments(:, [2 4]);
    end
    
    if SCALE_POINTS
        minX = min(min(lineSegments(:, [1 3])));
        maxX = max(max(lineSegments(:, [1 3])));
        minY = min(min(lineSegments(:, [2 4])));
        maxY = max(max(lineSegments(:, [2 4])));
        width = maxX - minX;
        height = maxY - minY;
        
        lineSegments(:, [1 3]) = (lineSegments(:, [1 3]) - minX) / width;
        lineSegments(:, [2 4]) = (lineSegments(:, [2 4]) - minY) / height;
    end
end




function [nearest1, nearest2] = nearest_intersection (line1, line2)
    N = size(line1, 1);
    M = size(line2, 1);
    
    nearest1 = [0 0];
    nearest2 = [0 0];
    nearestDistance = Inf;
    
    for i=1:N
        p1 = line1(i,:);
        for j=1:M
            p2 = line2(j,:);
            dist = norm(p1-p2);
            if dist < nearestDistance
                nearest1 = p1;
                nearest2 = p2;
                nearestDistance = dist;
            end
        end
    end
end


function nearestPoint = find_nearest_point (p, setOfPoints)
    nearestDistance = Inf;
    nearestPoint = [0 0];
    
    for i=1:size(setOfPoints, 1)
        q = setOfPoints(i,:);
        dist = norm(p-q);
        if dist < nearestDistance 
            nearestDistance = dist;
            nearestPoint = q;
        end
    end
end


function line = draw_line (start_point, end_point)
  line = zeros(5, 2);
  line(:, 1) = linspace(start_point(1), end_point(1), 5);
  line(:, 2) = linspace(start_point(2), end_point(2), 5);
end


function interpolated = findPoints (baseline, inter1, inter2)
    inter1(:,1) = smooth(inter1(:,1), 10);
    inter1(:,2) = smooth(inter1(:,2), 10);
    inter2(:,1) = smooth(inter2(:,1), 10);
    inter2(:,2) = smooth(inter2(:,2), 10);
    baseline(:,1) = smooth(baseline(:,1), 10);
    baseline(:,2) = smooth(baseline(:,2), 10);
    
    [start_point, ~] = nearest_intersection(baseline, inter1);
    [end_point, ~] = nearest_intersection(baseline, inter2);
    line = draw_line(start_point, end_point);
    
    interpolated = zeros(size(line));
    for i=1:size(line, 1)
        p = line(i,:);
        interpolated(i,:) = find_nearest_point(p, baseline);
    end
end



