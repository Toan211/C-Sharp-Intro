    using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dt.Columns.Add("Tên Sách", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Đơn GIá", typeof(int));
            dt.Columns.Add("Thành tiền", typeof(int));

        }
        int c1 = 0;
        void addRow(string Name, int SL, int Single, int Sum)
        {

                s++;
                dt.Rows.Add(Name, SL, Single, Sum);
                dataGridView1.DataSource = dt;
                TienHang += Single;
                richTextBox1.Text = TienHang.ToString();
                TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
                richTextBox3.Text = TongTien.ToString();
        
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    for (int j = i + 1; j < dt.Rows.Count; j++)
                    {
                        string b = dt.Rows[j]["Tên Sách"].ToString();
                        if (dt.Rows[i]["Tên Sách"].ToString() == b)
                        {
                            dt.Rows[i]["Số lượng"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[j].Cells[1].Value);
                            dataGridView1.Rows.Remove(dataGridView1.Rows[j]);
                            s--;
                            dt.Rows[i]["Thành tiền"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
            
            
        }

        private void button_Tra(object sender, EventArgs e)
        {
            panel_tra_sua.Visible = false;
            panel_tra.Visible = true;
            panel_Soda.Visible = false;
            bt_Tra.BackColor = Color.DeepSkyBlue;
            bt_TraSua.BackColor = Color.Aqua;
            bt_Soda.BackColor = Color.Aqua;
        }

        private void button_TraSua(object sender, EventArgs e)
        {
            panel_tra.Visible = false;
            panel_tra_sua.Visible = true;
            panel_Soda.Visible = false;
            bt_TraSua.BackColor = Color.DeepSkyBlue;
            bt_Tra.BackColor = Color.Aqua;
            bt_Soda.BackColor = Color.Aqua;
        }

        private void bt_Soda_Click(object sender, EventArgs e)
        {
            panel_tra.Visible = false;
            panel_Soda.Visible = true;
            panel_tra_sua.Visible = false;
            
            bt_TraSua.BackColor = Color.Aqua;
            bt_Tra.BackColor = Color.Aqua;
            bt_Soda.BackColor = Color.DeepSkyBlue;
        }


        int s = 0;


        Double TienHang = 0;
        Double GiamGia = 0;
        Double TongTien = 0;

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < s; i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

            }

            Double TienHang2 = 0;
            for (int i = 0; i < s; i++)
            {
                TienHang2 += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }

            
            richTextBox1.Text = TienHang2.ToString();
            TongTien = TienHang2 - TienHang2 * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
            TienHang = Int32.Parse(richTextBox1.Text);
            //txt_temp.Text = TienHang.ToString();
        }

       
#region btClickPanel
        private void bt1_Click(object sender, EventArgs e)
        {   
            addRow("Truyện Doramon", 1, 30000, 30000);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            addRow("Truyện Connan", 1, 25000, 25000);
        }

        private void bt2_1_Click(object sender, EventArgs e)
        {
            addRow("Sách Toán", 1, 25000, 25000);
        }

        private void bt2_2_Click(object sender, EventArgs e)
        {
            addRow("Sách Văn", 1, 25000, 25000);
        }

        private void bt2_3_Click(object sender, EventArgs e)
        {
            addRow("Sách Lý", 1, 23000, 23000);
        }

        private void bt2_4_Click(object sender, EventArgs e)
        {
            addRow("Sách Hóa học", 1, 27000, 27000);
        }

        private void bt2_5_Click(object sender, EventArgs e)
        {
            addRow("Sách Anh văn", 1, 25000, 25000);
        }

        private void bt2_6_Click(object sender, EventArgs e)
        {
            addRow("Sách Lịch sử", 1, 29000, 29000);
        }

        private void bt2_7_Click(object sender, EventArgs e)
        {
            addRow("Sách Địa lý", 1, 28000, 28000);
        }

        private void bt2_8_Click(object sender, EventArgs e)
        {
            addRow("Sách Tin học", 1, 26000, 26000);
        }

        private void bt2_9_Click(object sender, EventArgs e)
        {
            addRow("Sách Sinh học", 1, 25000, 25000);
        }

        private void bt2_10_Click(object sender, EventArgs e)
        {
            addRow("Sách Mỹ thuật", 1, 25000, 25000);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            addRow("Truyện Naruto", 1, 22000, 22000);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            addRow("Truyện Dragonball", 1, 25000, 25000);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            addRow("Truyện Tu-Gi-Oh", 1, 30000, 30000);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            addRow("Truyện Pokemon", 1, 33000, 33000);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            addRow("Truyện Shin", 1, 22000, 22000);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            addRow("truyện Subasa", 1, 30000, 30000);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            addRow("Truyện HunterxHunter", 1, 35000, 35000);
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            addRow("Truyện Yasiba", 1, 25000, 25000);
        }

        private void bt3_1_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết 1984", 1, 120000, 120000);
        }

        private void bt3_2_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết Harry Portter", 1, 145000, 145000);
        }

        private void bt3_3_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết The Lord of the Ring", 1, 130000, 130000);
        }

        private void bt3_4_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết Hunger Game", 1, 125000, 125000);
        }

        private void bt3_5_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết Maze Runner", 1, 115000, 115000);
        }

        private void bt3_6_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thiết Alice in Wonderland", 1, 120000, 120000);
        }

        private void bt3_7_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết Wizard of Oz", 1, 130000, 130000);
        }

        private void bt3_8_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết Twilight", 1, 100000, 100000);
        }

        private void bt3_9_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết Hannible", 1, 125000, 125000);
        }

        private void bt3_10_Click(object sender, EventArgs e)
        {
            addRow("Tiểu thuyết DaVinci Code", 1, 135000, 135000);
        }

        #endregion
        private void bt_del__Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Selected == true)
            {
                s--;
                double TienHang2 = 0;
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    TienHang2 += Convert.ToInt32(dataGridView1.Rows[cell.RowIndex].Cells[3].Value);
                    TongTien -= TienHang2 - TienHang2 * (Convert.ToDouble(richTextBox2.Text) / 100);
                    richTextBox3.Text = TongTien.ToString();
                    TienHang -= Convert.ToDouble(dataGridView1.Rows[cell.RowIndex].Cells[3].Value);
                    richTextBox1.Text = TienHang.ToString();
                    dataGridView1.Rows.RemoveAt(cell.RowIndex);
                }
                
            }
        }

        private void bt_del_all_Click(object sender, EventArgs e)
        {
            s = 0;
            dt.Clear();
            this.dataGridView1.DataSource = dt;
            TienHang = 0;
            richTextBox1.Text = TienHang.ToString();
            TongTien = 0;
            richTextBox3.Text = TongTien.ToString();
        }


    }
}
