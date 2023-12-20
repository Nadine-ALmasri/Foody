

namespace FoodRecipe.Models
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string Name { get; set; }
        public ICollection<IngredientRecipe> IngredientRecipes { get; set; } // Changed to IngredientRecipes

        
    }
}
