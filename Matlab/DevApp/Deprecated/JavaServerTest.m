

jss = JavaSensingServer.create(50005);
set(jss,'OpDataCallback',@JavaServerOnDataCallback);
set(jss,'OpAcceptCallback',@JavaServerOnAcceptCallback);


%jss2 = JavaSensingServer.create(50006);