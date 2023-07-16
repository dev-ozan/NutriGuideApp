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
        double toplamKalori = 0;
        double karbonhidrat = 0;
        double protein = 0;
        double yag = 0;
        NutriGuideContext _db = new NutriGuideContext();
        public Besinler(Kullanici kisi)
        {
            InitializeComponent();
            _kisi = kisi;
            Dongu();

            dgvYemekler.DataSource = _db.Foods.ToList();

            //cmbDiyetler.Items.Add("Diyet Secin");
            //cmbDiyetler.SelectedIndex = 0;
            if (_kisi.Diyetler != null)
            {
                foreach (var item in _kisi.Diyetler)
                {
                    cmbDiyetler.Items.Add(item);
                }
            }
            DiyetYemekleriniListele();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DiyetlereYemekEkle();
            DiyetYemekleriniListele();


        }


        private void dgvYemekler_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvYemekler.SelectedRows)
            {
                Food selectedFood = (Food)row.DataBoundItem;
                toplamKalori += selectedFood.Kalorisi;
                karbonhidrat += selectedFood.KarbonhidratMiktari;
                protein += selectedFood.ProteinMiktari;
                yag += selectedFood.YagMiktari;
            }
            lblToplamKalori.Text = toplamKalori.ToString();
            lblKarbonhidrat.Text = string.Format("{0:0.##}", karbonhidrat);
            lblProtein.Text = string.Format("{0:0.##}", protein);
            lblYag.Text = string.Format("{0:0.##}", yag);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {

        }

        private void cmbDiyetler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiyetYemekleriniListele();
        }

        public void Dongu()
        {
            foreach (var item in _db.Diyetler.Where(x => x.KullaniciId == _kisi.KullaniciId).ToList())
            {
                cmbDiyetler.Items.Clear();
                cmbDiyetler.Items.Add(item.DiyetAdi);
            }

        }
        public void DiyetlereYemekEkle()
        {

            //Diyetler diyet = cmbDiyetler.SelectedItem as Diyetler;
            //if (diyet != null)
            //{
            //    string foodName = dgvYemekler.SelectedRows[0].Cells[1].Value.ToString();
            //    foreach (var item in _db.Foods)
            //    {
            //        if (foodName == item.Ad)
            //        {

            //            diyet.Yemekler.Add(item);
            //            _kisi.Diyetler.Add(diyet);

            //            _db.Update(_kisi);
            //            _db.SaveChanges();

            //        }
            //    }
            //}


            var Diyetler = _db.Diyetler.Where(x => x.KullaniciId == _kisi.KullaniciId);

            foreach (var item in Diyetler)
            {

                if (item.DiyetAdi.Contains(cmbDiyetler.SelectedItem.ToString()))
                {
                    string food = dgvYemekler.SelectedRows[0].Cells[1].Value.ToString();
                    foreach (var item1 in _db.Foods)
                    {
                        if (item1.Ad == food)
                        {
                            item.Yemekler.Add(item1);
                            _db.SaveChanges();

                        }
                    }

                }
            }


        }
        public void DiyetYemekleriniListele()
        {
            //Diyetler diyet = cmbDiyetler.SelectedItem as Diyetler;
            //if (diyet != null)
            //{
            //    foreach (var item in _db.Diyetler)
            //    {
            //        if (diyet.KullaniciId == _kisi.KullaniciId && diyet.DiyetAdi == item.DiyetAdi)
            //        {
            //            dgvDiyetYemekleri.DataSource = item.Yemekler.ToList();
            //        }
            //    }
            //}




            var Diyetler = _db.Diyetler.Where(x => x.KullaniciId == _kisi.KullaniciId);
            foreach (var item in Diyetler)
            {
                if (cmbDiyetler.SelectedIndex != -1)
                    if (item.DiyetAdi.Contains(cmbDiyetler.SelectedItem.ToString()))
                    {
                        if (item.DiyetAdi != null)
                            dgvDiyetYemekleri.DataSource = item.DiyetAdi.ToList();
                    }


            }

        }
    }
}
