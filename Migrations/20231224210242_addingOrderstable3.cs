using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addingOrderstable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Cart_OrderId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cart_OrderId",
                table: "Orders",
                column: "OrderId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cart_OrderId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d5947f1-ac52-486f-aa04-e063d36f88f6", "95be5396-13de-43c3-8701-ec29c8f9dd60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "897c4f68-9bda-4ddf-b345-7f84e307ff2b", "ceaec5d0-1d5a-4aa9-9c7f-47b1d25cf99a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e213d0f-f40b-4059-81f1-51a36ba65a87", "a2b26d89-9bfa-45fa-8f2d-33b9e00ddad3" });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Cart_OrderId",
                table: "Order",
                column: "OrderId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
