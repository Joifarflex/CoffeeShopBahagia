using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeCoupon.Migrations
{
    public partial class AddCouponModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(nullable: false),
                    DiscountAmout = table.Column<double>(nullable: false),
                    MinAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "CouponCode", "DiscountAmout", "MinAmount" },
                values: new object[] { 1, "AA01", 1500.0, 65000 });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "CouponCode", "DiscountAmout", "MinAmount" },
                values: new object[] { 2, "BA02", 2000.0, 65000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");
        }
    }
}
