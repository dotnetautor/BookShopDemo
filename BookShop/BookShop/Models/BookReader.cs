 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using BookShop.Models;

public class BookReader {
    [Key]
    [Column(Order = 1)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BookId { get; set; }
    [Key]
    [Column(Order = 2)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ReaderId { get; set; }

    [ForeignKey("BookId")]
    public virtual Book Book { get; set; }
    [ForeignKey("ReaderId")]
    public virtual Reader Reader { get; set; }
  }