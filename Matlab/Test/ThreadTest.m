function [ ] = ThreadTest( )
    t = timer('StartDelay',0.1, 'TimerFcn',@utilityFcn);
    start(t);
    for i=1:10000;
        %pause(0.1);
        temp = rand(1000,1000)*rand(1000,1000); 
        fprintf('x\n');
    end
end

function utilityFcn(src,evt)
    % some lengthy calculation/update done here
    for i=1:100;
        temp = rand(1000,1000)*rand(1000,1000);
        pause(0.1);
    end
    fprintf('\ndone\n');
end
 
 
