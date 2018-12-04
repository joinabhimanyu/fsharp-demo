namespace ObjectPerson

module Ex1=
  type IPerson=
    abstract member showName:unit->unit
    abstract member showAge:unit->unit

  let createPerson name age=
    {
      new IPerson with
      member this.showName ()=printfn "Name: %s" name
      member this.showAge ()=printfn "Age: %s" age
    }