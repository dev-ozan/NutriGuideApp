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


            dgvYemekler.DataSource = _db.Foods.ToList();

            cmbDiyetler.Items.Add("Diyet Secin");
            cmbDiyetler.SelectedIndex = 0;
            if (_kisi.Diyetler != null)
            {
                foreach (var item in _kisi.Diyetler)
                {
                    cmbDiyetler.Items.Add(item);
                }
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvYemekler.SelectedRows)
            {
                Food selectedFood = (Food)row.DataBoundItem;
                _kisi.Foods.Add(selectedFood);
                _db.Update(_kisi);
                _db.SaveChanges();
            }


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
            dgvDiyetYemekleri.DataSource = cmbDiyetler.SelectedItem;
        }
    }
}
