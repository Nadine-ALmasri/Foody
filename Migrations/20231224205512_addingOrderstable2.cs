using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addingOrderstable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Cart_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks",
                columns: new[] { "Id", "BookId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6738efe7-d8ea-4dfa-8003-cb206a9c9f14", "1bf2997b-ddde-4930-8e9b-0f01b1e1520f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae491ef5-c5ec-4fe7-9ee9-d755829c214f", "9504347b-6db0-4729-b1cb-eb65aab407b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90dcefe7-301e-4646-a0cb-ff1dc970819e", "08f1b7c7-3a3a-45bc-bc7c-d8c054ea89d9" });
        }
    }
}
