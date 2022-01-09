
namespace gymtakipprojesi
{
    partial class egzersiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_getir = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_sec = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cb_bolge = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_hareketler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_set = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tekrar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_gun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_isim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.animasyon = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.animasyon);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Controls.Add(this.dGV);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.btn_sec);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.cb_bolge);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_hareketler);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_set);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_tekrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_gun);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_isim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egzersizler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(103, 93);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(64, 22);
            this.tb_id.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(250, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_getir
            // 
            this.btn_getir.BackColor = System.Drawing.Color.White;
            this.btn_getir.ForeColor = System.Drawing.Color.Black;
            this.btn_getir.Location = new System.Drawing.Point(250, 189);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(53, 27);
            this.btn_getir.TabIndex = 17;
            this.btn_getir.Text = "Seç";
            this.btn_getir.UseVisualStyleBackColor = false;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(300, 277);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(463, 178);
            this.dGV.TabIndex = 16;
            this.dGV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellEnter);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.White;
            this.btn_Sil.ForeColor = System.Drawing.Color.Black;
            this.btn_Sil.Location = new System.Drawing.Point(394, 245);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(69, 26);
            this.btn_Sil.TabIndex = 15;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_sec
            // 
            this.btn_sec.BackColor = System.Drawing.Color.White;
            this.btn_sec.ForeColor = System.Drawing.Color.Black;
            this.btn_sec.Location = new System.Drawing.Point(250, 242);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(60, 27);
            this.btn_sec.TabIndex = 14;
            this.btn_sec.Text = "Göster";
            this.btn_sec.UseVisualStyleBackColor = false;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_guncelle.Location = new System.Drawing.Point(169, 427);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.White;
            this.btn_kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_kaydet.Location = new System.Drawing.Point(169, 398);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cb_bolge
            // 
            this.cb_bolge.FormattingEnabled = true;
            this.cb_bolge.Items.AddRange(new object[] {
            "Back",
            "Biceps",
            "Chest",
            "Legs",
            "Shoulders",
            "Triceps"});
            this.cb_bolge.Location = new System.Drawing.Point(103, 192);
            this.cb_bolge.Name = "cb_bolge";
            this.cb_bolge.Size = new System.Drawing.Size(141, 24);
            this.cb_bolge.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bölge :";
            // 
            // cb_hareketler
            // 
            this.cb_hareketler.FormattingEnabled = true;
            this.cb_hareketler.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cb_hareketler.Location = new System.Drawing.Point(103, 245);
            this.cb_hareketler.Name = "cb_hareketler";
            this.cb_hareketler.Size = new System.Drawing.Size(141, 24);
            this.cb_hareketler.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hareketler :";
            // 
            // cb_set
            // 
            this.cb_set.FormattingEnabled = true;
            this.cb_set.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cb_set.Location = new System.Drawing.Point(103, 299);
            this.cb_set.Name = "cb_set";
            this.cb_set.Size = new System.Drawing.Size(141, 24);
            this.cb_set.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Set :";
            // 
            // cb_tekrar
            // 
            this.cb_tekrar.FormattingEnabled = true;
            this.cb_tekrar.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cb_tekrar.Location = new System.Drawing.Point(103, 354);
            this.cb_tekrar.Name = "cb_tekrar";
            this.cb_tekrar.Size = new System.Drawing.Size(141, 24);
            this.cb_tekrar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tekrar :";
            // 
            // cb_gun
            // 
            this.cb_gun.FormattingEnabled = true;
            this.cb_gun.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cb_gun.Location = new System.Drawing.Point(103, 137);
            this.cb_gun.Name = "cb_gun";
            this.cb_gun.Size = new System.Drawing.Size(141, 24);
            this.cb_gun.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gün :";
            // 
            // combo_isim
            // 
            this.combo_isim.FormattingEnabled = true;
            this.combo_isim.Location = new System.Drawing.Point(103, 54);
            this.combo_isim.Name = "combo_isim";
            this.combo_isim.Size = new System.Drawing.Size(141, 24);
            this.combo_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi Adı :";
            // 
            // animasyon
            // 
            this.animasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animasyon.Location = new System.Drawing.Point(423, 33);
            this.animasyon.Name = "animasyon";
            this.animasyon.Size = new System.Drawing.Size(328, 192);
            this.animasyon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animasyon.TabIndex = 23;
            this.animasyon.TabStop = false;
            // 
            // egzersiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gymtakipprojesi.Properties.Resources.egzersizMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 482);
            this.Controls.Add(this.groupBox1);
            this.Name = "egzersiz";
            this.ShowIcon = false;
            this.Text = "Egzersiz";
            this.Load += new System.EventHandler(this.egzersiz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animasyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox cb_bolge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_hareketler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_set;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_gun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox animasyon;
    }
}