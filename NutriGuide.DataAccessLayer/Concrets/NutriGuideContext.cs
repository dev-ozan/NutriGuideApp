using Microsoft.EntityFrameworkCore;
using NutriGuide.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGuide.DataAccessLayer.Concrets
{
    public class NutriGuideContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Diyetler> Diyetler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;database=NutriGuideDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    FoodId = 1,
                    Ad = "Elma",
                    Cins = "Meyve",
                    ProteinMiktari = 0.3,
                    KarbonhidratMiktari = 13.8,
                    YagMiktari = 0.4,
                    Kalorisi = 52
                },
                new Food
                {
                    FoodId = 2,
                    Ad = "Muz",
                    Cins = "Meyve",
                    ProteinMiktari = 1.1,
                    KarbonhidratMiktari = 22,
                    YagMiktari = 0.2,
                    Kalorisi = 96
                },
                new Food
                {
                    FoodId = 3,
                    Ad = "Tavuk Göğsü",
                    Cins = "Et",
                    ProteinMiktari = 20.8,
                    KarbonhidratMiktari = 0,
                    YagMiktari = 1.4,
                    Kalorisi = 95
                },
                new Food
                {
                    FoodId = 4,
                    Ad = "Patates",
                    Cins = "Sebze",
                    ProteinMiktari = 2,
                    KarbonhidratMiktari = 17.5,
                    YagMiktari = 0.1,
                    Kalorisi = 77
                },
                new Food
                {
                    FoodId = 5,
                    Ad = "Somon Balığı",
                    Cins = "Balık",
                    ProteinMiktari = 20.4,
                    KarbonhidratMiktari = 0,
                    YagMiktari = 6.6,
                    Kalorisi = 206
                },
                new Food
                {
                    FoodId = 6,
                    Ad = "Ekmek",
                    Cins = "Tahıl",
                    ProteinMiktari = 8.1,
                    KarbonhidratMiktari = 49,
                    YagMiktari = 1,
                    Kalorisi = 265
                },
                new Food
                {

                    FoodId = 7,
                    Ad = "Yoğurt",
                    Cins = "Süt Ürünü",
                    ProteinMiktari = 3.5,
                    KarbonhidratMiktari = 4.7,
                    YagMiktari = 3.3,
                    Kalorisi = 61
                },
                new Food
                {
                    FoodId = 8,
                    Ad = "Brokoli",
                    Cins = "Sebze",
                    ProteinMiktari = 2.8,
                    KarbonhidratMiktari = 6,
                    YagMiktari = 0.4,
                    Kalorisi = 31
                },
                new Food
                {
                    FoodId = 9,
                    Ad = "Kırmızı Et",
                    Cins = "Et",
                    ProteinMiktari = 26,
                    KarbonhidratMiktari = 0,
                    YagMiktari = 17,
                    Kalorisi = 250
                },
                new Food
                {
                    FoodId = 10,
                    Ad = "Marul",
                    Cins = "Sebze",
                    ProteinMiktari = 1.2,
                    KarbonhidratMiktari = 2.2,
                    YagMiktari = 0.2,
                    Kalorisi = 14
                }
                // Diğer yiyecek örneklerini buraya ekleyebilirsiniz
            );
        }

    }
}
