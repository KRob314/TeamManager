using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.Models
{
    public class SeasonPitchingStats
    {
        public int Id { get; set; } = default!;
        [Required]
        public int PlayerId { get; set; } = default!;
        [Required]
        public int SeasonId { get; set; } = default!;
        [Column(TypeName = "decimal(18,3)")]
        public decimal InningsPitched { get; set; } = default!;
        [MaxLength(2)]
        public int Hits { get; set; } = default!;
        [MaxLength(2)]
        public int Runs { get; set; } = default!;
        [MaxLength(2)]
        public int EarnedRuns { get; set; } = default!;
        [MaxLength(2)]
        public int Walks { get; set; } = default!;
        [MaxLength(2)]
        public int Strikeouts { get; set; } = default!;
        [MaxLength(2)]
        public bool Starter { get; set; } = default!;
        public bool Win { get; set; } = default!;
        public bool Saved { get; set; } = default!;
        [Column(TypeName = "decimal(18,3)")]
        public decimal EarnedRunAverage { get; set; } = default!;
        [MaxLength(2)]
        public int BattersFaced { get; set; } = default!;

        public virtual Season Season { get; set; } = default!;
        public virtual Player Player { get; set; } = default!;
    }
}
