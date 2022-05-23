using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace is_takip_programi
{
    public partial class YöneticiSayfasi : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";

        public YöneticiSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanEkle yeni = new CalisanEkle();
            yeni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüsteriEkle yeni = new MüsteriEkle();
            yeni.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalisandanGelenBildirim yeni = new CalisandanGelenBildirim();
            yeni.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Y_Tamamlananİsler yeni = new Y_Tamamlananİsler();
            yeni.Show();
        }

        public void calısangetir()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Personel where Yetki=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }
        public void musterigetir()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Musteri");
            dataGridView2.DataSource = ds.Tables["Musteri"];
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Y_DevamEdenİsler yeni = new Y_DevamEdenİsler();
            yeni.Show();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            string sqlsorgu = "insert into Isler(MID,PID,YapilacakIs,BaslangicTarihi,Durumu) Values (@MID,@PID,@YapilacakIs,@BaslangicTarihi,@Durumu)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@MID", textBox4.Text);
            cmd.Parameters.AddWithValue("@PID", textBox3.Text);
            cmd.Parameters.AddWithValue("@YapilacakIs", richTextBox2.Text);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", DateTime.Now); ;
            cmd.Parameters.AddWithValue("@Durumu", comboBox1.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlsorgu;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void YöneticiSayfasi_Load(object sender, EventArgs e)
        {
            calısangetir();
            musterigetir();
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
       
    }
}
