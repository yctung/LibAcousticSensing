function [ signalCorrected ] = LibTimeVaryingGainCorrect( signal, setting, DEBUG_SHOW)
% 2015/10/05: correct the gain degradation caused by path loss
% 2015/10/14: make support parsing multi-channel data

    if exist('setting','var'),
        FS = setting.FS;
        SOUND_SPEED = setting.SOUND_SPEED;
        TVG_ALPHA = setting.TVG_ALPHA;
        TVG_BETA = setting.TVG_BETA;
    else
        % use defualt setting
        % fprintf('[WARN]: LibTimeVaryingGainCorrect is using default setting\n');
        FS = 48000;
        SOUND_SPEED = 340;
        TVG_ALPHA = 0.65 % for note 4
        %TVG_ALPHA = 2; % for iphone
        TVG_BETA = 0;
    end

    SHOW_METERS = 1;
    
    if ~exist('DEBUG_SHOW','var'),
        DEBUG_SHOW = 0;
    end

    chCnt = size(signal, 3); % assume the input data is [signal, track, ch]
    
    ss = 1:size(signal,1);
    rs = (ss./(2*FS)).*SOUND_SPEED;
    %gainsDb = 0.5*log10(rs);
    %gainsDb = 0.7*log10(rs);
    gainsDb = TVG_ALPHA*log10(rs)+TVG_BETA;
    signalCorrected = signal.*repmat((10.^gainsDb(:)),[1,size(signal,2), chCnt, size(signal, 4)]); % support to 4d array now
    
    %signalCorrected = signal; % *** just for debug ***

    % *** start of debug ***
    if DEBUG_SHOW,
        figure;
        x = 1:size(signalCorrected, 1);
        if SHOW_METERS,
            x = LibSamplesToMeters(x, SOUND_SPEED, FS);
        end
        plot(x, signalCorrected);
        signalAveraged = convn(signalCorrected, ones(15,1), 'same');


        figure;
        plot(x, signalAveraged);


        figure;
        subplot(2,1,1);
        plot(x, LibNormalization(signalAveraged));

        subplot(2,1,2)
        plot(x, LibNormalization(signalAveraged, 'norm2'));


        %{
        figure; % NOTE: this figure only works for size of sound = 30;
        for i = 1:size(signalCorrected, 2);
            subplot(5,10,i);
            plot(x, LibNormalization(signalAveraged(:,i)));
            ylim([0,0.1]);
            ylabel(sprintf('i = %d',i));
        end
        %}

        signalBeforePostFiltered = LibNormalization(signalAveraged, 'norm2');
        order = 10;
        peakWindow = 80;
        %cutFreqLow = peakWindow/(FS/2);
        cutFreqLow = (1/peakWindow)*2;
        [B, A] = butter(order, cutFreqLow, 'high')
        signalAfterPostFiltered = filter(B, A, signalBeforePostFiltered);
        figure;
        plotIdx = 1;
        subplot(2,1,1);
        plot(signalBeforePostFiltered(:,plotIdx)); title('before filtered');
        subplot(2,1,2);
        plot(abs(signalAfterPostFiltered(:,plotIdx))); title('after filtered');


        figure;
        imagesc(LibNormalization(signalAveraged)');
        %colormap('gray');
        colorbar;
    end
    % *** end for debug ***

end

