using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models.Product
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }
        
        public virtual ICollection<GameGenre>? GameGenres { get; set; }
    }
}