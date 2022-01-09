
namespace gymtakipprojesi
{
    partial class kullaniciListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.tb_parola = new System.Windows.Forms.TextBox();
            this.lbl_parola = new System.Windows.Forms.Label();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.tb_adSoyad = new System.Windows.Forms.TextBox();
            this.lbl_adSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_uyari);
            this.panel1.Controls.Add(this.btn_guncelle);
            this.panel1.Controls.Add(this.tb_mail);
            this.panel1.Controls.Add(this.btn_Sil);
            this.panel1.Controls.Add(this.lbl_mail);
            this.panel1.Controls.Add(this.tb_parola);
            this.panel1.Controls.Add(this.lbl_parola);
            this.panel1.Controls.Add(this.tb_telefon);
            this.panel1.Controls.Add(this.lbl_telefon);
            this.panel1.Controls.Add(this.tb_adSoyad);
            this.panel1.Controls.Add(this.lbl_adSoyad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 347);
            this.panel1.TabIndex = 0;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(102, 301);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(71, 26);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(13, 172);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(160, 20);
            this.tb_mail.TabIndex = 8;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.White;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(10, 301);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(71, 26);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.Location = new System.Drawing.Point(10, 153);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(49, 16);
            this.lbl_mail.TabIndex = 7;
            this.lbl_mail.Text = "E-Mail:";
            // 
            // tb_parola
            // 
            this.tb_parola.Location = new System.Drawing.Point(13, 214);
            this.tb_parola.Name = "tb_parola";
            this.tb_parola.Size = new System.Drawing.Size(160, 20);
            this.tb_parola.TabIndex = 6;
            // 
            // lbl_parola
            // 
            this.lbl_parola.AutoSize = true;
            this.lbl_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_parola.Location = new System.Drawing.Point(10, 195);
            this.lbl_parola.Name = "lbl_parola";
            this.lbl_parola.Size = new System.Drawing.Size(51, 16);
            this.lbl_parola.TabIndex = 5;
            this.lbl_parola.Text = "Parola:";
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(13, 256);
            this.tb_telefon.MaxLength = 10;
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(160, 20);
            this.tb_telefon.TabIndex = 4;
            this.tb_telefon.TextChanged += new System.EventHandler(this.tb_telefon_TextChanged);
            this.tb_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_telefon_KeyPress);
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon.Location = new System.Drawing.Point(10, 237);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(57, 16);
            this.lbl_telefon.TabIndex = 3;
            this.lbl_telefon.Text = "Telefon:";
            // 
            // tb_adSoyad
            // 
            this.tb_adSoyad.Location = new System.Drawing.Point(13, 130);
            this.tb_adSoyad.Name = "tb_adSoyad";
            this.tb_adSoyad.Size = new System.Drawing.Size(160, 20);
            this.tb_adSoyad.TabIndex = 2;
            this.tb_adSoyad.TextChanged += new System.EventHandler(this.tb_adSoyad_TextChanged);
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adSoyad.Location = new System.Drawing.Point(10, 111);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(71, 16);
            this.lbl_adSoyad.TabIndex = 1;
            this.lbl_adSoyad.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Bilgileri";
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToAddRows = false;
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(223, 1);
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV1.Size = new System.Drawing.Size(701, 347);
            this.dGV1.TabIndex = 1;
            this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
            this.dGV1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellEnter);
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_uyari.Location = new System.Drawing.Point(13, 256);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(0, 13);
            this.lbl_uyari.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(13, 74);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(160, 20);
            this.tb_id.TabIndex = 11;
            // 
            // kullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 352);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.panel1);
            this.Name = "kullaniciListele";
            this.ShowIcon = false;
            this.Text = "Kullanıcı Listesi";
            this.Load += new System.EventHandler(this.kullaniciListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox tb_parola;
        private System.Windows.Forms.Label lbl_parola;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox tb_adSoyad;
        private System.Windows.Forms.Label lbl_adSoyad;
        private System.Windows.Forms.Label lbl_uyari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
    }
}