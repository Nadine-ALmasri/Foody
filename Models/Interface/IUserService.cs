using FoodRecipe.Models.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FoodRecipe.Models.Interface
{
    public interface IUserService
    {
        public Task<UserDto> Register(RegisterUserDto data, ModelStateDictionary modelState);
        public Task<UserDto> Authenticate(string username, string password);
        public Task Logout();

    }
}
