classdef AppSvmTrainHelper < handle
    % 2017/04/30: This is a helper class to control training/features    
    properties
        targets; % structure array of data
        isTrained;
        featureFreqBinStartIdx;
        featureFreqBinEndIdx;
    end
    
    methods
        % constructor
        function obj = AppSvmTrainHelper()
            obj.targets = []; % init targets as empty array
            obj.isTrained = 0;
            obj.featureFreqBinStartIdx = 850;
            obj.featureFreqBinEndIdx = 1150;
        end
        
        % check if tag existed
        function result = isTagExisted(obj, tag)
            if isempty(obj.targets),
                result = 0;
            else
                tags = {obj.targets(:).tag};
                if ismember(tag, tags),
                    result = 1; 
                else
                    result = 0; % false
                end
            end
        end
        
        % get cell strings of existing tags
        function tags = getTags(obj)
            if isempty(obj.targets), % no tag to return -> return a dummy string for GUI to show
                tags = '(no tag existed)';
            else
                tags = {obj.targets(:).tag};
            end
        end
        
        % add new tag
        function addNewTag(obj, tag)
            tagIdx = length(obj.targets)+1;
            obj.targets(tagIdx).tag = tag;
            FIG_WIDTH = 260;
            obj.targets(tagIdx).fig = figure('Position',[280+(tagIdx-1)*FIG_WIDTH,450,FIG_WIDTH,230],'Toolbar','none','MenuBar','none');
            ylabel('signature');
            xlabel('freq');
            title(sprintf('Tag = %s', tag));
            obj.targets(tagIdx).data = {};
        end
        
        function result = targetCnt(obj)
            result = length(obj.targets);
        end
        
        function idx = findTargetIdxByTag(obj, tag)
            for i = 1:length(obj.targets),
                if strcmp(obj.targets(i).tag, tag),
                    idx = i;
                    break;
                end
            end
        end
        
        function addTaggedData(obj, tag, data)
            targetIdx = obj.findTargetIdxByTag(tag);
            target = obj.targets(targetIdx);
            
            figure(target.fig);
            debugChIdx = 1;
            plot(mean(data(:,:,debugChIdx),2));
            
            obj.targets(targetIdx).data{length(target.data)+1} = data;
        end
        
        % train all the model
        function trainAll(obj)
            param = '-t 0 -b 1'; % default svm parameter
            trainAllWithParam(obj, param);
        end
        function trainAllWithParam(obj, param)
            % 1. concate all traces
            updateFeatureAll(obj);
            
            % 2. fetch features based on traces
            featureSize = size(obj.targets(1).features, 1);
            featureCnts = cell2mat(arrayfun(@(model){size(model.features, 2)}, obj.targets));
            
            % NOTE: this combine use all traces we have
            featureAll = zeros(featureSize, sum(featureCnts));
            featureAllEnd = 0;
            targetAll = zeros(sum(featureCnts), 1);
            for i = 1:length(obj.targets)
                target = obj.targets(i);
                featureAll(:,featureAllEnd+1:featureAllEnd+featureCnts(i)) = target.features;
                
                % update features to figure
                figure(target.fig);
                plot(mean(target.features,2));
                xlabel(sprintf('data size = %d', featureCnts(i)));
                ylabel('mean(signature)');
                title(sprintf('Tag = %s', target.tag));
                
                targetAll(featureAllEnd+1:featureAllEnd+featureCnts(i)) = i;
                featureAllEnd = featureAllEnd+featureCnts(i);
            end
            xTrain = featureAll;
            yTrain = targetAll;
            
            % 3. train svm -> use 1 against all svm now
            for targetIdx = 1:length(obj.targets),
                target = obj.targets(targetIdx);
                fprintf('---------- svm train of target model = %d , %s ----------\n', targetIdx, target.tag);
         
                ySVM = zeros(length(yTrain),1);
                ySVM(yTrain==targetIdx) = 1;
                ySVM(yTrain~=targetIdx) = -1;
                obj.targets(targetIdx).model = svmtrain(ySVM, xTrain', param);
            end
            
            % TODO: 4. do some simple validation by predicting it (e.g., Vlidation)
            
            obj.isTrained = 1;
        end
        
        % prcess data to extract feature for both train/predict
        function features = getFeatureFromData(obj, data)
            debugChIdx = 1; % use only the first channel for now
            smoothedFactor = 5; % debug only
            features = fftshift(abs(fft(data(:,:,debugChIdx)))); % for now, we just use a single fft as feature
            features = features(ceil(size(features,1)/2):end, :, :); % only keep the positive freq range
            for i = 1:size(features,2)
                features(:,i) = smooth(features(:,i), smoothedFactor);
            end
            % only keep some part of features (for learning optimization)
            if obj.featureFreqBinStartIdx < 1 || obj.featureFreqBinEndIdx > size(features,1)
                fprintf('[WARN]: featureFreqBin setting = (%d,%d) is out of range (set too big?)\n',obj.featureFreqBinStartIdx:obj.featureFreqBinEndIdx);
            end
            
            features = features(max(obj.featureFreqBinStartIdx,1):min(obj.featureFreqBinEndIdx,size(features,1)),:,:);
            
            % normalize feature to the range of 0~1
            features = features./repmat(max(features), [size(features, 1), 1]);
        end
        
        % update feature of the assigned target
        function updateFeature(obj, targetIdx)
            target = obj.targets(targetIdx);
            data = cell2mat(target.data); % concate data to a sngle matrix, note it is concated by the 2nd dimension
            obj.targets(targetIdx).features = getFeatureFromData(obj, data); 
        end
        
        % update feautre of all targets
        function updateFeatureAll(obj)
            for i = 1:length(obj.targets),
                updateFeature(obj, i);
            end
        end
        
        % make predict of svm results
        function [predictedIdx, predictedTag, predictedConfidence] = predict(obj, data)
            features = getFeatureFromData(obj, data);
            traceCnt = size(features, 2);
            
            probs = zeros(length(obj.targets), traceCnt);
            yDummy = zeros(size(features,2),1);
            for targetIdx = 1:length(obj.targets)
                [~, ~, prob] = svmpredict(yDummy, features', obj.targets(targetIdx).model,'-b 1');
                probs(targetIdx, :) = prob(:,obj.targets(targetIdx).model.Label==1);
            end
            
            [maxProbs, maxProbIdxs] = max(probs);
            
            predictedIdx = mode(maxProbIdxs);
            predictedTag = obj.targets(predictedIdx).tag;
            predictedConfidence = mean(probs(predictedIdx,:)) - min(mean(probs));
        end
    end
    
end

