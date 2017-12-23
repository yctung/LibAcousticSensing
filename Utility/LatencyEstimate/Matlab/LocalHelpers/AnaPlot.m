% reference: https://www.mathworks.com/matlabcentral/answers/85885-bar-with-errorbars-on-the-same-figure

NEED_TO_RELOAD_DATA = 1

if NEED_TO_RELOAD_DATA
    load('latency_0hop_mac_0x_1min');
    latency_0hop_0x = latency(2, :);
    load('latency_0hop_mac_1x_1min');
    latency_0hop_1x = latency(2, :);
    load('latency_0hop_mac_5x_1min');
    latency_0hop_5x = latency(2, :);


    figure; hold on;
    h_f = cdfplot(latency_0hop_0x); 
    h_f = cdfplot(latency_0hop_1x); 
    h_f = cdfplot(latency_0hop_5x);
    legend('0hop 0x', '0hop 1x', '0hop 5x');

    load('latency_1hop_nexus6p_0x_1min');
    latency_1hop_0x = latency(2, :);
    load('latency_1hop_nexus6p_1x_1min');
    latency_1hop_1x = latency(2, :);
    load('latency_1hop_nexus6p_5x_1min');
    latency_1hop_5x = latency(2, :);

    figure; hold on;
    h_f = cdfplot(latency_1hop_0x); 
    h_f = cdfplot(latency_1hop_1x); 
    h_f = cdfplot(latency_1hop_5x);
    legend('1hop 0x', '1hop 1x', '1hop 5x');

    % note: _2, _3 reuslts are made in my home with good wifi connectivity
    load('latency_2hop_nexus6p_0x_1min');
    latency_2hop_0x = latency(2, 1:420);
    load('latency_2hop_nexus6p_1x_1min');
    latency_2hop_1x = latency(2, :);
    load('latency_2hop_nexus6p_5x_debug');
    latency_2hop_5x = latency(2, :);

    figure; hold on;
    h_f = cdfplot(latency_2hop_0x); 
    h_f = cdfplot(latency_2hop_1x); 
    h_f = cdfplot(latency_2hop_5x);
    legend('2hop 0x', '2hop 1x', '2hop 5x');

    load('latency_c_nexus6p_0x_1min');
    latency_c_0x = latency(2, :);
    load('latency_c_nexus6p_1x_1min');
    latency_c_1x = latency(2, :);
    load('latency_c_nexus6p_5x_1min');
    latency_c_5x = latency(2, :);

    figure; hold on;
    h_f = cdfplot(latency_c_0x); 
    h_f = cdfplot(latency_c_1x); 
    h_f = cdfplot(latency_c_5x);
    legend('c 0x', 'c 1x', 'c 5x');
end

% output the final figure
%{
mean_velocity = [5 6 7; 8 9 10]; % mean velocity
std_velocity = randn(2,3);  % standard deviation of velocity
figure
hold on
hb = bar(1:3,mean_velocity', 'hist');
% For each set of bars, find the centers of the bars, and write error bars
pause(0.1); %pause allows the figure to be created
for ib = 1:numel(hb)
    %XData property is the tick labels/group centers; XOffset is the offset
    %of each distinct group
    %xData = hb(ib).XData+hb(ib).XOffset;
    ys = h_f(ib).Vertices(:, 2);
    xs = h_f(ib).Vertices(:, 1);
    
    xValid = xs(ys > 0);
    xData = xValid(1:2:end);
    
    
    errorbar(xData, mean_velocity(ib,:), std_velocity(ib,:),'k.')
end
%}


co = get(gca,'ColorOrder'); % Initial
colormap([co(1,:); co(2,:); co(3,:)])

meanAll = [mean(latency_2hop_0x), mean(latency_2hop_1x), mean(latency_2hop_5x);
           mean(latency_1hop_0x), mean(latency_1hop_1x), mean(latency_1hop_5x)
           mean(latency_0hop_0x), mean(latency_0hop_1x), mean(latency_0hop_5x)
           mean(latency_c_0x), mean(latency_c_1x), mean(latency_c_5x)];
       
medianAll = [median(latency_2hop_0x), median(latency_2hop_1x), median(latency_2hop_5x);
             median(latency_1hop_0x), median(latency_1hop_1x), median(latency_1hop_5x)
             median(latency_0hop_0x), median(latency_0hop_1x), median(latency_0hop_5x)
             median(latency_c_0x), median(latency_c_1x), median(latency_c_5x)];
         
stdAll = [std(latency_2hop_0x), std(latency_2hop_1x), std(latency_2hop_5x);
          std(latency_1hop_0x), std(latency_1hop_1x), std(latency_1hop_5x)
          std(latency_0hop_0x), std(latency_0hop_1x), std(latency_0hop_5x)
          std(latency_c_0x), std(latency_c_1x), std(latency_c_5x)];

labelAll = {'2hop', '1hop', '0hop', 'native'};         
         
figure; hold on;
plotConfig;

dataToPlot = meanAll;
errorToPlot = stdAll;

co = get(gca,'ColorOrder'); % Initial
colormap([co(1,:); co(2,:); co(3,:)])
h_f = bar(dataToPlot, 'hist');

box off;
xlabel('Settings');
ylabel('Latency (ms)');

ylim([0, 70]);
xlim([0.5, length(labelAll)+0.5]);

set(gca,'xtick', 1:length(labelAll));
set(gca,'xticklabel', labelAll);

h_l = legend('dummy', 'sonar','5x sonar','location','north');
set(h_l,'box','off')

NEED_TO_SHOW_ERROR = 1
if NEED_TO_SHOW_ERROR
    % ref: https://www.mathworks.com/matlabcentral/answers/242141-barplot-with-errorbar-for-matrix-of-variances
    % For each set of bars, find the centers of the bars, and write error bars
    pause(0.1); %pause allows the figure to be created
    for ib = 1:numel(h_f)
        %XData property is the tick labels/group centers; XOffset is the offset
        %of each distinct group
        %xData = h_f(ib).XData+h_f(ib).XOffset;
        ys = h_f(ib).Vertices(:, 2);
        xs = h_f(ib).Vertices(:, 1);
    
        xValid = xs(ys > 0);
        xData = xValid(1:2:end);
        xData = (xValid(1:2:end) + xValid(2:2:end))/2;
        
        errorbar(xData,dataToPlot(:,ib),errorToPlot(:,ib),'k.')
    end
end


hold off;

set(gcf, 'renderer', 'painters');
print(gcf, '-depsc2', 'Traces/result_latency.eps');



%--------------------------------------------------------------------------
% Plot accuracy by ssi traces
%--------------------------------------------------------------------------
%{
ssiTp = rand(3, 6);

PLOT_SCALE = 100;


% plot bar graph
h_f = figure; hold on;
plotConfigSmall;

set(gcf,'DefaultAxesFontSize',20);

co = get(gca,'ColorOrder'); % Initial
colormap([co(1,:); co(2,:); co(3,:)])
bar(ssiTp'.*PLOT_SCALE, 'hist');


%h_l = legend('In hand', 'Walking','In pocket','orientation','horizontal','location','north');
%set(h_l,'box','off')
h_l = legend('In hand', 'Walking','In pocket','location','southeast');
box off;
xlabel('Participant index');
ylabel('Accuracy (%)');
%plot(6,0);
%set(gca,'Xtick',0:6)
%str = {' ','1','2','3','4',' ',' '};
%set(gca, 'XTickLabel', str);
ylim([0, 100]);
xlim([0.5, length(TRACE_TESTERS)+0.5]);
xTickLabel = cell(length(TRACE_TESTERS), 1);
for i = 1:length(TRACE_TESTERS),
    xTickLabel{i} = sprintf('p%d', i);
end
set(gca,'xtick', 1:length(TRACE_TESTERS));
set(gca,'xticklabel', xTickLabel);
%set(gca,'ytick', [0, 50, 100]);

set(gcf, 'renderer', 'painters');
print(gcf, '-depsc2', 'Figures/result_trigger_squeeze_acc.eps');
%}