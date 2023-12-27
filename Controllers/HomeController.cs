using FoodRecipe.Models;
using FoodRecipe.Models.DTOs;
using FoodRecipe.Models.Interface;
using FoodRecipe.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodRecipe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly ICategory _categoryService;
        private readonly IBook _bookService;

        public HomeController(ILogger<HomeController> logger , ICategory categoryService, IBook bookService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _bookService = bookService;
        }

        public async Task< IActionResult >Index()
        {
            var books = await _bookService.GetAllProducts();
            var categories = await _categoryService.GetAllCategories();
			var viewModel = new CategoryBookViewModel
			{
				Categories = categories,
				Books = books
			};

			return View(viewModel);
		}
		public async Task< IActionResult> About()
		{
            var books = await _bookService.GetAllProducts();

            return View(books);
		}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}