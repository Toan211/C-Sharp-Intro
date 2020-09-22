using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace grabCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dista, disc, money;

        private void Calculator_button(object sender, EventArgs e)
        {
            dista = Convert.ToInt32(TBox_Dista.Text);
            if (dista <= 5)
            {
                money = dista * 20000;
            }   

            else if (dista <=20)
            {
                money = 5 * 20000 + (dista - 5) *15000;
            }    
            else
            {
                money = 5 * 20000 + 15 * 15000 + (dista - 20) * 10000;
            }

            disc = 0;
            if (dista > 100)
                {
                   disc = 10;
                }

            int Total_money = money - (money * (disc/100));

            // var text = Total_money.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("de"));
            
            //NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            //nfi.NumberGroupSeparator = ".";
            TBox_Money.Text = Convert.ToString(Total_money);

            TBox_Disc.Text = Convert.ToString(disc);

        }
    }
}
