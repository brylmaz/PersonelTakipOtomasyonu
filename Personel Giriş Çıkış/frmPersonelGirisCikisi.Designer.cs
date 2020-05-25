namespace Personel_Giriş_Çıkış
{
    partial class frmPersonelGirisCikis
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
            this.components = new System.ComponentModel.Container();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lblZamanİki = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.pcbLisans = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLisans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGiris.Location = new System.Drawing.Point(63, 214);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(110, 54);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "PERSONEL GİRİŞİ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnCıkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCıkıs.Location = new System.Drawing.Point(180, 214);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(110, 54);
            this.btnCıkıs.TabIndex = 1;
            this.btnCıkıs.Text = "PERSONEL ÇIKIŞI";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnYonetici.FlatAppearance.BorderSize = 0;
            this.btnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYonetici.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnYonetici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnYonetici.Location = new System.Drawing.Point(296, 214);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(110, 54);
            this.btnYonetici.TabIndex = 2;
            this.btnYonetici.Text = "YÖNETİCİ GİRİŞİ";
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.BtnYonetici_Click);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblZaman.ForeColor = System.Drawing.Color.White;
            this.lblZaman.Location = new System.Drawing.Point(230, 139);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(132, 25);
            this.lblZaman.TabIndex = 3;
            this.lblZaman.Text = "00000000";
            // 
            // lblZamanİki
            // 
            this.lblZamanİki.AutoSize = true;
            this.lblZamanİki.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblZamanİki.ForeColor = System.Drawing.Color.White;
            this.lblZamanİki.Location = new System.Drawing.Point(151, 94);
            this.lblZamanİki.Name = "lblZamanİki";
            this.lblZamanİki.Size = new System.Drawing.Size(312, 25);
            this.lblZamanİki.TabIndex = 4;
            this.lblZamanİki.Text = "00000000000000000000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnKapat.Location = new System.Drawing.Point(412, 214);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(110, 54);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "ÇIKIŞ";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.AutoSize = true;
            this.lblProjeAdi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeAdi.ForeColor = System.Drawing.Color.White;
            this.lblProjeAdi.Location = new System.Drawing.Point(175, 31);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(321, 25);
            this.lblProjeAdi.TabIndex = 7;
            this.lblProjeAdi.Text = "PERSONEL TAKİP SİSTEMİ";
            // 
            // pcbLisans
            // 
            this.pcbLisans.Image = global::Personel_Giriş_Çıkış.Properties.Resources.coding_icon_white;
            this.pcbLisans.Location = new System.Drawing.Point(543, 257);
            this.pcbLisans.Name = "pcbLisans";
            this.pcbLisans.Size = new System.Drawing.Size(27, 26);
            this.pcbLisans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLisans.TabIndex = 8;
            this.pcbLisans.TabStop = false;
            this.pcbLisans.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Personel_Giriş_Çıkış.Properties.Resources.user_personel;
            this.pcbLogo.Location = new System.Drawing.Point(112, 15);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(57, 54);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 6;
            this.pcbLogo.TabStop = false;
            // 
            // frmPersonelGirisCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(582, 295);
            this.Controls.Add(this.pcbLisans);
            this.Controls.Add(this.lblProjeAdi);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblZamanİki);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonelGirisCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL GİRİŞ ÇIKIŞ ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLisans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblZamanİki;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.PictureBox pcbLisans;
    }
}

