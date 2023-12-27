using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addingenity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Known for her incredibly approachable, slimmed-down, and outrageously delicious recipes, Erin Clarke is the creator of the smash-hit food blog in the healthy-eating blogosphere, Well Plated by Erin. Clarke's site welcomes millions of readers, and with good reason: Her recipes are fast, budget-friendly, and clever; she never includes an ingredient you can't find in a regular supermarket or that isn't essential to a dish's success, and she hacks her recipes for maximum nutrition by using the \"stealthy healthy\" ingredient swaps she's mastered so that you don't lose an ounce of flavor.", "https://m.media-amazon.com/images/I/91aPyBeX1-L._AC._SR360,460.jpg", 19.989999999999998, "The Well Plated Cookbook: Fast, Healthy Recipes You'll Want to Eat" },
                    { 2, "NEW YORK TIMES BESTSELLER • An inviting collection of more than 100 trusted, budget-friendly recipes for every meal and occasion from the creator of the wildly popular website Natasha’s Kitchen.\r\n\r\n“With delicious recipes and fun entertaining ideas, you’ll find inspiration and joy on every page.”—Jennifer Segal, author and creator of Once Upon a Chef", "https://m.media-amazon.com/images/I/81GpdYtKWrL._SY425_.jpg", 24.989999999999998, "Natasha's Kitchen: 100+ Easy Family-Favorite Recipes You'll Make Again and Again: A Cookbook" },
                    { 3, "Even Ina Garten, America's most-trusted and beloved home cook, sometimes finds cooking stressful. To make life easy she relies on a repertoire of recipes that she knows will turn out perfectly every time. Cooking night after night during the pandemic inspired her to re-think the way she approached dinner, and the result is this collection of comforting and delicious recipes that you’ll love preparing and serving. You’ll find lots of freeze-ahead, make-ahead, prep-ahead, and simply assembled recipes so you, too, can make dinner a breeze.", "https://m.media-amazon.com/images/I/813lOCfitDL._SY425_.jpg", 14.99, "Go-To Dinners: A Barefoot Contessa Cookbook" },
                    { 4, "What does comfort mean in The Comfortable Kitchen? ForAlex Snodgrass, New York Times bestselling author of The Defined Dish, bringing her family around the table to share a home-cooked meal is a favorite way to show love. Her recipes are designed to bring joy into that display of affection, from your own comfort cooking to your loved ones’ delight at the delicious flavors, to knowing that you’re caring for your family’s nutrition with each bite.", "https://m.media-amazon.com/images/I/818ZASRQ3uL._SY425_.jpg", 29.989999999999998, "The Comfortable Kitchen: 105 Laid-Back, Healthy, and Wholesome Recipes (A Defined Dish Book) " },
                    { 5, "Alex Snodgrass of TheDefinedDish.com is the third author in the popular Whole30 Endorsed series. With gluten-free, dairy-free, and grain-free recipes that sound and look way too delicious to be healthy, this is a cookbook people can turn to after completing a Whole30, when they’re looking to reintroduce healthful ingredients like tortillas, yogurt, beans, and legumes. Recipes like Chipotle Chicken Tostadas with Pineapple Salsa or Black Pepper Chicken are easy enough to prepare even after a busy day at work. There are no esoteric ingredients in these recipes, but instead something to suit every taste, each dish clearly marked if it is Whole30 compliant, paleo, gluten-free, dairy-free, and more. Alex includes delicious variations, too, such as using lettuce wraps instead of taco shells, to ensure recipes can work for almost any diet. And for anyone looking to stick to their Whole30 for longer, at least sixty of the recipes are fully compliant.", "https://m.media-amazon.com/images/I/71es0sIm5jL._SY425_.jpg", 34.990000000000002, "The Defined Dish: Whole30 Endorsed, Healthy and Wholesome Weeknight Recipes (A Defined Dish Book)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

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
    }
}
