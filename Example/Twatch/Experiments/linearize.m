function pointPairs = linearize(interpolatedSegments)
    % It takes all points in interpolated segments, in that order, and
    % outputs pairs of points which form the individual line segments. This
    % can be fed into the deformation algorithm.
    
    % InteprolatedSegments: <segment number, interpolated point index, x/y
    % of point>
    
    numSegs = size(interpolatedSegments,1);
    numPoints = size(interpolatedSegments,2);
    pointPairs = zeros(numSegs*(numPoints-1), 4);
    
    counter = 1;
    for sidx=1:numSegs
        for pidx=2:numPoints
            pointPairs(counter, 1:2) = interpolatedSegments(sidx, pidx-1, :);
            pointPairs(counter, 3:4) = interpolatedSegments(sidx, pidx, :);
            counter = counter + 1;
        end
    end
end

