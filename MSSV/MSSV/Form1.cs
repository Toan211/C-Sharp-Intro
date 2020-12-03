using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BarcodeLib;
using QRCoder;
using ZXing;

namespace MSSV
{

    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        BarcodeLib.Barcode code128;

        public Form1()
        {
            InitializeComponent();
            code128 = new Barcode();
            
        }
         
        void loadBar()
        {
            code128 = new Barcode();
            for (int i = 0; i< dataGridView1.Rows.Count -1; i++)
            {
                string ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                Image barCode = code128.Encode(BarcodeLib.TYPE.CODE128, ID);
                imageListID.Images.Add(barCode);
                listView1.Items.Add(ID, i);
            }
            listView1.LargeImageList = imageListID;
        }

        void loadQR()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                string Name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                QRCode qrC = new QRCode(qr.CreateQrCode(Name, QRCodeGenerator.ECCLevel.Q));
                Image QR = qrC.GetGraphic(2, Color.Black, Color.White, false);
                imageListName.Images.Add(QR);
                listView2.Items.Add(Name, i);
                qr.Dispose();
                qrC.Dispose();
            }
            listView2.LargeImageList = imageListName;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string ID, NAME;
            string path = @"C:\Users\Admin\Desktop\DSSV.txt";

            var RowR = File.ReadAllLines(path);

            Char[] sep = new char[] { '*' };

            if(RowR.Length >0)
            {
                for(int i = 0; i< RowR.Length;i++)
                {
                    var colR = RowR[i].Split(sep);
                    ID = colR[0];
                    NAME = colR[1];
                    dataGridView1.Rows.Add(ID, NAME);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadBar();
            loadQR();
        }
    }
}
