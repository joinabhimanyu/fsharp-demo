namespace Records

module Ex1=
  type T={First:string;Last:string} with
    member this.FullName =
      this.First + " " + this.Last

  let create first last=
    {First=first;Last=last}


module Ex2=
  type T={SKU:string;Price:float} with
    member this.TupleTotal(qty,?discount)=
      let extPrice=this.Price * float qty in
      match discount with
      |None->extPrice
      |Some discount->extPrice - float discount

  let create sku price=
    {SKU=sku;Price=float price}