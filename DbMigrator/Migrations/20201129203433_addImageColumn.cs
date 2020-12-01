using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbMigrator.Migrations
{
    public partial class addImageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Product",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Product",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Product",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[] {  });
        }
    }
}
