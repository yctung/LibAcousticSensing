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

% set up java static path if need
import edu.umich.cse.yctung.*
check = which('JavaSensingServer');
if isempty(check)
    fprintf(2, '[WARNING]: JavaClassPath is not added yet!\n');
    fprintf(1, 'Add this path will restart the Matlab.\nDo you wanto do this now?\n');
    add = input('(Y/N): ', 's');
    add = strtrim(lower(add));
    if strcmp(add, 'y') || strcmp(add, 'yes')
        fprintf(1, 'Going to add JavaClassPath');
        LibAddJavaClassPath;
    end
end

% final check
import edu.umich.cse.yctung.*
[check, err] = LibCheckSetup();
if ~check
    fprintf(2, '[ERROR]: fails to setup LibAcousticSensing,\nerr = %s\n', err);
else
    fprintf('Setup LibAS succesullfully.\nYou are ready to run our Matlab example :)\n');
end
