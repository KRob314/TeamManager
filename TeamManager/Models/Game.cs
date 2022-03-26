using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TeamManager.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public int BallparkId { get; set; } = default!;
        [Required]
        public int SeasonId { get; set; } = default!;
        [Required]
        public int HomeTeamId { get; set; } = default!;
        [Required]
        public int AwayTeamId { get; set; } = default!;
        public DateTime StartTime { get; set; } = default!;
        public int HomeTeamRuns { get; set; } = default!;
        public int AwayTeamRuns { get; set; } = default!;
        public GameResult Result { get; set; } = default!;

        public Ballpark Ballpark { get; set; } = default!;
        public Season Season { get; set; } = default!;
    }

    public enum GameResult
    {
        Won,
        Lost,
        Cancelled,
        Rainout,
        Pending
    }
}
