using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personel_Giriş_Çıkış
{
    public partial class frmPersonelGirisCikis : Form
    {
        public frmPersonelGirisCikis()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
          Time();
           

        }

        public void Time()
        {
            lblZaman.Text = DateTime.Now.ToLongTimeString();
            lblZamanİki.Text = DateTime.Now.ToLongDateString();

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            frmPersonelGirisCikis f1 = new frmPersonelGirisCikis();
            f1.Close();
            frmPersonelGirisi f2 = new frmPersonelGirisi(lblZaman.Text, lblZamanİki.Text);
            f2.Show();
            this.Hide();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            frmPersonelGirisCikis f1 = new frmPersonelGirisCikis();
            f1.Close();
            FrmPersonelCikisi f2 = new FrmPersonelCikisi();
            f2.Show();
            this.Hide();
        }

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            frmPersonelGirisCikis f1 = new frmPersonelGirisCikis();
            f1.Close();
            frmYonetici f2 = new frmYonetici();
            f2.Show();
            this.Hide();
        }
      
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Time();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İstanbul Esenyurt Üniversitesi \nBilgisayar Mühendisliği 3.sınıf \n(Nesne Tabanlı Programlama dersi projesi) \n-Abdurrahim Bulut \n-Barış Yılmaz \n-Onur Ülker", "PROJE",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
