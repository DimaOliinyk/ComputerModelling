module Controllers

    open Blocks

    let PID (dt: double) (pGain: double) (iGain: double) (dGain: double) =
        let intg = Integrate dt
        let derv = Derive dt
        
        fun (x: double) ->  
            Gain pGain x + 
            Gain dGain (derv x) + 
            Gain iGain (intg x) 
            
    let NegativeFeedbackLoop (fowardSignal: double) (backwardSignal: double) = 
        fowardSignal / (backwardSignal + fowardSignal)

    let PositiveFeedbackLoop (fowardSignal: double) (backwardSignal: double) = 
        -(NegativeFeedbackLoop -fowardSignal backwardSignal) // -(-Wf / Wb - Wf) = Wf / (Wb - Wf)
    
