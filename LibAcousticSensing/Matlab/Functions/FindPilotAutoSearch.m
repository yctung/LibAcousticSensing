function [ pilotEndOffsets, pilotDiffers ] = FindPilotAutoSearch( signalAll, preambleSource, serchChIdxs, DEBUG_SHOW)
% 2015/10/17: check if pilot is found successfully
%             pilotEndOffset is the end sample offset of last pilot signal
% 2016/11/29: update this function to auto search pilot for both channel
%           : algorithm: adjust the thres if need (ex: get 11 rather than 10 peaks)
    pilot = preambleSource.syncToDetect;

    if ~exist('DEBUG_SHOW','var'),
        DEBUG_SHOW = 1;
    end

    if exist('serchChIdxs', 'var'),
        PILOT_SEARCH_CH_IDXS = serchChIdxs;
    else
        PILOT_SEARCH_CH_IDXS = [1:2]; 
        % do pilot search for both channels as default now
    end
    
    assert(size(signalAll,2) == length(PILOT_SEARCH_CH_IDXS), '[ERROR]: inconsistent channel size for signal and PILOT_SEARCH_CH_IDXS\n');
    
    % TODO: update pilot setting based on the inputted preambleSource
    PILOT_SEARCH_CH_CNT = length(PILOT_SEARCH_CH_IDXS);
    PILOT_SEARCH_PEAK_WINDOW = 30;
    PILOT_REPEAT_CNT = 10;
    
    PILOT_REPEAT_DIFF = 1000;
    
    PILOT_LOCK_WINDOW_HALF_SIZE = floor(PILOT_REPEAT_DIFF*PILOT_REPEAT_CNT*1.2/2);
    
    pilotAll = repmat([pilot;zeros(PILOT_REPEAT_DIFF-length(pilot), 1)], [PILOT_REPEAT_CNT, 1]); % big pilot used for locking the window for search fisrt
    
    
    pilotEndOffsets = zeros(PILOT_SEARCH_CH_CNT, 1);
    pilotDiffers = zeros(PILOT_REPEAT_CNT-1, PILOT_SEARCH_CH_CNT);

    for chToSearchIdx = 1:PILOT_SEARCH_CH_CNT,
        chIdx = PILOT_SEARCH_CH_IDXS(chToSearchIdx);
        signal = signalAll(:, chIdx); % fetch just the
        
        conAll = abs(conv(signal, pilotAll(end:-1:1), 'same'));
        
        if DEBUG_SHOW == 1,
            figure; title(sprintf('pilot all at ch %d', chIdx));
            subplot(2,1,1);
            plot(signal);
            subplot(2,1,2);
            plot(conAll);
        end
        
        [~, maxIdx] = max(conAll);
        
        % lock the serach signal only to limited size
        convAllStart = max(1, maxIdx-PILOT_LOCK_WINDOW_HALF_SIZE);
        signal = signal(convAllStart:min(maxIdx+PILOT_LOCK_WINDOW_HALF_SIZE, length(signal)));
        
        con = abs(conv(signal, pilot(end:-1:1), 'same'));
        
        if DEBUG_SHOW == 1,
            figure; title(sprintf('locked pilot at ch %d', chIdx));
            subplot(2,1,1);
            plot(signal);
            subplot(2,1,2);
            plot(con);
        end
        
        % now start to search best theshold until get the matched result
        conMean = mean(con);
        conStd = std(con);
        
        THRES_MIN = 5;
        THRES_MAX = 15;
        
        thresPrevMin = THRES_MIN;
        thresPrevMax = THRES_MAX;
        thres = 10; % number of std added
        
        % binary search the matched result
        MAX_FOR_LOOP_FOR_SEARCH = 20;
        
        findMatch = 0;
        for searchIdx = 1:MAX_FOR_LOOP_FOR_SEARCH,
            validPeakIdxs = GetPilotValidPeaks( con, conMean + thres*conStd,  PILOT_SEARCH_PEAK_WINDOW, 0);
            if length(validPeakIdxs) ~= PILOT_REPEAT_CNT,
                fprintf('[WARN]: pilot repeat cnt not matches at search %d\n', searchIdx);
                
                % dump debug figures if necessary
                if DEBUG_SHOW==1,
                    figure;
                    conPlot = con;
                    title(sprintf('Pilot search fail %d at ch %d', searchIdx, chIdx)); hold on;

                    plot(conPlot,'b');
                    plot([0,length(conPlot)], [conMean + thres*conStd, conMean + thres*conStd], '-r', 'linewidth', 2);
                    plot([0,length(conPlot)], [conMean, conMean], '-g', 'linewidth', 2);
                    plot([0,length(conPlot)], [conMean+conStd, conMean+conStd], '-c', 'linewidth', 2); 
                    plot(validPeakIdxs, conPlot(validPeakIdxs), 'o', 'linewidth', 2);
                    legend('con','thres','mean','mean+std','peaks');
                end
                
                
                if length(validPeakIdxs)>=PILOT_REPEAT_CNT, % thres is too low -> so there is too many peaks
                    thresPrevMin = thres;
                    thres = (thresPrevMax+thres)/2;
                else
                    thresPrevMax = thres;
                    thres = (thresPrevMin+thres)/2;
                end
            else
                pilotDiffer = validPeakIdxs(2:end) - validPeakIdxs(1:end-1);
                if sum(pilotDiffer == PILOT_REPEAT_DIFF)<5, % lose mode
                    fprintf(2, '[WARN]: pilot repeat diff not matches -> go random search\n');
                    if randi(2) == 1,
                        thresPrevMin = thres;
                        thres = (thresPrevMax+thres)/2;
                    else
                        thresPrevMax = thres;
                        thres = (thresPrevMin+thres)/2;
                    end
                else % pilot diff matches
                    findMatch = 1;
                    break;
                end
            end
        end
        
        if findMatch == 1,
            pilotDiffers(:,chToSearchIdx) = pilotDiffer;
            pilotEndOffsets(chToSearchIdx) = validPeakIdxs(end) - floor(length(pilot)/2) + PILOT_REPEAT_DIFF + convAllStart -1;
        else
            fprintf(2,'[ERROR]: unable to find valid pilot at chIdx = %d\n',chIdx);
            pilotDiffers(:,chToSearchIdx) = -1;
            pilotEndOffsets(chToSearchIdx) = -1;
            
            % dump debug figures when detect fails
            figure(778898);
            plot(signalAll);
            title('audio');
            
            figure(778899);
            plot(0,0); % clean
            hold on;
            conPlot = con;
            title(sprintf('Pilot search fail %d at ch %d', searchIdx, chIdx)); hold on;

            plot(conPlot,'b');
            plot([0,length(conPlot)], [conMean + thres*conStd, conMean + thres*conStd], '-r', 'linewidth', 2);
            plot([0,length(conPlot)], [conMean, conMean], '-g', 'linewidth', 2);
            plot([0,length(conPlot)], [conMean+conStd, conMean+conStd], '-c', 'linewidth', 2); 
            plot(validPeakIdxs, conPlot(validPeakIdxs), 'o', 'linewidth', 2);
            legend('con','thres','mean','mean+std','peaks');
            title('preamble detect');
            
            hold off;
        end
    end
        
end

