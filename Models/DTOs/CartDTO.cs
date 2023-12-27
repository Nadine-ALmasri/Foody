namespace FoodRecipe.Models.DTOs
{
    public class CartDTO
    {
    }
    public class CartEmail
    {

        public int Id { get; set; }
        public double Total { get; set; }

        public List<CartBooks> CartBooks { get; set; }
    }
}
