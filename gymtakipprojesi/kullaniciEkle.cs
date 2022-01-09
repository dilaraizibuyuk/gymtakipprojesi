using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace gymtakipprojesi
{
    public partial class kullaniciEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-73KKVUB\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter sda;
        public kullaniciEkle()
        {
            InitializeComponent();
        }

        private void btn_uret_Click(object sender, EventArgs e)
        {
            int minL = 8;
            int maxL = 12;

            string charAvaliable = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ0123456789";

            StringBuilder pw = new StringBuilder();
            Random rdm = new Random();

            int pwLength = rdm.Next(minL, maxL + 1);
            while(pwLength-- > 0)
            {
                pw.Append(charAvaliable[rdm.Next(charAvaliable.Length)]);
            }

            tb_parola.Text = pw.ToString();
        }

        private void kullaniciEkle_Load(object sender, EventArgs e)
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

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            TimeSpan fark;
            fark = DateTime.Parse(dTP2.Text) - DateTime.Parse(dTP1.Text);
            string sonuc = fark.TotalDays.ToString();
            lbl_gun.Text = sonuc;

            int gun = Int32.Parse(sonuc);

            if (tb_adSoyad.Text== "" || tb_mail.Text=="" || tb_parola.Text=="" || tb_telefon.Text=="")
            {
                MessageBox.Show("Boş Yer Bırakılamaz..");

            }

            else if (gun <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tarih girin..");
            }


            
            else
            {
                string sorgu = "INSERT INTO kullanici(ad_soyad,mail,parola,kayit_baslama,kayit_bitis,telefon) VALUES (@ad_soyad,@mail,@parola,@kayit_baslama,@kayit_bitis,@telefon) ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad_soyad", tb_adSoyad.Text);
                komut.Parameters.AddWithValue("@mail", tb_mail.Text);
                komut.Parameters.AddWithValue("@parola", tb_parola.Text);
                komut.Parameters.AddWithValue("@telefon", tb_telefon.Text);
                komut.Parameters.AddWithValue("@kayit_baslama", dTP1.Value);
                komut.Parameters.AddWithValue("@kayit_bitis", dTP2.Value);
                baglanti.Open();
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Bilgiler Tamamdır..");
            }


        }

        private void NewMethod()
        {
            baglanti.Open();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
