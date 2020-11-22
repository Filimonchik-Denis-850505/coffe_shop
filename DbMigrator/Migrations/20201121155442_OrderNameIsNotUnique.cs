using Microsoft.EntityFrameworkCore.Migrations;

namespace DbMigrator.Migrations
{
    public partial class OrderNameIsNotUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_Name",
                table: "Orders");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Product",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Name",
                table: "Orders",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_Name",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Name",
                table: "Orders",
                column: "Name",
                unique: true);
        }
    }
}
