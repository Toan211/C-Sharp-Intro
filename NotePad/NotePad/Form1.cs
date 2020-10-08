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
                ofd.Filter = "Text Files|*.txt|All Files|*.*";
                ofd.Title = "Open Text Document";
                ofd.RestoreDirectory = true;
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
                sfd.Filter = "Text Files|*.txt|All Files|*.*";
                sfd.Title = "Save Text Document";
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    File.WriteAllText(path, richTextBox1.Text);
                }
            }
        }

        //similar to save
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog safd = new SaveFileDialog())
            {
                safd.Filter = "Text Files|*.txt";
                safd.Title = "Save as Text Document";
                safd.RestoreDirectory = true;
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
                fd.ShowColor = true;

                fd.Font = richTextBox1.Font;
                fd.Color = richTextBox1.ForeColor;
                if (fd.ShowDialog() ==DialogResult.OK)
                {
                    if (richTextBox1.SelectedText == "")
                    {
                        richTextBox1.Font = fd.Font;
                        richTextBox1.ForeColor = fd.Color;

                    }
                    else
                    {
                        richTextBox1.SelectionColor = fd.Color;
                        richTextBox1.SelectionFont = fd.Font;
                    }
                }
            }
        }

        Color colorSelectText = Color.White;
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    colorSelectText = cd.Color;
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
