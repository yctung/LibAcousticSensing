%==========================================================================
% 2014/01/24 - yctung : this config is used to set up plot configuration
%==========================================================================

LINE_WIDTH = 2.0;

W_SMALL = 5;
H_SMALL = 4;

%set(gcf,'DefaultAxesFontSize',18,'DefaultTextFontSize',16);
set(0,'DefaultAxesFontSize',18,'DefaultTextFontSize',16);
setappdata(0, 'DefaultAxesXLabelFontSize', 36) % fucking matlab stupid bug fuck


set(gcf, 'PaperSize', [W_SMALL H_SMALL]);
set(gcf, 'PaperPositionMode', 'manual');
set(gcf, 'PaperPosition', [0 0 W_SMALL H_SMALL]);

set(gcf, 'PaperUnits', 'inches');
set(gcf, 'PaperSize', [W_SMALL H_SMALL]);
set(gcf, 'PaperPositionMode', 'manual');
set(gcf, 'PaperPosition', [0 0 W_SMALL H_SMALL]);

%set(gcf,'DefaultAxesFontSize',500,'DefaultTextFontSize',500);

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