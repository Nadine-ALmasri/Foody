using System.ComponentModel.DataAnnotations;

namespace FoodRecipe.Models.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public IList<string>? Roles { get; set; }

    }
}
