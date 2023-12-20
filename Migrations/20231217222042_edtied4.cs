using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class edtied4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.CreateTable(
                name: "IngredientRecipes",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipes", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipes_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipes_RecipeId",
                table: "IngredientRecipes",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipes");

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    IngredientsIngredientID = table.Column<int>(type: "int", nullable: false),
                    RecipesRecipeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => new { x.IngredientsIngredientID, x.RecipesRecipeID });
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredients_IngredientsIngredientID",
                        column: x => x.IngredientsIngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipes_RecipesRecipeID",
                        column: x => x.RecipesRecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd557074-7c04-4c4b-b39f-cf58bc51028f", "eb57a369-25c4-49e7-9e3d-e620fb961d16" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59c374da-00b9-4a22-b0bd-798ee623ca01", "f887e066-9bac-4c57-8840-756418b91470" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "700b2268-033b-4c7d-8857-acb22bc51354", "3e840636-1ab9-4cf9-a3c9-6a60b6c26ac0" });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipesRecipeID",
                table: "IngredientRecipe",
                column: "RecipesRecipeID");
        }
    }
}
