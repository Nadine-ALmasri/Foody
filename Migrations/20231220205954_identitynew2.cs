using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class identitynew2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af7430f9-1d55-4414-823a-77b23e3bc96a", "ecc29781-9353-4631-a156-bd90e6355c70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f80078fc-b43a-48d3-ba11-bc45effb4786", "63e6e566-49d5-49dd-8067-7f374d6b9ffc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0f05f8d7-7596-4a93-925e-477a8f0a283a", "dfb95952-ce2d-498d-8596-0a1ded68c532" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c403cc86-f21b-4f93-b532-1d7959bc396f", "45c90841-cfc4-4259-b572-d9b1d47e651c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "245581fd-b8f3-435d-a592-2f432971385b", "f6ea3444-4965-4a82-a5f9-4eb2c39fa482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ca5e420-2fc0-4184-8e99-7656771063b6", "32eafc1f-e882-4b2f-b27e-be04daecd8c4" });
        }
    }
}
