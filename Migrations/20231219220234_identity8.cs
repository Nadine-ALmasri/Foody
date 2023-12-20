using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class identity8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e93f94e-e0d0-4677-abd9-354ad7585846", "7f3f752a-e997-4ae1-839f-39d34568fc83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78dbe7bd-f378-4cc7-a3e4-b33836e6e64e", "d6e0034d-9dcb-45d8-a392-731d3ade834e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96a42076-dc35-4146-b2ed-beedcd7a3fd7", "2f17d898-6d27-4c27-872b-9f788357fd95" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1,
                column: "CategoryName",
                value: "Breakfast");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2,
                column: "CategoryName",
                value: "Pasta");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3,
                column: "CategoryName",
                value: "Chicken Dishes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "572a79e8-f09e-40c0-bcad-fd6f6f5b3c15", "80f7fddb-512f-4a14-b558-aa9986d67f70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9efe6d04-282a-4a6b-8ca1-3580947eaf8d", "85eb5dc2-f382-4c4e-bed9-9fb3c0e05094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cab0ec54-7b9d-4a82-bf83-e455d3ef898c", "7bd390be-f149-4e3f-bbac-e57ece761fa4" });
        }
    }
}
