using FoodRecipe.Data;
using FoodRecipe.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodRecipe.Models.Services
{
    public class OrderServices : IOrder
    {
        private readonly FoodDbContaxt _context;

        public OrderServices(FoodDbContaxt context)
        {
            _context = context;
        }/// <summary>
        /// /to get and display all orders
        /// </summary>
        /// <returns></returns>
        public async Task<List<Order>> GetAllOrders()
        {
            var Orders= await _context.Orders.Include(c=>c.ShoppingCart).ToListAsync();
            return Orders;
        }
    }
}
