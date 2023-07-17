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
    public partial class AnaMenu : Form
    {
        Kullanici _kisi;
        NutriGuideContext _db = new NutriGuideContext();
        List<Food> Fooods = new();
        double miktar = 0;


        public AnaMenu(Kullanici kisi)
        {
            _kisi = kisi;


            InitializeComponent();
            FoodEkle();

            lblKullaniciAd.Text = kisi.KullaniciAdi.ToString();
            lblAdSoyad.Text = kisi.Ad + " " + kisi.Soyad;
            if (kisi.Cinsiyet == "Erkek")
                pictureBox1.Image = Properties.Resources.man;
            else if (kisi.Cinsiyet == "Kadın")
                pictureBox1.Image = Properties.Resources.woman;
            else
                pictureBox1.Image = Properties.Resources.userDefault;

        }
        void FoodEkle()
        {

            lstTuketilenler.DisplayMember = "Ad";
            var KullaniciId = _kisi.KullaniciId;
            var Foods = _db.Foods.Where(x => x.Diyetler.Any(k => k.Kullanicilar.Any(s => s.KullaniciId == _kisi.KullaniciId)));


            foreach (var item in Foods)
            {
                lstTuketilenler.Items.Add(item.Ad);
                miktar += item.Kalorisi;


            }
            label3.Text = miktar.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
