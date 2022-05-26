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
    public partial class MüsteriEkle : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";

        public MüsteriEkle()
        {
            InitializeComponent();
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            string Sqlmetin = "insert into Musteri(Adi,Soyadi,Telefon,KayitTarihi) values (@Adi,@Soyadi,@Telefon,@KayitTarihi)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@Soyadi", textBox2.Text);
            cmd.Parameters.AddWithValue("@Telefon", textBox3.Text);
            cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = Sqlmetin;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
