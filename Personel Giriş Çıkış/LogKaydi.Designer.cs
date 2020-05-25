namespace Personel_Giriş_Çıkış
{
    partial class LogKaydi
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
            this.dgwLog = new System.Windows.Forms.DataGridView();
            this.pcbGeri = new System.Windows.Forms.PictureBox();
            this.lblHareket = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLog
            // 
            this.dgwLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgwLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLog.Location = new System.Drawing.Point(12, 54);
            this.dgwLog.Name = "dgwLog";
            this.dgwLog.Size = new System.Drawing.Size(834, 486);
            this.dgwLog.TabIndex = 0;
            this.dgwLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pcbGeri
            // 
            this.pcbGeri.Image = global::Personel_Giriş_Çıkış.Properties.Resources._605772;
            this.pcbGeri.Location = new System.Drawing.Point(12, 12);
            this.pcbGeri.Name = "pcbGeri";
            this.pcbGeri.Size = new System.Drawing.Size(47, 36);
            this.pcbGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGeri.TabIndex = 2;
            this.pcbGeri.TabStop = false;
            this.pcbGeri.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblHareket
            // 
            this.lblHareket.AutoSize = true;
            this.lblHareket.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHareket.ForeColor = System.Drawing.Color.White;
            this.lblHareket.Location = new System.Drawing.Point(77, 23);
            this.lblHareket.Name = "lblHareket";
            this.lblHareket.Size = new System.Drawing.Size(210, 25);
            this.lblHareket.TabIndex = 3;
            this.lblHareket.Text = "Hareket Dökümü";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnYenile.Location = new System.Drawing.Point(779, 19);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(67, 29);
            this.btnYenile.TabIndex = 38;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(858, 552);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblHareket);
            this.Controls.Add(this.pcbGeri);
            this.Controls.Add(this.dgwLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogKaydi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogKaydi";
            this.Load += new System.EventHandler(this.LogKaydi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLog;
        private System.Windows.Forms.PictureBox pcbGeri;
        private System.Windows.Forms.Label lblHareket;
        private System.Windows.Forms.Button btnYenile;
    }
}