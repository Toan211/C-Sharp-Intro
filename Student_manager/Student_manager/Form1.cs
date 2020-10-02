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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Gender;
               
                
                if (radioButton1.Checked)
                {
                    Gender = "nam";
                } 
                else
                {
                    Gender = "nu";
                }    
                dt.Rows.Add(textBox2.Text, textBox1.Text, Gender  , dateTimePicker1.Text, comboBox1.Text);

                dataGridView1.DataSource = dt;

            }
            catch { MessageBox.Show("Dữ liệu nhập vào có lỗi !!!"); };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StreamWriter writer = new StreamWriter(@"C:\\Users\\Admin\\Desktop\\Text.txt");
            for (int i = 0; i<dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j<= dataGridView1.Columns.Count;j++)
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
