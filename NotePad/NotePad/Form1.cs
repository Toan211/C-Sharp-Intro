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

namespace Bruh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files|*.txt";
                ofd.Title = "Open Text Document";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader OpenFile = new StreamReader(ofd.FileName);
                    richTextBox1.Text = OpenFile.ReadToEnd();
                    OpenFile.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files|*.txt";
                sfd.Title = "Save Text Document";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    
                    File.WriteAllText(path, richTextBox1.Text);
                    
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog safd = new SaveFileDialog())
            {
                safd.Filter = "Text Files|*.txt";
                safd.Title = "Save as Text Document";
                if (safd.ShowDialog() == DialogResult.OK)
                {
                    string path = safd.FileName;

                    File.WriteAllText(path, richTextBox1.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                if (fd.ShowDialog() ==DialogResult.OK)
                {
                    if (richTextBox1.SelectedText == "")
                    {
                        richTextBox1.Font = fd.Font;
                        
                    }
                    else richTextBox1.SelectionFont = fd.Font;
                }
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    if (richTextBox1.SelectedText == "")
                    {
                        richTextBox1.ForeColor = cd.Color;

                    }
                    else richTextBox1.SelectionColor = cd.Color;

                }
            } 
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                     richTextBox1.SelectionBackColor = cd.Color;
                }
            }
        }
    }
}
