using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using QRCoder;
using barCode;
using ZXing;

namespace barCode
{
    public partial class Form1 : Form
    {
        BarcodeLib.Barcode code128;
        public Form1()
        {
            InitializeComponent();
            code128 = new Barcode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, textBox1.Text);
            pictureBox1.Image = barcode;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(textBox2.Text,
            QRCodeGenerator.ECCLevel.Q));
            pictureBox2.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap imgBarCode = (Bitmap)pictureBox1.Image;
            if (pictureBox2 != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imgBarCode);
                    string decoded = result.ToString().Trim();
                    if (!listBox1.Items.Contains(decoded))
                        listBox1.Items.Insert(0, decoded);
                    imgBarCode.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
        }
    }
}
