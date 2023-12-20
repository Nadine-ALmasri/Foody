using FoodRecipe.Models.DTOs;
namespace FoodRecipe.Models.Interface
{
    public interface IRecipe
    {
        Task<List<RecipeDTO>> GetAllRecipes();
        Task<RecipeDTO> GetRecipeById(int recipeId);
        Task<RecipeDTO> CreateRecipe(RecipeDTO recipe);
        Task<RecipeDTO> UpdateRecipe(int id ,RecipeDTO recipe);
        Task DeleteRecipe(int recipeId);
        Task<Comment> AddComment(Comment comment);
    }
}
