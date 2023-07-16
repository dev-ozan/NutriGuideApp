using Microsoft.EntityFrameworkCore;
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
    public partial class DietPlani : Form
    {
        NutriGuideContext _db = new NutriGuideContext();
        Kullanici _kisi;
        public DietPlani(Kullanici kisi)
        {
            InitializeComponent();
            _kisi = kisi;
            Dongu();
            dtpBaslama.MinDate = DateTime.Now;
        }



        private void dtpBaslama_ValueChanged(object sender, EventArgs e)
        {
            dtpBitis.MinDate = dtpBaslama.Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Diyetler d1 = new Diyetler();
            d1.DiyetAdi = txtDiyetIsmi.Text;
            _kisi.Diyetler.Add(d1);
            _db.Update(_kisi);
            _db.SaveChanges();
            Dongu();
        }
        public void Dongu()
        {
            cmbDiyetler.DataSource = null;
            cmbDiyetler.DataSource = _db.Diyetler.Where(x => x.Kullanicilar.Any(k => k.KullaniciId == _kisi.KullaniciId)).ToList();
        }

    }
}
