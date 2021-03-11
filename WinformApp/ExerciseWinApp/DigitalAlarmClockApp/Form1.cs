using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DigitalAlarmClockApp
{
    public partial class Form1 : Form
    {
        private DateTime SetDay;
        private DateTime SetTime;
        private bool IsSetAlarm;
        WindowsMediaPlayer mediaPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mediaPlayer = new WindowsMediaPlayer();
            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text = "";

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.CustomFormat = "tt hh:mm:ss";

            MyTimer.Interval = 1000;//1sec
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Enabled = true;
            MyTimer.Start();

            TabClock.SelectedTab = TapDigitalClock;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            LblDate.Text = curDate.ToShortDateString();
            LblTime.Text = curDate.ToString("tt HH:mm:ss");
            if (IsSetAlarm == true)
            {
                if (SetDay == DateTime.Today &&
                    SetTime.Hour == curDate.Hour &&
                    SetTime.Minute == curDate.Minute &&
                    SetTime.Second == curDate.Second)
                {
                    //IsSetAlarm = false;
                    BtnRelease_Click(sender, e);
                    mediaPlayer.URL = @".\Media/alarm.mp3";
                    mediaPlayer.controls.play();

                    MessageBox.Show("알람!!!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SetDay = DateTime.Parse(DtpAlarmDate.Text);
            SetTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {SetDay.ToShortDateString()} + {SetTime.ToString("tt HH:mm:ss")}";
            LblAlarm.ForeColor = Color.Red;

            TabClock.SelectedTab = TapDigitalClock;
            IsSetAlarm = true;
        }   

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            IsSetAlarm = false;
            LblAlarm.Text = "Alarm : ";
            LblAlarm.ForeColor = Color.Gray;
            TabClock.SelectedTab = TapDigitalClock;
            mediaPlayer.controls.pause();
        }

        private void DtpAlarmTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
