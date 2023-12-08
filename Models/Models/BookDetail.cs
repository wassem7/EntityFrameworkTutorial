using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Models.Models;

public class BookDetail
{
    [Key]
    public int BookDetailId { get; set; }
    
    [Required]
    public string Details { get; set; }
    
    public int NumberofChapter { get; set; }

    [ForeignKey("Book")]
    public int  BookId {
        get;
        set;
    }
    
    public Book Book { get; set; }
}