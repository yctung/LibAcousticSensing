function [callback] = CallbackFactory_FillUpIndices (ind1, ind2, CallOnceFull)
     callback = @FillUpCallback;
     
     
     
     %  has three dimensions. It is filled up as:
     %        < Data , Chirp Number, Fill Up Buffer Index >
     % This is called PER DEVICE (i.e., 2 microphones)
     % Where each ind1 and ind2 is used for each microphone
     
     function [] =  FillUpCallback ( obj, type, data )
        global FillUpBuffer;
        global FillUpPointers;
        global AlreadyProcessed;
        
        if type == obj.CALLBACK_TYPE_ERROR
            fprintf(2, '[ERROR]: get the error callback data = %s', data);
            return;
        end
    
        
        if (size(size(data), 2) == 2)
            return
        end
        
        % parse audio data
        if type == obj.CALLBACK_TYPE_DATA
            % Just fill up the FillUpBuffer
            for chirpInd=1:size(data,2)
                FillUpPointers(ind1) = FillUpPointers(ind1) + 1;
                FillUpPointers(ind2) = FillUpPointers(ind2) + 1;
                FillUpBuffer(:, FillUpPointers(ind1), ind1) = data(:, chirpInd, 1);
                FillUpBuffer(:, FillUpPointers(ind2), ind2) = data(:, chirpInd, 2);
            end
            
            % If enough data has filled up, we will look for peaks.
            if all(FillUpPointers > AlreadyProcessed)
                %Helper_DoAggregatePeaks();
                CallOnceFull();
            end
        end
    end 
end

