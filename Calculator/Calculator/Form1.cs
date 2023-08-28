using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        static public string previous = "";
        static public string operation = previous;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = operation;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operation += "9";
            textBox1.Text = operation;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operation += "8";
            textBox1.Text = operation;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operation += "7";
            textBox1.Text = operation;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operation += "6";
            textBox1.Text = operation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation += "5";
            textBox1.Text = operation;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation += "4";
            textBox1.Text = operation;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation += "3";
            textBox1.Text = operation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation += "2";
            textBox1.Text = operation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation += "1";
            textBox1.Text = operation;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            operation += "0";
            textBox1.Text = operation;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            operation += ".";
            textBox1.Text = operation;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            operation = operation.Remove(operation.Length - 1, 1);
            textBox1.Text = operation;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            var result = new DataTable().Compute(operation, null);
            previous = result.ToString();
            operation = previous;
            textBox1.Text = operation;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            operation += "+";
            textBox1.Text = operation;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operation += "-";
            textBox1.Text = operation;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operation += "*";
            textBox1.Text = operation;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operation += "/";
            textBox1.Text = operation;
        }

        private void PI_Click(object sender, EventArgs e)
        {
            operation += "3.14159265358979";
            textBox1.Text = operation;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            operation = previous;
            textBox1.Text = operation;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            previous = "";
            operation = "";
            textBox1.Text = operation;
        }
    }
}
