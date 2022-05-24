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
    public partial class CalisandanGelenBildirim : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";


        public CalisandanGelenBildirim()
        {
            InitializeComponent();
        }

        private void CalisandanGelenBildirim_Load(object sender, EventArgs e)
        {

        }

        private void Görüntüle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Mesaj", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Mesaj");
            dataGridView1.DataSource = ds.Tables["Mesaj"];
            con.Close();
        }
    }
}
