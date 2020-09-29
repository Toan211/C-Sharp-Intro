using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_test_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_File_Read__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";

            string filePath = txt_Dir_.Text + "/" + txt_Name_.Text;

            if (File.Exists(filePath))
            {
                StreamReader rd = new StreamReader(filePath);

                string Test = rd.ReadToEnd();
                txt_Box_.Text = Test;
            }
            else
            {
                txt_Box_.Text = "file ko ton tai";
            }                
        }
    }
}
