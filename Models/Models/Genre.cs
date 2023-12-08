
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Models.Models
{
    [Table("tb_genre")]
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Column("genre")]
        public string GenreName { get; set; }

        public int DisplayOrder { get; set; }
    }
}
