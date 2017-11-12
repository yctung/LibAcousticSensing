function [d] = calcDistance (PeakDown, PeakUp, ch1Num, ch2Num, d1, d2)
    c1PeakDown = PeakDown(ch1Num);
    c1PeakUp = PeakUp(ch1Num);
    c2PeakDown = PeakDown(ch2Num);
    c2PeakUp = PeakUp(ch2Num);
    
    % Fine-tune these numbers to get the actual distance
    
    C = 345.63334; %345.63334; % Actually it's 343 m/sec or something
    FS = 48000.0; %Actually it's 48000.
    
%     if ch1Num == 1 && ch2Num == 3
%         MIC_DISTANCE_CONSTANT = (0.12 + 0.1)/2.0;
%     elseif ch1Num == 2 && ch2Num == 3
%         MIC_DISTANCE_CONSTANT = (0.45 + 0.1)/2.0;
%     else
%         MIC_DISTANCE_CONSTANT = 0;
%     end
    
    MIC_DISTANCE_CONSTANT = (d1 + d2)/2.0;
    d = (c1PeakDown - c1PeakUp) - (c2PeakDown - c2PeakUp);
    d = C*d/(2*FS) + MIC_DISTANCE_CONSTANT;
end