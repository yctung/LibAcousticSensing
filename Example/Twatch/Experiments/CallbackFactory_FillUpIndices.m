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
        global DidMicModeCheck;
        global TapReceived;
        
        if type == obj.CALLBACK_TYPE_ERROR
            fprintf(2, '[ERROR]: get the error callback data = %s', data);
            return;
        end

       
        
        % parse audio data
        if type == obj.CALLBACK_TYPE_USER
            if data.code == 1 
                % Tap detected!
                TapReceived = 1;
            end
        elseif type == obj.CALLBACK_TYPE_DATA
             % Not data?
             
            if all(data == [1 2])
                return;
            end
            %if (size(size(data), 2) == 2)
            %    size(data);
            %    fprintf(2, 'early exit\n');
            %    size(data)
            %    return
            %end

            if ~DidMicModeCheck(ind1)
                C1 = data(:, 1, 1);
                C2 = data(:, 1, 2);
                DidMicModeCheck(ind1) = 1;
                
                if all(C1 == C2)
                    errordlg('Both channels have the same. Change the mic mode!');
                    return;
                end
            end
        
            %ind1
            %ind2
            %size(data)
            
            % Just fill up the FillUpBuffer
            for chirpInd=1:size(data,2)
                
                if ind1 == 3
                    % Watch trick
                    data(:, chirpInd, 2) = data(:, chirpInd, 1);
                end
                
                
                FillUpPointers(ind1) = FillUpPointers(ind1) + 1;
                FillUpBuffer(:, FillUpPointers(ind1), ind1) = data(:, chirpInd, 1);
                
                if ind2 <= 4
                    FillUpPointers(ind2) = FillUpPointers(ind2) + 1;
                    FillUpBuffer(:, FillUpPointers(ind2), ind2) = data(:, chirpInd, 2);
                end
            end
            
            % If enough data has filled up, we will look for peaks.
            
            if all(FillUpPointers > AlreadyProcessed)
                %Helper_DoAggregatePeaks();
                CallOnceFull();
            end
        end
    end 
end

