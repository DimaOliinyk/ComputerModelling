module Demo

    open Blocks

    //let input = [1.0; 2; 3; 4; 5; 6; 7; 8; 9;]
    let input = [1.; 1; 1; 1; 1; 1; 1; 1; 1;]

    printfn "\nGain block"
    let myGain = Gain -0.5

    input 
    |> List.map (fun x -> myGain x) 
    |> List.iter (fun x -> printf "%f, " x) 

    printfn "\nIntegrator block"
    let myInt = Integrate 1.

    input 
    |> List.map (fun x -> myInt x) 
    |> List.iter (fun x -> printf "%f, " x) 

    printfn "\nDerivative block"
    let myDiv = Derive 1.

    input 
    |> List.map (fun x -> myDiv x) 
    |> List.iter (fun x -> printf "%f, " x) 

    printfn "\nAperiodic block"
    let myAp = Aperiodic 1. 1.

    input 
    |> List.map (fun x -> myAp x) 
    |> List.iter (fun x -> printf "%f, " x) 

    printfn "\nDelay block"
    let myDelay = Option.get (Delay 1. 5.)

    input 
    |> List.map (fun x -> myDelay x) 
    |> List.iter (fun x -> printf "%f, " x) 

    printfn "\nGain of -0.5 and delay of 2 and integrator"
    let myNewInt = Integrate 1.
    let myNewDelay = Option.get (Delay 1. 2.)
    //let myTransferFunc = myGain >> myNewDelay >> myNewInt

    input 
    |> List.map (fun x -> 
        x
        |> myNewInt
        |> myNewDelay
        |> myGain)
    |> List.iter (fun x -> printf "%f, " x) 
