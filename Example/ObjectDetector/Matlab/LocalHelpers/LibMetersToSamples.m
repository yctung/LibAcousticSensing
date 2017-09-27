function [ samples ] = LibMetersToSamples( meters, SOUND_SPEED, FS, ROUND_TRIP_TIME_FACTOR)
% 2015/10/05: converts sacle from meters to samples
%       NOTE: "Round trip" time is considered
    if ~exist('ROUND_TRIP_TIME_FACTOR','var'),
        ROUND_TRIP_TIME_FACTOR = 2; % default is 2
    end

    times = meters./(SOUND_SPEED/ROUND_TRIP_TIME_FACTOR);
    samples = ceil(times.*FS); % sample is always integer value
end

