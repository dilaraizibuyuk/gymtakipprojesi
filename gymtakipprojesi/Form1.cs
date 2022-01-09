using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gymtakipprojesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-73KKVUB\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        private void btn_giris_Click(object sender, EventArgs e)
        {  
            if(tb_mail.Text ==""|| tb_sifre.Text =="")
            {
                MessageBox.Show("Lütfem Tüm Alanları Doldurunuz.");
            }
            else
            {
                string sorgu = "Select * from yonetici where kullanici_adi ='"+tb_mail.Text.Trim()+"' and sifre ='"+tb_sifre.Text.Trim()+"'";
                SqlDataAdapter dataA = new SqlDataAdapter(sorgu, bagla);
                DataTable dtbl = new DataTable();
                dataA.Fill(dtbl);
                if(dtbl.Rows.Count == 1)
                {
                    AnaMenu ac = new AnaMenu();
                    //this.Close();
                    ac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Bilgiler Hatalı");
                }
            }
            
        }

        private void tb_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) { 
   
        }
    }
}
