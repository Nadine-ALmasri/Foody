namespace FoodRecipe.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Comment> ?Comments { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public List<IngredientRecipe> IngredientRecipes { get; set; } // Changed to IngredientRecipes
        public Category Category { get; set; }
    }
}
