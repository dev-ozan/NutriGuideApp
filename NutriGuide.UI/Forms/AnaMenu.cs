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
        public AnaMenu(Kullanici kisi)
        {
            
            InitializeComponent();
            using (NutriGuideContext _db = new NutriGuideContext())
            {
                _kisi = kisi;
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
