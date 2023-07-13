using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.DataAccessLayer.Migrations
{
    public partial class diyetlerduzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Diyetler_DiyetlerId",
                table: "Kullanicilar");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_DiyetlerId",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Diyetler",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "DiyetlerId",
                table: "Kullanicilar");

            migrationBuilder.CreateTable(
                name: "DiyetlerKullanici",
                columns: table => new
                {
                    DiyetlerId = table.Column<int>(type: "int", nullable: false),
                    KullanicilarKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiyetlerKullanici", x => new { x.DiyetlerId, x.KullanicilarKullaniciId });
                    table.ForeignKey(
                        name: "FK_DiyetlerKullanici_Diyetler_DiyetlerId",
                        column: x => x.DiyetlerId,
                        principalTable: "Diyetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiyetlerKullanici_Kullanicilar_KullanicilarKullaniciId",
                        column: x => x.KullanicilarKullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiyetlerKullanici_KullanicilarKullaniciId",
                table: "DiyetlerKullanici",
                column: "KullanicilarKullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiyetlerKullanici");

            migrationBuilder.AddColumn<string>(
                name: "Diyetler",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiyetlerId",
                table: "Kullanicilar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_DiyetlerId",
                table: "Kullanicilar",
                column: "DiyetlerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Diyetler_DiyetlerId",
                table: "Kullanicilar",
                column: "DiyetlerId",
                principalTable: "Diyetler",
                principalColumn: "Id");
        }
    }
}
