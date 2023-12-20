namespace FoodRecipe.Models
{
    public class Like
    {
        public int LikeId { get; set; }

        // Foreign key for Recipe
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
