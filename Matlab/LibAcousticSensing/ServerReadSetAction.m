function [ name, value, evalString ] = ServerReadSetAction(t)
% 2015/10/16: This reads the set commands details
    % Supported type for ACTION_SET
    SET_TYPE_BYTE_ARRAY = 1;
    SET_TYPE_STRING = 2;
    SET_TYPE_DOUBLE = 3;
    SET_TYPE_INT = 4;
    SET_TYPE_VALUE_STRING = 5;

    % read data from socket
    
    % just for debug
    setType = fread(t, 1, 'int32');
    nameBytes = ServerReadFullData(t);
    valueBytes = ServerReadFullData(t);

    % convert format 
    name = native2unicode(nameBytes);
    name = name(:)'; % ensure name is the row-based string
    
    switch setType,
        case SET_TYPE_STRING,
            value = native2unicode(valueBytes);
            evalString = sprintf('%s = ''%s'';', name, value);
        case SET_TYPE_INT, %int 32
            value = valueBytes(end:-1:1);
            value = typecast(value, 'INT32');
            evalString = sprintf('%s = %d;', name, value);
        case SET_TYPE_VALUE_STRING,
            value = str2double(native2unicode(valueBytes));
            evalString = sprintf('%s = %s;', name, native2unicode(valueBytes));
        case SET_TYPE_BYTE_ARRAY,
            value = valueBytes;
            evalString = '';
        otherwise
            fprintf('[ERROR]: undefined setType = %s', setType);
    end
    %fprintf('LibReadSetAction: (name, setType, value) = (%s, %d, %s) ')

end

