using FoodRecipe.Models.DTOs;

namespace FoodRecipe.Models.Interface
{
    public interface IOrder
    {
        public Task<List<Order>> GetAllOrders();
    }
}
