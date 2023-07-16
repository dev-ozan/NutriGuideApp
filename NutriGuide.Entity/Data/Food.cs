using NutriGuide.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGuide.Entity.Data
{
    public class Food
    {
        public int FoodId { get; set; }
        public string? Ad { get; set; }
        public string? Cins { get; set; }
        public double ProteinMiktari { get; set; }
        public double KarbonhidratMiktari { get; set; }
        public double YagMiktari { get; set; }
        public double Kalorisi { get; set; }
        
        public List<Diyetler> Diyetler { get; set; } = new();
        public override string ToString()
        {
            return Ad;
        }
    }
}
