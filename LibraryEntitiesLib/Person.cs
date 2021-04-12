using System;
using System.Collections.Generic;

namespace Packt.Shared {
  public class Person {
    public int Id {get; set;}
    public string personName {get; set;}
    public decimal fees {get; set;}
    public int creditCardID {get; set;}
    public int itemId {get; set;}
    // related entities
    public ICollection<CreditCard> CreditCards {get; set;}
    public ICollection<BookList> bookTitles {get; set;}
  }
}