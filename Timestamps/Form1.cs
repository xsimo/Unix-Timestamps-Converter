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
    public partial class Form1 : Form
    {
        static DateTimeDiff BigD;
        static long UnixTimeStampTicks = 621355968000000000;
        //DateTime.MaxValue == 3155378975999999999;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long val = long.Parse(textBox1.Text);
            val = (val * 10000000);
            Int64 valTicks = val + UnixTimeStampTicks;
            Console.WriteLine(valTicks + "");
            DateTime d = new DateTime(valTicks, DateTimeKind.Utc);
            DateTime dUTC = new DateTime(d.Ticks);
            if (!checkBox2.Checked)
            {
                TimeZone tz = TimeZone.CurrentTimeZone;
                d = tz.ToLocalTime(d);
            }
            label1.Text = dUTC.ToLongDateString() + "  " + dUTC.ToLongTimeString() + " UTC";

            DateTime dMinuit = new DateTime(d.Year, d.Month, d.Day);

            monthCalendar1.SetDate(dMinuit);
            monthCalendar1.UpdateBoldedDates();
            heureDebut.Value = d.Hour;
            minuteDebut.Value = d.Minute;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d = monthCalendar1.SelectionStart;

            d = d.AddHours((double)heureDebut.Value);
            d = d.AddMinutes((double)minuteDebut.Value);
            if(!checkBox2.Checked)
            {
                TimeZone tz = TimeZone.CurrentTimeZone;
                d = tz.ToUniversalTime(d);
            }
            long val = d.Ticks - UnixTimeStampTicks;
            textBox1.Text= (val/ 10000000 ) + "";
            label1.Text = d.ToLongDateString() + "  " + d.ToLongTimeString() + " UTC";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            DateTime dUTC = d.ToUniversalTime();
            long val = dUTC.Ticks - UnixTimeStampTicks;
            textBox1.Text = (val / 10000000) + "";
            label1.Text = dUTC.ToLongDateString() + "  " + dUTC.ToLongTimeString() + " UTC";
            heureDebut.Value = d.Hour;
            minuteDebut.Value = d.Minute;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigD = new DateTimeDiff();
            BigD.Visible = true;
        }
    }
}
