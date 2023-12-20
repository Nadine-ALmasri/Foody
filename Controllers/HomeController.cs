using FoodRecipe.Models;
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

		public HomeController(ILogger<HomeController> logger , ICategory categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        public async Task< IActionResult >Index()
        {
			var categories = await _categoryService.GetAllCategories();
			return View(categories);
		}
		public IActionResult About()
		{
			return View();
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