using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_and_perimeter_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısakenar = Convert.ToInt32(textBox1.Text);
            int uzunkenar = Convert.ToInt32(textBox2.Text);
            int alan = kısakenar * uzunkenar;
            label6.Text = alan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kısakenar = Convert.ToInt32(textBox1.Text);
            int uzunkenar = Convert.ToInt32(textBox2.Text);
            int çevre = (kısakenar + uzunkenar) * 2;
            label7.Text = çevre.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
