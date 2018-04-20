using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timestamps
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            richTextBox1.Text = "3rd rock from the Sun specs\r\n"
                + "m=60s ; h=60m ; D=24h\r\n"
                + "M : [31D,XD,31D,30D,31D,30D,31D,31D,30D,31D,30D,31D]\r\n"
                + "y: Gregorian Calendar ; Y: Unix Timestamp Year gap\r\n"
                + "Y : [y-1970] : \r\n"
                + "X : ((Y%4==0) ? ((Y%100==0)? (( Y%1000==0 )?29:28) : 29 ) : 28)";
        }
    }
}
