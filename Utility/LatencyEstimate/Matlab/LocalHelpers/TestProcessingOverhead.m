% yctung: 2017/12/04 it is just a test to see how heavy the matched filter
%         processin might be

REPEAT_CNT = 10;

data = rand(2400, REPEAT_CNT);
match = rand(2400, 1);

tic
for repeat = 1:REPEAT_CNT
    result = conv(data(:, 1), match);
end
toc

