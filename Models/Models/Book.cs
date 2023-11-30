using System.ComponentModel.DataAnnotations;

namespace Entity_Models.Models
{
    public class Book
    {
        [Key]
        public int bookId { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }
    }
}
