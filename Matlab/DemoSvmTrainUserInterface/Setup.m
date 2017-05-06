%==========================================================================
% 2017/01/26: Set paths of local helpers and lib
%==========================================================================
oriPath=cd('..');
LibSetup;
cd(oriPath);
addpath('LocalHelpers');
clear oriPath

% check if the java class is correctly included
which JavaSensingServer
