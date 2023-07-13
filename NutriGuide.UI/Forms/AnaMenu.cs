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
        public AnaMenu(string a)
        {
            InitializeComponent();
            using (NutriGuideContext _db = new NutriGuideContext())
            {
                var kisi = _db.Kullanicilar.FirstOrDefault(b => b.KullaniciAdi == a.ToString());
                lblKullaniciAd.Text = kisi.KullaniciAdi.ToString();
                lblAdSoyad.Text = kisi.Ad + " " + kisi.Soyad;
                if (kisi.Cinsiyet == "Erkek")
                    pictureBox1.Image = Properties.Resources.man;
                else if (kisi.Cinsiyet == "Kadın")
                    pictureBox1.Image = Properties.Resources.woman;
                else
                    pictureBox1.Image = Properties.Resources.userDefault;
            }
        }
    }
}
