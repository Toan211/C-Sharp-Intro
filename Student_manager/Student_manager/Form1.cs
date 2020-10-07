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

namespace Student_manager
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
         
            dataGridView1.Columns.Clear();
            dt.Columns.Add("Ma Hoc sinh", typeof(string));
            dt.Columns.Add("Ho Ten", typeof(string));
            dt.Columns.Add("Gioi Tinh", typeof(string));
            dt.Columns.Add("Ngay sinh", typeof(string));
            dt.Columns.Add("Noi sinh", typeof(string));
        }

     

        private void button_Add(object sender, EventArgs e)
        {
           
                string Gender;

            if (textBox2.Text == "")
            {
                MessageBox.Show("dữ liệu MSSV nhập vào có lỗi !!!");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("dữ liệu tên học sinh nhập vào có lỗi !!!");
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("dữ liệu nơi sinh nhập vào có lỗi !!!");
                return;
            }

            if (radioButton1.Checked)
                {
                    Gender = "nam";
                } 
                else
                {
                    Gender = "nu";
                }
                dt.Rows.Add(textBox2.Text, textBox1.Text, Gender, dateTimePicker1.Text, comboBox1.Text);
                dataGridView1.DataSource = dt;
        }

     

        private void button_save(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files|*.txt";
                sfd.Title = "Save Text Document";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            // the code will bug if dataGridView1.Columns.Count not -1 (out of range)
                            for (int j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                            writer.WriteLine("");
                            writer.WriteLine("--------------------");
                        }
                        writer.Close();
                    }                        
                }
            }              
        }

        private void button_Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
