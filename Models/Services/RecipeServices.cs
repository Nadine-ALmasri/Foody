using FoodRecipe.Data;
using FoodRecipe.Models.DTOs;
using FoodRecipe.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace FoodRecipe.Models.Services
{
    public class RecipeServices : IRecipe
    {
        private readonly FoodDbContaxt _context;
        public RecipeServices(FoodDbContaxt context)
        {
            _context = context;

        }
        public async Task<RecipeDTO> CreateRecipe(RecipeDTO recipe)
        {
            /*var newRecipe = new Recipe
                        {
                            Title = recipe.Title,
                            ImgUrl= recipe.ImgUrl,
                            Description= recipe.Description,
                            CategoryId= recipe.CategoryId,
                            Steps= recipe.Steps,
                            IngredientRecipes= recipe.IngredientRecipes,

                        };

                        var RecipyCat = await _context.Recipes.Include(r => r.Category).FirstOrDefaultAsync(x => x.CategoryId == newRecipe.CategoryId);
                        _context.Entry(newRecipe).State= EntityState.Added;
                        await _context.SaveChangesAsync();
                        var recipyDto = new RecipeDTO()
                        {
                            Title = newRecipe.Title,
                            ImgUrl = newRecipe.ImgUrl,
                            Description = newRecipe.Description,
                            CategoryId = newRecipe.CategoryId,
                            Steps = newRecipe.Steps,
                           IngredientRecipes = newRecipe.IngredientRecipes,
                            CategoryName = RecipyCat.Category.Name

                        };
                        return recipyDto;*/
            var theRecipy = new Recipe
            {
                Title = recipe.Title,
                ImgUrl = recipe.ImgUrl,
                Description = recipe.Description,
                CategoryId = recipe.CategoryId,
                Steps = recipe.Steps,
                IngredientRecipes = recipe.Ingredient.Select(a => new IngredientRecipe { IngredientId = a.IngredientID }).ToList()
            };

            _context.Recipes.Add(theRecipy);
            await _context.SaveChangesAsync();

            recipe.RecipeId = theRecipy.RecipeID;
            return recipe;


        }
        public async Task DeleteRecipe(int recipeId)
        {
            Recipe recipe = await _context.Recipes.FindAsync(recipeId);
            _context.Entry(recipe).State = EntityState.Deleted;
            await _context.SaveChangesAsync();


        }

        public async Task<List<RecipeDTO>> GetAllRecipes()
        {
            /* var Recipes = await _context.Recipes.Include(_ => _.Category).Select(x => new GetRecipiesDTO()
             {RecipeId=x.RecipeID,
                 Title = x.Title,
                 ImgUrl = x.ImgUrl,
                 Description = x.Description
             }).ToListAsync(); 
             return Recipes;*/
            var recipes = await _context.Recipes
                    .Include(r => r.IngredientRecipes)
                    .ThenInclude(ir => ir.Ingredient)
                    .Select(r => new RecipeDTO
                    {
                        RecipeId = r.RecipeID,
                        Title = r.Title,
                        ImgUrl = r.ImgUrl,
                        Description = r.Description,
                        CategoryId = r.CategoryId,
                        Steps = r.Steps,
                       CategoryName = r.CategoryName,
                        Ingredient = r.IngredientRecipes.Select(ir => new IngredientDTO
                        {
                            IngredientID = ir.Ingredient.IngredientID,
                            Name = ir.Ingredient.Name,
                            Amount = ir.Amount
                        }).ToList()
                    })
                    .ToListAsync();

            return recipes;
        }

        public async Task<RecipeDTO> GetRecipeById(int recipeId)
        {
           
            var newRecipe = await _context.Recipes
                .Where(r => r.RecipeID == recipeId)
                .Select(r => new RecipeDTO()
                {
                    Title = r.Title,
                    ImgUrl = r.ImgUrl,
                    Description = r.Description,
                    CategoryId = r.CategoryId,
                    Steps = r.Steps,
                    RecipeId=r.RecipeID,
                    Ingredient = r.IngredientRecipes.Select(ra => new IngredientDTO
                    {
                        IngredientID = ra.Ingredient.IngredientID,
                        Name = ra.Ingredient.Name
                    }).ToList(),
                    Comments = r.Comments.Select(c => new Comment // Assuming you have a CommentDTO class
                    {
                       CommentId = c.CommentId,
                        Text = c.Text,
                       
                       RecipeID=c.RecipeID ,
                       User=c.User,
                       UserId=c.UserId,
                       time= c.time ,
                        // Map other comment properties as needed
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            return newRecipe;
        }

        public async Task<RecipeUpdate> UpdateRecipe(int id, RecipeUpdate recipe)
        {
            var recipeToUpdate = await _context.Recipes.FindAsync(id);
            if (recipeToUpdate != null)
            {
                recipeToUpdate.Title = recipe.Title;
                recipeToUpdate.Description = recipe.Description;
                recipeToUpdate.Steps = recipe.Steps;
                recipeToUpdate.ImgUrl = recipe.ImgUrl;
                _context.Entry(recipeToUpdate).State = EntityState.Modified;
                await _context.SaveChangesAsync();

              /*  // Map the updated recipe to a RecipeDTO and return
                var updated = new RecipeDTO()
                {
                    RecipeId = recipeToUpdate.RecipeID,
                    Title = recipeToUpdate.Title,
                    CategoryId = recipeToUpdate.CategoryId,
                    Description = recipeToUpdate.Description,
                    Steps = recipeToUpdate.Steps,
                    ImgUrl = recipeToUpdate.ImgUrl,
                    IngredientRecipes = recipeToUpdate.IngredientRecipes.Select(ir => new IngredientRecipe
                    {
                        Id = ir.Ingredient.IngredientID,
                       
                    }).ToList()*/
               // };

                return recipe;
            }
            return null;
        }
        public async Task<Comment> AddComment(Comment comment)
        { 
           

            
            _context.Entry(comment).State = EntityState.Added;
            await _context.SaveChangesAsync();
          

            return comment;
        }
    }
}
