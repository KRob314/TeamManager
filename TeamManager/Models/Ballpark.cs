using System.ComponentModel.DataAnnotations;

namespace TeamManager.Models
{
    public class Ballpark
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; } = default!;
        [MaxLength(300)]
        public string ShortName { get; set; } = default!;
        [MaxLength(150)]
        public string Street { get; set; } = default!;
        [MaxLength(50)]
        public string City { get; set; } = default!;
        //public string StateId { get; set; } = default!;
        [MaxLength(25)]
        public string State { get; set; } = default!;
        [MaxLength(10)]
        public string Zip { get; set; } = default!;
        public string Info { get; set; } = default!;

        //public State State { get; set; } = default!;
    }
}
