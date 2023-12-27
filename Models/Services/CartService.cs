using FoodRecipe.Models.Interface;
using FoodRecipe.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FoodRecipe.Models.Services
{
    public class CartService : ICart
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly FoodDbContaxt _context;

        public CartService(FoodDbContaxt context, IHttpContextAccessor httpContextAccessor, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _signInManager = signInManager;
        }
        public async Task<List<CartBooks>> AddToCart(Book book)
        {
            var userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return null;
            }

            // Get the user's cart.
            var userCart = await _context.Cart
                .Include(c => c.CartBooks)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            // If the user doesn't have a cart, create a new one.
            if (userCart == null)
            {
                userCart = new Cart
                {
                    UserId = userId,

                    // Other cart properties initialization if needed...
                };
                _context.Cart.Add(userCart);
                await _context.SaveChangesAsync();
            }
            if (userCart != null && userCart.CartBooks != null)
            {
                var cartBook = userCart.CartBooks.FirstOrDefault(cb => cb.BookId == book.Id);
                // Rest of your code...



                if (cartBook != null)
                {
                    cartBook.Quantity += 1;
                }
                else
				{
					_context.Entry(book).State = EntityState.Unchanged;

					CartBooks newCartBook = new CartBooks
                    {
                        Cart = userCart,
                        BookId = book.Id,
                        Quantity = 1,
                        UserId = userId,
                    };
                    _context.CartBooks.Add(newCartBook);
                }
            }
                await _context.SaveChangesAsync();

                return userCart.CartBooks.ToList();
            }
        
		public async Task<Cart> GetCart(string userId)
        {
            var userCart = await _context.Cart
                .Include(c => c.CartBooks)
                .ThenInclude(cp => cp.Book)
                .FirstOrDefaultAsync(c => c.UserId == userId);


            return userCart;




        }
        public async Task DeleteProduct(int id)
        {
            var userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return;
            }

            // Get or create the user's Cart.
            var userCart = await _context.Cart.FirstOrDefaultAsync(c => c.UserId == userId);
            var CartofUser = await _context.Cart.Where(x => x.UserId == userId).SelectMany(x => x.CartBooks).FirstOrDefaultAsync(x => x.BookId == id);
            if (CartofUser != null)
            {
                _context.CartBooks.Remove(CartofUser);
                await _context.SaveChangesAsync();
            }
        }

        public async Task LessQuantity(int id)
        {
            var userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return;
            }

            // Get or create the user's Cart.
            var userCart = await _context.Cart.FirstOrDefaultAsync(c => c.UserId == userId);
            var CartofUser = await _context.Cart.Where(x => x.UserId == userId).SelectMany(x => x.CartBooks).FirstOrDefaultAsync(x => x.BookId == id);
            if (CartofUser != null && CartofUser.Quantity > 1)
            {
                CartofUser.Quantity--;
                await _context.SaveChangesAsync();
            }
            else if (CartofUser != null && CartofUser.Quantity == 1)
            {
                _context.CartBooks.Remove(CartofUser);
                await _context.SaveChangesAsync();
            }
        }
    }
}
