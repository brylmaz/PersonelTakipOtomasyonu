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
          
          
            panel3.Visible = false;
            dataGridView1.Visible = false;
            button3.Visible = false;
            label7.Visible = false;



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
           
             panel3.Visible = true;
             dataGridView1.Visible = true;
             button3.Visible = true;
             label7.Visible = true;
             panel1.Visible = false;
            
            }
            else
            {
                MessageBox.Show("YANLIŞ ŞİFRE", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string ad= textBox1.Text;
            string soyad= textBox2.Text;
            string telno = textBox3.Text;
            string tcno = textBox4.Text;
            string adres = richTextBox1.Text;


            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            //deger 0:çıkış yaptı , 1:çıkış yapmamış
            cmd.CommandText = "insert into tblgiriscikis (ADI,SOYADI,DEGER,TELNO,ADRES,TCNO) values ('"+ ad+ "','" + soyad + "',1,'" + telno + "','" + adres + "','" + tcno + "')";
            cmd.ExecuteNonQuery();
         
            conn.Close();
            PersonelYenile();

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
           
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns["DEGER"].Visible = false;
            dataGridView1.Columns["TELNO"].Visible = false;
            dataGridView1.Columns["TCNO"].Visible = false;
            dataGridView1.Columns["ADRES"].Visible = false;
            DataGridViewButtonColumn btnSil = new DataGridViewButtonColumn();
            btnSil.HeaderText = "Sil";
            btnSil.Name = "button";
            btnSil.Text = "Sil";
            btnSil.UseColumnTextForButtonValue = true;
            
            dataGridView1.Columns.Add(btnSil);



            conn.Close();
        


        }
        private void PersonelYenile()
        {
            dataGridView1.Columns.RemoveAt(9);
       
           


            SQLiteConnection conn = new SQLiteConnection("Data Source=giriscikis.sqlite;Version=3;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM tblgiriscikis";//Sql Sorgusu
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
          
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns["DEGER"].Visible = false;
            dataGridView1.Columns["TELNO"].Visible = false;
            dataGridView1.Columns["TCNO"].Visible = false;
            dataGridView1.Columns["ADRES"].Visible = false;
            DataGridViewButtonColumn btnSil = new DataGridViewButtonColumn();
            btnSil.HeaderText = "Sil";
            btnSil.Name = "button";
            btnSil.Text = "Sil";
            btnSil.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnSil);

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
            
            LogKaydi f2 = new LogKaydi();
            f2.Show();
            this.Hide();
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
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string telno = textBox3.Text;
            string tcno = textBox4.Text;
            string adres = richTextBox1.Text;

           
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            //deger 0:çıkış yaptı, 1:çıkış yapmadı
            cmd.CommandText = "UPDATE  tblgiriscikis SET  ADI='" + ad + "', SOYADI='" + soyad + "', TELNO='" + telno + "', ADRES='" + adres + "', TCNO='" + tcno + "'   WHERE ID=" + id + " ";
            cmd.ExecuteNonQuery();

            conn.Close();
            PersonelYenile();
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex==9 && e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
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
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id=int.Parse(row.Cells["ID"].Value.ToString());
                textBox1.Text = row.Cells["ADI"].Value.ToString();
                textBox2.Text = row.Cells["SOYADI"].Value.ToString();
                textBox3.Text = row.Cells["TELNO"].Value.ToString();
                textBox4.Text = row.Cells["TCNO"].Value.ToString();
                richTextBox1.Text = row.Cells["ADRES"].Value.ToString();
            }

         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelYenile();
        }
    }
}
