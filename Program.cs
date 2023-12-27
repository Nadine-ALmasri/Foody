using FoodRecipe.Data;
using Microsoft.Extensions.Options;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using FoodRecipe.Models.Interface;
using FoodRecipe.Models.Services;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using FoodRecipe.Models;

namespace FoodRecipe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            string connString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<FoodDbContaxt>(options => options.UseSqlServer(connString));
            builder.Services.AddTransient<ICategory, CategoryService>();
            builder.Services.AddTransient<IRecipe, RecipeServices>();
            builder.Services.AddTransient<IUserService, UserService>();
			builder.Services.AddScoped<IEmailSender, EmailSender>();
			builder.Services.AddTransient<ICart,CartService>();

			builder.Services.AddTransient<IBook, BookService>();
			builder.Services.AddTransient<IOrder, OrderServices>();



			builder.Services.AddIdentity<ApplicationUser, IdentityRole>()

    .AddEntityFrameworkStores<FoodDbContaxt>();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
              .AddCookie(options =>
              {
                  options.ExpireTimeSpan = TimeSpan.FromMinutes(1);
                  options.LoginPath = "/auth/LogIn"; // Set the login path
                  options.AccessDeniedPath = "/Account/auth/AccessDenied"; // Set the access denied path
              });
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdministratorPolicy", policy =>
                    policy.RequireRole("Administrator"));
                options.AddPolicy("EditorPolicy", policy =>
                    policy.RequireRole("Editor"));
                options.AddPolicy("UserPolicy", policy =>
                    policy.RequireRole("User"));
            });
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "Recipe API",
                    Version = "v1",
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); // Place UseAuthentication before UseAuthorization
            app.UseAuthorization(); // Place UseAuthorization here
            app.UseSwagger(aptions =>
            {
                aptions.RouteTemplate = "/api/{documentName}/swagger.json";
            });
            app.UseSwaggerUI(aptions =>
            {
                aptions.SwaggerEndpoint("/api/v1/swagger.json", "Recipe API");
                aptions.RoutePrefix = "docs";
            });
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}