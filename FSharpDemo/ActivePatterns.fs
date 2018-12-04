
module ActivePatterns
  let (|Even|Odd|) input=if input%2=0 then Even else Odd

  let isEven input=
    match input with
    |Even->printfn "%i is even" input
    |Odd->printfn "%i is odd" input