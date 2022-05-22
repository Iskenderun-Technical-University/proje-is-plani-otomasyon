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
    public partial class GirisEkrani : Form
    {

        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static SqlDataAdapter da;
        static DataSet ds;
        public static string SqlCon = @"Data Source=LAPTOP-RBI3N3HS\SQLEXPRESS;Initial Catalog=IsTakip;Integrated Security=True";
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            yetki.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitEkrani yeni = new KayitEkrani();
            yeni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kullanici.Text != "" && sifre.Text != "")
            {
                if (yetki.Text != "Yetkiniz")
                {
                    if (Convert.ToInt32(yetki.Text) == 0)
                    {
                        if (Girisİslemi(kullanici.Text, sifre.Text, Convert.ToInt32(yetki.Text)))
                        {
                            YöneticiSayfasi yeni = new YöneticiSayfasi();
                            yeni.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı , şifre veya yetki yanlış girildi kontrol ediniz !!!");
                        }
                    }
                    else if (Convert.ToInt32(yetki.Text) == 1)
                    {
                        if (Girisİslemi(kullanici.Text, sifre.Text, Convert.ToInt32(yetki.Text)))
                        {
                            MessageBox.Show("calisan");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı , şifre veya yetki yanlış girildi kontrol ediniz !!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Yetki Boş geçtiniz. Doldurunuz !!!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçtiniz. Doldurunuz !!!");
                kullanici.Clear();
                sifre.Clear();
            }
        }

        public bool Girisİslemi(string kullanici, string sifre, int yetki)
        {
            string sqlsorgu = "select * from Giris where Kullanici_Adi=@kullanici and Sifre=@sifre and Yetki=@yetki";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sqlsorgu, con);
            cmd.Parameters.AddWithValue("@kullanici", kullanici);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            cmd.Parameters.AddWithValue("@yetki", yetki);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

    }
}
