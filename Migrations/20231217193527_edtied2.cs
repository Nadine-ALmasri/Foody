using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class edtied2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_ApplicationUser_UserId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_UserId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ingredients");

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
                values: new object[] { "ddff3a41-6fc9-4e10-a803-fac159ae27d7", "efa68984-03cf-4696-b13e-2f5d382c69c4" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36b7cd95-ba92-4c56-aa1a-863a451b1807", "bfa75709-ea86-43bb-b6af-3adeca866d48" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b824a725-1cd4-4a9d-8021-c6b23ffea454", "adb319c0-e8a3-4467-b79f-c6e4a8f0425e" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Ingredients");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Ingredients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7df00b6-6cb4-4a4c-bcfe-2ff36349a794", "167551a3-d690-42b7-b4e2-c1511d6a6eb8" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99c92c96-18cd-46d9-a3b6-5603165c015c", "e3aa75f7-775e-44ee-833e-8f85d66db2d0" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "781452ee-d1de-487e-b706-d2c4a806fd78", "62ec03f7-d566-4ff8-b89a-9a54e43afa8b" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_UserId",
                table: "Ingredients",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_ApplicationUser_UserId",
                table: "Ingredients",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");
        }
    }
}
