using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class identitynew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
