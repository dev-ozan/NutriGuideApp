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
        Kullanici _kisi;
        NutriGuideContext db = new();
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
            cmbDiyetler.Items.Clear();
            Diyetler diyet = new Diyetler();
            diyet.DiyetAdi = txtDiyetIsmi.Text;
            diyet.KullaniciId = _kisi.KullaniciId;
            _kisi.Diyetler.Add(diyet);
            db.Kullanicilar.Update(_kisi);
            db.SaveChanges();
            Dongu();

        }
        public void Dongu()
        {
            foreach (var item in db.Diyetler.Where(x => x.KullaniciId == _kisi.KullaniciId).ToList())
            {
                cmbDiyetler.Items.Add(item.DiyetAdi);
            }
            
        }
        
    }
}
