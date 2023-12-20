namespace FoodRecipe.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        public List<Recipe> ?Recipes { get; set; }
    }
}
