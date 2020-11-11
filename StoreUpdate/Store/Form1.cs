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
            dt.Columns.Add("Tên Món Nước", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Đơn GIá", typeof(int));
            dt.Columns.Add("Thành tiền", typeof(int));

        }

        void addRow(string Name, int SL, int Single, int Sum)
        {
            s++;
            dt.Rows.Add(Name, SL, Single, Sum);
            dataGridView1.DataSource = dt;

            TienHang += Single;
            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();

        }

        private void button_Tra(object sender, EventArgs e)
        {
            panel_tra_sua.Visible = false;
            panel_tra.Visible = true;
            panel_Soda.Visible = false;
            bt_Tra.BackColor = Color.ForestGreen;
            bt_TraSua.BackColor = Color.LightGreen;
            bt_Soda.BackColor = Color.LightGreen;
        }

        private void button_TraSua(object sender, EventArgs e)
        {
            panel_tra.Visible = false;
            panel_tra_sua.Visible = true;
            panel_Soda.Visible = false;
            bt_TraSua.BackColor = Color.ForestGreen;
            bt_Tra.BackColor = Color.LightGreen;
            bt_Soda.BackColor = Color.LightGreen;
        }

        private void bt_Soda_Click(object sender, EventArgs e)
        {
            panel_tra.Visible = false;
            panel_Soda.Visible = true;
            panel_tra_sua.Visible = false;
            
            bt_TraSua.BackColor = Color.LightGreen;
            bt_Tra.BackColor = Color.LightGreen;
            bt_Soda.BackColor = Color.ForestGreen;
        }

        int indexRow;
        int s = 0;


        Double TienHang = 0;
        Double GiamGia = 10;
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
            s++;

            dt.Rows.Add("Trà Đào", "1", "30000", "30000");
            dataGridView1.DataSource = dt;

            TienHang += 30000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Thảo Dược", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_1_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Việt Quất", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_2_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Socola", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_3_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa", "1", "23000", "23000");
            dataGridView1.DataSource = dt;

            TienHang += 23000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_4_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Dâu", "1", "27000", "27000");
            dataGridView1.DataSource = dt;

            TienHang += 27000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_5_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Bạc Hà", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_6_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Đào", "1", "29000", "29000");
            dataGridView1.DataSource = dt;

            TienHang += 29000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_7_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Thái xanh", "1", "28000", "28000");
            dataGridView1.DataSource = dt;

            TienHang += 28000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_8_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Kiwi", "1", "26000", "26000");
            dataGridView1.DataSource = dt;

            TienHang += 26000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_9_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Thái Đỏ", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt2_10_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Sữa Cherry", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Trái cây", "1", "22000", "22000");
            dataGridView1.DataSource = dt;

            TienHang += 22000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Bạc Hà", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Hoa Hồng", "1", "30000", "30000");
            dataGridView1.DataSource = dt;

            TienHang += 30000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Oải Hương", "1", "33000", "33000");
            dataGridView1.DataSource = dt;

            TienHang += 33000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Lá", "1", "22000", "22000");
            dataGridView1.DataSource = dt;

            TienHang += 22000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Matcha", "1", "30000", "30000");
            dataGridView1.DataSource = dt;

            TienHang += 30000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Ô Long", "1", "35000", "35000");
            dataGridView1.DataSource = dt;

            TienHang += 35000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Trà Táo Đỏ", "1", "25000", "25000");
            dataGridView1.DataSource = dt;

            TienHang += 25000;

            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt3_1_Click(object sender, EventArgs e)
        {
            s++;

            dt.Rows.Add("Soda Mix", "1", "30000", "30000");
            dataGridView1.DataSource = dt;

            TienHang += 30000;
            
            richTextBox1.Text = TienHang.ToString();
            TongTien = TienHang - TienHang * (Convert.ToDouble(richTextBox2.Text) / 100);
            richTextBox3.Text = TongTien.ToString();
        }

        private void bt3_2_Click(object sender, EventArgs e)
        {
            addRow("Soda Dưa", 1, 28000, 28000);
        }

        private void bt3_3_Click(object sender, EventArgs e)
        {
            addRow("Italian Soda", 1, 35000, 35000);
        }

        private void bt3_4_Click(object sender, EventArgs e)
        {
            addRow("Soda Bạc hà", 1, 30000, 30000);
        }

        private void bt3_5_Click(object sender, EventArgs e)
        {
            addRow("Soda Blue Ocean", 1, 38000, 38000);
        }

        private void bt3_6_Click(object sender, EventArgs e)
        {
            addRow("Italian Sữa đào", 1, 22000, 22000);
        }

        private void bt3_7_Click(object sender, EventArgs e)
        {
            addRow("Soda việt quất", 1, 30000, 30000);
        }

        private void bt3_8_Click(object sender, EventArgs e)
        {
            addRow("Soda kem cherry", 1, 25000, 25000);
        }

        private void bt3_9_Click(object sender, EventArgs e)
        {
            addRow("Soda xoài", 1, 22000, 22000);
        }

        private void bt3_10_Click(object sender, EventArgs e)
        {
            addRow("Soda cam", 1, 20000, 20000);
        }

#endregion
        private void bt_del__Click(object sender, EventArgs e)
        {
            s--;
            double TienHang2 = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                TienHang2 += Convert.ToInt32(dataGridView1.Rows[cell.RowIndex].Cells[3].Value);
                TongTien -= TienHang2 - TienHang2 * (Convert.ToDouble(richTextBox2.Text) / 100) ;
                richTextBox3.Text = TongTien.ToString();
                TienHang -= Convert.ToDouble(dataGridView1.Rows[cell.RowIndex].Cells[3].Value);
                richTextBox1.Text = TienHang.ToString();
                
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
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
