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
            dtpDogumTarih.MaxDate = DateTime.Now.AddYears(-18);
            dtpDogumTarih.MinDate = new DateTime(1908, 1, 1);
            lblKullaniciAd.Text = _a;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            HataliVeriGirisi();

            using (NutriGuideContext _db = new NutriGuideContext())
            {
                var kisi = _db.Kullanicilar.FirstOrDefault(b => b.KullaniciAdi == _a.ToString());
                kisi.Ad = txtAd.Text.Trim();
                kisi.Soyad = txtSoyad.Text.Trim();
                kisi.Kilosu = Convert.ToInt32(txtKilo.Text);
                kisi.Boyu = Convert.ToInt32(txtBoy.Text);

                if (cmbCinsiyet.SelectedIndex != -1)
                {
                    string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
                    kisi.Cinsiyet = cinsiyet;
                    MessageBox.Show("Bilgileriniz Başarıyla Güncellendi");
                    _db.SaveChanges();
                }
            }
        }

        private void HataliVeriGirisi()
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Adınız Boşluklardan Oluşamaz..");
                return;
            }
            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyadınız Boşluklardan Oluşamaz..");
                return;
            }
            else if (cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz..");
                return;
            }
            else if (Convert.ToInt32(txtBoy.Text) > 251 || Convert.ToInt32(txtBoy.Text) < 65)
            {
                MessageBox.Show("Yanlış Boy Aralığı Girdiniz..");
                return;
            }
            else if (Convert.ToInt32(txtKilo.Text) > 650 || Convert.ToInt32(txtKilo.Text) < 26)
            {
                MessageBox.Show("Yanlış Kilo Aralığı Girdiniz..");
                return;
            }
            else if (Convert.ToInt32(txtHedefKilo.Text) > 650 || Convert.ToInt32(txtHedefKilo.Text) < 26)
            {
                MessageBox.Show("Yanlış Hedef Kilo Aralığı Girdiniz..");
                return;
            }
        }
    }
}
