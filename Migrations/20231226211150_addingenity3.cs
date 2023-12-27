using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addingenity3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8cbf103-03f2-4c40-b2a7-2a89b20505f0", "40199964-7852-426c-a256-380c9695d2b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdae8dd4-9721-4131-bde0-2d65283b8c71", "e2c9e32d-807b-426b-bec9-623a6817c172" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c7a23f9-47de-4d69-9687-bedbc9762f7d", "bf4bfd92-9d2f-4523-8856-9e02c2bd804f" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 6, "Want to bake the most-awesome-ever cupcakes? Or surprise your family with breakfast tacos on Sunday morning? Looking for a quick snack after school? Or maybe something special for a sleepover? It's all here. Learn to cook like a pro―it's easier than you think.", "https://m.media-amazon.com/images/I/91GqAI8VDUL._SY425_.jpg", 19.989999999999998, "The Complete Cookbook for Young Chefs" },
                    { 7, "A decade-by-decade cookbook that highlights the best (and a few of the worst) baking recipes from the 20th century", "https://m.media-amazon.com/images/I/81o-PyNHxbL._SL1500_.jpg", 29.989999999999998, "Baking Yesteryear" },
                    { 8, "Known for her incredibly approachable, slimmed-down, and outrageously delicious recipes, Erin Clarke is the creator of the smash-hit food blog in the healthy-eating blogosphere, Well Plated by Erin. Clarke's site welcomes millions of readers, and with good reason: Her recipes are fast, budget-friendly, and clever; she never includes an ingredient you can't find in a regular supermarket or that isn't essential to a dish's success, and she hacks her recipes for maximum nutrition by using the \"stealthy healthy\" ingredient swaps she's mastered so that you don't lose an ounce of flavor.", "https://m.media-amazon.com/images/I/91mis0XfORL._SL1500_.jpg", 16.989999999999998, "Snoop Dogg Presents Goon with the Spoon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

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
    }
}
