using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_programi
{
    public partial class CalisanSayfasi : Form
    {
        public CalisanSayfasi()
        {
            InitializeComponent();
        }

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
    }
}
