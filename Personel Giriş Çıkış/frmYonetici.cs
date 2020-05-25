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
    public partial class frmYonetici : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=giriscikis.sqlite;Version=3;");
        int id;
        public frmYonetici()
        {
            InitializeComponent();
        }

        public void IDsıralama()
        {
          


        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
          
        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {
          
          
            pnlEdit.Visible = false;
            dgwVeriTabani.Visible = false;
            btnYenile.Visible = false;
            lblYonetimPaneli.Visible = false;



        }
      
        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn2 = new SQLiteConnection(@"Data Source=giriscikis.sqlite;Version=3;");
            SQLiteCommand cmd2 = conn2.CreateCommand();
            conn2.Open();
            cmd2.CommandText = "SELECT * FROM SIFRE";
            SQLiteDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            string sifre = dr2["SIFRE"].ToString();
            dr2.Close();
            cmd2.ExecuteNonQuery();
            conn2.Close();
          

            
         
            if (txtSifre.Text == sifre)
            {

                PersonelYukle();
           
             pnlEdit.Visible = true;
             dgwVeriTabani.Visible = true;
             btnYenile.Visible = true;
             lblYonetimPaneli.Visible = true;
             panel1.Visible = false;
            
            }
            else
            {
                MessageBox.Show("YANLIŞ ŞİFRE", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Clear();
            }
          //txtSifre.Clear();
        }

     

        private void BtnYetkiliGirisi_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDegistir_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            string ad= txtAdi.Text;
            string soyad= txtSoyadi.Text;
            string telno = txtTelefonNo.Text;
            string tcno = txtTC.Text;
            string adres = txtAdres.Text;


            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            //deger 0:çıkış yaptı , 1:çıkış yapmamış
            cmd.CommandText = "insert into tblgiriscikis (ADI,SOYADI,DEGER,TELNO,ADRES,TCNO) values ('"+ ad+ "','" + soyad + "',1,'" + telno + "','" + adres + "','" + tcno + "')";
            cmd.ExecuteNonQuery();
         
            conn.Close();
            PersonelYenile();

            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefonNo.Clear();
            txtTC.Clear();
            txtAdres.Clear();

        }






        private void PersonelYukle()
        {
           

            SQLiteConnection conn = new SQLiteConnection("Data Source=giriscikis.sqlite;Version=3;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM tblgiriscikis";//Sql Sorgusu
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
           
            dgwVeriTabani.DataSource = tablo;
            dgwVeriTabani.Columns["DEGER"].Visible = false;
            dgwVeriTabani.Columns["TELNO"].Visible = false;
            dgwVeriTabani.Columns["TCNO"].Visible = false;
            dgwVeriTabani.Columns["ADRES"].Visible = false;
            DataGridViewButtonColumn btnSil = new DataGridViewButtonColumn();
            btnSil.HeaderText = "Sil";
            btnSil.Name = "button";
            btnSil.Text = "Sil";
            btnSil.UseColumnTextForButtonValue = true;
            
            dgwVeriTabani.Columns.Add(btnSil);



            conn.Close();
        


        }
        private void PersonelYenile()
        {
            dgwVeriTabani.Columns.RemoveAt(9);
       
           


            SQLiteConnection conn = new SQLiteConnection("Data Source=giriscikis.sqlite;Version=3;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM tblgiriscikis";//Sql Sorgusu
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
          
            dgwVeriTabani.DataSource = tablo;
            dgwVeriTabani.Columns["DEGER"].Visible = false;
            dgwVeriTabani.Columns["TELNO"].Visible = false;
            dgwVeriTabani.Columns["TCNO"].Visible = false;
            dgwVeriTabani.Columns["ADRES"].Visible = false;
            DataGridViewButtonColumn btnSil = new DataGridViewButtonColumn();
            btnSil.HeaderText = "Sil";
            btnSil.Name = "button";
            btnSil.Text = "Sil";
            btnSil.UseColumnTextForButtonValue = true;
            dgwVeriTabani.Columns.Add(btnSil);

            conn.Close();

        }

        private void yenile()
        {


        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
           
          
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //this.Hide();
            LogKaydi f2 = new LogKaydi();
            f2.Show();
            
        }

        private void frmPersonelGirisiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmYoneticiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmYonetici f1 = new frmYonetici();
            f1.Close();
            frmPersonelGirisCikis f2 = new frmPersonelGirisCikis();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ad = txtAdi.Text;
            string soyad = txtSoyadi.Text;
            string telno = txtTelefonNo.Text;
            string tcno = txtTC.Text;
            string adres = txtAdres.Text;

           
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            //deger 0:çıkış yaptı, 1:çıkış yapmadı
            cmd.CommandText = "UPDATE  tblgiriscikis SET  ADI='" + ad + "', SOYADI='" + soyad + "', TELNO='" + telno + "', ADRES='" + adres + "', TCNO='" + tcno + "'   WHERE ID=" + id + " ";
            cmd.ExecuteNonQuery();

            conn.Close();
            PersonelYenile();

            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefonNo.Clear();
            txtTC.Clear();
            txtAdres.Clear();
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex==9 && e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dgwVeriTabani.Rows[e.RowIndex];
                
                id = int.Parse(row.Cells["ID"].Value.ToString());
            
                string sql1 = "delete from tblgiriscikis  WHERE ID='" + id + "'";
                conn.Open();
                SQLiteCommand command1 = new SQLiteCommand(sql1, conn);
                command1.ExecuteNonQuery();
                conn.Close();

                PersonelYenile();

            }
            else if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.dgwVeriTabani.Rows[e.RowIndex];
                id=int.Parse(row.Cells["ID"].Value.ToString());
                txtAdi.Text = row.Cells["ADI"].Value.ToString();
                txtSoyadi.Text = row.Cells["SOYADI"].Value.ToString();
                txtTelefonNo.Text = row.Cells["TELNO"].Value.ToString();
                txtTC.Text = row.Cells["TCNO"].Value.ToString();
                txtAdres.Text = row.Cells["ADRES"].Value.ToString();
            }

         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelYenile();
        }

        private void LblSifre_Click(object sender, EventArgs e)
        {

        }
    }
}
