global dsDetectsAll;
global dsDetectsAllEnd;

dataToPlot = dsDetectsAll(:, 1:dsDetectsAllEnd, 1);

imagesc(dataToPlot);
