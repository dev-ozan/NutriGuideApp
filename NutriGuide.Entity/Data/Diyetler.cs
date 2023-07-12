using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGuide.Entity.Data
{
    public class Diyetler
    {
        public int Id { get; set; }
        public string? DiyetAdi { get; set; }
        public List<Kullanici> Kullanicilar { get; set; } = new();
        public List<Food> Yemekler { get; set; } = new();

    }
}
