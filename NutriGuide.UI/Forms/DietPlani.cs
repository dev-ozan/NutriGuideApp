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
    public partial class DietPlani : Form
    {
        string _a;
        public DietPlani(string a)
        {
            InitializeComponent();
            _a = a;
            dtpBaslama.MinDate = DateTime.Now;          
        }

        private void dtpBaslama_ValueChanged(object sender, EventArgs e)
        {
            dtpBitis.MinDate = dtpBaslama.Value;
        }
    }
}
