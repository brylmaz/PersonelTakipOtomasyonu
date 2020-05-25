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
    public partial class FrmPersonelCikisi : Form
    {
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        public FrmPersonelCikisi()
        {
            InitializeComponent();
        }
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=giriscikis.sqlite;Version=3;");

        private void BtnGeri_Click(object sender, EventArgs e)
        {
           /* FrmPersonelCikisi f1 = new FrmPersonelCikisi();
            f1.Close();
            frmPersonelGirisCikis f2 = new frmPersonelGirisCikis();
            f2.Show();
            this.Hide();*/
        }

        private void FrmPersonelCikisi_Load(object sender, EventArgs e)
        {

            //label1.Visible = false;
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
            cmbAdSoyad.DataSource = tablo;
            cmbAdSoyad.ValueMember = "ID";//personel id
            cmbAdSoyad.DisplayMember = "ADISOYADI";//personel ad
            
            conn.Close();// bağlantı kapalı



        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            string zaman = DateTime.Now.ToLongTimeString() + " " +DateTime.Now.ToLongDateString();
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM tblgiriscikis where ID='" + cmbAdSoyad.SelectedValue + "'";


            SQLiteDataReader dr = cmd.ExecuteReader();
            string ad = "";
            string soyad = "";
            string giris = "";//GİRİŞ ZAMANI
            int kontrol;//bu değişlken çıkış yapıldıysa tekrar çıkışı engeller
            dr.Read();
            ad = dr["ADI"].ToString();
            soyad = dr["SOYADI"].ToString();
            giris = dr["GIRIS"].ToString();
            kontrol = int.Parse(dr["DEGER"].ToString());
            dr.Close();
            if (kontrol == 1)
            {

                MessageBox.Show("PERSONEL GİRİŞ YAPMAMIŞ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
                string sql1 = "UPDATE tblgiriscikis SET  DEGER='1', CIKIS='" + zaman.ToString() + "' WHERE ID='" + cmbAdSoyad.SelectedValue + "'";
                SQLiteCommand command1 = new SQLiteCommand(sql1, conn);
                command1.ExecuteNonQuery();
                //label1.Visible = true;
                //label1.Text = "Hoçakal " + ad;

                MessageBox.Show("HOŞÇAKAL "+ad, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // LOG KAYDI
                string sql3 = "insert into tbllogkaydi(ADI,SOYADI,GIRIS,CIKIS) values ('" + ad + "','" + soyad + "','" + giris + "','" + zaman + "')";
                SQLiteCommand command3 = new SQLiteCommand(sql3, conn);
                command3.ExecuteNonQuery();

                this.Close();
                frmPersonelGirisCikis f2 = new frmPersonelGirisCikis();
                f2.Show();
            }
            conn.Close();
        
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedValue.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmPersonelCikisi f1 = new FrmPersonelCikisi();
            f1.Close();
            frmPersonelGirisCikis f2 = new frmPersonelGirisCikis();
            f2.Show();
            this.Close();
        }
    }
}
