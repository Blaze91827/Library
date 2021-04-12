using System;
using System.Collections.Generic;
using System.Linq;

namespace Packt.Shared {
  public class BookList {
    public int Id {get; set;}
    public string title {get; set;}
    public bool missing {get; set;}
    public bool late {get; set;}
    public DateTime returnDate {get; set;}
    public int personID {get; set;}
    public int bookTitleId {get; set;}

    // related entities
    public Person Person {get; set;}
    public Title bookTitle {get; set;}
  }
}