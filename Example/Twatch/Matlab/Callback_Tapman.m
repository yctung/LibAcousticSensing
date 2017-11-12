function [] =  Callback_Tapman ( obj, type, data )

    if type == obj.CALLBACK_TYPE_ERROR
        fprintf(2, '[ERROR]: get the error callback data = %s', data);
        return;
    end
    
    
    
    if type == obj.CALLBACK_TYPE_USER
        if data.code == 1 
            % Tap detected!
            fprintf('Tap received!');
        end
    end
end 

function createUI(obj, data)
end