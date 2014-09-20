using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BookShop.Models {
  [DebuggerDisplay("Category: [{Title}]")]
  public class Category {
    public int Id { get; set; }
    [Required]
    [StringLength(250)]
    public string Title { get; set; }

    public virtual ICollection<Book> Books { get; set; }

    
  }
}