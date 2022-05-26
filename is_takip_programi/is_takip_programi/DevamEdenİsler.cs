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
    public partial class DevamEdenİsler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";

        public DevamEdenİsler()
        {
            InitializeComponent();
        }

        private void DevamEdenİsler_Load(object sender, EventArgs e)
        {
            string metin = "select * from Personel where KullaniciAdi='" + GirisEkrani.kullanicimsession + "'";
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Isler where Durumu='" + Convert.ToString("Devam Ediyor") + "' and PID='" + IdDegeri(metin) + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Isler");
            dataGridView1.DataSource = ds.Tables["Isler"];
            con.Close();
        }
        public int IdDegeri(string metin)
        {
            int x = 0;
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = metin;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                x = Convert.ToInt32(dr[0]);
            }
            con.Close();
            return x;
        }
    }
}
