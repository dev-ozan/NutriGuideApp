using NutriGuide.DataAccessLayer.Concrets;
using NutriGuide.Entity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriGuide.UI.Forms
{
    public partial class Besinler : Form
    {
        Kullanici _kisi;

        public Besinler(Kullanici kisi)
        {
            InitializeComponent();
            dgvYemekler.ColumnCount = 1;
            dgvYemekler.Columns[0].Name = "Column 1";
            dgvYemekler.Rows.Add( "ad", "\t", "cins", "\t", "protein miktari", "\t", "karbonhidrat miktari", "\t", "Yag miktari", "\t", "Kalorisi", "\t");
            _kisi = kisi;
            using (NutriGuideContext _db = new NutriGuideContext())
            {
                dgvYemekler.DataSource = _db.Foods.ToList();
            }

        }
    }
}
