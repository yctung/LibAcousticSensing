%==========================================================================
% 2017/01/26: Set up class paths for matlab library
%==========================================================================
addpath(strcat(pwd,'/LibAcousticSensing/'));
addpath(strcat(pwd,'/LibAcousticSensing/Classes/'));
addpath(strcat(pwd,'/tcp_udp_ip_2.0.6/tcp_udp_ip/'));

% add path of svm libaray
if strcmp(computer,'GLNXA64'), % ubuntu in lab
    addpath(genpath(strcat(pwd,'/LibAcousticSensing/3rdLibs/libsvm_ubuntu/')));
elseif strcmp(computer,'MACI64'), % MAC air
    addpath(genpath(strcat(pwd,'/LibAcousticSensing/3rdLibs/libsvm_mac/')));
else
    fprintf(2,'[ERROR]: fails to load svm library due to unrecognized OS = %s\n', computer);
end
% TODO: add windows support

import edu.umich.cse.yctung.*