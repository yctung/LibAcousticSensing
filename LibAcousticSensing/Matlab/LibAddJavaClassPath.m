%==========================================================================
% 2017/03/30: a simple script to add current path to java
%           : NOTE: this script will exit matlab to update static classpath
%           : ref: http://undocumentedmatlab.com/blog/static-java-classpath-hacks
%           : ref: http://www.mathworks.com/help/matlab/matlab_external/static-path.html#bvnynym
%==========================================================================

%pathToAdd = strcat(pwd,'/LibAcousticSensing/3rdLibs/matSock/bin\n')
filePath = strcat(prefdir,'/javaclasspath.txt')
% NOTE you can open this file by "open /Users/eddyxd/.matlab/R2016a/javaclasspath.txt"

% check matlab version

try
    fid = fopen(filePath, 'wt');
    %fprintf(fid, pathToAdd);  % add folder of *.class files
    parts = strsplit(version('-java'), ' ');
    vs = strsplit(parts{2}, '.');
    
    fprintf(2, 'Your Matlab is using %s.%s\n', vs{1}, vs{2});
    
    fprintf(fid, '%s/JavaSensingServer/prebuild/java%s%s/bin',pwd, vs{1}, vs{2});
    fclose(fid);
    
    
    fprintf(2, '[WARNING]: JavaClassPath is added but not loaded yet!\n');
    fprintf(1, 'Do you wanto do restart Matlab to reload JavaClassPath now?\n');
    restart = input('(Y/N): ', 's');
    restart = strtrim(lower(restart));
    if strcmp(restart, 'y') || strcmp(restart, 'yes')
        fprintf(1, 'Going to restart Matlab');
        % exit matlab to update static paths
        exit
    end
    
    fprintf(2, '[WARNING]: LibAS will not work until you restart your Matlab\n');
catch err
    msg = sprintf('Could not create %s/javaclasspath.txt - error was: %s', pwd, err.message);
    uiwait(msgbox(msg, 'Error', 'warn'));  % need uiwait since otherwise exit below will delete the msgbox
end

