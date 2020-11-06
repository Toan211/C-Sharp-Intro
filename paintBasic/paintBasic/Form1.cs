using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorchooser = new ColorDialog();
            colorchooser.FullOpen = true;
            colorchooser.ShowDialog();
            bt_color.BackColor = colorchooser.Color;
        }

        Point Begin = new Point();
        Point End = new Point();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Begin.X = e.X;
            Begin.Y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            End.X = e.X;
            End.Y = e.Y;

            Graphics g = CreateGraphics();
            Pen p = new Pen(bt_color.BackColor);
            if (radio_btn_line.Checked == true)
            {
                g.DrawLine(p, Begin.X,Begin.Y,End.X,End.Y);
            }

            
            if (radio_btn_hcn.Checked == true)
            {
                if (End.X < Begin.X && End.Y < Begin.Y)
                {
                    g.DrawRectangle(p, End.X, End.Y, Begin.X - End.X, Begin.Y - End.Y);
                }
                else if (Begin.X > End.X && Begin.Y < End.Y)
                {
                    g.DrawRectangle(p, End.X, Begin.Y, Begin.X - End.X, End.Y - Begin.Y);
                }
                else if (Begin.X < End.X && Begin.Y > End.Y)
                {
                    g.DrawRectangle(p, Begin.X, End.Y ,End.X - Begin.X, Begin.Y - End.Y);
                }
                else
                {
                    g.DrawRectangle(p, Begin.X, Begin.Y, End.X - Begin.X, End.Y - Begin.Y);
                }
            }    
            
            if (radio_btn_elipse.Checked == true)
            {
                g.DrawEllipse(p, Begin.X, Begin.Y, End.X - Begin.X, End.Y - Begin.Y);
            }    
            
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(Color.White);
        }

        private void bt_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(dialog.FileName);
                Graphics g = CreateGraphics();
                g.DrawImage(img, Int32.Parse(txt_x.Text), Int32.Parse(txt_y.Text));
            }    

        }
    }
}
