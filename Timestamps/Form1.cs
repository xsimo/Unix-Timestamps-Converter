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
            String prepa = dUTC.ToLongDateString() + "  " + dUTC.ToLongTimeString();

            prepa += " UTC [ week n° " + GetIso8601WeekOfYear(dUTC) + "]";
            label1.Text = prepa;

            DateTime dMinuit = new DateTime(d.Year, d.Month, d.Day);

            monthCalendar1.SetDate(dMinuit);
            monthCalendar1.UpdateBoldedDates();
            heureDebut.Value = d.Hour;
            minuteDebut.Value = d.Minute;
            secondesDebut.Value = d.Second;
        }
        // https://stackoverflow.com/a/11155102
        private int GetIso8601WeekOfYear(DateTime dUTC)
        {
            CultureInfo fr_ca = new CultureInfo("fr-CA");
            DateTime reference = dUTC.ToUniversalTime();
            DayOfWeek day = fr_ca.Calendar.GetDayOfWeek(dUTC);
            if (day >= DayOfWeek.Sunday && day <= DayOfWeek.Tuesday)
            {
                reference = dUTC.AddDays(3);
            }
            return fr_ca.Calendar.GetWeekOfYear(reference, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d = monthCalendar1.SelectionStart;

            d = d.AddHours((double)heureDebut.Value);
            d = d.AddMinutes((double)minuteDebut.Value);
            d = d.AddSeconds((double)secondesDebut.Value);
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
            secondesDebut.Value = d.Second;
            goldWeek.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigD = new DateTimeDiff();
            BigD.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime calD = monthCalendar1.SelectionStart;
            int weekNumber = GetIso8601WeekOfYear(calD);
            Console.WriteLine("week number = " + weekNumber);
            ader.Text = "w"+weekNumber;
        }
    }
}
