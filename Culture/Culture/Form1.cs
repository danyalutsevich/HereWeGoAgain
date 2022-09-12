using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            labelNewYorkTIme.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Eastern Standard Time").ToString(new CultureInfo("en-US").DateTimeFormat); ;
            labelLondonTime.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "GMT Standard Time").ToString(new CultureInfo("en-GB").DateTimeFormat);
            labelCaliforniaTime.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Pacific Standard Time").ToString(new CultureInfo("en-US").DateTimeFormat);
            labelTokyoTime.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Tokyo Standard Time").ToString(new CultureInfo("ja-JP").DateTimeFormat);
            labelKyivTime.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "FLE Standard Time").ToString(new CultureInfo("uk-UA").DateTimeFormat);

        }
    }
}
