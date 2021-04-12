using System;
using System.Collections.Generic;

namespace Packt.Shared {
  public class Title {
    public int Id {get; set;}
    public string title {get; set;}
    public string author {get; set;}
    public string summary {get; set;}
    public int quantity {get; set;}

    // related entities
    public ICollection<BookList> BookList {get; set;}
  }
}