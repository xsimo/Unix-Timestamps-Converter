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

        private enum WeekNumberingScheme { Silver, Bronze, Platine, Gold }
        private WeekNumberingScheme weekScheme = WeekNumberingScheme.Gold; // overwritten by goldWeek.Checked in InitializeComponent
        private DateTime lastComputedDate = DateTime.UtcNow;

        // First day of week for silver/bronze/gold, driven by weekStartPreference.
        // platineWeek (ISO-8601) ignores this and always anchors on Monday.
        private DayOfWeek weekStartPreferenceDay = DayOfWeek.Sunday;

        public Form1()
        {
            InitializeComponent();
            // Set here instead of the designer: the WinForms designer regenerates
            // InitializeComponent() wholesale on every save from the visual editor
            // and silently drops statements it doesn't own, like a raw SelectedIndex
            // assignment it never recorded through the Properties window.
            weekStartPreference.SelectedIndex = 0; // "A week starts on Sunday"
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

            prepa += " UTC [ week n° " + GetWeekOfYear(dUTC) + "]";
            label1.Text = prepa;
            UpdateWeekNumberDisplay(dUTC);

            DateTime dMinuit = new DateTime(d.Year, d.Month, d.Day);

            monthCalendar1.SetDate(dMinuit);
            monthCalendar1.UpdateBoldedDates();
            heureDebut.Value = d.Hour;
            minuteDebut.Value = d.Minute;
            secondesDebut.Value = d.Second;
        }
        // platineWeek is the only true ISO-8601 scheme (Monday-anchored fix-up adapted
        // from https://stackoverflow.com/a/11155102). bronzeWeek is the same
        // "first four-day week" rule but anchored on Sunday instead, which is NOT
        // ISO-8601 despite the similar name. silverWeek/goldWeek use .NET's own
        // FirstDay/FirstFullWeek rules directly, both anchored on Sunday.
        private int GetWeekOfYear(DateTime date)
        {
            CultureInfo fr_ca = new CultureInfo("fr-CA");
            if (weekScheme == WeekNumberingScheme.Platine)
            {
                DateTime reference = date;
                DayOfWeek day = fr_ca.Calendar.GetDayOfWeek(date);
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                {
                    reference = date.AddDays(3);
                }
                return fr_ca.Calendar.GetWeekOfYear(reference, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            }
            CalendarWeekRule rule = weekScheme == WeekNumberingScheme.Silver ? CalendarWeekRule.FirstDay
                : weekScheme == WeekNumberingScheme.Bronze ? CalendarWeekRule.FirstFourDayWeek
                : CalendarWeekRule.FirstFullWeek;
            return fr_ca.Calendar.GetWeekOfYear(date, rule, weekStartPreferenceDay);
        }

        // The calendar year a week number is reported against: can differ from
        // date.Year near year boundaries (e.g. week 52/53 of the previous year).
        private int GetWeekYear(DateTime date, int week)
        {
            if (weekScheme == WeekNumberingScheme.Platine)
            {
                int isoDayIndex = ((int)date.DayOfWeek + 6) % 7; // Monday = 0 .. Sunday = 6
                DateTime thursday = date.AddDays(3 - isoDayIndex);
                return thursday.Year;
            }
            if (date.Month == 1 && week >= 52) return date.Year - 1;
            if (date.Month == 12 && week == 1) return date.Year + 1;
            return date.Year;
        }

        private void UpdateWeekNumberDisplay(DateTime date)
        {
            lastComputedDate = date;
            int week = GetWeekOfYear(date);
            int year = GetWeekYear(date, week);
            ader.Text = "w" + year + "." + week.ToString("D2");
        }

        private void weekRuleRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;

            if (rb == SilverWeek) weekScheme = WeekNumberingScheme.Silver;
            else if (rb == bronzeWeek) weekScheme = WeekNumberingScheme.Bronze;
            else if (rb == platineWeek) weekScheme = WeekNumberingScheme.Platine;
            else if (rb == goldWeek) weekScheme = WeekNumberingScheme.Gold;

            UpdateWeekNumberDisplay(lastComputedDate);
        }

        private void weekStartPreference_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sundayStart = weekStartPreference.SelectedIndex == 0; // "A week starts on Sunday"
            weekStartPreferenceDay = sundayStart ? DayOfWeek.Sunday : DayOfWeek.Monday;

            // ISO-8601 mandates Monday as the first day of the week, so it's
            // incompatible with a Sunday-start preference.
            platineWeek.Enabled = !sundayStart;
            if (sundayStart && platineWeek.Checked)
            {
                goldWeek.Checked = true; // cascades into weekRuleRadio_CheckedChanged, which refreshes the display
            }
            else
            {
                UpdateWeekNumberDisplay(lastComputedDate);
            }
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
            UpdateWeekNumberDisplay(d);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            DateTime dUTC = d.ToUniversalTime();
            long val = dUTC.Ticks - UnixTimeStampTicks;
            textBox1.Text = (val / 10000000) + "";
            label1.Text = dUTC.ToLongDateString() + "  " + dUTC.ToLongTimeString() + " UTC";
            UpdateWeekNumberDisplay(dUTC);
            heureDebut.Value = d.Hour;
            minuteDebut.Value = d.Minute;
            secondesDebut.Value = d.Second;
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
            UpdateWeekNumberDisplay(monthCalendar1.SelectionStart);
        }
    }
}
