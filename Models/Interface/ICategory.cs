using FoodRecipe.Models.DTOs;

namespace FoodRecipe.Models.Interface
{
    public interface ICategory
    {
        Task<CategoryDTO> Create(CategoryDTO category);
        Task<List<CategoryDTO>> GetAllCategories();
        Task<GetAllCategoryDTO> GetCategoryById(int id);
        Task<CategoryDTO> Update(int id, CategoryDTO category);
        Task Delete(int id);
    }
}
