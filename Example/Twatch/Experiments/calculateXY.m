function [x, y] = calculateXY(r1, r2, D)
    %D = 0.142; % Mic to speaker distance -- fixed
    x = (D^2 - r2^2 + r1^2) / (2*D);
    if r1^2 - x^2 < 0
        y = -abs(sqrt(r1^2 - x^2));
    else
        y = sqrt(r1^2 - x^2);
    end
end