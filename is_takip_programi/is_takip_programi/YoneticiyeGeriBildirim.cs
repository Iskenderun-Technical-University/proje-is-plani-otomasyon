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
    public partial class YoneticiyeGeriBildirim : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=LAPTOP-OH6U8HKF\SQL;Initial Catalog=IsTakip;Integrated Security=True";

        public YoneticiyeGeriBildirim()
        {
            InitializeComponent();
        }

        private void Gönder_Click(object sender, EventArgs e)
        {
            string sqlsorgu = "insert into Mesaj(PID,IsID,Mesaj) Values (@PID,@IsID,@Mesaj)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@PID", Convert.ToInt32(textBox2.Text));
            cmd.Parameters.AddWithValue("@IsID", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Mesaj", richTextBox1.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlsorgu;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
