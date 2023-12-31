﻿using System.ComponentModel.DataAnnotations;

namespace FoodRecipe.Models.DTOs
{
    public class UserEmailDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public CartEmail ShoppingCart { get; set; }
      
        public string Phone { get; set; }
    }
}
