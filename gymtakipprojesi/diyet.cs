using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gymtakipprojesi
{
    public partial class diyet : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-73KKVUB\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter sda;
        public diyet()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void diyet_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand ("select k.ad_soyad , k.id from kullanici k;  ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = read[0].ToString();
                item.value = read[1].ToString();
                combo_isim.Items.Add(item);
            }
            baglanti.Close();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From diyet d where d.kullanici_id=@kullanici";
            komut = new SqlCommand(sorgu, baglanti);

            string kullanici_id = ((ComboBoxItem)combo_isim.SelectedItem).value.ToString();
            int k_adi = Int32.Parse(kullanici_id);

            komut.Parameters.AddWithValue("@kullanici", k_adi);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                //öğünler
                tb_kahvalti.Text = read[2].ToString();
                tb_kusluk.Text = read[3].ToString();
                tb_ogle.Text = read[4].ToString();
                tb_ikindi.Text = read[5].ToString();
                tb_aksam.Text = read[6].ToString();
                tb_ara.Text = read[7].ToString();

                //öğün saatleri
                //kahvalti saat
                string str_kahvalti = read["kahvalti_saat"].ToString();
                DateTime dt_kahvalti = DateTime.Parse(str_kahvalti);


                t_kahvalti.Value = dt_kahvalti;


                //kusluk saat
                string str_kusluk = read["kusluk_saat"].ToString();
                DateTime dt_kusluk = DateTime.Parse(str_kusluk);
                t_kusluk.Value = dt_kusluk;

                //öğle saat
                string str_ogle = read["ogle_saat"].ToString();
                DateTime dt_ogle = DateTime.Parse(str_ogle);
                t_ogle.Value = dt_ogle;

                //ikindi saat
                string str_ikindi = read["ikindi_saat"].ToString();
                DateTime dt_ikindi = DateTime.Parse(str_ikindi);
                t_ikindi.Value = dt_ikindi;

                //aksam saat
                string str_aksam = read["aksam_saat"].ToString();
                DateTime dt_aksam = DateTime.Parse(str_aksam);
                t_aksam.Value = dt_aksam;

                //ara saat
                string str_ara = read["ara_saat"].ToString();
                DateTime dt_ara = DateTime.Parse(str_ara);
                t_ara.Value = dt_ara;




                //tarihler
                dTP_baslangic.Value = (DateTime)read[14];
                dTP_bitis.Value = (DateTime)read[15];



            }
            baglanti.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO diyet(kullanici_id, kahvalti, kusluk, ogle, ikindi, aksam, ara, kahvalti_saat, kusluk_saat, ogle_saat, ikindi_saat, aksam_saat, ara_saat, baslangic_tarihi, bitis_tarihi ) VALUES (@kullanici_id,@kahvalti, @kusluk, @ogle, @ikindi, @aksam, @ara, @kahvalti_saat, @kusluk_saat, @ogle_saat, @ikindi_saat, @aksam_saat, @ara_saat, @baslangic_tarihi, @bitis_tarihi)";
            komut = new SqlCommand(sorgu, baglanti);
            //kişi
            string kullanici_id = ((ComboBoxItem)combo_isim.SelectedItem).value.ToString();
            komut.Parameters.AddWithValue("@kullanici_id", kullanici_id);
            //kahvaltı
            komut.Parameters.AddWithValue("@kahvalti", tb_kahvalti.Text);
            komut.Parameters.AddWithValue("@kahvalti_saat", t_kahvalti.Value);
            //kuşluk
            komut.Parameters.AddWithValue("@kusluk", tb_kusluk.Text);
            komut.Parameters.AddWithValue("@kusluk_saat", t_kusluk.Value);
            ///öğle
            komut.Parameters.AddWithValue("@ogle", tb_ogle.Text);
            komut.Parameters.AddWithValue("@ogle_saat", t_ogle.Value);
            //ikindi
            komut.Parameters.AddWithValue("@ikindi", tb_ikindi.Text);
            komut.Parameters.AddWithValue("@ikindi_saat", t_ikindi.Value);
            //akşam
            komut.Parameters.AddWithValue("@aksam", tb_aksam.Text);
            komut.Parameters.AddWithValue("@aksam_saat", t_aksam.Value);
            //ara
            komut.Parameters.AddWithValue("@ara", tb_ara.Text);
            komut.Parameters.AddWithValue("@ara_saat", t_ara.Value);
            //başlangıç ve bitiş tarihi
            komut.Parameters.AddWithValue("@baslangic_tarihi", dTP_baslangic.Value);
            komut.Parameters.AddWithValue("@bitis_tarihi", dTP_bitis.Value);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
