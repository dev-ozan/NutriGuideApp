using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriGuide.UI
{
    public partial class MainMenu : Form
    {
        bool panelGizlimi = false;
        Form activeForm;
        public MainMenu(string a, string b)
        {
            InitializeComponent();
            lblKullaniciAd.Text = a.ToString();
            lblSaat.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AnaMenu());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Profile());
        }

        private void btnDiyetPlan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DietPlani());
        }

        private void btnYemekler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Besinler());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Infos());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString();
        }

        private void btnMenuSide_Click(object sender, EventArgs e)
        {
            if (panelGizlimi == false)
            {
                panel2.Hide();
                for (int i = 258; i >= 70; i--)
                {
                    panel3.Width = i;
                    btnMenuSide.Width = i + 3;
                }
                panelGizlimi = true;
            }
            else if (panel3.Width == 70)
            {
                panelGizlimi = false;
                for (int i = 70; i <= 258; i++)
                {
                    panel3.Width = i;
                    btnMenuSide.Width = i;
                }
                btnMenuSide.Width = btnMenuSide.Width + 3;
                panel2.Show();
            }
        }
    }
}
