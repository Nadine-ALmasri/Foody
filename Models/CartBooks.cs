namespace FoodRecipe.Models
{
    public class CartBooks
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Cart? Cart { get; set; }

        public string UserId { get; set; }
        public Book? Book { get; set; }

        public int Quantity { get; set; }
    }
}
