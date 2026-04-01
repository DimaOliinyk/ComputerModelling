namespace ModellingLogic


module Models =
    open Blocks
    open System
    open Controllers

    type PIDparams = { Pgain: double; Igain: double; Dgain: double }

    let Model (dt: double) = 
        let intg1 = IntegrateAndLimit dt None None 
        let intg2 = IntegrateAndLimit dt None None

        fun (x: double) -> 
            (x
            |> Gain(Math.PI / 180.0)
            |> sin
            |> Gain (5.0 / 7.0 * 9.80665)
            |> intg1
            |> intg2) 

    (*let SetUpModel (dt: double) = 
        let model = Model dt
        let controller = PID dt 0.2 0 0
        let setpoint = 0.1

        fun(x: double) ->
            (setpoint - x)
            |> controller
            |> model*)

    let SetUpModel (dt: double) = 
        let model = Model dt
        fun(x: double) ->
            x |> model


    let SetUpController (setpoint: double) (dt: double) (pid: PIDparams) = 
        let contr = PID dt pid.Pgain pid.Igain pid.Dgain     

        fun (x: double) ->
            (setpoint - x)
            |> contr


