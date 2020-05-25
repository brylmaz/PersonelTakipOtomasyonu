namespace Personel_Giriş_Çıkış
{
    partial class frmPersonelGirisi
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
            this.lblAd = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.cmbAdiSoyadi = new System.Windows.Forms.ComboBox();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.pcbGeri = new System.Windows.Forms.PictureBox();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(14, 31);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(130, 25);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad Soyad:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGiris.Location = new System.Drawing.Point(150, 68);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(162, 59);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // cmbAdiSoyadi
            // 
            this.cmbAdiSoyadi.BackColor = System.Drawing.Color.White;
            this.cmbAdiSoyadi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbAdiSoyadi.FormattingEnabled = true;
            this.cmbAdiSoyadi.Location = new System.Drawing.Point(150, 35);
            this.cmbAdiSoyadi.Name = "cmbAdiSoyadi";
            this.cmbAdiSoyadi.Size = new System.Drawing.Size(162, 21);
            this.cmbAdiSoyadi.TabIndex = 7;
            this.cmbAdiSoyadi.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // pnlGiris
            // 
            this.pnlGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlGiris.Controls.Add(this.cmbAdiSoyadi);
            this.pnlGiris.Controls.Add(this.lblAd);
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Location = new System.Drawing.Point(87, 12);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(347, 200);
            this.pnlGiris.TabIndex = 10;
            // 
            // pcbGeri
            // 
            this.pcbGeri.Image = global::Personel_Giriş_Çıkış.Properties.Resources._605772;
            this.pcbGeri.Location = new System.Drawing.Point(12, 12);
            this.pcbGeri.Name = "pcbGeri";
            this.pcbGeri.Size = new System.Drawing.Size(42, 40);
            this.pcbGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGeri.TabIndex = 11;
            this.pcbGeri.TabStop = false;
            this.pcbGeri.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPersonelGirisi
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(446, 225);
            this.Controls.Add(this.pcbGeri);
            this.Controls.Add(this.pnlGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonelGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL GİRİŞİ";
            this.Load += new System.EventHandler(this.FrmPersonelGirisi_Load);
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ComboBox cmbAdiSoyadi;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.PictureBox pcbGeri;
    }
}