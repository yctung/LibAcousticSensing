%==========================================================================
% 2017/01/26: Set paths of local helpers and lib
%==========================================================================
libPath = '../../../LibAcousticSensing/Matlab/'
oriPath = cd(libPath)

LibSetup; % setup paths for the core LibAcousticSensing

cd(oriPath); % go back to the original path

addpath('LocalHelpers');
addpath('Traces');
clear oriPath

% check if the java class is correctly included
which JavaSensingServer
