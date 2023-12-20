using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class identitynew3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "time",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0aadda9c-0b82-4b0f-9f69-ba163786ab28", "96a7806a-9094-4d65-b880-9a52cc6295ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ebdc5c6e-b11b-49f6-b47f-37edb0309dc2", "b2146718-588f-4242-9ece-b3d3af86ab41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd9177fa-9984-40e8-9ad1-5d91e319ce6a", "765ec7fc-ecd5-4865-82aa-339a80128e3e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "time",
                table: "Comments");

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
    }
}
