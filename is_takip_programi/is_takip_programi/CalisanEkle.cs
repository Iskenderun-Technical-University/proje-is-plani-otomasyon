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
    public partial class CalisanEkle : Form
    {
        public CalisanEkle()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=HaliSaha;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string Sqlmetin = "insert into Personel(Adi,Soyadi,Görevi,Telefon,KayitTarihi,KullaniciAdi,sifre,Yetki) values (@Adi,@Soyadi,@Görevi,@Telefon,@KayitTarihi,@KullaniciAdi,@sifre,@Yetki)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@Soyadi", textBox2.Text);
            cmd.Parameters.AddWithValue("@Görevi", textBox3.Text);
            cmd.Parameters.AddWithValue("@Telefon", textBox4.Text);
            cmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
            cmd.Parameters.AddWithValue("@KullaniciAdi", textBox1.Text + "." + textBox2.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
            cmd.Parameters.AddWithValue("@Yetki", Convert.ToInt32( comboBox1.Text));
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = Sqlmetin;
            cmd.ExecuteNonQuery();
            con.Close();
          
        }
    }
}
