﻿using System;
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
        public InfoCbBox()
        {
            
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form addForm = new Add();
            addForm.ShowDialog();

        }
    }
}
