using Microsoft.EntityFrameworkCore.Migrations;

namespace restaurant.ProductAPI.Migrations
{
    public partial class seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Electronics", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!", "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/images.jpg", "Samsung", 150.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, "Fashion", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!", "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/d0dc9d33e87883dba9ba2e115cdc7abce289f18c.webp", "School bag", 50.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "Fashion", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!", "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/product-jpeg-500x500.webp", "Snickers", 250.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
