﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selam");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oldula");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            MessageBox.Show((a + b).ToString());
        }
    }
}
