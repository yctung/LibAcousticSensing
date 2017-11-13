function segments = getReference ()
    T1 = 1; T2 = 2; R1 = 3; R2 = 4;
    B1 = 5; B2 = 6; L1 = 7; L2 = 8;
    MV1 = 9; MV2 = 10; MH1 = 11; MH2 = 12;
    
    %     expSteps = zeros(1, 22);
    %     expSteps(1) = plot([0 1], [1 1]);
    %     expSteps(2) = plot([1 1], [1 0]);
    %     expSteps(3) = plot([0 1], [0 0]);
    %     expSteps(4) = plot([0 0], [0 1]);
    %     expSteps(5) = plot([0 1], [0.5 0.5]);
    %     expSteps(6) = plot([0.5 0.5], [0 1]);
    
    segments = zeros(12, 5, 2);
    segments(T1,:,1) = linspace(0,0.5,5); segments(T1,:,2) = linspace(1,1,5);
    segments(T2,:,1) = linspace(0.5,1,5); segments(T2,:,2) = linspace(1,1,5);
    segments(R1,:,1) = linspace(1,1,5); segments(R1,:,2) = linspace(1,0.5,5);
    segments(R2,:,1) = linspace(1,1,5); segments(R2,:,2) = linspace(0.5,0,5);
    segments(B1,:,1) = linspace(1,0.5,5); segments(B1,:,2) = linspace(0,0,5);
    segments(B2,:,1) = linspace(0.5,0,5); segments(B2,:,2) = linspace(0,0,5);
    segments(L1,:,1) = linspace(0,0,5); segments(L1,:,2) = linspace(0,0.5,5);
    segments(L2,:,1) = linspace(0,0,5); segments(L2,:,2) = linspace(0.5,1,5);
    segments(MV1,:,1) = linspace(0.5,0.5,5); segments(MV1,:,2) = linspace(1,0.5,5);
    segments(MV2,:,1) = linspace(0.5,0.5,5); segments(MV2,:,2) = linspace(0.5,0,5);
    segments(MH1,:,1) = linspace(0,0.5,5); segments(MH1,:,2) = linspace(0.5,0.5,5);
    segments(MH2,:,1) = linspace(0.5,1,5); segments(MH2,:,2) = linspace(0.5,0.5,5);
    
    segments = linearize(segments);
    
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
end

