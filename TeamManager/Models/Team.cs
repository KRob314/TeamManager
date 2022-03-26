using System.ComponentModel.DataAnnotations;

namespace TeamManager.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; } = default!;
        public int SeasonId { get; set; } = default!;
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string ManagerFirstName { get; set; } = default!;
        [MaxLength(100)]
        public string ManagerLastName { get; set; } = default!;
        [MaxLength(100)]
        public string ManagerEmail { get; set; } = default!;
        [MaxLength(14)]
        public string ManagerPhone { get; set; } = default!;

        public ApplicationUser User { get; set; }
    }
}
