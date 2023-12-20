using System.ComponentModel.DataAnnotations;

namespace FoodRecipe.Models.DTOs
{
    public class LogInDto
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
