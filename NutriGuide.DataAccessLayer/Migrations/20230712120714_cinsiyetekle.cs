using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.DataAccessLayer.Migrations
{
    public partial class cinsiyetekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "Kullanicilar");
        }
    }
}
