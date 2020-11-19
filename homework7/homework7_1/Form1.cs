using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7_1
{
    public partial class Form1 : Form
    {
        public Stack<char> buttons = new Stack<char>();
        public Random rnd = new Random();
        public int finalNumber = 0;
        public Form1()
        {
            InitializeComponent();
            finalNumber = rnd.Next(2, 100);

            btnCommand1.Enabled = false;
            btnCommand2.Enabled = false;
            btnReset.Enabled = false;
            btnCancel.Enabled = false;
            btnCancel.Enabled = false;

            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "reset";
            btnStart.Text = "СТАРТ";
            btnCancel.Text = "отменить";

            this.Text = "Удвоитель";

            lblCount.Text = "0";
            lblNumber.Text = "1";

            lblMessage.Text = $"Вы должны набрать {finalNumber} очков";
            lblMessage.Visible = true;
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            buttons.Push('+');
        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            buttons.Push('*');
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCount.Text = "0";
        }

        private void lblNumber_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(lblNumber.Text) == finalNumber)
            {
                // сразу же рандомлю новое число после окончания программы
                finalNumber = rnd.Next(2, 100);

                lblMessage.Text = "Вы победили";
                lblMessage.Visible = true;

                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
                btnReset.Enabled = false;
                btnCancel.Enabled = false;

                btnStart.Text = "ЕЩЕ РАЗ";
                btnStart.Visible = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblCount.Text = "0";
            lblNumber.Text = "1";

            lblMessage.Text = $"Вы должны набрать {finalNumber} очков";
            lblMessage.Visible = true;

            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            btnReset.Enabled = true;
            btnCancel.Enabled = true;

            btnStart.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons.Pop() == '+') lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
                else lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
            }
            catch
            {

            }
        }
    }
}
