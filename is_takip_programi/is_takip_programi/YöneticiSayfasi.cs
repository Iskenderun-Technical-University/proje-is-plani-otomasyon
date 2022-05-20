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
    public partial class YöneticiSayfasi : Form
    {
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

        private void button5_Click(object sender, EventArgs e)
        {
            Y_DevamEdenİsler yeni = new Y_DevamEdenİsler();
            yeni.Show();
        }
    }
}
