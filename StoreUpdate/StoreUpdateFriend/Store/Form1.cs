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

        int indexRow;
        int s = 0;

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

        private void button_comic(object sender, EventArgs e)
        {
            panel_History.Visible = false;
            panel_comic.Visible = true;
            panel_Scifi.Visible = false;
            bt_truyenTranh.BackColor = Color.SlateBlue;
            bt_LichSu.BackColor = Color.BlueViolet;
            bt_Scifi.BackColor = Color.BlueViolet;
        }

        private void button_LichSu(object sender, EventArgs e)
        {
            panel_comic.Visible = false;
            panel_History.Visible = true;
            panel_Scifi.Visible = false;
            bt_LichSu.BackColor = Color.SlateBlue;
            bt_truyenTranh.BackColor = Color.BlueViolet;
            bt_Scifi.BackColor = Color.BlueViolet;
        }

        private void button_scifi(object sender, EventArgs e)
        {
            panel_comic.Visible = false;
            panel_Scifi.Visible = true;
            panel_History.Visible = false;
            
            bt_LichSu.BackColor = Color.BlueViolet;
            bt_truyenTranh.BackColor = Color.BlueViolet;
            bt_Scifi.BackColor = Color.SlateBlue;
        }

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
            
        }

#region btClickPanel
        private void bt1_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 1", 1, 30000, 30000);

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 2", 1, 30000, 30000);
        }

        private void bt2_1_Click(object sender, EventArgs e)
        {
            addRow("Lịch sử Việt Nam", 1, 230000, 230000);
        }

        private void bt2_2_Click(object sender, EventArgs e)
        {
            addRow("Lịch sử Thế giới", 1, 147000, 147000);
        }

        private void bt2_3_Click(object sender, EventArgs e)
        {
            addRow("Mein Kampf", 1, 317000, 317000);
        }

        private void bt2_4_Click(object sender, EventArgs e)
        {
            addRow("Tiểu sử Hồ Chí Minh", 1, 275000, 275000);
        }

        private void bt2_5_Click(object sender, EventArgs e)
        {
            addRow("Đại Việt sử ký toàn thư", 1, 235000, 235000);
        }

        private void bt2_6_Click(object sender, EventArgs e)
        {
            addRow("The Second world war", 1, 279000, 279000);
        }

        private void bt2_7_Click(object sender, EventArgs e)
        {
            addRow("Perfect Spy: The Incredible Double Life of Pham Xuan An", 1, 260000, 260000);
        }

        private void bt2_8_Click(object sender, EventArgs e)
        {
            addRow("Sử thi Gilgamesh", 1, 179000, 179000);
        }

        private void bt2_9_Click(object sender, EventArgs e)
        {
            addRow("Sapiens: Lược Sử Loài Người", 1, 125500, 125500);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 3", 1, 30000, 30000);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 4", 1, 30000, 30000);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 5", 1, 30000, 30000);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 6", 1, 30000, 30000);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 7", 1, 30000, 30000);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 8", 1, 30000, 30000);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            addRow("Thanh gươm diệt quỷ 9", 1, 30000, 30000);
        }

        private void bt3_1_Click(object sender, EventArgs e)
        {
            addRow("Tanya chiến ký 1", 1, 101200, 101200);
        }

        private void bt3_2_Click(object sender, EventArgs e)
        {
            addRow("Cô gái văn chương", 1, 99000, 99000);
        }

        private void bt3_3_Click(object sender, EventArgs e)
        {
            addRow("Another tập 1", 1, 49000, 49000);
        }

        private void bt3_4_Click(object sender, EventArgs e)
        {
            addRow("Mất tư cách làm người", 1,79900, 79900);
        }

        private void bt3_5_Click(object sender, EventArgs e)
        {
            addRow("Another tập 2", 1, 49000, 49000);
        }

        private void bt3_6_Click(object sender, EventArgs e)
        {
            addRow("Đồi gió hú", 1, 86000, 86000);
        }

        private void bt3_7_Click(object sender, EventArgs e)
        {
            addRow("Tôi thấy hoa vàng trên cỏ xanht", 1, 119500, 119500);
        }

        private void bt3_8_Click(object sender, EventArgs e)
        {
            addRow("Mộ đom đóm", 1, 57600, 57600);
        }

        private void bt3_9_Click(object sender, EventArgs e)
        {
            addRow("Những người khốn khổ (bổ 2 quyển)", 1, 246900, 246900);
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
