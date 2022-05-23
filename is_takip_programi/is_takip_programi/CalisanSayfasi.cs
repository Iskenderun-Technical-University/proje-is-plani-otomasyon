using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient

namespace is_takip_programi
{
    public partial class CalisanSayfasi : Form
    {
        public CalisanSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiyeGeriBildirim yeni = new YoneticiyeGeriBildirim();
            yeni.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C_Tamamlananİsler yeni = new C_Tamamlananİsler();
            yeni.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C_Tamamlananİsler yeni = new C_Tamamlananİsler();
            yeni.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriBilgileri yeni = new MusteriBilgileri();
            yeni.Show();
        }

        private void Görüntüle_Click(object sender, EventArgs e)
        {
            isgoster();
        }
        public void isgoster()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Isler where Durumu='Devam Ediyor'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Isler");
            dataGridView1.DataSource = ds.Tables["Isler"];
            con.Close();
        }
    }
}
