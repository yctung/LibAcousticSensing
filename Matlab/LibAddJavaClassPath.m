%==========================================================================
% 2017/03/30: a simple script to add current path to java
%           : NOTE: this script will exit matlab to update static classpath
%           : ref: http://undocumentedmatlab.com/blog/static-java-classpath-hacks
%           : ref: http://www.mathworks.com/help/matlab/matlab_external/static-path.html#bvnynym
%==========================================================================

pathToAdd = strcat(pwd,'/LibAcousticSensing/3rdLibs/matSock/bin\n')

filePath = strcat(prefdir,'/javaclasspath.txt')

try
    fid = fopen(filePath, 'wt');
    fprintf(fid, pathToAdd);  % add folder of *.class files
    fprintf(fid, '%s/LibAcousticSensing/JavaSensingServer/bin',pwd);
    fclose(fid);
catch err
    msg = sprintf('Could not create %s/javaclasspath.txt - error was: %s', pwd, err.message);
    uiwait(msgbox(msg, 'Error', 'warn'));  % need uiwait since otherwise exit below will delete the msgbox
end

% exit matlab to update static paths
exit