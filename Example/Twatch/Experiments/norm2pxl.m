function pxls = norm2pxl (normalizedPoints)
    % For normalized points, the bottom left is 0, 0
    % For pixels, traditionally the top left is 0, 0
    
    % We just need the X/Y and Row/Col values for the four borders
    % Y = 0, Row = 1079
    % Y = 1, Row = 179
    % X = 0, Col = 250
    % X = 1, Col = 1738
    
    X1 = 1738;
    X0 = 250;
    Y0 = 1079;
    Y1 = 179;
    
    pxls = zeros(size(normalizedPoints));
    for p=1:size(normalizedPoints, 1)
        x = normalizedPoints(p, 1);
        y = normalizedPoints(p, 2);
        
        pxls(p, 1) = (X1-X0)*x + X0;
        pxls(p, 2) = (1-y)*(Y0-Y1) + Y1;
    end
end