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

namespace Notepad
{
    public partial class Form1 : Form
    {
        String path = String.Empty;

        public Form1() => InitializeComponent();


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(path = openFileDialog1.FileName);
                string[] SplitExtension = openFileDialog1.FileName.Split('.');

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(path = saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(path))
            {
                File.WriteAllText(path, textBox1.Text);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void exitPrompt()
        {
            DialogResult = MessageBox.Show("Do you want to save current file?",
                "Notepad",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                exitPrompt();

                if (DialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    textBox1.Text = String.Empty;
                    path = String.Empty; ;
                }
                else if (DialogResult == DialogResult.No)
                {
                    textBox1.Text = String.Empty; ;
                    path = String.Empty; ;
                    
                }

            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.SelectAll();
        
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Cut();

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Copy();

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Paste();

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.SelectedText = String.Empty;

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine if last operation can be undone in text box.   
            if (textBox1.CanUndo == true)
            {
                // Undo the last operation.
                textBox1.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                textBox1.ClearUndo();
                
            }
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            textBox1.Text = textBox1.Text + System.DateTime.Now ;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                textBox1.WordWrap = false;
                textBox1.ScrollBars = ScrollBars.Both;
                wordWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                textBox1.WordWrap = true;
                textBox1.ScrollBars = ScrollBars.Vertical;
                wordWrapToolStripMenuItem.Checked = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = new Font(fontDialog1.Font, fontDialog1.Font.Style);
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new Form2();
            aboutForm.ShowDialog();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                exitPrompt();
                    
                if (DialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }


        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm f1 = new FindForm();
            f1.ShowDialog();
            if (f1.getFindWord() != "")
            {

                int index = 0;
                while (index != -1 && index < textBox1.Text.Length)
                {
                    
                    index = textBox1.Text.IndexOf(f1.getFindWord(), index);
                    if (index != -1)
                    {
                        textBox1.Select(index, f1.getFindWord().Length);
                        
                        index++;
                        f1.ShowDialog();
                    }
                }
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.ShowDialog();
        }

        int i = 12;

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            i++;
            textBox1.Font = new Font("Consolas", i);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i--;
            textBox1.Font = new Font("Consolas", i);
        }
    }
}
