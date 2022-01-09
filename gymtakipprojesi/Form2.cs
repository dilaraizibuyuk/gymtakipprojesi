using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymtakipprojesi
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            kullaniciEkle ac = new kullaniciEkle();
            ac.ShowDialog();
        }

        private void btn_kListele_Click(object sender, EventArgs e)
        {
            kullaniciListele ac = new kullaniciListele();
            ac.ShowDialog();
        }

        private void btn_egzersiz_Click(object sender, EventArgs e)
        {
            egzersiz ac = new egzersiz();
            ac.ShowDialog();
        }

        private void btn_diyet_Click(object sender, EventArgs e)
        {
            diyet ac = new diyet();
            ac.ShowDialog();
        }
    }
}
