using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UControl
{
    public partial class InfoCbBox : UserControl
    {
        public  static string txt_cb_;
        public InfoCbBox()
        {            
            InitializeComponent();
        }



        public void AddItem(object item)
        {
            this.comboBox2.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form addForm = new Add();
            addForm.Show();
        }
        

    }
}
