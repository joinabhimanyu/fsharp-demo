namespace Classes

type FibExample ()=
  member this.add x y=
    x+y
  member this.Fib x=
    match x with
      | 0 | 1->1
      |_->this.Fib (x-1) + this.Fib (x-2)