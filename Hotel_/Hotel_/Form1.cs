using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        int indexRow;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dt.Columns.Add("Ma", typeof(string));
            dt.Columns.Add("Loai", typeof(string));
            dt.Columns.Add("Gia", typeof(double));
            dt.Columns.Add("TT", typeof(string));
            dt.Columns.Add("Ngay", typeof(int));
        }

        private void BT_TP_Click(object sender, EventArgs e)
        {
            try
            {
                string ma, loai, tt;
                int ngay;
                double gia;
                ma = TB_MP.Text;
                loai = CB_LP.Text;
                gia = Convert.ToDouble(TB_GP.Text);
                tt = CB_TTP.Text;
                ngay = Convert.ToInt32(TB_Day.Text);
                dt.Rows.Add(ma, loai, gia, tt, ngay);
                
                dataGridView1.DataSource = dt;

            }
            catch { MessageBox.Show("Dữ liệu nhập vào có lỗi !!!"); };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0)
            {
                
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                TB_MP.Text = row.Cells[0].Value.ToString();
                CB_LP.Text = row.Cells[1].Value.ToString();
                TB_GP.Text = row.Cells[2].Value.ToString();
                

                 //Không cho phép sửa trường STT
                TB_MP.Enabled = false;
                CB_LP.Enabled = false;
                TB_GP.Enabled = false;
                
            }
            */
            indexRow = e.RowIndex; // get the selected Row Index

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                
                dataGridView1.CurrentRow.Selected = true;
                
                TB_MP.Text = row.Cells[0].Value.ToString();
                CB_LP.Text = row.Cells[1].Value.ToString();
                TB_GP.Text = row.Cells[2].Value.ToString();
                CB_TTP.Text = row.Cells[3].Value.ToString();
                TB_Day.Text = row.Cells[4].Value.ToString();

            }
        }


        private void BT_DP_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];

            newDataRow.Cells[0].Value = TB_MP.Text;
            newDataRow.Cells[1].Value = CB_LP.Text;
            newDataRow.Cells[2].Value = TB_GP.Text;
            newDataRow.Cells[3].Value = CB_TTP.Text;
            newDataRow.Cells[4].Value = TB_Day.Text;

        }



        private void BT_HP_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[3].Value = "Trống"; //tt phong
            newDataRow.Cells[4].Value = "0"; //ngay o
        }

        private void BT_TT_Click(object sender, EventArgs e)
        {
            
            int totalMoney = 0;
            int moneyCount;
            int dayCount;


            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                moneyCount = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                dayCount = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);

                totalMoney += (moneyCount * dayCount);

            }    


                MessageBox.Show(totalMoney.ToString());
        }

       
    }
}
