using FoodRecipe.Models;
using FoodRecipe.Models.DTOs;
using FoodRecipe.Models.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FoodRecipe.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipe _recipeService;
        private UserManager<ApplicationUser> _userManager;

        public RecipeController(IRecipe recipeService , UserManager<ApplicationUser> userManager)
        {
            _recipeService = recipeService;
            _userManager = userManager;
        }
        // GET: Recipe
        public async Task<IActionResult> Index()
        {
            var recipes = await _recipeService.GetAllRecipes();
            return View(recipes);
        }
        // GET: Recipe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _recipeService.GetRecipeById(id.Value);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RecipeDTO recipe)
        {
            if (ModelState.IsValid)
            {
                var newRecipe = await _recipeService.CreateRecipe(recipe);
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _recipeService.GetRecipeById(id.Value);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RecipeDTO recipe)
        {
            if (id != recipe.RecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var updatedRecipe = await _recipeService.UpdateRecipe(id, recipe);
                if (updatedRecipe == null)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _recipeService.DeleteRecipe(id.Value);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task< IActionResult> AddComment(CommentDTO model)
        {
            var user = await _userManager.FindByIdAsync(model.UserID);
            var currentDate = DateTime.UtcNow;
            if (user != null)
            {
                var userName = user.UserName;
                // Now you have the user name associated with the given user ID
            }
            var newComment = new Comment()
            {
                Text = model.Text,
                UserId=model.UserID ,
                User=user ,
                RecipeID=model.recipeId ,
                time= currentDate ,





            };

                // Save the new comment using your service/repository
                _recipeService.AddComment(newComment);

                // Redirect to the recipe details page after adding the comment
                return RedirectToAction("Details", new { id = model.recipeId });
        }

            // If model state is not valid, return the view with errors
 
    }


    }

