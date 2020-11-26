using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tesseract;

namespace optics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string OCR(Bitmap b)
        {
            string res = "";
            try
            {
                using (var engine = new TesseractEngine(@"tessdata", "vie", EngineMode.Default))
                {
                    using (var page = engine.Process(b, PageSegMode.AutoOnly))

                        res = page.GetText();
                }
            }
            catch { }
            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string result = "";
                Task.Factory.StartNew(() =>
                {
                    picloading.BeginInvoke(new Action(() =>
                    {
                        picloading.Visible = true;
                    }));
                    result = OCR((Bitmap)picloading.Image);
                    richTextBox1.BeginInvoke(new Action(() =>
                    {
                        richTextBox1.Text = result;
                    }));
                    picloading.BeginInvoke(new Action(() =>
                    {
                        picloading.Visible = false;
                    }));
                });
        }

        private string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                string path = openFile.FileName;
                picloading.ImageLocation = path;
            }
            

        }
    }
}
