using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.DataAccessLayer.Migrations
{
    public partial class MigrationChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiyetlerFood_Foods_YemeklerFoodId",
                table: "DiyetlerFood");

            migrationBuilder.DropTable(
                name: "FoodKullanici");

            migrationBuilder.RenameColumn(
                name: "YemeklerFoodId",
                table: "DiyetlerFood",
                newName: "FoodsFoodId");

            migrationBuilder.RenameIndex(
                name: "IX_DiyetlerFood_YemeklerFoodId",
                table: "DiyetlerFood",
                newName: "IX_DiyetlerFood_FoodsFoodId");

            migrationBuilder.AddColumn<int>(
                name: "FoodsId",
                table: "Diyetler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DiyetlerFood_Foods_FoodsFoodId",
                table: "DiyetlerFood",
                column: "FoodsFoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiyetlerFood_Foods_FoodsFoodId",
                table: "DiyetlerFood");

            migrationBuilder.DropColumn(
                name: "FoodsId",
                table: "Diyetler");

            migrationBuilder.RenameColumn(
                name: "FoodsFoodId",
                table: "DiyetlerFood",
                newName: "YemeklerFoodId");

            migrationBuilder.RenameIndex(
                name: "IX_DiyetlerFood_FoodsFoodId",
                table: "DiyetlerFood",
                newName: "IX_DiyetlerFood_YemeklerFoodId");

            migrationBuilder.CreateTable(
                name: "FoodKullanici",
                columns: table => new
                {
                    FoodsFoodId = table.Column<int>(type: "int", nullable: false),
                    KullanicilarKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodKullanici", x => new { x.FoodsFoodId, x.KullanicilarKullaniciId });
                    table.ForeignKey(
                        name: "FK_FoodKullanici_Foods_FoodsFoodId",
                        column: x => x.FoodsFoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodKullanici_Kullanicilar_KullanicilarKullaniciId",
                        column: x => x.KullanicilarKullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodKullanici_KullanicilarKullaniciId",
                table: "FoodKullanici",
                column: "KullanicilarKullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiyetlerFood_Foods_YemeklerFoodId",
                table: "DiyetlerFood",
                column: "YemeklerFoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
