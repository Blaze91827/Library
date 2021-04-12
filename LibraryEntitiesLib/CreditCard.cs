using System;
using System.Collections.Generic;

namespace Packt.Shared {
  public class CreditCard {
    public int Id {get; set;}
    public string cardName {get; set;}
    public string number {get; set;}
    public string cvc {get; set;}
    public DateTime expdate {get; set;}
    public int PersonId {get; set;}

    // related entities
    public Person Person {get; set;}
  }
}