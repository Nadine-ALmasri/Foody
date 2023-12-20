using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class edtied : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee69912c-0739-48bc-a456-ff842f46b0e9", "6e3808ee-cc17-43d3-9a9d-f82403586769" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "afb4ea8c-59c9-47f1-935d-6814dbf976c0", "87f7484d-4209-4a9b-86d3-064c49cb759e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5480419d-01ed-4625-aad6-4f12a4a4ce58", "728ad1f0-bffc-4e61-80a0-3a4e50ae495f" });
        }
    }
}
