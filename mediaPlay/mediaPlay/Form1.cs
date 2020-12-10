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

namespace mediaPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer.uiMode = "none";
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {Multiselect = true, ValidateNames= true, Filter= "MP4|*.mp4|MP3|*.mp3|WMV|*.wmv|MKV|*.mkv|ALLFILE|*.*" })
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    //List<MediaFile> files = new List<MediaFile>();
                    //foreach(string fileName in ofd.FileNames)
                    //{
                    //    FileInfo fi = new FileInfo(fileName);
                    //    files.Add(new MediaFile() { 
                    //        _FileName = Path.GetFileNameWithoutExtension(fi.FullName), _Path = fi.FullName });

                    //}
                    //listFile.DataSource = files;
                    //listFile.ValueMember = "_Path";
                    //listFile.DisplayMember = "_FileName";
                    foreach (string T in ofd.FileNames)
                    {
                        axWindowsMediaPlayer.URL = ofd.FileName;
                        listFile.Items.Add(T);
                    }
                }
            }    
        }

        
        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MediaFile file = listFile.SelectedItem as MediaFile;
            //if(file!= null)
            //{
            //    axWindowsMediaPlayer.URL = file._Path;
            //    axWindowsMediaPlayer.Ctlcontrols.play();
            //}
            axWindowsMediaPlayer.URL = listFile.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MediaFile file = listFile.SelectedItem as MediaFile;
            //if (file != null)
            //{
            //    axWindowsMediaPlayer.URL = file._Path;
            //    axWindowsMediaPlayer.Ctlcontrols.play();
            //}

            axWindowsMediaPlayer.URL = listFile.Text;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listFile.ValueMember = "_Path";
            //listFile.DisplayMember = "_FileName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.fastReverse();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.fastForward();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listFile.Items.Clear();
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.fullScreen = true;
        }

        
    }
}
