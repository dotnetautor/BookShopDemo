using System.Collections.Generic;
using System.Diagnostics;

namespace BookShop.Models {
  [DebuggerDisplay("Reader: [{Firstname} {LastName}]")]
  public class Reader {
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string City { get; set; }
    public string Plz { get; set; }
    //public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<BookReader> BookReaders { get; set; }
    public string Street { get; set; }
  }
}