using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeCustomer.Migrations
{
    public partial class AddCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    TotalAmout = table.Column<double>(nullable: false),
                    CouponId = table.Column<int>(nullable: false),
                    CouponCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CouponCode", "CouponId", "CustomerName", "MobileNumber", "TotalAmout" },
                values: new object[] { 1, null, 0, "Aaron", "053166778990", 100000.0 });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CouponCode", "CouponId", "CustomerName", "MobileNumber", "TotalAmout" },
                values: new object[] { 2, null, 0, "Sarai", "051798822001", 610000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
