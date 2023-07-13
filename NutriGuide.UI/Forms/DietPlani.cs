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
    public partial class DietPlani : Form
    {
        Kullanici _kisi;
        public DietPlani(Kullanici kisi)
        {
            InitializeComponent();
            _kisi = kisi;

            dtpBaslama.MinDate = DateTime.Now;
        }

        private void dtpBaslama_ValueChanged(object sender, EventArgs e)
        {
            dtpBitis.MinDate = dtpBaslama.Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _kisi.Diyetler.
        }
    }
}
