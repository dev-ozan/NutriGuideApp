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
    public partial class Profile : Form
    {
        Kullanici _kisi;
        bool hataliGiris = true;
        public Profile(Kullanici kisi)
        {

            InitializeComponent();
            _kisi = kisi;

            dtpDogumTarih.MaxDate = DateTime.Now.AddYears(-18);
            dtpDogumTarih.Value = DateTime.Now.AddYears(-19);
            dtpDogumTarih.MinDate = new DateTime(1908, 1, 1);
            lblKullaniciAd.Text = _kisi.KullaniciAdi;

            txtAd.Text = _kisi.Ad;
            txtSoyad.Text = _kisi.Soyad;
            txtBoy.Text = _kisi.Boyu.ToString();
            txtKilo.Text = _kisi.Kilosu.ToString();
            txtHedefKilo.Text = _kisi.HedefKilosu.ToString();
            dtpDogumTarih.Value = _kisi.DogumTarihi;
            cmbCinsiyet.SelectedItem = _kisi.Cinsiyet;

            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (HataliVeriGirisi())
            {
                using (NutriGuideContext _db = new NutriGuideContext())
                {

                    _kisi.Ad = txtAd.Text.Trim();
                    _kisi.Soyad = txtSoyad.Text.Trim();
                    _kisi.Kilosu = Convert.ToInt32(txtKilo.Text);
                    _kisi.Boyu = Convert.ToInt32(txtBoy.Text);
                    _kisi.DogumTarihi = dtpDogumTarih.Value;
                    _kisi.HedefKilosu = Convert.ToInt32(txtHedefKilo.Text);
                    string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
                    _kisi.Cinsiyet = cinsiyet;
                    MessageBox.Show(_kisi.Ad);
                    MessageBox.Show("Bilgileriniz Başarıyla Güncellendi");
                    _db.Update(_kisi);
                    _db.SaveChanges();

                }
            }
            

           
        }

        private bool HataliVeriGirisi()
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Adınız Boşluklardan Oluşamaz..");
                return false;
            }
            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyadınız Boşluklardan Oluşamaz..");
                return false;
            }
            else if (cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz..");
                return false;
            }
            else if (Convert.ToInt32(txtBoy.Text) > 251 || Convert.ToInt32(txtBoy.Text) < 65)
            {
                MessageBox.Show("Yanlış Boy Aralığı Girdiniz..");
                return false;
            }
            else if (Convert.ToInt32(txtKilo.Text) > 650 || Convert.ToInt32(txtKilo.Text) < 26)
            {
                MessageBox.Show("Yanlış Kilo Aralığı Girdiniz..");
                return false;
            }
            else if (Convert.ToInt32(txtHedefKilo.Text) > 650 || Convert.ToInt32(txtHedefKilo.Text) < 26)
            {
                MessageBox.Show("Yanlış Hedef Kilo Aralığı Girdiniz..");
                return false;
            }
            return true;
        }
    }
}
