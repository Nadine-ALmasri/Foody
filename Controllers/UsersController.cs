using FoodRecipe.Models.DTOs;
using FoodRecipe.Models.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;

namespace FoodRecipe.Controllers
{
    public class UsersController : Controller
    {
        private IUserService userService;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UsersController(IUserService service, RoleManager<IdentityRole> roleManager)
        {
            userService = service;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SignUp()
        {

            return View();

        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        /// <summary>
        /// Action to handle user registration and sign-up process.
        /// </summary>
        public async Task<ActionResult<UserDto>> SignUp(RegisterUserDto data)
        {

            if (data.Roles == null)
            {
                data.Roles = new List<string>() { "User" };
            }

            var user = await userService.Register(data, this.ModelState);
            if (!ModelState.IsValid)
            {
                //var Roles = await _roleManager.Roles.ToListAsync();
                //ViewBag.RolesList = new SelectList(Roles, "Id", "Name");
                return View(user);
            }
            //  await SendWelcomeEmailAsync(user);

            return RedirectToAction("LogIn");
        }
        [HttpPost]
        /// <summary>
        /// Action to handle user login and authentication.
        /// </summary>
        public async Task<ActionResult<UserDto>> LogIn(LogInDto loginData)
        {

            var user = await userService.Authenticate(loginData.UserName, loginData.Password);

            if (user == null)
            {
                this.ModelState.AddModelError("InvalidLogin", "Invalid login attempt");

                return View(loginData);

            }

            /*  var shoppingCart = userService.LoadShoppingCartForUser(user);

              var jsonSerializerSettings = new JsonSerializerSettings
              {
                  ReferenceLoopHandling = ReferenceLoopHandling.Ignore
              };

              // Serialize the shopping cart with the configured settings
              var serializedShoppingCart = JsonConvert.SerializeObject(shoppingCart, jsonSerializerSettings);
              // Add the shopping Cart to the user's claims*/
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, user.Username),
    };

            var claimsIdentity = new ClaimsIdentity(claims, "LogIn");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            if (user.Roles.Contains("User"))
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");




        }
        public async Task<IActionResult> Logout()
        {
            await userService.Logout();

            return RedirectToAction("Index", "Home");
        }
    }
}
