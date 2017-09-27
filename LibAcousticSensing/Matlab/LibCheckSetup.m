function [ ret, err ] = LibCheckSetup()
% return 1(true) if the link is correctly setted
    ret = 0; % false
    err = '';
    if isempty(which('SensingServer'))
        err = 'SensingServer is not found (add the wrong LibAcousticSensing path?)'
        return
    end
    
    import edu.umich.cse.yctung.*
    if isempty(which('JavaSensingServer'))
        err = 'JavaSensingServer is not found (fail to add java static path?)'
        return
    end
    
    try
        JavaSensingServer.closeAll();
    catch exception
        err = 'JavaSensingServer is not correctly loaded (built by the wrong jdk version?)';
        err = sprintf('%s\n%s', err, exception.message)
        return
    end    
    
    ret = 1; % true
end

