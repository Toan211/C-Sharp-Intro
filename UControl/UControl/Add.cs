using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UControl
{
    public partial class Add : Form
    {
        public static string txt_;
        public Add()
        {   
            
            InitializeComponent();
          
        }

        protected void bt_Add__Click(object sender, EventArgs e)
        {

            txt_ = txt_Add_.Text;
            InfoCbBox user = new InfoCbBox();

            InfoCbBox.txt_cb_ = txt_Add_.Text;

            user.AddItem("what");
            user.comboBox2.Items.Add("what");
            
            
        }
    }
}
