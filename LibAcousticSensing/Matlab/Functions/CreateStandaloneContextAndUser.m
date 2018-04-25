function [context, user] = CreateStandaloneContextAndUser()
% 2018/04/13: this function helps to build standalone context/user
%           : that can be later used to auto-define Matlab Coder's
%           : callback input types
% TODO: find a smarter way to get these values directly from the SensingServer class    

% define the context for standalone mode
context.mode = int32(SensingServer.MODE_STANDALONE);

% Types of user-defined callback messages 
context.CALLBACK_TYPE_ERROR = int32(SensingServer.CALLBACK_TYPE_ERROR);
context.CALLBACK_TYPE_INIT  = int32(SensingServer.CALLBACK_TYPE_INIT);
context.CALLBACK_TYPE_DATA  = int32(SensingServer.CALLBACK_TYPE_DATA);
context.CALLBACK_TYPE_USER  = int32(SensingServer.CALLBACK_TYPE_USER);

% Here we define the user data
user.code = int32(5566);
user.valInt = int32(5566);


end

