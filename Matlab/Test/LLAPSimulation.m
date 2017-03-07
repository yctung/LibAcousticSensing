%==========================================================================
% 2017/02/22: Testing the algroithm of Device-Free Gesture Tracking Using Acoustic Signals Limitations of Prior Art
%==========================================================================
close all;

S = 34300; % speed of sound, (cm/s)
A = 1.0; % gain
f = 19000; % 19kHz
FS = 960000; % sample rate
ts = 0:1/FS:100/FS; % time series for sampling
DMS = 5; % distance from microphone to speaker (cm)


ori = A*cos(2*pi*f*(ts-DMS/S));
plot(ori);

d = 10; % initial distance between hand and speaker (cm)
v = 1; % moving toward velocity cm/s
%v = 0;
ds = 2*10-v*ts*2+DMS;

ref = A*cos(2*pi*f*(ts-ds/S)); % reflected signal


rec = ori;

figure; hold on;
plot(ori, 'b-');
plot(ref, 'r--');
plot(rec, 'm.');
legend('ori','ref','rec');
hold off;




i = cos(2*pi*f*ts).*rec;
q = -sin(2*pi*f*ts).*rec;

figure; hold on;
plot(i, 'b-');
plot(q, 'r--');
legend('I','Q');
hold off;

figure;
plot(angle(i+q*j));

figure;
plot(i+q*j);