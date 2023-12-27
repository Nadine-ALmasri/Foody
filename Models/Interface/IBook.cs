namespace FoodRecipe.Models.Interface
{
    public interface IBook
    {
        Task<Book> Create(Book book);
        Task<List<Book>> GetAllProducts();
        Task<Book> GetProductById(int Id);
        Task<Book> Update(int Id, Book book);
        Task<List<CartBooks>> AddToCart(int BookId);
        Task Delete(int id);
    }
}
