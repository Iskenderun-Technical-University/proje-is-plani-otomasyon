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
    public partial class MusteriBilgileri : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";
        public MusteriBilgileri()
        {
            InitializeComponent();
        }

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Musteri ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Isler");
            dataGridView1.DataSource = ds.Tables["Isler"];
            con.Close();
        }
    }
}
