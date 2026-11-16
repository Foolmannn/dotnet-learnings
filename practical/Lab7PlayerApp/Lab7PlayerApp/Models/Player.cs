using System.ComponentModel.DataAnnotations;

namespace Lab7PlayerApp.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Player name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Name must be 3 to 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 40,
            ErrorMessage = "Age must be between 18 and 40")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Sport is required")]
        public string Sport { get; set; }
    }
}