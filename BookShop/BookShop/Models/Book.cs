using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Newtonsoft.Json;

namespace BookShop.Models {
  [DebuggerDisplay("Book: [{Title}]")]
  public class Book {
    public int Id { get; set; }
    [Required]
    [StringLength(250)]
    public string Title { get; set; }
    public string SubTitle { get; set; }

    public string Description { get; set; }
   
    public virtual ICollection<BookReader> BookReaders { get; set; }
   
    public virtual Category Category { get; set; }

    [NotMapped]
    public string Info { get { return ""; } }

  }
}