% Implemented from paper: https://www.cs.princeton.edu/courses/archive/fall00/cs426/papers/beier92.pdf
function deformedPoints = bnTransform (recSegments, refSegments, recPoints, a, b, p)
    % Params
    % We might want to pass these in as params
    deformedPoints = zeros(size(recPoints));
    numpoints = size(recPoints, 1);
    numsegments = size(recSegments, 1);
    
    for pidx=1:numpoints
        X = recPoints(pidx, :);
        DSUM = [0 0];
        weightsum = 0;
        
        for sidx=1:numsegments
            P = recSegments(sidx, 1:2);
            Q = recSegments(sidx, 3:4);
            u = getU(X, P, Q);
            v = getV(X, P, Q);
            Pp = refSegments(sidx, 1:2);
            Qp = refSegments(sidx, 3:4);
            Xp = getXp(u, v, Pp, Qp);
            D = Xp-X;
            dist = shortest(X, P, Q);
            weight = getWeight(P, Q, dist, p, a, b);
            DSUM = DSUM + D*weight;
            weightsum = weightsum + weight;
        end
        
        Xp = X + DSUM/weightsum;
        deformedPoints(pidx,:) = Xp;
    end 
end


function w = getWeight (P, Q, dist, p, a, b)
    len = norm(Q-P);
    num = len^p;
    den = a + dist;
    w = (num/den)^b;
end



function u = getU (X, P, Q)
    num = dot(X-P, Q-P);
    den = norm(Q-P)^2;
    if (den == 0)
        u = 0;
    else
        u = num / den;
    end
end


function v = getV (X, P, Q)
    num = dot(X-P, Perpendicular(Q-P));
    den = norm(Q-P);
    if den == 0
        v = 0;
    else
        v = num / den;
    end
end

function flipped = Perpendicular (X)
    flipped = [-X(2) X(1)];
end

function Xp = getXp (u, v, Pp, Qp)
    term1 = u*(Qp - Pp);
    term2num = v*Perpendicular(Qp-Pp);
    term2den = norm(Qp-Pp);
    if term2den == 0
        Xp = Pp + term1;
    else
        Xp = Pp + term1 + term2num/term2den;
    end
end


function s = shortest (X, P, Q)
    x1 = P(1); y1 = P(2);
    x2 = Q(1); y2 = Q(2);
    x0 = X(1); y0 = X(2);
    num = abs((y2-y1)*x0 - (x2-x1)*y0 + x2*y1 - y2*x1);
    den = sqrt((y2-y1)^2 + (x2-x1)^2);
    if den == 0
        s = 0;
    else
        s = num/den;
    end
end