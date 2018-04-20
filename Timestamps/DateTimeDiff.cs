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

    

    public partial class DateTimeDiff : Form
    {

        static Form2 telexravarty;
        public DateTimeDiff()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            TimeSpan diff = d2 - d1;

            Int32 jourz = diff.Days;
            Int32 jours = jourz % 365;

            int years = jourz / 365;
            int months = jours /30 ;
            int jour = jours % 30;

            label1.Text = years + " an " + months + " mois " + jour + "jours";

            //label1.Text = diff.Days + " jours";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telexravarty = new Timestamps.Form2();
            telexravarty.Visible = true;
        }
    }
}
