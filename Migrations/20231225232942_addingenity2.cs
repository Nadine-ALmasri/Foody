using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addingenity2 : Migration
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
                columns: new[] { "Id", "BookId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a137fccf-84ef-4df0-842c-6397a806c99f", "78eb4ebf-167e-434a-8457-7e221b76add2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0fc221f6-be00-4b47-9523-329f67263ab2", "19f5d3b5-f124-40dd-865a-46c6d554900a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54045ab2-ae27-4893-8970-e683763dc1a8", "ac1fba04-6b76-4904-b1b4-a69ef933a47d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbbcf473-3ed5-4cae-8882-263fdaff4860", "2fb20a38-baf2-4195-8519-4021fd2cfde7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02a4ada8-fa41-45d0-96b4-127144da88dc", "8bff3917-19a4-4748-8cb1-9816a8d0c564" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "803e7c6f-9f92-4d41-84c7-675d9a02fc16", "e9ffda7f-0ae0-450c-93dd-a2315eb760ee" });
        }
    }
}
