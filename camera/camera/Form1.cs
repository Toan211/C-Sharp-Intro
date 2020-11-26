using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;


namespace camera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Capture cap;

        private void Form1_Load(object sender, EventArgs e)
        {
            cap = new Capture(0); //set up camera
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //tạo mot bien nextframe de chup anh
            Image<Bgr, byte> nextFrame = cap.QueryFrame();
            Image<Gray, byte> grayframe = nextFrame.Convert<Gray, byte>();
            pictureBox1.Image = nextFrame.ToBitmap(); //hien anh mau
            pictureBox2.Image = grayframe.ToBitmap(); //hien anh trang den
        }

       
    }
}
