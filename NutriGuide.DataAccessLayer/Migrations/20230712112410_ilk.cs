using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.DataAccessLayer.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cins = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false),
                    Kalorisi = table.Column<double>(type: "float", nullable: false),
                    KullaniciTipi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kilosu = table.Column<int>(type: "int", nullable: false),
                    Boyu = table.Column<int>(type: "int", nullable: false),
                    HedefKilosu = table.Column<int>(type: "int", nullable: false),
                    KullaniciTipi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciId);
                });

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

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Ad", "Cins", "Kalorisi", "KarbonhidratMiktari", "KullaniciTipi", "ProteinMiktari", "YagMiktari" },
                values: new object[,]
                {
                    { 1, "Elma", "Meyve", 52.0, 13.800000000000001, 0, 0.29999999999999999, 0.40000000000000002 },
                    { 2, "Muz", "Meyve", 96.0, 22.0, 0, 1.1000000000000001, 0.20000000000000001 },
                    { 3, "Tavuk Göğsü", "Et", 95.0, 0.0, 0, 20.800000000000001, 1.3999999999999999 },
                    { 4, "Patates", "Sebze", 77.0, 17.5, 0, 2.0, 0.10000000000000001 },
                    { 5, "Somon Balığı", "Balık", 206.0, 0.0, 0, 20.399999999999999, 6.5999999999999996 },
                    { 6, "Ekmek", "Tahıl", 265.0, 49.0, 0, 8.0999999999999996, 1.0 },
                    { 7, "Yoğurt", "Süt Ürünü", 61.0, 4.7000000000000002, 0, 3.5, 3.2999999999999998 },
                    { 8, "Brokoli", "Sebze", 31.0, 6.0, 0, 2.7999999999999998, 0.40000000000000002 },
                    { 9, "Kırmızı Et", "Et", 250.0, 0.0, 0, 26.0, 17.0 },
                    { 10, "Marul", "Sebze", 14.0, 2.2000000000000002, 0, 1.2, 0.20000000000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodKullanici_KullanicilarKullaniciId",
                table: "FoodKullanici",
                column: "KullanicilarKullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodKullanici");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
