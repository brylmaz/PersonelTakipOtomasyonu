using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Personel_Giriş_Çıkış
{
    public partial class frmPersonelGirisi : Form
    {
        
        string text1, text2;
        public frmPersonelGirisi(string TEXT1, string TEXT2)
        {
            InitializeComponent();
            text1 = TEXT1;
            text2 = TEXT2;
        }



        SQLiteConnection conn = new SQLiteConnection(@"Data Source=giriscikis.sqlite;Version=3;");

        private void BtnGeri_Click(object sender, EventArgs e)
        {

        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                  && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);
        }

        private void TxtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                   && !char.IsControl(e.KeyChar)
                   && !char.IsSeparator(e.KeyChar);
        }

        private void FrmPersonelGirisi_Load(object sender, EventArgs e)
        {

            lblHosgeldiniz.Visible = false;
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM tblgiriscikis";//Sql Sorgusu
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);

            tablo.Columns.Add(
            "ADISOYADI",
            typeof(string),
            "ADI + ' ' + SOYADI");

            //combobox
            cmbSecim.DataSource = tablo;
            cmbSecim.ValueMember = "ID";//personel id
            cmbSecim.DisplayMember = "ADISOYADI";//personel ad
             conn.Close();// bağlantı kapalı


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            frmPersonelGirisCikis f2 = new frmPersonelGirisCikis();
            f2.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            string zaman = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM tblgiriscikis where ID='" + cmbSecim.SelectedValue + "'";


            SQLiteDataReader dr = cmd.ExecuteReader();
            string ad = "";
            string soyad = "";
            int kontrol;//bu değişlken çıkış yapılmadıysa tekrar girişi engeller
            dr.Read();
            ad = dr["ADI"].ToString();
            soyad = dr["SOYADI"].ToString();
            kontrol = int.Parse(dr["DEGER"].ToString());
            dr.Close();
            if (kontrol == 0)
            {
                MessageBox.Show("PERSONEL ÇIKIŞ YAPMAMIŞ");

            }
            else
            {
                string sql1 = "UPDATE tblgiriscikis SET  DEGER='0', GIRIS='" + zaman.ToString() + "', CIKIS='Çıkış yapmadı' WHERE ID='" + cmbSecim.SelectedValue + "'";
                SQLiteCommand command1 = new SQLiteCommand(sql1, conn);
                command1.ExecuteNonQuery();
                lblHosgeldiniz.Visible = true;
                lblHosgeldiniz.Text = "Hoşgeldin " + ad;


                MessageBox.Show("GİRİŞ BAŞARILI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(comboBox1.SelectedValue.ToString(), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPersonelGirisCikis f2 = new frmPersonelGirisCikis();
                f2.Show();
                this.Close();


            }



            conn.Close();


            
             }
       
        }
    }