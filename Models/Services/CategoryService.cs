using FoodRecipe.Data;
using FoodRecipe.Models.DTOs;
using FoodRecipe.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodRecipe.Models.Services
{
    public class CategoryService : ICategory
    {
        private readonly FoodDbContaxt _context;
        public CategoryService(FoodDbContaxt context)
        {
            _context = context;
        }
        public async Task<CategoryDTO> Create(CategoryDTO category)
        {

            var newCategory = new Category
            {
                Name = category.Name ,
                ImgUrl=category.ImgUrl

            };

            _context.Entry(newCategory).State = EntityState.Added;

            await _context.SaveChangesAsync();

            var categorydto = new CategoryDTO()
            {
               CategoryID = newCategory.CategoryID,
                Name = newCategory.Name
            };

            return categorydto;
        }

        public async Task Delete(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            _context.Entry(category).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            var TheCategory = await _context.Categories.Select(category => new CategoryDTO
            {
                CategoryID = category.CategoryID,
                ImgUrl=category.ImgUrl ,
                Name = category.Name,
            }).ToListAsync();
            return TheCategory;
        }

        public async Task<GetAllCategoryDTO> GetCategoryById(int id)
        {
            var TheCategory = await _context.Categories
                .Include(category => category.Recipes)
                .ThenInclude(recipe => recipe.IngredientRecipes)
                .ThenInclude(ir => ir.Ingredient)
                .Where(category => category.CategoryID == id)
                .Select(category => new GetAllCategoryDTO
                {
                    Id = category.CategoryID,
                    Name = category.Name,
                    ImgUrl = category.ImgUrl,
                    Recipes = category.Recipes.Select(p => new RecipeDTO
                    {
                        RecipeId = p.RecipeID,
                        Title = p.Title,
                        Description = p.Description,
                        CategoryId = p.CategoryId,
                        ImgUrl = p.ImgUrl,
                      Ingredient = p.IngredientRecipes.Select(i => new IngredientDTO()
                        {
                           IngredientID = i.Ingredient.IngredientID,
                           Name=i.Ingredient.Name ,
                       
                            // Include other properties as needed
                        }).ToList()
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            return TheCategory;
        }


        public async Task<CategoryDTO> Update(int id, CategoryDTO category)
        {
            var UpdatedCategory = await _context.Categories.FindAsync(id);

            if (UpdatedCategory != null)
            {
                UpdatedCategory.Name = category.Name;
                UpdatedCategory.ImgUrl = category.ImgUrl;
                UpdatedCategory.CategoryID = id;
                _context.Entry(UpdatedCategory).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                return null;
            }

            var UpdatedCategoryDTO = new CategoryDTO
            {
               CategoryID = UpdatedCategory.CategoryID,
                Name = UpdatedCategory.Name
            };

            return UpdatedCategoryDTO;
        }
    }
}
