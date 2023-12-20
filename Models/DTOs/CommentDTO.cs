namespace FoodRecipe.Models.DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public string Text { get; set; }
        public int recipeId { get; set; }
        public string userName { get; set;}
    }
}
