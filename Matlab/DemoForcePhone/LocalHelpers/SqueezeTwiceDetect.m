function [sRatioTo2Ends, peakX, checkStatus ] = SqueezeTwiceDetect( s, setting, DEBUG_SHOW)
% 2015/11/10: analyze if there is a squeeze action
% 2015/12/02: update new squeeze detection -> solve the "decareed peak"
    CHECK_STATUS_INIT = -1;
    CHECK_STATUS_PASS_PEAK_CNT = 0;
    CHECK_STATUS_PASS_PEAK_X_OFFSET_DIFF = 1;
    CHECK_STATUS_PASS_PEAK_X_OFFSET_START = 2;
    CHECK_STATIS_PASS_PEAK_RATIO_MIN = 3;

    if ~exist('s','var'),
        fprintf('[WARN]: s is undefined -> use default setting (only used for debug)\n');
        
        load Traces/SqueezeTuning/note4/DebugOutput_sse_2_null_null_5/trace.mat
        ParserConfig;
        DetectionSettingNote4; % NOTE: this must be set based on the device we used!!
        %gds.SQUEEZE_LEN_TO_CHECK = 35; % *** just for debug ***
        
        
        
        %load Traces/Trigger/iphone/PhoneTrace/DebugOutput_ssi_2_inhand_dongyao_2/trace.mat
        %ParserConfig;
        %DetectionSettingIPhone6s; % NOTE: this must be set based on the device we used!!
        
        
        %SQUEEZE_IDX_START_TO_CHECK = 1154; % reference from the start
        SQUEEZE_IDX_START_TO_CHECK = 776-gds.SQUEEZE_LEN_TO_CHECK+1; % reference from the end
        
        setting = gds;
        SQUEEZE_LEN_TO_CHECK = gds.SQUEEZE_LEN_TO_CHECK; % setting for me and dongyao
        s = data(SQUEEZE_IDX_START_TO_CHECK:SQUEEZE_IDX_START_TO_CHECK+SQUEEZE_LEN_TO_CHECK-1);
        DEBUG_SHOW = 1;
    else
        if ~exist('DEBUG_SHOW','var')
            DEBUG_SHOW = 0;
        end
    end
    %DEBUG_SHOW = 1;
    
    %s = s/10^5; % *** just for debug ***
    
    
    if exist('setting','var') && ~isempty(setting),
        % load setting
        USE_TWO_END_CORRECT         = setting.USE_TWO_END_CORRECT;
        PEAK_WIN                    = setting.PEAK_WIN;
        PEAK_HARD_THRES_HIGH        = setting.PEAK_HARD_THRES_HIGH;
        PEAK_HARD_THRES_LOW         = setting.PEAK_HARD_THRES_LOW;
        PEAK_SORT_THRES_RATIO_HIGH  = setting.PEAK_SORT_THRES_RATIO_HIGH;
        PEAK_SORT_THRES_RATIO_LOW   = setting.PEAK_SORT_THRES_RATIO_LOW;
        PEAK_LOW_WIDTH_MAX          = setting.PEAK_LOW_WIDTH_MAX; % with constrain of the peak values over low thres
        PEAK_LOW_WIDTH_MIN          = setting.PEAK_LOW_WIDTH_MIN;
        CHECK_PEAK_CNT              = setting.CHECK_PEAK_CNT;
        CHECK_PEAK_DIFF_RANGE       = setting.CHECK_PEAK_DIFF_RANGE;
        CHECK_PEAK_OFFSET_START_RANGE = setting.CHECK_PEAK_OFFSET_START_RANGE;
        CHECK_PEAK_RATIO_MIN        = setting.CHECK_PEAK_RATIO_MIN;
    else
        %TODO: need to make poper setting latter
        USE_TWO_END_CORRECT = 1; % correct data by two end
        PEAK_WIN = 8;
        %PEAK_HARD_THRES_HIGH = 0.08; % this is the hard threshold must feed    
        %PEAK_HARD_THRES_LOW = 0.04;
        
        %{
        PEAK_HARD_THRES_HIGH = 0.05; % for Nexus 6p
        PEAK_HARD_THRES_LOW = 0.03;
        %}
        
        PEAK_HARD_THRES_HIGH = 0.1; % for Nexus 6p
        PEAK_HARD_THRES_LOW = 0.05;
        
        PEAK_SORT_THRES_RATIO_HIGH = 1.5; % multiple of std to achieve for peak
        PEAK_SORT_THRES_RATIO_LOW = 0.5; % multiple of std to achieve for peak
        %PEAK_LOW_WIDTH_MAX = 8; % with constrain of the peak values over low thres
        PEAK_LOW_WIDTH_MAX = 10; % with constrain of the peak values over low thres
        PEAK_LOW_WIDTH_MIN = 2;
        CHECK_PEAK_CNT = 2;
        CHECK_PEAK_DIFF_RANGE = [6, 25];
        CHECK_PEAK_OFFSET_START_RANGE = [0, 40];
        CHECK_PEAK_RATIO_MIN = 0.4; % 0.5 means peak should be twice as the edge
    end
    PEAK_WIN_SIDE = floor(PEAK_WIN/2);
    NEED_ABS = 1; % is it necessary in the end

    
    %DEBUG_SHOW = 1 % *** just for debug ***
    
    X_CNT = length(s);

    
    
    %----------------------------------------------------------------------
    % 1. convert to force ratio based on the first or two ends signals
    %----------------------------------------------------------------------
    sRatio = (s(1)-s)./s(1);
    sRatioTo2Ends = zeros(X_CNT, 1);
    for xNow = 1:X_CNT,
        disToStart = xNow-1;
        disToEnd = X_CNT - xNow;
        sRef = (s(1)*disToEnd + s(end)*disToStart)/(disToStart+disToEnd);
        %sRef = (s(1)*disToStart + s(end)*disToEnd)/(disToStart+disToEnd);
        sRatioTo2Ends(xNow) = (s(xNow) - sRef)/sRef;
    end
    
    if NEED_ABS,
        sRatio = abs(sRatio);
        sRatioTo2Ends = abs(sRatioTo2Ends);
    end
    
    if USE_TWO_END_CORRECT,
        sCorrected = sRatioTo2Ends;
    else
        sCorrected = sRatio;
    end    
    
    
    
    %----------------------------------------------------------------------
    % 2. get thre based on mean, std, and hard thres
    %----------------------------------------------------------------------
    sCorrectedMean = mean(sCorrected);
    sCorrectedStd = std(sCorrected);
    %PEAK_THRES_HIGH = max(sCorrectedMean+PEAK_SORT_THRES_RATIO_HIGH*sCorrectedStd, PEAK_HARD_THRES);
    %fprintf('[WARN]: soft thres high is disabled\n');
    PEAK_THRES_HIGH = PEAK_HARD_THRES_HIGH;
    %PEAK_THRES_LOW = max(sCorrectedMean+PEAK_SORT_THRES_RATIO_LOW*sCorrectedStd, PEAK_HARD_THRES_LOW);
    PEAK_THRES_LOW = PEAK_HARD_THRES_LOW;
    
    assert(PEAK_THRES_HIGH>PEAK_THRES_LOW,'[ERROR]: PEAK_THRES_HIGH<PEAK_THRES_LOW');
    
    %----------------------------------------------------------------------
    % 3. find peaks based on my ad-hoc way
    %    : based on skip peak-width of data once the peak is found
    %----------------------------------------------------------------------
    sToFindPeak = sCorrected;
    peakX = zeros(X_CNT, 1);
    peakY = zeros(X_CNT, 1);
    valleyXLeft = zeros(X_CNT, 1);
    valleyXRight = zeros(X_CNT, 1);
    peakR = zeros(X_CNT, 1);
    peakXIdx = 1;
    
    % new peak detection, considering the "concaved peak"
    xNow = 1;
    while xNow <= X_CNT,
        % find the start of data bigger than high thres
        if sToFindPeak(xNow) >= PEAK_THRES_HIGH, 
            % search the end of left/right low peak reference
            lowPeakLeftNow = xNow; 
            for xRef = xNow-1:-1:1,
                if sToFindPeak(xRef) > PEAK_THRES_LOW,
                    lowPeakLeftNow = xRef;
                else
                    break;
                end
            end

            lowPeakRightNow = xNow;
            for xRef = xNow+1:X_CNT,
                if sToFindPeak(xRef) > PEAK_THRES_LOW,
                    lowPeakRightNow = xRef;
                else
                    break;
                end
            end

            lowPeakWidth = lowPeakRightNow - lowPeakLeftNow + 1;
            peakXNow = round((lowPeakRightNow + lowPeakLeftNow)/2);
            
            if peakXNow-PEAK_WIN_SIDE>=1 && peakXNow+PEAK_WIN_SIDE<=X_CNT && lowPeakWidth >= PEAK_LOW_WIDTH_MIN && lowPeakWidth <= PEAK_LOW_WIDTH_MAX,
                isPeak = 1; % only consider peak with proper peak width and peakX
            else
                isPeak = 0;
            end


            if isPeak,
                peakX(peakXIdx) = peakXNow;
                yInLowRange = sToFindPeak(lowPeakLeftNow:lowPeakRightNow);
                peakY(peakXIdx) = mean(yInLowRange(yInLowRange>PEAK_THRES_HIGH));
                peakYNow = peakY(peakXIdx);
                
                [~,valleyXLeft(peakXIdx)] = min(sToFindPeak(peakXNow-PEAK_WIN_SIDE:peakXNow));
                valleyXLeft(peakXIdx) = valleyXLeft(peakXIdx) + peakXNow-PEAK_WIN_SIDE-1;
                [~,valleyXRight(peakXIdx)] = min(sToFindPeak(peakXNow:peakXNow+PEAK_WIN_SIDE));
                valleyXRight(peakXIdx) = valleyXRight(peakXIdx) + peakXNow - 1;

                peakR(peakXIdx) = (sToFindPeak(valleyXLeft(peakXIdx))+sToFindPeak(valleyXRight(peakXIdx)))/(peakYNow*2);
                peakXIdx = peakXIdx + 1; % update number of peak
            end
            % update the xNow after this peak detections
            xNow = lowPeakRightNow+1;
        else
            xNow = xNow+1;
        end
    end
    
    % resize peakX vector
    if peakXIdx > 1,
        peakX = peakX(1:peakXIdx-1);
        peakY = peakY(1:peakXIdx-1);
        peakR = peakR(1:peakXIdx-1);
        valleyXLeft = valleyXLeft(1:peakXIdx-1);
        valleyXRight = valleyXRight(1:peakXIdx-1);
    else
        peakX = [];
    end
    
    %----------------------------------------------------------------------
    % 4. check peak statistics
    %    : need to pass each "test" before the next test
    %----------------------------------------------------------------------
    checkStatus = CHECK_STATUS_INIT;
    
    % a. check peak cnt
    if length(peakX) == CHECK_PEAK_CNT, 
        checkStatus = CHECK_STATUS_PASS_PEAK_CNT;
    end
    
    % b. check peak offset/diff
    if checkStatus == CHECK_STATUS_PASS_PEAK_CNT,
        peakDiff = peakX(2:end)-peakX(1:end-1);
        if all(peakDiff >= CHECK_PEAK_DIFF_RANGE(1) && peakDiff <= CHECK_PEAK_DIFF_RANGE(2)),
            checkStatus = CHECK_STATUS_PASS_PEAK_X_OFFSET_DIFF;
        end
    end
    
    % c. check peak offset/start and end
    if checkStatus == CHECK_STATUS_PASS_PEAK_X_OFFSET_DIFF,
        if peakX(1) >= CHECK_PEAK_OFFSET_START_RANGE(1) && peakX(1) <= CHECK_PEAK_OFFSET_START_RANGE(2),
            checkStatus = CHECK_STATUS_PASS_PEAK_X_OFFSET_START;
        end
    end
    
    % d. check peak ratios
    if checkStatus == CHECK_STATUS_PASS_PEAK_X_OFFSET_START,
        if all(peakR < CHECK_PEAK_RATIO_MIN),
            checkStatus = CHECK_STATIS_PASS_PEAK_RATIO_MIN;
        end
    end
    
    
    %----------------------------------------------------------------------
    % 5. Visualize data if need
    %----------------------------------------------------------------------
    
    if DEBUG_SHOW,
        figure; hold on;
        titlsToShow = {'fail PASS PEAK CNT','fail PASS PEAK X OFFSET DIFF','fail PASS PEAK X OFFSET START','fail PASS PEAK RATIO MIN','passed'};
        title(sprintf('checkStatus = %d (%s)', checkStatus, titlsToShow{checkStatus+2})); % +2 is ad-hoc offset -> NOTE: it needs to feed the check assigned number
        plot(sRatio,'k--'); ylabel('sRatio')
        plot(sRatioTo2Ends, 'b-', 'linewidth', 2);
        xlimNow = get(gca,'xlim');
        plot(xlimNow, [sCorrectedMean, sCorrectedMean],'g-.');
        plot(xlimNow, [sCorrectedMean+sCorrectedStd, sCorrectedMean+sCorrectedStd],'b-.');
        plot(xlimNow, [PEAK_HARD_THRES_HIGH, PEAK_HARD_THRES_HIGH], 'k-.');
        plot(xlimNow, [PEAK_HARD_THRES_HIGH, PEAK_HARD_THRES_HIGH], 'k:');
        plot(xlimNow, [PEAK_THRES_HIGH, PEAK_THRES_HIGH],'r--');
        plot(xlimNow, [PEAK_THRES_LOW, PEAK_THRES_LOW],'m--');
        l_h = legend('rate','ratio2ends','mean','mean+std','hard high thr','hard low thr','high thr','low thr','location','best');
        set(l_h, 'box','off');
        
        if ~isempty(peakX),
            plot(peakX, peakY, 'ro','linewidth',2);
            plot(valleyXLeft, sCorrected(valleyXLeft), 'mo','linewidth',2);
            plot(valleyXRight, sCorrected(valleyXRight), 'gx','linewidth',2);
        end
    end

end

