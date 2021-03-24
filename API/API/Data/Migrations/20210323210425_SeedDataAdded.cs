using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "ProductCode", "ProductName", "ReleaseDate", "StarRating" },
                values: new object[,]
                {
                    { 1, "Leaf rake with 48-inch wooden handle.", "../assets/images/leaf_rake.png", 19.949999999999999, "GDN-0011", "Leaf Rake", "March 19, 2019", 3.2000000000000002 },
                    { 2, "15 gallon capacity rolling garden cart", "../assets/images/garden_cart.png", 32.990000000000002, "GDN-0023", "Garden Cart", "March 18, 2019", 4.2000000000000002 },
                    { 5, "Curved claw steel hammer", "../assets/images/hammer.png", 8.9000000000000004, "TBX-0048", "Hammer", "May 21, 2019", 4.7999999999999998 },
                    { 8, "15-inch steel blade hand saw", "../assets/images/saw.png", 11.550000000000001, "TBX-0022", "Saw", "May 15, 2019", 3.7000000000000002 },
                    { 10, "Standard two-button video game controller", "../assets/images/xbox-controller.png", 35.950000000000003, "GMG-0042", "Video Game Controller", "October 15, 2018", 4.5999999999999996 }
                });
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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);
        }
    }
}
