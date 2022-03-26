using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.Models
{
    public class GameHittingStats
    {
        public int Id { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [MaxLength(2)]
        public int PlateAppearance { get; set; }
        [MaxLength(2)]
        public int AtBats { get; set; }
        [MaxLength(3)]
        public int Runs { get; set; }
        [MaxLength(2)]
        public int Singles { get; set; }
        [MaxLength(2)]
        public int Doubles { get; set; }
        [MaxLength(2)]
        public int Triples { get; set; }
        [MaxLength(2)]
        public int Homeruns { get; set; }
        [MaxLength(2)]
        public int Walks { get; set; }
        [MaxLength(2)]
        public int HitByPitch { get; set; }
        [MaxLength(2)]
        public int RunsBattedIn { get; set; }
        [MaxLength(2)]
        public int StolenBases { get; set; }
        [MaxLength(2)]
        public int CaughtStealing { get; set; }
        [MaxLength(2)]
        public int Strikeouts { get; set; }
        [MaxLength(2)]
        public int SacrificeHits { get; set; }
        [MaxLength(2)]
        public int GroundedInToDoublePlay { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal BattingAvg { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal ScorePercent { get; set; }
        [MaxLength(2)]
        public Nullable<int> BattingOrder { get; set; }

        public virtual Game Game { get; set; } = default!;
        public virtual Player Player { get; set; } = default!;

    }
}
