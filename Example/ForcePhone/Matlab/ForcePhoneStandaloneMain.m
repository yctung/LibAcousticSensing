%==========================================================================
% 2018/04/13: this main helps to use Matlab's auto fill type function
%           : to define the input class of callback function
% NOTE: this main MUST be executed after the ForcePhoneMain so we can get
%       the parse setting (PS) global variable
% WARN: if Matlab Coder complains about the missing PS, define it and
%       select "init by example"
%==========================================================================
[context, user] = CreateStandaloneContextAndUser();

% TODO: get data as constant
data = zeros(2400, 2);

ret = ForcePhoneCallback(context, context.CALLBACK_TYPE_INIT, data, user);

% export the audo setting to files for the standalone use
SaveAudioSourceAndParseSetting(as, 'assets')