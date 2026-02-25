module InputFunctions

let Heaviside (dt:double) (time: double): double list = 
    [for i in 0.0..dt..time do yield 1.0]

let DeltaFunc (dt:double) (time: double): double list = 
    0.0 :: 1.0 :: [for i in 0.0..dt..(time - 2.) do yield 0.0]

let HarmonicOscillation (dt:double) (time: double): double list = 
    [for i in 0.0..dt..time do yield sin(i)]