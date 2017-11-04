% Load the reuslt

%load OkResultForDemoVideo.mat;

for i = 1:2,
    features = mean(svm.targets(i).features,2);
    figure;
    h_f = plot(features, 'linewidth', 2);
    axis off;
    box off;
    saveas(h_f,sprintf('app_fingerprint_result_target_%d',i),'epsc');
end