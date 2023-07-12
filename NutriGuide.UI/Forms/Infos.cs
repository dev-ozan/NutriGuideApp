using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriGuide.UI.Forms
{
    public partial class Infos : Form
    {
        public Infos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/dev-ozan";  // Replace with your desired link
            Process.Start("explorer.exe", url);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Ewdod";  // Replace with your desired link
            Process.Start("explorer.exe", url);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/SinanTsy";  // Replace with your desired link
            Process.Start("explorer.exe", url);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/dev-ozan/";  // Replace with your desired link
            Process.Start("explorer.exe", url);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/batuhan-haybek-192680223/";  // Replace with your desired link
            Process.Start("explorer.exe", url);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/sinan-taşyapar-85116a16a";  // Replace with your desired link
            Process.Start("explorer.exe", url);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/SinanTsy/NutriGuideApp";  // Replace with your desired link
            Process.Start("explorer.exe", url);
        }
    }
}
