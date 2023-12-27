using FoodRecipe.Data;
using FoodRecipe.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodRecipe.Models.Services
{
    public class BookService : IBook
    {
        private readonly FoodDbContaxt _context;
        private readonly ICart _cart;
        public BookService(FoodDbContaxt context , ICart cart)
        {
            _context = context;
            _cart = cart;
            
        }
        public async Task<List<CartBooks>> AddToCart(int BookId)
        {
            var book = await GetProductById(BookId); // Fetch the product details.

            if (book != null)
            {
                var cartProducts = await _cart.AddToCart(book);
                return cartProducts;
            }
            return null;
        }

        public async Task<Book> Create(Book book)
        {
            var newbook = new Book
            {
                Title = book.Title,
                Price = book.Price,
                Description = book.Description,
                ImageUrl = book.ImageUrl
            };
            _context.Entry(newbook).State = EntityState.Added;
            await _context.SaveChangesAsync();


            return newbook;
        }

        public async Task Delete(int id)
        {
            var book = await _context.Book.FindAsync(id);
            if (book != null)
            {
                _context.Entry(book).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAllProducts()
        {
            var Books = await _context.Book.Select(pr => new Book()
            {
                Id = pr.Id,
               Title = pr.Title,
                Description = pr.Description,
                Price = pr.Price,
                ImageUrl = pr.ImageUrl
            }).ToListAsync();
            return Books;
        }

        public async Task<Book> GetProductById(int Id)
        {

            var Book = await _context.Book.FirstOrDefaultAsync(x => x.Id == Id);
            if (Book == null)
                return null;
            var products = await _context.Book.Select(pr => new Book()
            {
                Id = pr.Id,
               Title = pr.Title,
                Description = pr.Description,
                Price = pr.Price,
                ImageUrl = pr.ImageUrl,

            }).FirstOrDefaultAsync((x => x.Id == Id));
            return Book;
        }

        public async Task<Book> Update(int Id, Book book)
        {
            var UpdateBook = await _context.Book.FindAsync(Id);
            if (UpdateBook != null)
            {
                UpdateBook.Title = book.Title;
                UpdateBook.Title = book.Title;
                UpdateBook.Description = book.Description;
                UpdateBook.ImageUrl = book.ImageUrl;

                _context.Entry(UpdateBook).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            else
            {
                return null;
            }

           


            return UpdateBook;
        }
    }
}
