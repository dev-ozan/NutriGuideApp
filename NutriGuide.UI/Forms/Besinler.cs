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
        public Besinler(Kullanici kisi)
        {
            InitializeComponent();
            _kisi = kisi;
            using(NutriGuideContext _db = new NutriGuideContext())
            {

            }
            
        }
    }
}
