using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bfada60-16c2-414c-8220-d22503282256", "f8c8b357-fd41-40a4-91d6-0cdcb0edc640" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58d67804-deea-4be6-a00f-da18bf33f4bb", "da0ddd4d-727f-42ce-acad-53254de4a958" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "149c10c1-7dc1-4f2c-abb8-7b8c289e6445", "37cbb7e4-62eb-46c4-be0f-149050c3daa5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5910b26-86c7-499a-8d75-6970574dfff3", "e83a9923-3f57-4ab3-b4b0-98b326f86b1c" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bbf5116-bd6d-48ce-8d58-974d81dd56b0", "38f7b55e-edd1-47a9-88e8-6de83304c64a" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3b3d317-0413-4270-80a8-de127c9c4a8c", "61df9930-439b-4765-9637-36a60bd56423" });
        }
    }
}
