using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.DataAccessLayer.Migrations
{
    public partial class MigrationChanged2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodsId",
                table: "Diyetler");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Diyetler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodsId",
                table: "Diyetler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Diyetler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
