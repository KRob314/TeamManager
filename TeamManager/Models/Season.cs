namespace TeamManager.Models
{
    public class Season
    {
        public int Id { get; set; }
        public SeasonType SeasonType { get; set; } = default!;
        public int Year { get; set; }
    }

    public enum SeasonType
    {
        Spring,
        Summmer,
        Fall,
        Winter
    }

}
