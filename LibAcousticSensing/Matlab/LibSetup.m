%==========================================================================
% 2017/01/26: Set up class paths for matlab library
%==========================================================================
addpath(strcat(pwd,'/'));
addpath(strcat(pwd,'/Classes/'));
addpath(strcat(pwd,'/Functions/'));

% add path of svm libaray
% TODO: add windows support
if strcmp(computer,'GLNXA64'), % ubuntu in lab
    addpath(genpath(strcat(pwd,'/3rdLibs/libsvm_ubuntu/')));
elseif strcmp(computer,'MACI64'), % MAC air
    addpath(genpath(strcat(pwd,'/3rdLibs/libsvm_mac/')));
else
    fprintf(2,'[WARNING]: fails to load libsvm (you might need to compile libsvm and add to your path) = %s\n', computer);
end

import edu.umich.cse.yctung.*
[check, err] = LibCheckSetup();
if ~check
    fprintf(2, '[ERROR]: fails to setup LibAcousticSensing,\nerr = %s\n', err);
end
