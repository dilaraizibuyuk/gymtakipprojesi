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
using System.Text.RegularExpressions;

namespace gymtakipprojesi
{
    public partial class kullaniciListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-73KKVUB\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter sda;
        public kullaniciListele()
        {
            InitializeComponent();
        }


        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_mail_TextChanged(object sender, EventArgs e)
        {

        }
        void kullanici_Listele()
        {
            baglanti.Open();
            sda = new SqlDataAdapter("Select * from kullanici ",baglanti );
            DataTable tablo = new DataTable();
            sda.Fill(tablo);
            dGV1.DataSource = tablo;
            baglanti.Close();


        }

        private void kullaniciListele_Load(object sender, EventArgs e)
        {
            kullanici_Listele();
        }

        private void dGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dGV1.CurrentRow.Cells[0].Value.ToString();
            tb_adSoyad.Text = dGV1.CurrentRow.Cells[1].Value.ToString();
            tb_mail.Text = dGV1.CurrentRow.Cells[2].Value.ToString();
            tb_parola.Text = dGV1.CurrentRow.Cells[3].Value.ToString();
            tb_telefon.Text = dGV1.CurrentRow.Cells[6].Value.ToString();
        }

        private void tb_telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex R = new Regex(@"^[0-9]{9}");
            bool isValid = R.IsMatch(tb_telefon.Text);
            if (!isValid)
            {
                lbl_uyari.Text = "Uygun Değildir.";
                lbl_uyari.ForeColor = Color.Red;

            }
            else
            {
                lbl_uyari.Text = "Uygundur.";
                lbl_uyari.ForeColor = Color.Green;
            }

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                string sorgu = "Delete from kullanici where id=@id";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(tb_id.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                kullanici_Listele();
            }
           
        }

        private void tb_adSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE kullanici set ad_soyad=@ad_soyad,mail=@mail,parola=@parola,telefon=@telefon where id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(tb_id.Text));
            komut.Parameters.AddWithValue("@ad_soyad", tb_adSoyad.Text);
            komut.Parameters.AddWithValue("@mail", tb_mail.Text);
            komut.Parameters.AddWithValue("@parola", tb_parola.Text);
            komut.Parameters.AddWithValue("@telefon", tb_telefon.Text);
            baglanti.Open();

            komut.ExecuteNonQuery();
            baglanti.Close();
            kullanici_Listele();
          
        }
    }
}
