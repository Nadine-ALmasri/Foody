using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addingOrderstable5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Book",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8d65149-b1a6-4deb-badd-d7fb0047cfac", "ba96ccbc-bdb4-488b-971a-ee226fceff5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a383ee3d-f441-40f2-bbe7-0e1ef91968ec", "28e41c14-e020-467c-9b3a-efd34a11309e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ed26dff-95a0-4775-8e34-673c68c78015", "fbf94dac-bacf-40c7-98e2-a2655fdfaee3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f14b6dce-9f94-47b1-93dc-0442a5858898", "3741f5f7-72eb-4753-919a-5070c62a024f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0fabc7d8-ee72-4e9f-8e8d-9e9c1e07f271", "28bc94d5-37bd-4cd3-9558-b8aa56f2d012" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f940c908-32ad-4f2d-a800-2352cbaff9f1", "81bf925c-8d2d-4385-8028-08ede31b779d" });
        }
    }
}
