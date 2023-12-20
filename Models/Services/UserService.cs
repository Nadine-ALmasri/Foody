using FoodRecipe.Data;
using FoodRecipe.Models.DTOs;
using FoodRecipe.Models.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FoodRecipe.Models.Services
{
    public class UserService : IUserService

    {
        private readonly FoodDbContaxt _context;
        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;
        public UserService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager,FoodDbContaxt context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<UserDto> Authenticate(string username, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, true, false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(username);

                return new UserDto()
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user)
                };
            }

            return null;
        }

        public async  Task<UserDto> Register(RegisterUserDto data, ModelStateDictionary modelState)
        {
            var user = new ApplicationUser()
            {
                UserName = data.Username,
                PhoneNumber = data.PhoneNumber,
                Email = data.Email,

            };

            var result = await _userManager.CreateAsync(user, data.Password);
            if (result.Succeeded)
            {

                await _userManager.AddToRolesAsync(user, data.Roles);

                UserDto userDto = new UserDto
                {
                    Email = user.Email,
                    Id = user.Id,
                    Username = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user)
                };
                return userDto;
            }
            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? "Password Issue" :
                    error.Code.Contains("Email") ? "Email Issue" :
                    error.Code.Contains("UserName") ? nameof(RegisterUserDto.Username) :
                    "";

                modelState.AddModelError(errorKey, error.Description);
            }

            return null;
        }
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
