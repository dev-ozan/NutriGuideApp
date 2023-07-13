using NutriGuide.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGuide.Entity.Data
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciPassword { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime DietBaslamaTarihi { get; set; }
        public DateTime DietBitisTarihi { get; set; }
        public int Kilosu { get; set; } = 0;
        public int Boyu { get; set; } = 0;
        public int HedefKilosu { get; set; } = 0;
        public KullaniciTipi KullaniciTipi { get; set; }
        public List<Diyetler> Diyetler { get; set; } = new();

        public List<Food> Foods { get; set; } = new();

    }
}
