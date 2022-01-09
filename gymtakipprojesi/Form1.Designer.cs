
namespace gymtakipprojesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.ForeColor = System.Drawing.Color.White;
            this.lbl_mail.Location = new System.Drawing.Point(38, 168);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(150, 25);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "Kullanıcı Adı:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_sifre.Location = new System.Drawing.Point(120, 233);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(68, 25);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(199, 168);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(148, 20);
            this.tb_mail.TabIndex = 2;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(199, 238);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.PasswordChar = '*';
            this.tb_sifre.Size = new System.Drawing.Size(148, 20);
            this.tb_sifre.TabIndex = 3;
            this.tb_sifre.Text = "*";
            this.tb_sifre.TextChanged += new System.EventHandler(this.tb_sifre_TextChanged);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(272, 281);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gymtakipprojesi.Properties.Resources.anamenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 445);
            this.ControlBox = false;
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_mail);
            this.Name = "Form1";
            this.Text = "Gym Tracing - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}

