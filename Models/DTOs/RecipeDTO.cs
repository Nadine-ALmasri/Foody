namespace FoodRecipe.Models.DTOs
{
    public class RecipeDTO
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<IngredientDTO> Ingredient { get; set; } // Changed to IngredientRecipes
        public ICollection<Comment> Comments { get; set; }


    }
    public class RecipeUpdate
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }
        public string ImgUrl { get; set; }


    }
    public class GetRecipiesDTO
    {
        public int RecipeId { get; set; }
        public string Description { get; set; }

        public string ImgUrl { get; set; }
        public string Title { get; set; }
    }
    public class DetailRecipeDTO
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<IngredientRecipeDto> IngredientRecipeDto { get; set; }
    }
}
