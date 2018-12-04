namespace VariantTypes

type Creature=
  | Human of (string*string*int)
  | Dog of (string*int)
  | Cat of (string*int)


module Ex1=
  open System

  let showDetails creature=
    match creature with
    | Human (firstname,lastname,age)->
        Console.WriteLine "Human details:"
        let details=sprintf "Firstname: %s, Lastname: %s, Age: %i" firstname lastname age
        printfn "%s" details
    | Dog (breed,age)->
        Console.WriteLine "Dog details:"
        let details=sprintf "Breed: %s, Age: %i" breed age
        printfn "%s" details
    | Cat (name,age)->
        Console.WriteLine "Cat details:"
        let details=sprintf "Name: %s, Age: %i" name age
        printfn "%s" details