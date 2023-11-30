using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_Models.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        public string GenreName { get; set; }

        public int DisplayOrder { get; set; }
    }
}
