using System.ComponentModel.DataAnnotations;

namespace TeamManager.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = default!;
        [MaxLength(100)]
        public string LastName { get; set; } = default!;
        public DateTime? BirthDate { get; set; } = default!;
        [MaxLength(3)]
        public string JerseyNumber { get; set; } = default!;
        [MaxLength(14)]
        public string PhoneNumber { get; set; } = default!;
        [MaxLength(150)]
        public string StreetAddress { get; set; } = default!;
        [MaxLength(100)]
        public string City { get; set; } = default!;
        [MaxLength(25)]
        public string State { get; set; } = default!;
        [MaxLength(10)]
        public string ZipCode { get; set; } = default!;
        [MaxLength(100)]
        public string Email { get; set; } = default!;
    }
}
