using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void BT_DP_Click(object sender, EventArgs e)
        {

        }

        private void BT_HP_Click(object sender, EventArgs e)
        {

        }

        private void BT_TT_Click(object sender, EventArgs e)
        {

        }
    }
}
