function [ret] = ForcePhoneCallback(context, type, data, user)
% This callback only focuses on handling the data, no GUI anymore
% To convert this to the offline mode, use the
    global PS;
    ret = CreateCallbackReturn();
    %ret = 0;
    
    if type == context.CALLBACK_TYPE_INIT
        PS.touched = 0;
        
    elseif type == context.CALLBACK_TYPE_DATA
        cons = convn(data, PS.signalToCorrelate,'same');
        % estimate vibration by sound correlation
        vib = mean(abs(cons(PS.detectRangeStart:PS.detectRangeEnd, PS.detectChIdx)), 1);
        PS.vibLatest = vib;
        
        if PS.touched == 1
            force = abs(vib - PS.vibRef) / PS.vibRef;
            ret = SetCallbackReturnDouble(ret, force);
            %ret = 0.5;
        end
    elseif type == context.CALLBACK_TYPE_USER
        if user.code == PS.USER_CODE_TOUCH_START
            fprintf(1, "touch start");
            PS.touched = 1;
            PS.vibRef = PS.vibLatest;
        elseif user.code == PS.USER_CODE_TOUCH_END
            fprintf(1, "touch end");
            PS.touched = 0;
        end
    end
end

