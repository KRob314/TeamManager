using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.Models
{
    public class SeasonHittingStats
    {
        public int Id { get; set; }
        [Required]
        public int SeasonId { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [MaxLength(4)]
        public int PlateAppearance { get; set; }
        [MaxLength(4)]
        public int AtBats { get; set; }
        [MaxLength(3)]
        public int Runs { get; set; }
        [MaxLength(4)]
        public int Singles { get; set; }
        [MaxLength(4)]
        public int Doubles { get; set; }
        [MaxLength(4)]
        public int Triples { get; set; }
        [MaxLength(4)]
        public int Homeruns { get; set; }
        [MaxLength(4)]
        public int Walks { get; set; }
        [MaxLength(4)]
        public int HitByPitch { get; set; }
        [MaxLength(4)]
        public int RunsBattedIn { get; set; }
        [MaxLength(4)]
        public int StolenBases { get; set; }
        [MaxLength(4)]
        public int CaughtStealing { get; set; }
        [MaxLength(4)]
        public int Strikeouts { get; set; }
        [MaxLength(4)]
        public int SacrificeHits { get; set; }
        [MaxLength(4)]
        public int GroundedInToDoublePlay { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal ScorePercent { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal BattingAvg { get; set; }


        public virtual Season Season { get; set; } = default!;
        public virtual Player Player { get; set; } = default!;

    }
}
