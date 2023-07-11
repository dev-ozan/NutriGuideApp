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
        public MainMenu()
        {
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (panelGizlimi == false)
            {

                panel2.Hide();
                panelGizlimi = true;
                for (int i = 257; i > 109; i--)
                {
                    Thread.Sleep(0);
                    panel3.Width = i;
                    label1.Width = i;
                }
                
            }
            else
            {
                panel2.Show();
                panelGizlimi = false;
                panel3.Width = 257;
                label1.Width = 257;

            }

        }
    }
}
