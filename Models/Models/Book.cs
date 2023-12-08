using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Models.Models
{
    public class Book
    {
        [Key]
        public int bookId { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public List<Author> Authors { get; set; }
        public decimal Price { get; set; }

        public BookDetail BookDetail { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
