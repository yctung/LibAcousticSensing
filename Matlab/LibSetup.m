%==========================================================================
% 2017/01/26: Set up class paths for matlab library
%==========================================================================
addpath(strcat(pwd,'/LibAcousticSensing/'));
addpath(strcat(pwd,'/LibAcousticSensing/Classes/'));

% add path of svm libaray
if strcmp(computer,'GLNXA64'), % ubuntu in lab
    addpath(genpath(strcat(pwd,'/LibAcousticSensing/3rdLibs/libsvm_ubuntu/')));
elseif strcmp(computer,'MACI64'), % MAC air
    addpath(genpath(strcat(pwd,'/LibAcousticSensing/3rdLibs/libsvm_mac/')));
else
    fprintf(2,'[WARNING]: fails to load libsvm (you might need to compile libsvm and add to your path) = %s\n', computer);
end
% TODO: add windows support

import edu.umich.cse.yctung.*
check = which('JavaSensingServer');
if isempty(check)
    fprintf(2, '[ERROR] JavaSensingServer is not correctlly included (has not executed LibAddJavaClassPath.m?)\n');
end