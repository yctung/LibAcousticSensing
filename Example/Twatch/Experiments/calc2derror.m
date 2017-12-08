function [ mu, V, errors] = calc2derror(points1, points2)
    diff = points1 - points2;
    errors = sqrt(sum(diff.^2, 2));
    mu = mean(errors);
    V = var(errors);
end

