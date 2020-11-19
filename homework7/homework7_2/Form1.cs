using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7_2
{
    public partial class Form1 : Form
    {
        int number;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblWin.Visible = false;
            textBox1.Enabled = true;
            lblCount.Text = "0";
            btnStart.Visible = false;
            number = rnd.Next(100);

            label3.Text = number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCount.Text = (Int32.Parse(lblCount.Text) + 1).ToString();
            int num = 0;
            bool success = Int32.TryParse(textBox1.Text, out num);
            if (num == number)
            {
                lblWin.Visible = true;
                btnStart.Text = "заного";
                btnStart.Visible = true;
                textBox1.Enabled = false;
            }
        }
    }
}
