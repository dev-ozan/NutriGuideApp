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
            label3.Text = a.ToString();
            label4.Text = b.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panelGizlimi == false)
            {
                panel2.Hide();
                for (int i = 258; i >= 70; i--)
                {
                    panel3.Width = i;
                    button5.Width = i + 3;
                }
                panelGizlimi = true;
            }
            else if (panel3.Width == 70)
            {
                panelGizlimi = false;
                for (int i = 70; i <= 258; i++)
                {
                    panel3.Width = i;
                    button5.Width = i;
                }
                button5.Width = button5.Width + 3;
                panel2.Show();
            }
            label2.Text = panel3.Width.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AnaMenu());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Profile());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DietPlani());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
