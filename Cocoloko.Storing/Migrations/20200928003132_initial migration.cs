using Microsoft.EntityFrameworkCore.Migrations;

namespace Cocoloko.Storing.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beverage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beverage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beverage_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    BeverageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredient_Beverage_BeverageId",
                        column: x => x.BeverageId,
                        principalTable: "Beverage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Beverage",
                columns: new[] { "Id", "Name", "Price", "UserId" },
                values: new object[] { 1, "irish car bomb", 8.5, null });

            migrationBuilder.InsertData(
                table: "Beverage",
                columns: new[] { "Id", "Name", "Price", "UserId" },
                values: new object[] { 2, "jaggerbomb", 7.0, null });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "BeverageId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "baileys", 1.5 },
                    { 2, 1, "guinness", 5.0 },
                    { 3, 1, "jameson", 2.0 },
                    { 4, 2, "jagger", 4.0 },
                    { 5, 2, "red bull", 3.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beverage_UserId",
                table: "Beverage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BeverageId",
                table: "Ingredient",
                column: "BeverageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Beverage");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
