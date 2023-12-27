using FoodRecipe.Models;
using FoodRecipe.Models.DTOs;

namespace FoodRecipe.Models.Interface
{
    public interface ICart
    {
        Task<List<CartBooks>> AddToCart(Book book);
        Task DeleteProduct(int id);
        Task LessQuantity(int id);

        public Task<Cart> GetCart(string userId);



    }

}
