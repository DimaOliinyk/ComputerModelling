 
open System
open Blocks
open InputFunctions
open FSharp.Charting

let DegreesToRadians deg = deg * Math.PI / 180.0

let dt = 0.1
let myIntgr = Integrate dt

//(DeltaFunc dt 50.)
//(Heaviside dt 10.0) 
//|> List.map myIntgr
//|> List.iter (fun x -> printf "%f, " x) 

//printf "%f, " (sin <| DegreesToRadians 90.0)

let Intr1 = Integrate dt
let Intr2 = Integrate dt
let kObj = Gain (5.0 / 7.0 * 9.80665)

let model = fun x -> 
    x
    |> kObj
    |> Intr1
    |> Intr2

(Heaviside dt 10.0)
|> List.map(fun x -> x * DegreesToRadians 5.0)
|> List.map(fun x -> model x)
|> List.iter (fun x -> printf "%f, " x) 


Chart.Line [ for x in 0 .. 10 -> x, x*x ]