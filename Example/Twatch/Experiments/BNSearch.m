function [minA, minB, minP, minerror] = BNSearch(recordedBorder, referenceBorder)
    [minA, minB, minP, minerror] = gradientdescent(recordedBorder, referenceBorder);
    
    figure;
    subplot(2,2,1);
    hold on;
    title('Recorded data');
    for lidx=1:length(recordedBorder)
        plot(recordedBorder(lidx,[1 3]), recordedBorder(lidx, [2 4])); 
    end
    bPoints = [recordedBorder(:, [1 2]); recordedBorder(:, [3 4])];
    scatter(bPoints(:, 1), bPoints(:, 2), 'g');
    hold off;
    
    subplot(2,2,2);
    hold on;
    title('Reference data');
    for lidx=1:length(referenceBorder)
        plot(referenceBorder(lidx,[1 3]), referenceBorder(lidx, [2 4])); 
    end
    hold off;
    
    
    deformedBorder = doBNLocal(recordedBorder, referenceBorder, minA, minB, minP);
    subplot(2,2,4);
    hold on;
    for lidx=1:length(deformedBorder)
        plot(deformedBorder(lidx,[1 3]), deformedBorder(lidx, [2 4])); 
    end
    deformedBoundaryPoints = [deformedBorder(:, [1 2]); deformedBorder(:, [3 4])];
    scatter(deformedBoundaryPoints(:, 1), deformedBoundaryPoints(:, 2), 'g');
    title('Deformed data');
    hold off;
end


function [minA, minB, minP, minerror] = gradientdescent(recordedBorder, referenceBorder)
    a= 10;
    b= 10;
    p= 0;
    
    % a8.8,  b50
    
    delta = 1;
    MoveBy = 150;%100;% //1000; %1000
    
    errors = zeros(1, 10);
    Iterations = 25;
    counter = 1;
    
    deformedBorder = doBNLocal(recordedBorder, referenceBorder, a, b, p);
    prevError = calcErrorLocal(deformedBorder, referenceBorder);
    errors(counter) = prevError;
    counter = counter + 1;

        
    while Iterations > 0
        fprintf('A=%f, B=%f, P=%f; MoveBy=%d. Error = %f\n', a, b, p, MoveBy, prevError);
        
        deformedBorder = doBNLocal(recordedBorder, referenceBorder, a+delta, b, p);
        error2 = calcErrorLocal(deformedBorder, referenceBorder);
        newA = a + (prevError - error2)*MoveBy; % Move in the opposite direction

        deformedBorder = doBNLocal(recordedBorder, referenceBorder, a, b+delta, p);
        error2 = calcErrorLocal(deformedBorder, referenceBorder);
        newB = b + (prevError - error2)*MoveBy; % Move in the opposite direction
        
        if newA < 0 || newB < 0
            break;
        end
        
        
        deformedBorder = doBNLocal(recordedBorder, referenceBorder, newA, newB, p);
        newerror = calcErrorLocal(deformedBorder, referenceBorder);
        if newerror > prevError
            MoveBy = MoveBy/2;
            if MoveBy <= 1, break; end
        else
            prevError = newerror;
            errors(counter) = prevError;
            counter = counter + 1;
            a = newA;
            b = newB;
            Iterations = Iterations - 1;
        end
        
        
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

