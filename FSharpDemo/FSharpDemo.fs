namespace FSharpDemo
open System
open VariantTypes


module main=
  let rec sum l=
    match l with
    |[]->0
    |head::tail->head + sum tail

  let rec fact acc num=
    match num with
    |0->acc
    |1->acc
    |_->fact (acc*num) (num-1)  


  let processHuman()=
    Console.WriteLine "Enter human details:"
    Console.WriteLine "Enter firstname:"
    Console.ReadLine()
    |>function
      |""->printfn "invalid firstname"
      |x->Console.WriteLine "Enter lastname:"
          Console.ReadLine()
          |>function
            |""->printfn "invalid name"
            |y->Console.WriteLine "Enter age:"
                Console.ReadLine()
                |>function
                  |""->printfn "invalid age"
                  |z->let age=z|>int in
                        Human(x,y,age)|>Ex1.showDetails


  let processDog()=
    Console.WriteLine "Enter dog details:"
    Console.WriteLine "Enter breed:"
    Console.ReadLine()
    |>function
      |""->printfn "invalid breed"
      |x->Console.WriteLine "Enter age:"
          Console.ReadLine()
          |>function
            |""->printfn "invalid age"
            |y->let age=y|>int in
                  Dog(x,age)|>Ex1.showDetails

  let processCat()=
    Console.WriteLine "Enter cat details:"
    Console.WriteLine "Enter name:"
    Console.ReadLine()
    |>function
      |""->printfn "invalid name"
      |x->Console.WriteLine "Enter age:"
          Console.ReadLine()
          |>function
            |""->printfn "invalid age"
            |y->let age=y|>int in
                  Cat(x,age)|>Ex1.showDetails

  let matchOption=function
    |1->processHuman()
    |2->processDog()
    |3->processCat()
    |_->printfn "invalid option"

  let enterOption()=
    Console.WriteLine "Enter option for variant type: 1:Human 2:Dog 3:Cat:"
    Console.ReadLine()
    |>function
      |""->printfn "invalid input"
      |opt->let iopt=opt|>int in
              matchOption iopt

  let repeatOption()=
    Console.WriteLine "Do you want to repeat option: 1:Yes 2:No:"
    Console.ReadLine()
    |>function
      |""->printfn "invalid option"
      |x->let opt=x|>int in
            match opt with
            |1->enterOption()
            |2->printfn "exiting"
            |_->printfn "exiting"

  [<EntryPoint>]
  let main _ =
    sum [1;2;3;4]
    |>printfn "Sum of array: %A"
    Console.WriteLine("Enter a number for fact:")
    Console.ReadLine()
    |>Convert.ToInt32
    |>fact 1
    |>printfn "Factorial: %i"
    enterOption()
    Console.ReadLine()|>ignore
    0