function [minA, minB, minP, minerror] = BNSearch(recordedBorder, referenceBorder)
    [minA, minB, minP, minerror] = gradientdescent(recordedBorder, referenceBorder);
end


function [minA, minB, minP, minerror] = gradientdescent(recordedBorder, referenceBorder)
    a= 10;
    b= 10;
    p= 0;
    
    % a8.8,  b50
    
    delta = 1;
    MoveBy = 1000;
    
    errors = zeros(1, 10);
    for i=1:10
        deformedBorder = doBNLocal(recordedBorder, referenceBorder, a, b, p);
        error1 = calcErrorLocal(deformedBorder, referenceBorder);
        errors(i) = error1;
        fprintf('A=%f, B=%f, P=%f; Error = %f\n', a, b, p, error1);
        
        deformedBorder = doBNLocal(recordedBorder, referenceBorder, a+delta, b, p);
        error2 = calcErrorLocal(deformedBorder, referenceBorder);
        newA = a + (error1 - error2)*MoveBy; % Move in the opposite direction

        deformedBorder = doBNLocal(recordedBorder, referenceBorder, a, b+delta, p);
        error2 = calcErrorLocal(deformedBorder, referenceBorder);
        newB = b + (error1 - error2)*MoveBy; % Move in the opposite direction
        
        a = newA;
        b = newB;
    end
    
    minA = a;
    minB = b;
    minP = p;
    
    deformedBorder = doBNLocal(recordedBorder, referenceBorder, a, b, p);
    minerror = calcErrorLocal(deformedBorder, referenceBorder);
    
    figure;
    plot(errors);
end


function error = calcErrorLocal (defPoints, refPoints)
    diff = defPoints(:, [1 2]) - refPoints(:, [1 2]);
    errors = sqrt(sum(diff.^2, 2));
    error = mean(errors);
end

function deformedBorder = doBNLocal (recBorder, refBorder, a, b, p)
    bPoints = [recBorder(:, [1 2]); recBorder(:, [3 4])];
    deformedBoundaryPoints = bnTransform(recBorder, refBorder, bPoints, a, b, p);
    deformedBorder = zeros(size(recBorder));
    numLines = size(deformedBorder, 1);
    deformedBorder(:, [1 2]) = deformedBoundaryPoints(1:numLines, :);
    deformedBorder(:, [3 4]) = deformedBoundaryPoints(numLines+1:end, :);
end

