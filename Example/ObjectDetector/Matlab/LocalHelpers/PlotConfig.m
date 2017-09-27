%==========================================================================
% 2014/01/24 - yctung : this config is used to set up plot configuration
%==========================================================================

LINE_WIDTH = 2.0;
set(0,'DefaultAxesFontSize',18,'DefaultTextFontSize',16);

W = 13; H = 4;

%Position plot at left hand corner with width 5 and height 5.
%set(gcf, 'PaperPosition', [0 0 10 4]); 
%set(gcf, 'PaperSize', [10 4]); 
%Set the paper to have width 5 and height 5.

set(gcf, 'PaperSize', [W H]);
set(gcf, 'PaperPositionMode', 'manual');
set(gcf, 'PaperPosition', [0 0 W H]);

set(gcf, 'PaperUnits', 'inches');
set(gcf, 'PaperSize', [W H]);
set(gcf, 'PaperPositionMode', 'manual');
set(gcf, 'PaperPosition', [0 0 W H]);

H_SMALL = 4;
W_SMALL = 5;

myR = [141+60,0,0]/256;
myY = [255,211,0]/256;
myC = [0,227,255]/256;
myB = [35,0,145-60]/256;

myColorMap = [myB; myY; myR]



%---------- this is the setting used for CCS submission ---------
% LINE_WIDTH = 2.0;
% set(0,'DefaultAxesFontSize',18,'DefaultTextFontSize',16);
% %Position plot at left hand corner with width 5 and height 5.
% 
% set(gcf, 'PaperPosition', [0 0 10 3]); 
% %Set the paper to have width 5 and height 5.
% set(gcf, 'PaperSize', [10 3]); 
%------------ end of setting used for CCS submission -------------