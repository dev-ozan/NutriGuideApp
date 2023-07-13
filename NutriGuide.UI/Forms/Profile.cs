using NutriGuide.DataAccessLayer.Concrets;
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
    public partial class Profile : Form
    {
        string _a;
        public Profile(string a)
        {


            InitializeComponent();
            _a = a;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (NutriGuideContext _db = new NutriGuideContext())
            {
                var kisi = _db.Kullanicilar.FirstOrDefault(b => b.KullaniciAdi == _a.ToString());
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.Kilosu = Convert.ToInt32(txtKilo.Text);
                kisi.Boyu = Convert.ToInt32(txtBoy.Text);



                if (cmbCinsiyet.SelectedIndex != -1)
                {
                    string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
                    kisi.Cinsiyet = cinsiyet;
                    _db.SaveChanges();
                }


            }
        }
    }
}
