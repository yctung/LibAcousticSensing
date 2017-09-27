function [ meters ] = LibSamplesToMeters( samples ,SOUND_SPEED, FS )
% 2015/10/05: converts sacle from samples to meters
%       NOTE: "Round trip" time is considered
    ROUND_TRIP_TIME_FACTOR = 2;

    times = samples./(FS*ROUND_TRIP_TIME_FACTOR);
    meters = times*SOUND_SPEED; % sample is always integer value

end

