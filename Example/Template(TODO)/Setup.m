libPath = '../../../LibAcousticSensing/Matlab/'
oriPath = cd(libPath)

LibSetup; % setup paths for the core LibAcousticSensing

cd(oriPath); % go back to the original path

addpath('LocalHelpers');
clear oriPath

% check if the java class is correctly included
LibLoad; % load java classes
which JavaSensingServer