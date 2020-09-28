using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocoloko.Storing.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Beverage",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Beverage",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "http://placecorgi.com/260/180");

            migrationBuilder.UpdateData(
                table: "Beverage",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "http://placecorgi.com/260/180");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Beverage");
        }
    }
}
