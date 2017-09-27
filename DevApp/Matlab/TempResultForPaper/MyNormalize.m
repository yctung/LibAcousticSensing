function [ dataNormalized ] = MyNormalize( data )
    dataNormalized = data./max(data);
end

