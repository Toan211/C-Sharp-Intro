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

namespace folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


#region folder

        private void Folder_BT_check__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";
            string DirectoryPath = Folder_Box_Disk_.Text + Folder_file_.Text;
            DirectoryInfo DInfo = new DirectoryInfo(DirectoryPath);
            if (DInfo.Exists)
            {
                txt_Box_.Text = "co ton tai";
            }
            else
            {
                txt_Box_.Text = "ko ton tai";
            }
        }

        private void Folder_BT_create__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";

            string DirectoryPath = Folder_Box_Disk_.Text + Folder_file_.Text;

            Directory.CreateDirectory(DirectoryPath);
            txt_Box_.Text = "Da tao file";
        }

        private void Folder_BT_del__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";

            string DirectoryPath = Folder_Box_Disk_.Text + Folder_file_.Text;

            Directory.Delete(DirectoryPath);
          
            txt_Box_.Text = "Da xoa file";
        }

        private void Folder_BT_File_del__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";

            string DirectoryPath = Folder_Box_Disk_.Text + Folder_file_.Text;

            int n = Convert.ToInt32(File1_numeric_.Value);

            for (int i = 1; i <= n; i++)
            {
                string FileNumb = Convert.ToString(i);
                string FileName = DirectoryPath + "/" + File1_Box_Name_.Text + FileNumb;
                File.Delete(FileName + ".txt");
            }
        }

        #endregion

        private void File1_BT_create__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";

            string DirectoryPath = Folder_Box_Disk_.Text + Folder_file_.Text;

            int n = Convert.ToInt32(File1_numeric_.Value);

            for(int i = 1; i<= n; i++)
            {
                string FileNumb = Convert.ToString(i);
                string FileName = DirectoryPath + "/" + File1_Box_Name_.Text + FileNumb;
                using (File.Create(FileName + ".txt")) ;
                
            }
           
        }

        private void File1_BT_del__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";

            string DirectoryPath = Folder_Box_Disk_.Text + Folder_file_.Text;
                
            string FileName = DirectoryPath + "/" + File1_Box_Del_.Text;
            File.Delete(FileName + ".txt");
            
        }

        private void File1_BT_check__Click(object sender, EventArgs e)
        {

        }
    }
}
