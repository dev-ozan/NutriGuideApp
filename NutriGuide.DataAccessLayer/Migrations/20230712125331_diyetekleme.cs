using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.DataAccessLayer.Migrations
{
    public partial class diyetekleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Diyetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiyetAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diyetler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiyetlerFood",
                columns: table => new
                {
                    DiyetlerId = table.Column<int>(type: "int", nullable: false),
                    YemeklerFoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiyetlerFood", x => new { x.DiyetlerId, x.YemeklerFoodId });
                    table.ForeignKey(
                        name: "FK_DiyetlerFood_Diyetler_DiyetlerId",
                        column: x => x.DiyetlerId,
                        principalTable: "Diyetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiyetlerFood_Foods_YemeklerFoodId",
                        column: x => x.YemeklerFoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_DiyetlerId",
                table: "Kullanicilar",
                column: "DiyetlerId");

            migrationBuilder.CreateIndex(
                name: "IX_DiyetlerFood_YemeklerFoodId",
                table: "DiyetlerFood",
                column: "YemeklerFoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Diyetler_DiyetlerId",
                table: "Kullanicilar",
                column: "DiyetlerId",
                principalTable: "Diyetler",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Diyetler_DiyetlerId",
                table: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "DiyetlerFood");

            migrationBuilder.DropTable(
                name: "Diyetler");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_DiyetlerId",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Diyetler",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "DiyetlerId",
                table: "Kullanicilar");
        }
    }
}
