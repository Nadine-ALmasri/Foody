namespace FoodRecipe.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }

        // Foreign key for Recipe
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime time { get; set; }

    }
}
