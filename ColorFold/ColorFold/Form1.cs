using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorFold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int NumRand;
        int step = 0;
        private void bt_Start__Click(object sender, EventArgs e)
        {
            
            Random rd = new Random();
            NumRand = rd.Next(1, 10);
            if (NumRand == 1)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M1;
            if (NumRand == 2)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M2;
            if (NumRand == 3)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M3;
            if (NumRand == 4)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M4;
            if (NumRand == 5)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M5;
            if (NumRand == 6)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M6;
            if (NumRand == 7)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M7;
            if (NumRand == 8)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M8;
            if (NumRand == 9)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M9;
            if (NumRand == 10)
                this.pictureBox1.Image = global::ColorFold.Properties.Resources.M10;

            button1.BackColor = Color.White;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Blue;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Blue;
            button9.BackColor = Color.Red;
            button1.Focus();
            step = 0;
            label3.Text = step.ToString();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (button1.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "S" && button4.BackColor == Color.White)
                {
                    button4.BackColor = button1.BackColor;
                    button1.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "D" && button2.BackColor == Color.White)
                {
                    button2.BackColor = button1.BackColor;
                    button1.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (button2.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "A" && button1.BackColor == Color.White)
                {
                    button1.BackColor = button2.BackColor;
                    button2.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "S" && button5.BackColor == Color.White)
                {
                    button5.BackColor = button2.BackColor;
                    button2.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "D" && button3.BackColor == Color.White)
                {
                    button3.BackColor = button2.BackColor;
                    button2.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (button3.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "S" && button6.BackColor == Color.White)
                {
                    button6.BackColor = button3.BackColor;
                    button3.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "A" && button2.BackColor == Color.White)
                {
                    button2.BackColor = button3.BackColor;
                    button3.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (button4.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "W" && button1.BackColor == Color.White)
                {
                    button1.BackColor = button4.BackColor;
                    button4.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "S" && button7.BackColor == Color.White)
                {
                    button7.BackColor = button4.BackColor;
                    button4.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "D" && button5.BackColor == Color.White)
                {
                    button5.BackColor = button4.BackColor;
                    button4.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (button5.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "W" && button2.BackColor == Color.White)
                {
                    button2.BackColor = button5.BackColor;
                    button5.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "A" && button4.BackColor == Color.White)
                {
                    button4.BackColor = button5.BackColor;
                    button5.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "S" && button8.BackColor == Color.White)
                {
                    button8.BackColor = button5.BackColor;
                    button5.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "D" && button6.BackColor == Color.White)
                {
                    button6.BackColor = button5.BackColor;
                    button5.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (button6.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "W" && button3.BackColor == Color.White)
                {
                    button3.BackColor = button6.BackColor;
                    button6.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "A" && button5.BackColor == Color.White)
                {
                    button5.BackColor = button6.BackColor;
                    button6.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "S" && button9.BackColor == Color.White)
                {
                    button9.BackColor = button6.BackColor;
                    button6.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if (button7.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "W" && button4.BackColor == Color.White)
                {
                    button4.BackColor = button7.BackColor;
                    button7.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "D" && button8.BackColor == Color.White)
                {
                    button8.BackColor = button7.BackColor;
                    button7.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            if (button8.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "W" && button5.BackColor == Color.White)
                {
                    button5.BackColor = button8.BackColor;
                    button8.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "A" && button7.BackColor == Color.White)
                {
                    button7.BackColor = button8.BackColor;
                    button8.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "D" && button9.BackColor == Color.White)
                {
                    button9.BackColor = button8.BackColor;
                    button8.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            if (button9.BackColor != Color.White)
            {
                if (e.KeyData.ToString() == "W" && button6.BackColor == Color.White)
                {
                    button6.BackColor = button9.BackColor;
                    button9.BackColor = Color.White;
                    step++;
                }
                if (e.KeyData.ToString() == "A" && button8.BackColor == Color.White)
                {
                    button8.BackColor = button9.BackColor;
                    button9.BackColor = Color.White;
                    step++;
                }
            }
            label3.Text = step.ToString();
        }
    }
}
