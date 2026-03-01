namespace ModellingLogic

module Models =
    open Blocks
    open System

    //Example 1 in Class 
    (*let SetUpModel (dt: double) = 
        let apb1 = Aperiodic dt 1.
        let apb2 = Aperiodic dt 2.
        let del = Option.get (Delay dt 5)

        fun (x:double) -> 
            x 
            |> Gain 2.0
            |> apb1
            |> apb2
            |> del*)

    // Example 2 in Class 
    (*let SetUpModel (dt: double) = 
        let intg = IntegrateAndLimit dt (Some 0.0) (Some 100.0)

        fun (x: double) -> intg x*)

    let SetUpModel (dt: double) = 
        let intg1 = IntegrateAndLimit dt None None 
        let intg2 = IntegrateAndLimit dt None None

        fun (x: double) -> 
            (x
            |> Gain(Math.PI / 180.0)
            |> sin
            |> Gain (5.0 / 7.0 * 9.80665)
            |> intg1
            |> intg2) + 0.5
            