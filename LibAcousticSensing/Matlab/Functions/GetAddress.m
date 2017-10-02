function [ address ] = GetAddress()
% 2017/09/28: function to know IP, return IP as a string
%       TODO: try to load IP in a more reliable way?
    MSG_UNKNOWN_IP = 'Unknown address';

    address = MSG_UNKNOWN_IP;
    findAdress = 0;
    
    % first
    try
        % ref: https://www.mathworks.com/matlabcentral/newsreader/view_thread/292100
        % issue: not able to get ipaddress form the "getLocalHost" in new MAC
        data = java.net.InetAddress.getLocalHost;
        address = char(data.getHostAddress);
        findAdress = 1;
    catch exception
        fprintf(1, '[WARN]: Unable to find machine IP (try to get it from ifconfig?)\n');
    end
    
    
    % TODO: try to use ifconfig to get IP if the java.net.InetAddress fails
    %{
    if strcmp(computer,'GLNXA64')
                IPaddress = '(not implemented)';
            elseif strcmp(computer,'MACI64')
                IPaddress = system('ifconfig en0 inet | awk ''{print $2}''');
            %elseif strcmp() % TODO: add windows
            else
                IPaddress = 'Unknown IP';
            end
    %}

end

