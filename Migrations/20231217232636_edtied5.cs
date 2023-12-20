using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class edtied5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Ingredients");

            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "IngredientRecipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fae8d540-7bba-4a28-ada7-d27e3d3da4e2", "152b4586-bd1f-4650-a4d2-16df318a246f" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8dd0b363-9022-4da0-9fb1-f9f8012fd4d0", "ee0ed91d-10d7-44d5-b9e9-cafc9bdf2932" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e95ec5bf-3178-4e78-a493-df3274bab76c", "7659ff7a-64f3-4fc7-a661-98f3660a5d99" });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "Id" },
                values: new object[,]
                {
                    { 1, 1, "cup", 1 },
                    { 2, 1, "two", 2 },
                    { 3, 1, "250 gram", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "IngredientRecipes");

            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b557a9de-14fb-4d09-8dc4-7449691098e3", "29d6086f-9f2d-435e-bc32-15114e1d24a3" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08518f30-6f1b-44ac-87c9-fe514558ff73", "e83879c7-609f-4bfd-8721-08253cfc6be5" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72da03be-bc2c-4550-935a-13e2170420dd", "14bd408e-64bc-4791-9823-f1aa033c270d" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 1,
                column: "Amount",
                value: "cup");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 2,
                column: "Amount",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 3,
                column: "Amount",
                value: "400 GRAM");
        }
    }
}
