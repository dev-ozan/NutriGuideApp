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
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime DietBaslamaTarihi { get; set; }
        public DateTime DietBitisTarihi { get; set; }
        public int Kilosu { get; set; }
        public int Boyu { get; set; }
        public int HedefKilosu { get; set; }
        public KullaniciTipi KullaniciTipi { get; set; }


        public List<Food> Foods { get; set; } = new();

    }
}
