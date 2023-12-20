using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class identity7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "administrator", "00000000-0000-0000-0000-000000000000", "Administrator", "ADMINISTRATOR" },
                    { "editor", "00000000-0000-0000-0000-000000000000", "Editor", "EDITOR" },
                    { "user", "00000000-0000-0000-0000-000000000000", "User", "USER" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "editor");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cae83b79-c6a6-4a7a-9040-cb36ed3d6c97", "edcd18fa-04b3-4e0d-890d-b2a0b7f5324c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be21bfa9-f86d-4504-ac92-a86bd25192df", "cedf6ff0-4baa-45c4-a513-5ebeb76fec53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fff2f75b-7c42-4f5a-98d1-bb9a29c7c35f", "73fe3f56-a6bd-4d53-b8ca-1515587dea0d" });
        }
    }
}
