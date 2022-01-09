
namespace gymtakipprojesi
{
    partial class AnaMenu
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
            this.btn_egzersiz = new System.Windows.Forms.Button();
            this.btn_kListele = new System.Windows.Forms.Button();
            this.btn_diyet = new System.Windows.Forms.Button();
            this.btn_kEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_egzersiz
            // 
            this.btn_egzersiz.BackgroundImage = global::gymtakipprojesi.Properties.Resources.egzersiz;
            this.btn_egzersiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_egzersiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_egzersiz.ForeColor = System.Drawing.Color.White;
            this.btn_egzersiz.Location = new System.Drawing.Point(12, 234);
            this.btn_egzersiz.Name = "btn_egzersiz";
            this.btn_egzersiz.Size = new System.Drawing.Size(251, 227);
            this.btn_egzersiz.TabIndex = 3;
            this.btn_egzersiz.Text = "Egzersiz";
            this.btn_egzersiz.UseVisualStyleBackColor = true;
            this.btn_egzersiz.Click += new System.EventHandler(this.btn_egzersiz_Click);
            // 
            // btn_kListele
            // 
            this.btn_kListele.BackgroundImage = global::gymtakipprojesi.Properties.Resources.kListele;
            this.btn_kListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kListele.ForeColor = System.Drawing.Color.White;
            this.btn_kListele.Location = new System.Drawing.Point(269, 1);
            this.btn_kListele.Name = "btn_kListele";
            this.btn_kListele.Size = new System.Drawing.Size(251, 227);
            this.btn_kListele.TabIndex = 2;
            this.btn_kListele.Text = "Kullanıcı Listele";
            this.btn_kListele.UseVisualStyleBackColor = true;
            this.btn_kListele.Click += new System.EventHandler(this.btn_kListele_Click);
            // 
            // btn_diyet
            // 
            this.btn_diyet.BackgroundImage = global::gymtakipprojesi.Properties.Resources.diyet;
            this.btn_diyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_diyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_diyet.ForeColor = System.Drawing.Color.White;
            this.btn_diyet.Location = new System.Drawing.Point(269, 234);
            this.btn_diyet.Name = "btn_diyet";
            this.btn_diyet.Size = new System.Drawing.Size(251, 227);
            this.btn_diyet.TabIndex = 1;
            this.btn_diyet.Text = "Diyet";
            this.btn_diyet.UseVisualStyleBackColor = true;
            this.btn_diyet.Click += new System.EventHandler(this.btn_diyet_Click);
            // 
            // btn_kEkle
            // 
            this.btn_kEkle.BackgroundImage = global::gymtakipprojesi.Properties.Resources.kEkle;
            this.btn_kEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kEkle.ForeColor = System.Drawing.Color.White;
            this.btn_kEkle.Location = new System.Drawing.Point(12, 1);
            this.btn_kEkle.Name = "btn_kEkle";
            this.btn_kEkle.Size = new System.Drawing.Size(251, 227);
            this.btn_kEkle.TabIndex = 0;
            this.btn_kEkle.Text = "Kullanıcı Ekle";
            this.btn_kEkle.UseVisualStyleBackColor = true;
            this.btn_kEkle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 472);
            this.Controls.Add(this.btn_egzersiz);
            this.Controls.Add(this.btn_kListele);
            this.Controls.Add(this.btn_diyet);
            this.Controls.Add(this.btn_kEkle);
            this.Name = "AnaMenu";
            this.ShowIcon = false;
            this.Text = "Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kEkle;
        private System.Windows.Forms.Button btn_diyet;
        private System.Windows.Forms.Button btn_kListele;
        private System.Windows.Forms.Button btn_egzersiz;
    }
}