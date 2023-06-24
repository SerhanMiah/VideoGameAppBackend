using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models
{
    public class GameImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Url { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }
    }
}