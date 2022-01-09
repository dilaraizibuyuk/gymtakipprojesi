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
    public partial class egzersiz : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-73KKVUB\\SQLEXPRESS; Initial Catalog = GYM; Integrated Security = True");
        SqlCommand komut;
        SqlDataAdapter sda;
        public egzersiz()
        {
            InitializeComponent();
        }

        void kullanici_Listele()
        {
            baglanti.Open();

            string kullanici_id = ((ComboBoxItem)combo_isim.SelectedItem).value.ToString();
            int k_adi = Int32.Parse(kullanici_id);
            sda = new SqlDataAdapter("select * from egzersiz_programi d where d.kisi_id=" + k_adi + "", baglanti);

            DataTable tablo = new DataTable();
            sda.Fill(tablo);
            dGV.DataSource = tablo;
            baglanti.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void egzersiz_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select k.ad_soyad,k.id from kullanici k;", baglanti);
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
            string sorgu = "Select * From egzersizler Where egzersiz_index=@index";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@index", cb_bolge.SelectedIndex);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();
            cb_hareketler.Items.Clear();
            while (read.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = read[1].ToString();
                item.value = read[3].ToString();
                cb_hareketler.Items.Add(item.ToString());


            }
            baglanti.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO egzersiz_programi(kisi_id,gun,bolge,hareket,set_sayisi,tekrar) VALUES (@kisi_id,@gun,@bolge,@hareket,@set_sayisi,@tekrar)";
            komut = new SqlCommand(sorgu, baglanti);

            string kullanici_id = ((ComboBoxItem)combo_isim.SelectedItem).value.ToString();
            int k_adi = Int32.Parse(kullanici_id);

            komut.Parameters.AddWithValue("@kisi_id", k_adi);

            int gun = int.Parse(cb_gun.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@gun", gun);

            komut.Parameters.AddWithValue("@bolge", cb_bolge.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@hareket", cb_hareketler.SelectedItem.ToString());

            int set = int.Parse(cb_set.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@set_sayisi", set);

            int tekrar = int.Parse(cb_tekrar.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@tekrar", tekrar);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kullanici_Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_Listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Güncellemeyi Onaylıyor Musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                string sorgu = "UPDATE egzersiz_programi SET gun=@gun, bolge=@bolge, hareket=@hareket, set_sayisi=@set_sayisi, tekrar=@tekrar WHERE id=@id";
                komut = new SqlCommand(sorgu, baglanti);

                string kullanici_id = tb_id.Text;
                int k_adi = Int32.Parse(kullanici_id);

                komut.Parameters.AddWithValue("@id", k_adi);

                komut.Parameters.AddWithValue("@gun", cb_gun.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@bolge", cb_bolge.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@hareket", cb_hareketler.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@set_sayisi", cb_set.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@tekrar", cb_tekrar.SelectedItem.ToString());

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                kullanici_Listele();
            }
        }

        private void dGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dGV.CurrentRow.Cells[0].Value.ToString();
            cb_gun.Text = dGV.CurrentRow.Cells[2].Value.ToString();
            cb_bolge.Text = dGV.CurrentRow.Cells[3].Value.ToString();
            cb_hareketler.Text = dGV.CurrentRow.Cells[4].Value.ToString();
            cb_set.Text = dGV.CurrentRow.Cells[5].Value.ToString();
            cb_tekrar.Text = dGV.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Silmeyi Onaylıyor Musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                string sorgu = "Delete from egzersiz_programi Where id=@id";
                komut = new SqlCommand(sorgu, baglanti);
                int id = Convert.ToInt32(tb_id.Text);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(tb_id.Text));


                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                kullanici_Listele();
            }
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
         if(cb_hareketler.Text== "Lat Pull-Downs")
            {
                animasyon.Image = Properties.Resources.backLatPull_Downs;
            }else if(cb_hareketler.Text== "Seated Rows")
            {
                animasyon.Image = Properties.Resources.back_SeatedRows;
            }else
            {
                animasyon.Image = Properties.Resources.backOne_ArmsDumbellRows;
            }
        
                if (cb_hareketler.Text == "Preacher Curl")
                {
                    animasyon.Image = Properties.Resources.bicepsPreacherCurl;
                }
                else if (cb_hareketler.Text == "Curls")
                {
                    animasyon.Image = Properties.Resources.bicepsCurls;
                }
                else
                {
                    animasyon.Image = Properties.Resources.bicepsHammerCurls;
                }
            if (cb_hareketler.Text == "Bench Presses")
            {
                animasyon.Image = Properties.Resources.chestBenchPress;
            }
            else if (cb_hareketler.Text == "Dumbell Flys")
            {
                animasyon.Image = Properties.Resources.chestDumbellFlys;
            }
            else
            {
                animasyon.Image = Properties.Resources.chestButterfly;
            }
            if (cb_hareketler.Text == "Legs Extentions")
            {
                animasyon.Image = Properties.Resources.legsLegExtension;
            }
            else if (cb_hareketler.Text == "Dumbell Lunges")
            {
                animasyon.Image = Properties.Resources.legsDumbellLunges;
            }
            else
            {
                animasyon.Image = Properties.Resources.legsLegCurl;
            }
            if (cb_hareketler.Text == "Seated Dumbell Presses")
            {
                animasyon.Image = Properties.Resources.shoulderSeatedDumbellPresses;
            }
            else if (cb_hareketler.Text == "Lateral Raises")
            {
                animasyon.Image = Properties.Resources.shoulderaLateralRaises;
            }
            else
            {
                animasyon.Image = Properties.Resources.shouldersFrontRaises;
            }
            if (cb_hareketler.Text == "Push Downs")
            {
                animasyon.Image = Properties.Resources.tricepsTricepsExtension;
            }
            else if (cb_hareketler.Text == "Triceps Extension")
            {
                animasyon.Image = Properties.Resources.tricepsTricepsExtension;
            }
            else
            {
                animasyon.Image = Properties.Resources.TricepsOneArmDumbellTriceps;
            }
        }
    }
}
