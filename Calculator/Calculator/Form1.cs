using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try { richTextBox2.Text = RPN.Calculate(richTextBox1.Text).ToString(); }
            catch (MyException ex) { richTextBox2.Text = ex.type; }
        }

        public static string ans = String.Empty;
        private void Del__Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ans = String.Empty;
        }

        private void ADel__Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
                richTextBox1.Text = (richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1));
        }

        
    }
}
