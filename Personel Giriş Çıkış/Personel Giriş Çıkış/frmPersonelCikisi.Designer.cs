namespace Personel_Giriş_Çıkış
{
    partial class FrmPersonelCikisi
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
            this.cmbCikisSecim = new System.Windows.Forms.ComboBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHoscakalın = new System.Windows.Forms.Label();
            this.pcbGeri = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCikisSecim
            // 
            this.cmbCikisSecim.BackColor = System.Drawing.Color.White;
            this.cmbCikisSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCikisSecim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCikisSecim.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCikisSecim.FormattingEnabled = true;
            this.cmbCikisSecim.Location = new System.Drawing.Point(153, 34);
            this.cmbCikisSecim.Name = "cmbCikisSecim";
            this.cmbCikisSecim.Size = new System.Drawing.Size(164, 21);
            this.cmbCikisSecim.TabIndex = 6;
            this.cmbCikisSecim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(17, 30);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(130, 25);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Ad Soyad:";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCikis.Location = new System.Drawing.Point(153, 66);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(164, 60);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "ÇIKIŞ ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.lblHoscakalın);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.cmbCikisSecim);
            this.panel1.Location = new System.Drawing.Point(80, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 201);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHoscakalın
            // 
            this.lblHoscakalın.AutoSize = true;
            this.lblHoscakalın.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoscakalın.ForeColor = System.Drawing.Color.White;
            this.lblHoscakalın.Location = new System.Drawing.Point(150, 174);
            this.lblHoscakalın.Name = "lblHoscakalın";
            this.lblHoscakalın.Size = new System.Drawing.Size(79, 14);
            this.lblHoscakalın.TabIndex = 12;
            this.lblHoscakalın.Text = "Hoşcakalın";
            // 
            // pcbGeri
            // 
            this.pcbGeri.Image = global::Personel_Giriş_Çıkış.Properties.Resources._605772;
            this.pcbGeri.Location = new System.Drawing.Point(12, 12);
            this.pcbGeri.Name = "pcbGeri";
            this.pcbGeri.Size = new System.Drawing.Size(43, 40);
            this.pcbGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGeri.TabIndex = 13;
            this.pcbGeri.TabStop = false;
            this.pcbGeri.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPersonelCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(444, 230);
            this.Controls.Add(this.pcbGeri);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelCikisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL ÇIKIŞI";
            this.Load += new System.EventHandler(this.FrmPersonelCikisi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCikisSecim;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHoscakalın;
        private System.Windows.Forms.PictureBox pcbGeri;
    }
}