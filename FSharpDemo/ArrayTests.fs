namespace ArrayTest

module Ex1=
  let rec arrSum x cursum=
    match x with
    |[]->cursum
    |head::tail->arrSum tail head+cursum
  
module Ex2=
  let square num=num*num
  let squareSum count=
    let ns=[1..count]
    ns|>List.sum|>square

  let sumSquare count=
    let ns=[1..count]
    ns|>List.map square|>List.sum

  let processArray count=
    squareSum count - sumSquare count
    |>printfn "Result: %i"