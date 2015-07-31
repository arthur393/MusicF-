open System


//notes in (hz)
let c = 16.35
let d = 18.35
let e = 20.60
let f = 21.83
let g = 24.50
let a = 27.50
let b = 30.87


//octaves
let octave note n  = 
    (int note * n)
    
//time
let time = 
    4000

//time named
let doubleWholeNote  = 
    time * 2
let wholeNote        = 
    time 
let halfNote         = 
    time / 2
let quarterNote      = 
    time / 4
let eightNote        = 
    time / 8
let sisxteenthNote   = 
    time / 16
let thirtySecondNote =
    time / 32
let sixtyFourthNote  = 
    time /64


Console.Beep(octave c 20, thirtySecondNote)
Console.Beep(octave d 20, thirtySecondNote)
Console.Beep(octave e 20, thirtySecondNote)
Console.Beep(octave f 20, thirtySecondNote)
Console.Beep(octave g 20, thirtySecondNote)
Console.Beep(octave a 20, thirtySecondNote)
Console.Beep(octave b 20, thirtySecondNote)
Console.Beep(octave c 40, thirtySecondNote)



Console.ReadKey() |> ignore
