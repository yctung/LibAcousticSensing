%==========================================================================
% 2014/01/24 - yctung : this config is used to set up plot configuration
% 2015/05/
%==========================================================================

LINE_WIDTH = 2.0;
set(0,'DefaultAxesFontSize',18,'DefaultTextFontSize',16);

W = 5; H = 4;

set(gcf, 'PaperSize', [W H]);
set(gcf, 'PaperPositionMode', 'manual');
set(gcf, 'PaperPosition', [0 0 W H]);

set(gcf, 'PaperUnits', 'inches');
set(gcf, 'PaperSize', [W H]);
set(gcf, 'PaperPositionMode', 'manual');
set(gcf, 'PaperPosition', [0 0 W H]);

myR = [141+60,0,0]/256;
myY = [255,211,0]/256;
myC = [0,227,255]/256;
myB = [35,0,145-60]/256;
myK = [255,255,255]/256;

myColorMap = [myB; myY; myR; myK]
