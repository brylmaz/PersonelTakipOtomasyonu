namespace Personel_Giriş_Çıkış
{
    partial class frmYonetici
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
            this.components = new System.ComponentModel.Container();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.dgwVeriTabani = new System.Windows.Forms.DataGridView();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblEdit = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.btnPersoneliDuzenle = new System.Windows.Forms.Button();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYoneticiGiris = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblYonetimPaneli = new System.Windows.Forms.Label();
            this.pcbGeri = new System.Windows.Forms.PictureBox();
            this.frmPersonelGirisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmYoneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriTabani)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPersonelGirisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmYoneticiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(55, 58);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(57, 16);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "ŞİFRE :";
            this.lblSifre.Click += new System.EventHandler(this.LblSifre_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(118, 57);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(147, 20);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // dgwVeriTabani
            // 
            this.dgwVeriTabani.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgwVeriTabani.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwVeriTabani.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwVeriTabani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVeriTabani.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgwVeriTabani.Location = new System.Drawing.Point(14, 64);
            this.dgwVeriTabani.Name = "dgwVeriTabani";
            this.dgwVeriTabani.Size = new System.Drawing.Size(645, 411);
            this.dgwVeriTabani.TabIndex = 9;
            this.dgwVeriTabani.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgwVeriTabani.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGiris.Location = new System.Drawing.Point(118, 83);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(147, 45);
            this.btnGiris.TabIndex = 11;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEkle.Location = new System.Drawing.Point(211, 263);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(99, 50);
            this.btnEkle.TabIndex = 29;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlEdit.Controls.Add(this.lblEdit);
            this.pnlEdit.Controls.Add(this.txtTC);
            this.pnlEdit.Controls.Add(this.txtTelefonNo);
            this.pnlEdit.Controls.Add(this.txtAdres);
            this.pnlEdit.Controls.Add(this.btnPersoneliDuzenle);
            this.pnlEdit.Controls.Add(this.lblAdres);
            this.pnlEdit.Controls.Add(this.lblTC);
            this.pnlEdit.Controls.Add(this.lblTelefonNo);
            this.pnlEdit.Controls.Add(this.btnLog);
            this.pnlEdit.Controls.Add(this.btnEkle);
            this.pnlEdit.Controls.Add(this.txtAdi);
            this.pnlEdit.Controls.Add(this.txtSoyadi);
            this.pnlEdit.Controls.Add(this.lblAd);
            this.pnlEdit.Controls.Add(this.lblSoyad);
            this.pnlEdit.Location = new System.Drawing.Point(665, 65);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(332, 410);
            this.pnlEdit.TabIndex = 33;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(98, 34);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(180, 25);
            this.lblEdit.TabIndex = 36;
            this.lblEdit.Text = "Personel Girişi";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(103, 155);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(207, 20);
            this.txtTC.TabIndex = 27;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(103, 129);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(207, 20);
            this.txtTelefonNo.TabIndex = 26;
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.Location = new System.Drawing.Point(104, 184);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(206, 73);
            this.txtAdres.TabIndex = 28;
            this.txtAdres.Text = "";
            // 
            // btnPersoneliDuzenle
            // 
            this.btnPersoneliDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPersoneliDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneliDuzenle.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnPersoneliDuzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPersoneliDuzenle.Location = new System.Drawing.Point(103, 263);
            this.btnPersoneliDuzenle.Name = "btnPersoneliDuzenle";
            this.btnPersoneliDuzenle.Size = new System.Drawing.Size(99, 50);
            this.btnPersoneliDuzenle.TabIndex = 29;
            this.btnPersoneliDuzenle.Text = "Personeli Düzenle";
            this.btnPersoneliDuzenle.UseVisualStyleBackColor = false;
            this.btnPersoneliDuzenle.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblAdres.ForeColor = System.Drawing.Color.White;
            this.lblAdres.Location = new System.Drawing.Point(44, 182);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 16);
            this.lblAdres.TabIndex = 39;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(44, 156);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(54, 16);
            this.lblTC.TabIndex = 37;
            this.lblTC.Text = "TC No:";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblTelefonNo.ForeColor = System.Drawing.Color.White;
            this.lblTelefonNo.Location = new System.Drawing.Point(11, 130);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(84, 16);
            this.lblTelefonNo.TabIndex = 35;
            this.lblTelefonNo.Text = "Telefon No:";
            // 
            // btnLog
            // 
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(103, 333);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(207, 48);
            this.btnLog.TabIndex = 30;
            this.btnLog.Text = "Hareket Dökümü";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(103, 77);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(207, 20);
            this.txtAdi.TabIndex = 23;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(103, 103);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(207, 20);
            this.txtSoyadi.TabIndex = 24;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(58, 78);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(39, 16);
            this.lblAd.TabIndex = 25;
            this.lblAd.Text = "Adı :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Location = new System.Drawing.Point(32, 104);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(63, 16);
            this.lblSoyad.TabIndex = 26;
            this.lblSoyad.Text = "Soyadı :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.lblYoneticiGiris);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Location = new System.Drawing.Point(334, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 145);
            this.panel1.TabIndex = 1;
            // 
            // lblYoneticiGiris
            // 
            this.lblYoneticiGiris.AutoSize = true;
            this.lblYoneticiGiris.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblYoneticiGiris.ForeColor = System.Drawing.Color.White;
            this.lblYoneticiGiris.Location = new System.Drawing.Point(82, 17);
            this.lblYoneticiGiris.Name = "lblYoneticiGiris";
            this.lblYoneticiGiris.Size = new System.Drawing.Size(166, 25);
            this.lblYoneticiGiris.TabIndex = 35;
            this.lblYoneticiGiris.Text = "Yönetici Giriş";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnYenile.Location = new System.Drawing.Point(592, 29);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(67, 29);
            this.btnYenile.TabIndex = 37;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblYonetimPaneli
            // 
            this.lblYonetimPaneli.AutoSize = true;
            this.lblYonetimPaneli.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblYonetimPaneli.ForeColor = System.Drawing.Color.White;
            this.lblYonetimPaneli.Location = new System.Drawing.Point(87, 25);
            this.lblYonetimPaneli.Name = "lblYonetimPaneli";
            this.lblYonetimPaneli.Size = new System.Drawing.Size(188, 25);
            this.lblYonetimPaneli.TabIndex = 43;
            this.lblYonetimPaneli.Text = "Yönetim Paneli";
            // 
            // pcbGeri
            // 
            this.pcbGeri.Image = global::Personel_Giriş_Çıkış.Properties.Resources._605772;
            this.pcbGeri.Location = new System.Drawing.Point(14, 12);
            this.pcbGeri.Name = "pcbGeri";
            this.pcbGeri.Size = new System.Drawing.Size(49, 38);
            this.pcbGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGeri.TabIndex = 36;
            this.pcbGeri.TabStop = false;
            this.pcbGeri.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPersonelGirisiBindingSource
            // 
            this.frmPersonelGirisiBindingSource.DataSource = typeof(Personel_Giriş_Çıkış.frmPersonelGirisi);
            this.frmPersonelGirisiBindingSource.CurrentChanged += new System.EventHandler(this.frmPersonelGirisiBindingSource_CurrentChanged);
            // 
            // frmYoneticiBindingSource
            // 
            this.frmYoneticiBindingSource.DataSource = typeof(Personel_Giriş_Çıkış.frmYonetici);
            this.frmYoneticiBindingSource.CurrentChanged += new System.EventHandler(this.frmYoneticiBindingSource_CurrentChanged);
            // 
            // frmYonetici
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1004, 483);
            this.Controls.Add(this.lblYonetimPaneli);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.pcbGeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.dgwVeriTabani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÖNETİCİ";
            this.Load += new System.EventHandler(this.frmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriTabani)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPersonelGirisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmYoneticiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.BindingSource frmPersonelGirisiBindingSource;
        private System.Windows.Forms.BindingSource frmYoneticiBindingSource;
        private System.Windows.Forms.DataGridView dgwVeriTabani;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYoneticiGiris;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.PictureBox pcbGeri;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnPersoneliDuzenle;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblYonetimPaneli;
    }
}