using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManager.Models
{
    public class SeasonFieldingStats
    {
        public int Id { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int  SeasonId { get; set; }
        [MaxLength(2)]
        public int TotalChances { get; set; }
        [MaxLength(2)]
        public int Putouts { get; set; }
        [MaxLength(2)]
        public int Assists { get; set; }
        [MaxLength(2)]
        public int Errors { get; set; }
        [MaxLength(2)]
        public int DoublePlays { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal FieldingPercent { get; set; }

        public virtual Season Season { get; set; } = default!;
        public virtual Player Player { get; set; } = default!;
    }
}
