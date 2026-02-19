
module Blocks

    open System
    open System.Collections.Generic


    let Gain (gainCoefficient: double) (x: double) = 
        gainCoefficient * x 

    let Integrate (dt: double) = 
        let mutable prev = double 0.
        let mutable sum = double 0.
        fun (x: double) -> 
            sum <- (prev + x) * dt / 2. + sum
            prev <- x 
            sum

    let Derive (dt: double)  = 
        let mutable prev = 0.
        fun (x: double) -> 
            let y = (x - prev) / dt 
            prev <- x 
            y

    let Aperiodic (dt: double) (timeConstant: double) = 
        let mutable prev = 0.
        fun (x: double) -> 
            let y = (dt * x + timeConstant * prev) / (timeConstant + dt)
            prev <- y 
            y

    let Delay (dt: double) (timeDelay: double) = 
        let delayQueue = Queue<double>()
        let count = int (timeDelay / dt)

        if count < 1 then None
        else Some(
            fun (x: double) ->
                delayQueue.Enqueue(x)
                if delayQueue.Count > count then
                    delayQueue.Dequeue()
                else 
                    0)


    type ClampableSignal<'a> = 
        | NotClamped of 'a
        | Clamped of 'a

    let Limit (min: double) (max: double) (x: double) = 
        match x with 
        | x when x < min -> Clamped min
        | x when x > max -> Clamped max
        | _ -> NotClamped x
