namespace FoodRecipe.Models.DTOs
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

    }
    public class GetAllCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RecipeDTO> Recipes { get; set; }
        public string ImgUrl { get; set; }
    }
}
