using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoomZone.Migrations
{
    public partial class ProductTableDiscountRowAddNullbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Discount",
                table: "Products",
                nullable: true,
                oldClrType: typeof(byte));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Discount",
                table: "Products",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);
        }
    }
}
