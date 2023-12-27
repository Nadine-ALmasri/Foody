using FoodRecipe.Models.DTOs;
namespace FoodRecipe.Models.Interface
{
    public interface IRecipe
    {
        Task<List<RecipeDTO>> GetAllRecipes();
        Task<RecipeDTO> GetRecipeById(int recipeId);
        Task<RecipeDTO> CreateRecipe(RecipeDTO recipe);
        Task<RecipeUpdate> UpdateRecipe(int id , RecipeUpdate recipe);
        Task DeleteRecipe(int recipeId);
        Task<Comment> AddComment(Comment comment);
    }
}
