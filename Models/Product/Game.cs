using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models
{
      public enum GameGenre
        {
            Action,
            Adventure,
            RolePlaying,
            Simulation,
            Strategy,
            Puzzle,
            Sports,
            Racing,
            Fighting,
            Shooter,
            Stealth,
            Survival,
            BattleRoyale,
            Music,

            ThirdPersonShooter,
            Horror,
            Platform,
            MOBA,   // Multiplayer Online Battle Arena
            MMORPG, // Massively Multiplayer Online Role-Playing Game
            Sandbox,

            Roguelike,
            OpenWorld,
            VisualNovel
        }

        public enum GamePlatform
        {
            PC,
            PlayStation5,
            PlayStation4,
            XboxOne,
            XboxSeriesX,
            Switch,
            Mobile,
            MacOS,
            Linux,
            VirtualReality
        }

    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        public string Platform { get; set; }

        [Display(Name = "Images")]
        public virtual ICollection<GameImage> GameImages { get; set; }

        [Display(Name = "Trailer URL")]
        [DataType(DataType.Url)]
        public string TrailerUrl { get; set; }

        [ForeignKey("GameImage")]
        public int? GameImageId { get; set; }

        public virtual GameImage GameImage { get; set; }
    }
}