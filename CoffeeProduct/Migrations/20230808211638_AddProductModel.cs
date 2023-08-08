using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeProduct.Migrations
{
    public partial class AddProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: false),
                    ProductPrice = table.Column<double>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "ImageUrl", "ProductName", "ProductPrice" },
                values: new object[] { 1, "Raw", "https://placehold.co/603x403", "BrazilianCoffee", 80000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "ImageUrl", "ProductName", "ProductPrice" },
                values: new object[] { 2, "Raw", "https://placehold.co/602x402", "JavaCoffee", 55000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
