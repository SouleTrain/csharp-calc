using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Test_0._1
{
    public partial class SharpCalculator : Form
    {
        public SharpCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.AppendText("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("9");
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("0");
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText(".");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("/");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("*");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("-");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            listView1.AppendText("+");
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (listView1.Text.Contains("/"))
            {
                listView1.Text.Split('/');
                double number1 = Convert.ToDouble(listView1.Text.Split('/')[0]);
                double number2 = Convert.ToDouble(listView1.Text.Split('/')[1]);
                listView1.Text = (number1 / number2).ToString();
            }
            if (listView1.Text.Contains("*"))
            {
                listView1.Text.Split('*');
                double number1 = Convert.ToDouble(listView1.Text.Split('*')[0]);
                double number2 = Convert.ToDouble(listView1.Text.Split('*')[1]);
                listView1.Text = (number1 * number2).ToString();
            }
            if (listView1.Text.Contains("-"))
            {
                listView1.Text.Split('-');
                double number1 = Convert.ToDouble(listView1.Text.Split('-')[0]);
                double number2 = Convert.ToDouble(listView1.Text.Split('-')[1]);
                listView1.Text = (number1 - number2).ToString();
            }
            if (listView1.Text.Contains("+"))
            {
                listView1.Text.Split('+');
                double number1 = Convert.ToDouble(listView1.Text.Split('+')[0]);
                double number2 = Convert.ToDouble(listView1.Text.Split('+')[1]);
                listView1.Text = (number1 + number2).ToString();
            }
        }
    }
}
