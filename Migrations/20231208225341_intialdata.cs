using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class intialdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_ApplicationUser_UserId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_ApplicationUser_ApplicationUserId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ApplicationUserId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Recipes");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ingredients",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "421877c3-3bb3-4e8b-b8be-85a394f84a96", null, false, false, null, null, null, null, null, false, "6cc1cd66-4bf3-47f0-8478-ce9332233874", false, "user1@example.com" },
                    { "2", 0, "5c078858-994b-42ed-93d4-889de623fb3c", null, false, false, null, null, null, null, null, false, "94ea13b0-424b-4f72-a60c-aab0af185822", false, "user2@example.com" },
                    { "3", 0, "9e9761b5-9be4-4678-8a9c-84c27743824d", null, false, false, null, null, null, null, null, false, "04ae1276-a6d8-4629-bdba-59bf62d79644", false, "user3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Pasta" },
                    { 3, "Chicken Dishes" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientID", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Flour", null },
                    { 2, "Eggs", null },
                    { 3, "Chicken Breast", null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeID", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "A simple and delicious pancake recipe.", "Classic Pancakes" },
                    { 2, "Traditional Italian pasta dish with meat sauce.", "Spaghetti Bolognese" },
                    { 3, "Quick and easy chicken stir-fry recipe.", "Chicken Stir Fry" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_ApplicationUser_UserId",
                table: "Ingredients",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_ApplicationUser_UserId",
                table: "Ingredients");

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Recipes");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ingredients",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ApplicationUserId",
                table: "Recipes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_ApplicationUser_UserId",
                table: "Ingredients",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_ApplicationUser_ApplicationUserId",
                table: "Recipes",
                column: "ApplicationUserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");
        }
    }
}
