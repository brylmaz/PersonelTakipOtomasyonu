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
    public partial class LogKaydi : Form
    {
        public LogKaydi()
        {
            InitializeComponent();
        }

        private void LogKaydi_Load(object sender, EventArgs e)
        {
            SQLiteConnection con;
            SQLiteDataAdapter da;
            DataSet ds;
            con = new SQLiteConnection("Data Source=giriscikis.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select * From tbllogkaydi ORDER BY ID DESC", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbllogkaydi");
            dataGridView1.DataSource = ds.Tables["tbllogkaydi"];
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
        


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmYonetici f1 = new frmYonetici();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection con;
            SQLiteDataAdapter da;
            DataSet ds;
            con = new SQLiteConnection("Data Source=giriscikis.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select * From tbllogkaydi ORDER BY ID DESC", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbllogkaydi");
            dataGridView1.DataSource = ds.Tables["tbllogkaydi"];
        }
    }
}
