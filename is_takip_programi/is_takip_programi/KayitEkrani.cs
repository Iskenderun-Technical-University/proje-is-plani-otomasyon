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
    public partial class KayitEkrani : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";

        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsorgu = "insert into Personel(Adi,Soyadi,Görevi,Telefon,KayitTarihi,KullaniciAdi,sifre,Yetki) Values (@Adi,@Soyadi,@Görevi,@Telefon,@KayıtTarihi,@KullaniciAdi,@Sifre,@Yetki)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@Soyadi", textBox2.Text);
            cmd.Parameters.AddWithValue("@Görevi", textBox3.Text);
            cmd.Parameters.AddWithValue("@Telefon", textBox4.Text);
            cmd.Parameters.AddWithValue("@KayıtTarihi", DateTime.Now);
            cmd.Parameters.AddWithValue("@KullaniciAdi", textBox5.Text);
            cmd.Parameters.AddWithValue("@Sifre", textBox6.Text);
            cmd.Parameters.AddWithValue("@Yetki", Convert.ToInt32(comboBox1.Text));
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlsorgu;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
